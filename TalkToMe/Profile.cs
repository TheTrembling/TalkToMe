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
    public partial class Profile : Form
    {
        bool activated = true;
        string _viewerRole;
        string startRole;
        public string yourNickname
        {
            get { return login.Text; }
            set { login.Text = value; }
        }
        public string viewerRole
        {
            get { return _viewerRole; }
            set { _viewerRole = value; }
        }
        public string yourId
        {
            get { return id.Text; }
            set { id.Text = value; }
        }

        public Profile()
        {
            InitializeComponent();
        }

        private void LoadInfo()
        {
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (yourNickname == a.Login)
                        {
                            name.Text = a.Name;
                            id.Text = $"ID: {a.Id}";
                            surname.Text = a.Surname;
                            status.Text = a.Status;
                            sex.Text = a.Sex;
                            dateOfBirth.Text = $"{Convert.ToDateTime(a.DateOfBirth).ToShortDateString()}";
                            dateOfReg.Text = $"{Convert.ToDateTime(a.DateOfReg).ToShortDateString()}";
                            role.Text = a.Role;
                            county.Text = a.Country;
                            city.Text = a.City;

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            if (status.Text == "Online")
                status.ForeColor = ColorTranslator.FromHtml("#baf7c1");

            if (status.Text == "Offline")
                status.ForeColor = ColorTranslator.FromHtml("#e49797");

            if (sex.Text == "Чоловіча")
                sex.ForeColor = ColorTranslator.FromHtml("#82b2db");

            if (sex.Text == "Жіноча")
                sex.ForeColor = ColorTranslator.FromHtml("#d6a8f6");
        }

        private void design()
        {
            id.Parent = background;
            login.Parent = background;

            name.Parent = background;
            surname.Parent = background;
            status.Parent = background;
            sex.Parent = background;
            dateOfBirth.Parent = background;
            dateOfReg.Parent = background;
            role.Parent = background;
            county.Parent = background;
            city.Parent = background;

            scrollLeft.Parent = background;
            scrollRight.Parent = background;

            name.ForeColor = ColorTranslator.FromHtml("#fbd18f");
            surname.ForeColor = ColorTranslator.FromHtml("#fce98f");
            dateOfBirth.ForeColor = ColorTranslator.FromHtml("#bbecdc");
            dateOfReg.ForeColor = ColorTranslator.FromHtml("#9287cf");
            role.ForeColor = ColorTranslator.FromHtml("#b49f85");
            county.ForeColor = ColorTranslator.FromHtml("#99b680");
            city.ForeColor = ColorTranslator.FromHtml("#83a4b0");
        }

        private string LoadPhoto(string lgn1, string lgn2)
        {
            Image images = new Image();
            if (images.LoadImage(lgn1, lgn2) != "")
                return images.LoadImage(lgn1, lgn2);
            else
                return "";
        }

        private void Profile_Activated(object sender, EventArgs e)
        {
            if (activated == true)
            {
                design();
                LoadInfo();
                startRole = role.Text;

                if(viewerRole == "Admin" && login.Text != "Admin")
                {
                    scrollRight.Visible = true;
                    scrollLeft.Visible = true;
                }
                
                if (LoadPhoto(login.Text, yourNickname) != "")
                {
                    avatar.Visible = true;
                    avatar.Image = System.Drawing.Image.FromFile(LoadPhoto(login.Text, yourNickname));
                }
            }

            activated = false;
        }

        private void SaveNewRole()
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
                            a.Role = role.Text;
                            db.SaveChanges();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (avatar.Image != null) avatar.Image.Dispose();
                if (startRole != role.Text) SaveNewRole();
            }
            catch (Exception) { };
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

        private void RoleChange()
        {
            if (role.Text == "Admin")
                role.Text = "User";
            else
                role.Text = "Admin";
        }

        private void scrollLeft_Click(object sender, EventArgs e)
        {
            RoleChange();
        }

        private void scrollRight_Click(object sender, EventArgs e)
        {
            RoleChange();
        }
    }
}
