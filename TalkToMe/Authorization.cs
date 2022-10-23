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
    public partial class Authorization : Form
    {
        int id;
        string role;
        private void GetAllUsers(string login, string password)
        {
            bool userChecking = false;
            string status = "";
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (login == a.Login && password == a.Password)
                        {
                            userChecking = true;
                            id = a.Id;
                            status = a.Status;
                            role = a.Role;
                        }

                        if (userChecking == true)
                            break;
                    }

                    if (userChecking == true && status == "Offline")
                        OpenTTM();

                    if (userChecking == true && status == "Online")
                        MessageBox.Show("Користувач з таким логіном вже знаходиться у мережі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (userChecking == false)
                        MessageBox.Show("Акаунту з таким логіном не існує або пароль було введено неправильно.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void OpenTTM()
        {
            TalkToMe ttm = new TalkToMe();
            ttm.yourNickname = login.Text;
            ttm.yourId = id;
            ttm.yourRole = role;
            this.Hide();
            ttm.Show();
        }

        public Authorization()
        {
            InitializeComponent();
            design();
        }
        private void design()
        {
            enter.Parent = background;
            create.Parent = background;
        }

        private void enter_MouseMove(object sender, MouseEventArgs e)
        {
            enter.Image = Properties.Resources.enter2;
        }

        private void enter_MouseLeave(object sender, EventArgs e)
        {
            enter.Image = Properties.Resources.enter1;
        }

        private void create_MouseMove(object sender, MouseEventArgs e)
        {
            create.Image = Properties.Resources.create2;
        }

        private void create_MouseLeave(object sender, EventArgs e)
        {
            create.Image = Properties.Resources.create1;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            GetAllUsers(login.Text, password.Text);
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetAllUsers(login.Text, password.Text);
            
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                try
                {
                    using (TalkToMeEntities db = new TalkToMeEntities())
                    {
                        var au = db.Users.ToList();
                        foreach (var a in au)
                        {
                            a.Status = "Offline";
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetAllUsers(login.Text, password.Text);     
        }

        private void create_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.yourNickname = "";
            r.ShowDialog();
        }
    }
}
