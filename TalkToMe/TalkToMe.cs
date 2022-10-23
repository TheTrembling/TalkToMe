using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TalkToMe
{
    public partial class TalkToMe : Form
    {
        bool dialogOpened = false;
        bool accountWasDeleted = false;
        private class Dialog
        {
            public string logins { get; set; }
            public string dates { get; set; }
            public string messages { get; set; }
        }
        public string yourNickname
        {
            get { return login.Text; }
            set { login.Text = value; }
        }
        public int yourId
        {
            get { return identity; }
            set { identity = value; }
        }

        public string yourRole
        {
            get { return role; }
            set { role = value; }
        }

        int identity;
        string role;
        bool activated = true;
        string lastFriend;
        string dialogCode;
        int lastMessageLocation = 0;
        List<Dialog> messageList = new List<Dialog>();

        Timer timer = new Timer
        {
            Interval = 1000
        };

        public TalkToMe()
        {
            InitializeComponent();
            design();
            friendSearching.LostFocus += friendSearchingLostFocus;

            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            timer.Stop();        
        }

        private void RefreshFriendlist()
        {
            int count1 = friendList.Items.Count, count2 = 0;
            bool friendChecking = false;
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Friendlist.ToList();
                    foreach (var a in au)
                    {
                        if (a.User == login.Text)
                        {
                            count2++;

                            if (a.Friend == friendLogin.Text)
                                friendChecking = true;
                        }
                    }
                    if (count1 != count2)
                        GetAllFriends();

                    if (friendChecking == false)
                    {
                        friendLogin.Text = "";
                        dialogOpened = false;
                        windowSize(324, this.Height);
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshMessages()
        {
            int count1 = messageList.Count(), count2 = 0;
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Messages.ToList();
                    foreach (var a in au)
                    {
                        if (a.DialogCode == dialogCode)
                            count2++;
                    }
                    if (count1 != count2)
                        PublicMessages();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckAccount()
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    bool isExists = false;

                    foreach (var a in au)
                        if (a.Login == login.Text)
                        {
                            isExists = true;
                            break;
                        }
                    if (isExists == false)
                    {
                        accountWasDeleted = true;
                        MessageBox.Show("Ваш акаунт було видалено адміністратором.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Restart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (search2.Visible == true)
                RefreshFriendlist();

            if (dialogOpened == true)
            {
                RefreshMessages();
                LoadFriendInfo();
            }
            if (accountWasDeleted == false)
                CheckAccount();
        }

        private void friendSearchingLostFocus(object sender, EventArgs e)
        {
            if (friendSearching.Text == "")
                search2.Visible = true;
        }

        private void design()
        {
            login.Parent = background;
            id.Parent = background;

            friendProfile.Parent = background;
            deleteFriend.Parent = background;
            openChat.Parent = background;

            closeChat.Parent = background;

            yourLogin.Parent = background;
            yourStatus.Parent = background;

            friendLogin.Parent = background;
            friendStatus.Parent = background;
            lastVisit.Parent = background;

            sendMessage.Parent = background;

            messages.Parent = background;
            yourMessageText.Parent = background;
            search2.Parent = background;
            friendSearching.Parent = background;
            friendList.Parent = background;
            symbolsLimit.Parent = background;

            avatar.Parent = background;
            yourAvatar.Parent = background;
            friendAvatar.Parent = background;

            friendList.BackColor = ColorTranslator.FromHtml("#1c1c1a");

            search2.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            friendSearching.BackColor = ColorTranslator.FromHtml("#2c1e1d");

            yourMessageText.BackColor = ColorTranslator.FromHtml("#312926");
        }

        private void TalkToMe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void windowSize(int width, int height)
        {
            this.MinimumSize = new Size(width, height);
            this.MaximumSize = new Size(width, height);
            this.Size = new Size(width, height);
        }
        private void LoadFriendInfo()
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (lastFriend == a.Login)
                        {
                            friendStatus.Text = a.Status;
                            if (a.LastVisit != null)
                            {
                                lastVisit.Text = $"Був у мережі {a.LastVisit}";
                                lastVisit.Visible = true;
                            }
                            else
                            {
                                lastVisit.Visible = false;
                                lastVisit.Text = "";
                            }
                            break;
                        }
                    }
                    if (friendStatus.Text == "Offline")
                    {
                        lastVisit.Visible = true;
                        friendStatus.ForeColor = Color.IndianRed;
                    }
                    if (friendStatus.Text == "Online")
                    {
                        lastVisit.Visible = false;
                        friendStatus.ForeColor = Color.MediumAquamarine;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateADialogCode()
        {
            int friendId = 0;
            try
            {           
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (friendLogin.Text == a.Login)
                        {
                            friendId = a.Id;
                        }
                    }
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (yourId < friendId) dialogCode = $"{login.Text} {yourId} {friendLogin.Text} {friendId}";
            else dialogCode = $"{friendLogin.Text} {friendId} {login.Text} {yourId}";
        }

        private void GetMessages()
        {
            messageList.Clear();
            CreateADialogCode();

            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Messages.ToList();
                    foreach (var a in au)
                    {
                        if (dialogCode == a.DialogCode)
                        {
                            messageList.Add(new Dialog() { logins = a.Addressant, dates = a.SendDate.ToString(), messages = a.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PublicMessages()
        {
            int loc = 0;

            messages.Controls.Clear();

            GetMessages();

            FontFamily fontFamily = new FontFamily("Comic Sans MS");
            Font font = new Font(fontFamily, 13, FontStyle.Bold, GraphicsUnit.Pixel);

            foreach (var i in messageList)
            {
                string[] split = i.dates.ToString().Split(' ');


                //Повідомлення

                Label message = new Label();
                message.AutoSize = true;
                message.MaximumSize = new Size(496, 600);
                message.MinimumSize = new Size(496, 13);
                message.Font = font;
                message.BorderStyle = BorderStyle.None;
                message.Location = new Point(0, loc);
                message.Text = $"\n{i.messages}\n\n";
                message.Padding = new Padding(5, 5, 5, 5);
                message.ForeColor = ColorTranslator.FromHtml("#e8e7d6");
                
                messages.Controls.Add(message);

                //Логін і час

                Label nickname = new Label();
                nickname.AutoSize = true;
                nickname.Font = font;
                nickname.Location = new Point(5, 3);
                nickname.Text = $"{i.logins} ({Convert.ToDateTime(split[1]).ToShortTimeString()})";

                messages.Controls.Add(nickname);
                nickname.Parent = message;

                //Дата

                Label date = new Label();
                date.AutoSize = true;
                date.Font = font;
                date.Location = new Point(200, 0);
                date.ForeColor = ColorTranslator.FromHtml("#ada8a9");
                date.Text = $"{split[0]}";

                messages.Controls.Add(date);
                date.Parent = message;

                if (i.logins == login.Text)
                {
                    nickname.ForeColor = ColorTranslator.FromHtml("#81adce");
                    message.BackColor = ColorTranslator.FromHtml("#3e2121");
                    date.BackColor = ColorTranslator.FromHtml("#3f2c2a");
                }
                else
                {
                    nickname.ForeColor = ColorTranslator.FromHtml("#8ace81");
                    message.BackColor = ColorTranslator.FromHtml("#3f2c2a");
                    date.BackColor = ColorTranslator.FromHtml("#3e2121");
                }           

                loc = message.Location.Y + message.Height;
            }
            lastMessageLocation = loc;
            
            scrollDialog();
        }

        private void openChat_Click(object sender, EventArgs e)
        {
            if (friendList.SelectedIndex != -1)
            {
                windowSize(1038, 862);
                friendLogin.Text = lastFriend;
                LoadFriendInfo();

                PublicMessages();

                if (LoadPhoto(friendLogin.Text, login.Text) != "")
                {
                    friendAvatar.Visible = true;
                    yourAvatar.Visible = true;
                    if (friendAvatar.Image != null) friendAvatar.Image.Dispose();
                    friendAvatar.Image = System.Drawing.Image.FromFile(LoadPhoto(friendLogin.Text, login.Text));

                    if (yourAvatar.Image == null) yourAvatar.Visible = false;
                }
                else
                    friendAvatar.Visible = false;

                dialogOpened = true;
            }
        }

        public void scrollDialog()
        {
            messages.AutoScroll = true;
            messages.AutoScrollPosition = new Point(0, lastMessageLocation);
        }

        private void closeChat_Click(object sender, EventArgs e)
        {
            windowSize(324, 862);
            dialogOpened = false;
            friendLogin.Text = "";
            messages.Controls.Clear();
        }

        private void sendMessage_MouseMove(object sender, MouseEventArgs e)
        {
            sendMessage.Image = Properties.Resources.send2;
        }

        private void sendMessage_MouseLeave(object sender, EventArgs e)
        {
            sendMessage.Image = Properties.Resources.send1;
        }

        private void closeChat_MouseMove(object sender, MouseEventArgs e)
        {
            closeChat.Image = Properties.Resources.close_chat2;
        }

        private void closeChat_MouseLeave(object sender, EventArgs e)
        {
            closeChat.Image = Properties.Resources.close_chat1;
        }

        private void openChat_MouseMove(object sender, MouseEventArgs e)
        {
            openChat.Image = Properties.Resources.open_chat2;
        }

        private void openChat_MouseLeave(object sender, EventArgs e)
        {
            openChat.Image = Properties.Resources.open_chat1;
        }

        private void deleteFriend_MouseMove(object sender, MouseEventArgs e)
        {
            deleteFriend.Image = Properties.Resources.delete_friend2;
        }

        private void deleteFriend_MouseLeave(object sender, EventArgs e)
        {
            deleteFriend.Image = Properties.Resources.delete_friend1;
        }

        private void friendProfile_MouseMove(object sender, MouseEventArgs e)
        {
            friendProfile.Image = Properties.Resources.open_profile2;
        }

        private void friendProfile_MouseLeave(object sender, EventArgs e)
        {
            friendProfile.Image = Properties.Resources.open_profile1;
        }

        private void GetAllFriends()
        {
            friendList.Items.Clear();
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    db.Friendlist.Count();

                    var au = db.Friendlist.ToList();
                    foreach (var a in au)
                    {
                        if (login.Text == a.User)
                        {
                            friendList.Items.Add(a.Friend);
                        }
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeStatus(string status)
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (a.Login == yourNickname)
                        {
                            a.Status = status;
                            db.SaveChanges();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string LoadPhoto(string lgn1, string lgn2)
        {
            Image images = new Image();
            if (images.LoadImage(lgn1, lgn2) != "")
                return images.LoadImage(lgn1, lgn2);
            else
                return "";
        }

        private void TalkToMe_Activated(object sender, EventArgs e)
        {
            if (activated == true)
            {
                yourLogin.Text = yourNickname;
                id.Text = $"ID: {yourId}";
                GetAllFriends();
                ChangeStatus("Online");
                timer.Start();
                if (LoadPhoto(login.Text, login.Text) != "")
                {
                    avatar.Visible = true;
                    avatar.Image = System.Drawing.Image.FromFile(LoadPhoto(login.Text, login.Text));

                    yourAvatar.Visible = true;
                    yourAvatar.Image = System.Drawing.Image.FromFile(LoadPhoto(login.Text, login.Text));
                }
            }

            activated = false;
        }

        private void RemoveAFriend()
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Friendlist.ToList();
                    foreach (var a in au)
                    {
                        if (login.Text == a.User && lastFriend == a.Friend)
                        {
                            db.Friendlist.Remove(a);
                            db.SaveChanges();
                        }
                        if (login.Text == a.Friend && lastFriend == a.User)
                        {
                            db.Friendlist.Remove(a);
                            db.SaveChanges();
                        }
                    }
                }
                GetAllFriends();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteFriend_Click(object sender, EventArgs e)
        {
            if(friendList.SelectedIndex != -1)
            {
                var request = MessageBox.Show("Ви дійсно хочете видалити цього користувача зі списку друзів?", "Підтвердіть свій запит", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogOpened == true && friendList.SelectedItem.ToString() == friendLogin.Text)
                {
                    dialogOpened = false;
                    windowSize(324, 862);
                }

                if (request == DialogResult.Yes)
                    RemoveAFriend();              
            }
        }

        private void friendList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (friendList.SelectedIndex != -1)
                lastFriend = friendList.SelectedItem.ToString();
        }

        private void SaveLastVisit()
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (a.Login == login.Text)
                        {
                            a.LastVisit = $"{DateTime.Now}";
                            db.SaveChanges();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AvatarsDispose()
        {
            if (avatar.Image != null) avatar.Image.Dispose();
            if (yourAvatar.Image != null) yourAvatar.Image.Dispose();
            if (friendAvatar.Image != null) friendAvatar.Image.Dispose();
            if (Directory.Exists($"{login.Text}/Photos"))
            {
                Directory.Delete($"{login.Text}/Photos", true);
                Directory.Delete($"{login.Text}", true);
            }
        }

        private void TalkToMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            AvatarsDispose();
            SaveLastVisit();
            ChangeStatus("Offline");
        }

        private void search2_Click(object sender, EventArgs e)
        {
            search2.Visible = false;
            friendSearching.Visible = true;
            friendSearching.Focus();
        }

        private void SearchFriends()
        {
            friendList.Items.Clear();
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Friendlist.ToList();
                    foreach (var a in au)
                    {
                        if (a.User == login.Text && a.Friend.StartsWith(friendSearching.Text))
                        {
                            friendList.Items.Add(a.Friend);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void friendSearching_TextChanged(object sender, EventArgs e)
        {
            if (friendSearching.Text == "")
                GetAllFriends();
            else
                SearchFriends();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            SaveLastVisit();
            ChangeStatus("Offline");
            Application.Restart();
        }

        private void SaveMessage()
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    Messages mssgs = new Messages()
                    {
                        Addressant = login.Text,
                        Addressee = friendLogin.Text,
                        DialogCode = dialogCode,
                        SendDate = DateTime.Now,
                        Message = yourMessageText.Text
                    };

                    db.Messages.Add(mssgs);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            if (yourMessageText.Text != "" && yourMessageText.Text.Length <= 1000)
            {
                SaveMessage();
                PublicMessages();
                yourMessageText.Text = "";
            }
        }

        private void yourMessageText_TextChanged(object sender, EventArgs e)
        {
            if (yourMessageText.Text.Length > 1000)
            {
                symbolsLimit.Text = $"Перевищено ліміт символів(1000): {yourMessageText.Text.Length}";
                symbolsLimit.ForeColor = Color.Crimson;
            }
            else
            {
                symbolsLimit.Text = $"Кількість символів: {yourMessageText.Text.Length}";
                symbolsLimit.ForeColor = Color.LightGreen;
            }
        }

        private void OpenProfile(string lgn)
        {
            Profile pr = new Profile();
            pr.yourNickname = lgn;
            pr.viewerRole = yourRole;
            pr.ShowDialog();
        }

        private void friendProfile_Click(object sender, EventArgs e)
        {
            if(friendList.SelectedIndex != -1)
            {
                OpenProfile(friendList.SelectedItem.ToString());
            }
        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            OpenProfile(login.Text);
        }

        private void requestsToAdd_Click(object sender, EventArgs e)
        {
            RequestsToAdd rta = new RequestsToAdd();
            rta.yourLogin = login.Text;
            rta.ShowDialog();
        }

        private void usersSearching_Click(object sender, EventArgs e)
        {
            UsersSearching us = new UsersSearching();
            us.yourRole = yourRole;
            us.yourNickname = yourNickname;
            us.ShowDialog();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.yourNickname = login.Text;
            if (avatar.Image != null)
            {
                avatar.Image.Dispose();
                yourAvatar.Image.Dispose();
            }
          
            r.ShowDialog();

            if (LoadPhoto(login.Text, login.Text) != "")
            {
                avatar.Visible = true;
                avatar.Image = System.Drawing.Image.FromFile(LoadPhoto(login.Text, login.Text));

                yourAvatar.Visible = true;
                yourAvatar.Image = System.Drawing.Image.FromFile(LoadPhoto(login.Text, login.Text));
            }
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics();
            st.yourNickname = login.Text;
            st.ShowDialog();
        }
    }
}
