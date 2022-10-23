using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TalkToMe
{
    public partial class UsersSearching : Form
    {
        bool activated = true;
        public string yourNickname
        {
            get { return lgn; }
            set { lgn = value; }
        }

        public string yourRole
        {
            get { return role; }
            set { role = value; }
        }

        string lgn, role;
        public UsersSearching()
        {
            InitializeComponent();
            design();
        }

        private void design()
        {
            search.Parent = background;
            openProfile.Parent = background;
            addToFriendlist.Parent = background;

            idCb.Parent = background;
            loginCb.Parent = background;
            nameCb.Parent = background;
            surnameCb.Parent = background;
            countryCb.Parent = background;
            cityCb.Parent = background;
            sexCb.Parent = background;
            yearCb.Parent = background;

            scrollLeft.Parent = background;
            scrollRight.Parent = background;

            removeUser.Parent = background;

            editUser.Parent = background;

            userList.BackColor = ColorTranslator.FromHtml("#1c1c1a");
            id.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            login.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            name.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            surname.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            country.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            city.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            sex.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            yearOfBirth.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
        }

        private void search_MouseMove(object sender, MouseEventArgs e)
        {
            search.Image = Properties.Resources.search_user2;
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.Image = Properties.Resources.search_user1;
        }

        private void openProfile_MouseMove(object sender, MouseEventArgs e)
        {
            openProfile.Image = Properties.Resources.open_profile2;
        }

        private void openProfile_MouseLeave(object sender, EventArgs e)
        {
            openProfile.Image = Properties.Resources.open_profile1;
        }

        private void addToFriendlist_MouseMove(object sender, MouseEventArgs e)
        {
            addToFriendlist.Image = Properties.Resources.addToFriendlist2;
        }

        private void addToFriendlist_MouseLeave(object sender, EventArgs e)
        {
            addToFriendlist.Image = Properties.Resources.addToFriendlist1;
        }

        private void idCb_CheckedChanged(object sender, EventArgs e)
        {
            if (idCb.Checked == false)
                id.ReadOnly = true;

            else
            {
                id.ReadOnly = false;
                id.Focus();
            }
        }

        private void loginCb_CheckedChanged(object sender, EventArgs e)
        {
            if (loginCb.Checked == false)
                login.ReadOnly = true;

            else
            {
                login.ReadOnly = false;
                login.Focus();
            }
        }

        private void nameCb_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCb.Checked == false)
                name.ReadOnly = true;

            else
            {
                name.ReadOnly = false;
                name.Focus();
            }
        }

        private void surnameCb_CheckedChanged(object sender, EventArgs e)
        {
            if (surnameCb.Checked == false)
                surname.ReadOnly = true;

            else
            {
                surname.ReadOnly = false;
                surname.Focus();
            }
        }

        private void countryCb_CheckedChanged(object sender, EventArgs e)
        {
            if (countryCb.Checked == false)
                country.ReadOnly = true;

            else
            {
                country.ReadOnly = false;
                country.Focus();
            }
        }

        private void cityCb_CheckedChanged(object sender, EventArgs e)
        {
            if (cityCb.Checked == false)
                city.ReadOnly = true;

            else
            {
                city.ReadOnly = false;
                city.Focus();
            }
        }

        private void yearCb_CheckedChanged(object sender, EventArgs e)
        {
            if (yearCb.Checked == false)
                yearOfBirth.ReadOnly = true;

            else
            {
                yearOfBirth.ReadOnly = false;
                yearOfBirth.Focus();
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            char[] c = id.Text.ToArray();

            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '1' || i > '9')
                        id.Text = "";
            }
        }

        private void yearOfBirth_TextChanged(object sender, EventArgs e)
        {
            char[] c = yearOfBirth.Text.ToArray();

            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '1' || i > '9')
                        yearOfBirth.Text = "";
            }
        }

        private void GetUsers()
        {
            string command = "";
            userList.Items.Clear();
            var values = new List<string>();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=TTM; Integrated Security=SSPI;";

            if (idCb.Checked) values.Add($"Id = {id.Text}");
            if (loginCb.Checked) values.Add($"Login = N'{login.Text}'");
            if (nameCb.Checked) values.Add($"Name = N'{name.Text}'");
            if (surnameCb.Checked) values.Add($"Surname = N'{surname.Text}'");
            if (countryCb.Checked) values.Add($"Country = N'{country.Text}'");
            if (cityCb.Checked) values.Add($"City = N'{city.Text}'");
            if (sexCb.Checked) values.Add($"Sex = N'{sex.Text}'");
            if (yearCb.Checked) values.Add($"Year(DateOfBirth) = {yearOfBirth.Text}");

            foreach (string i in values)
            {
                if (values.Count > 1) command += i + " And ";
                if (values.Count == 1) command += i;
            }

            char[] cm = command.ToCharArray();

            string command2 = "";

            for (int i = 0; i < cm.Length; i++)
            {
                if (values.Count > 1)
                    if (i < cm.Length - 5) command2 += cm[i];

                if (values.Count == 1) command2 += cm[i];
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand($"Select Login From Users Where {command2}", connection);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr[0].ToString() != yourNickname)
                            userList.Items.Add(sdr[0].ToString());
                    }
                    sdr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetAllUsers()
        {
            userList.Items.Clear();
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                        if (a.Login != yourNickname)
                            userList.Items.Add(a.Login);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (idCb.Checked == false && loginCb.Checked == false && nameCb.Checked == false && surnameCb.Checked == false && countryCb.Checked == false && cityCb.Checked == false && sexCb.Checked == false && yearCb.Checked == false)
                GetAllUsers();

            else
                GetUsers();
        }

        private void SexChanging()
        {
            if (sex.Text == "Чоловіча")
                sex.Text = "Жіноча";

            else
                sex.Text = "Чоловіча";
        }

        private void scrollLeft_Click(object sender, EventArgs e)
        {
            SexChanging();
        }

        private void scrollRight_Click(object sender, EventArgs e)
        {
            SexChanging();
        }

        private void scrollLeft_MouseMove(object sender, MouseEventArgs e)
        {
            scrollLeft.Image = Properties.Resources.left2;
        }

        private void scrollLeft_MouseLeave(object sender, EventArgs e)
        {
            scrollLeft.Image = Properties.Resources.left1;
        }

        private void scrollRight_MouseMove(object sender, MouseEventArgs e)
        {
            scrollRight.Image = Properties.Resources.right2;
        }

        private void scrollRight_MouseLeave(object sender, EventArgs e)
        {
            scrollRight.Image = Properties.Resources.right1;
        }

        private void openProfile_Click(object sender, EventArgs e)
        {
            if(userList.SelectedIndex != -1)
            {
                Profile p = new Profile();
                p.yourNickname = userList.SelectedItem.ToString();
                p.viewerRole = yourRole;
                p.ShowDialog();
            }
        }
        private void DeleteRequest(string lg1, string lg2)
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Requests.ToList();
                    foreach (var a in au)
                    {
                        if (a.From == lg1 && a.To == lg2)
                        {
                            db.Requests.Remove(a);
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
        private void AcceptRequest(string lg1, string lg2)
        {
            bool yourReq = false, userReq = false;
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Requests.ToList();
                    foreach (var a in au)
                    {
                        if (a.From == lg1 && a.To == lg2)
                            yourReq = true;

                        if (a.From == lg2 && a.To == lg1)
                            userReq = true;
                    }

                    if (yourReq == true)
                    {
                        MessageBox.Show($"Ви вже відправляли свій запит до користувача {lg2}.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (yourReq == false && userReq == false)
                    {
                        Requests r = new Requests() { From = lg1, To = lg2 };
                        db.Requests.Add(r);
                        db.SaveChanges();
                        MessageBox.Show($"Ви відправили свій запит на додавання до списку друзів користувачу {lg2}.", "Запит відправлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (userReq == true)
                    {
                        Friendlist fl1 = new Friendlist() { User = lg1, Friend = lg2 };
                        db.Friendlist.Add(fl1);
                        Friendlist fl2 = new Friendlist() { User = lg2, Friend = lg1 };
                        db.Friendlist.Add(fl2);
                        db.SaveChanges();
                        DeleteRequest(lg2, lg1);

                        MessageBox.Show($"Ви прийняли запит на додавання до списку друзів користувача {lg2}.", "Запит відправлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FriendChecking()
        {
            bool friend = false;
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Friendlist.ToList();
                    foreach (var a in au)
                    {
                        if (a.User == yourNickname && a.Friend == userList.SelectedItem.ToString())
                        {
                            friend = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (friend == true)
            {
                MessageBox.Show($"Користувач {userList.SelectedItem.ToString()} вже є у вашому списку друзів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AcceptRequest(yourNickname, userList.SelectedItem.ToString());
            }
        }
        private void addToFriendlist_Click(object sender, EventArgs e)
        {
            if (userList.SelectedIndex != -1)
                FriendChecking();
        }

        private void UsersSearching_Activated(object sender, EventArgs e)
        {
            if (activated == true)
            {
                if (yourRole == "Admin")
                {
                    removeUser.Visible = true;
                    editUser.Visible = true;
                }
            }
            activated = false;
        }

        private void DeleteUser(string user)
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var u = db.Users.ToList();
                    foreach (var a in u)
                    {
                        if (a.Login == user)
                        {
                            db.Users.Remove(a);
                            db.SaveChanges();
                            break;
                        }
                    }

                    var f = db.Friendlist.ToList();
                    foreach (var a in f)
                    {
                        if (a.User == user || a.Friend == user)
                        {
                            db.Friendlist.Remove(a);
                            db.SaveChanges();
                        }
                    }

                    var p = db.Photos.ToList();
                    foreach (var a in p)
                    {
                        if (a.Login == user)
                        {
                            db.Photos.Remove(a);
                            db.SaveChanges();
                            break;
                        }
                    }

                    var r = db.Requests.ToList();
                    foreach (var a in r)
                    {
                        if (a.From == user || a.To == user)
                        {
                            db.Requests.Remove(a);
                            db.SaveChanges();
                        }
                    }

                    var m = db.Messages.ToList();
                    foreach (var a in m)
                    {
                        if (a.Addressant == user || a.Addressee == user)
                        {
                            db.Messages.Remove(a);
                            db.SaveChanges();
                        }
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeUser_MouseMove(object sender, MouseEventArgs e)
        {
            removeUser.Image = Properties.Resources.delete_friend2; 
        }

        private void removeUser_MouseLeave(object sender, EventArgs e)
        {
            removeUser.Image = Properties.Resources.delete_friend1;
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            if (userList.SelectedIndex != -1)
            {
                var req = MessageBox.Show($"Ви дійсно хочете видалити користувача {userList.SelectedItem.ToString()} з цієї мережі?", "Підтвердіть свій запит", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (req == DialogResult.Yes)
                {
                    DeleteUser(userList.SelectedItem.ToString());
                    userList.Items.Remove(userList.SelectedItem.ToString());
                }
            }
        }

        private void editUser_MouseMove(object sender, MouseEventArgs e)
        {
            editUser.Image = Properties.Resources.edit_profile2;
        }

        private void editUser_MouseLeave(object sender, EventArgs e)
        {
            editUser.Image = Properties.Resources.edit_profile1;
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yourRole == "Admin")
            {
                if(userList.SelectedItem.ToString() == "Admin")
                {
                    removeUser.Visible = false;
                    editUser.Visible = false;
                }
                else
                {
                    removeUser.Visible = true;
                    editUser.Visible = true;
                }
            }
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            if (userList.SelectedIndex != -1)
            {
                Registration r = new Registration();
                r.yourNickname = userList.SelectedItem.ToString();
                r.ShowDialog();
            }
        }
    }
}