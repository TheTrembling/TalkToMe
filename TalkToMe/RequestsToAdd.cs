using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkToMe
{
    public partial class RequestsToAdd : Form
    {
        string login;
        bool activated = true;
        public string yourLogin
        {
            get { return login; }
            set { login = value; }
        }
        public RequestsToAdd()
        {
            InitializeComponent();
            design();
            yourReqSearching.LostFocus += YourReqSearching_LostFocus;
            otherReqSearching.LostFocus += OtherReqSearching_LostFocus;
        }

        private void OtherReqSearching_LostFocus(object sender, EventArgs e)
        {
            if (otherReqSearching.Text == "")
            {
                otherReqSearching.Visible = false;
                search2.Visible = true;
            }
        }

        private void YourReqSearching_LostFocus(object sender, EventArgs e)
        {
            if (yourReqSearching.Text == "")
            {
                yourReqSearching.Visible = false;
                search1.Visible = true;
            }
        }

        private void design()
        {
            profile1.Parent = background;
            cancel1.Parent = background;

            profile2.Parent = background;
            cancel2.Parent = background;
            accept.Parent = background;

            yourRequests.BackColor = ColorTranslator.FromHtml("#1c1c1a");
            otherRequests.BackColor = ColorTranslator.FromHtml("#dbddcc");

            yourReqSearching.BackColor = ColorTranslator.FromHtml("#2c1e1d");
            otherReqSearching.BackColor = ColorTranslator.FromHtml("#e9e0df");
            search1.BackColor = ColorTranslator.FromHtml("#2c1e1d");
            search2.BackColor = ColorTranslator.FromHtml("#e9e0df");
        }

        private void search1_Click(object sender, EventArgs e)
        {
            search1.Visible = false;
            yourReqSearching.Visible = true;
            yourReqSearching.Focus();
        }

        private void search2_Click(object sender, EventArgs e)
        {
            search2.Visible = false;
            otherReqSearching.Visible = true;
            otherReqSearching.Focus();
        }

        private void profile1_MouseMove(object sender, MouseEventArgs e)
        {
            profile1.Image = Properties.Resources.open_profile2;
        }

        private void profile1_MouseLeave(object sender, EventArgs e)
        {
            profile1.Image = Properties.Resources.open_profile1;
        }

        private void cancel1_MouseMove(object sender, MouseEventArgs e)
        {
            cancel1.Image = Properties.Resources.delete_friend2;
        }

        private void cancel1_MouseLeave(object sender, EventArgs e)
        {
            cancel1.Image = Properties.Resources.delete_friend1;
        }

        private void profile2_MouseMove(object sender, MouseEventArgs e)
        {
            profile2.Image = Properties.Resources.user_profile2;
        }

        private void profile2_MouseLeave(object sender, EventArgs e)
        {
            profile2.Image = Properties.Resources.user_profile1;
        }

        private void accept_MouseMove(object sender, MouseEventArgs e)
        {
            accept.Image = Properties.Resources.accept2;
        }

        private void accept_MouseLeave(object sender, EventArgs e)
        {
            accept.Image = Properties.Resources.accept1;
        }

        private void cancel2_MouseMove(object sender, MouseEventArgs e)
        {
            cancel2.Image = Properties.Resources.cancel2;
        }

        private void cancel2_MouseLeave(object sender, EventArgs e)
        {
            cancel2.Image = Properties.Resources.cancel1;
        }

        private void GetRequests(bool req1, bool req2)
        {
            try
            {
                if (req1 == true) yourRequests.Items.Clear();
                if (req2 == true) otherRequests.Items.Clear();

                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Requests.ToList();
                    foreach (var a in au)
                    {
                        if (yourLogin == a.From && req1 == true)
                        {
                            yourRequests.Items.Add(a.To);
                        }
                        if (yourLogin == a.To && req2 == true)
                        {
                            otherRequests.Items.Add(a.From);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void RequestsToAdd_Activated(object sender, EventArgs e)
        {
            if(activated == true)
            {
                GetRequests(true, true);
            }
            activated = false;
        }
        private void SearchRequests(bool req1, bool req2)
        {
            if (req1 == true) yourRequests.Items.Clear();
            if (req2 == true) otherRequests.Items.Clear();

            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Requests.ToList();
                    foreach (var a in au)
                    {
                        if (req1 == true && a.From == yourLogin && a.To.StartsWith(yourReqSearching.Text))
                        {
                            yourRequests.Items.Add(a.To);
                        }

                        if (req2 == true && a.To == yourLogin && a.From.StartsWith(otherReqSearching.Text))
                        {
                            otherRequests.Items.Add(a.From);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void yourReqSearching_TextChanged(object sender, EventArgs e)
        {
            if (yourReqSearching.Text == "")
                GetRequests(true, false);
            else
                SearchRequests(true, false);
        }

        private void otherReqSearching_TextChanged(object sender, EventArgs e)
        {
            if (otherReqSearching.Text == "")
                GetRequests(false, true);
            else
                SearchRequests(false, true);
        }

        private void profile1_Click(object sender, EventArgs e)
        {
            if(yourRequests.SelectedIndex != -1)
            {
                Profile p = new Profile();
                p.yourNickname = yourRequests.SelectedItem.ToString();
                p.ShowDialog();
            }
        }

        private void profile2_Click(object sender, EventArgs e)
        {
            if (otherRequests.SelectedIndex != -1)
            {
                Profile p = new Profile();
                p.yourNickname = otherRequests.SelectedItem.ToString();
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            if (yourRequests.SelectedIndex != -1)
            {
                yourReqSearching.Text = "";
                yourReqSearching.Visible = false;
                search1.Visible = true;
                DeleteRequest(yourLogin, yourRequests.SelectedItem.ToString());
                GetRequests(true, false);
            }
        }

        private void cancel2_Click(object sender, EventArgs e)
        {
            if (otherRequests.SelectedIndex != -1)
            {
                otherReqSearching.Text = "";
                otherReqSearching.Visible = false;
                search2.Visible = true;
                DeleteRequest(otherRequests.SelectedItem.ToString(), yourLogin);
                GetRequests(false, true);
            }
        }

        private void AcceptRequest(string lgn)
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    Friendlist fl1 = new Friendlist() { User = yourLogin, Friend = lgn };
                    db.Friendlist.Add(fl1);
                    Friendlist fl2 = new Friendlist() { User = lgn, Friend = yourLogin };
                    db.Friendlist.Add(fl2);

                    db.SaveChanges();

                    DeleteRequest(otherRequests.SelectedItem.ToString(), yourLogin);
                    GetRequests(false, true);

                    MessageBox.Show($"Ви прийняли запит користувача {lgn}", "Запит прийнято", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (otherRequests.SelectedIndex != -1)
                AcceptRequest(otherRequests.SelectedItem.ToString());
        }
    }
}
