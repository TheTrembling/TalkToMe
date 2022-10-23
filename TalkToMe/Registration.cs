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
    public partial class Registration : Form
    {
        bool activated = true;
        string format, path;
        string avatarName = "";
        
        public string yourNickname
        {
            get { return login.Text; }
            set { login.Text = value; }
        }

        private class Months
        {
            public string monthNumber { get; set; }
            public int dayNumber { get; set; }
        }

        List<Months> monthsList = new List<Months>();
        public Registration()
        {
            InitializeComponent();
            design();
            day.LostFocus += Day_LostFocus;
            month.LostFocus += Month_LostFocus;
            year.LostFocus += Year_LostFocus;

            monthsList.Add(new Months() { monthNumber = "01", dayNumber = 31 });
            monthsList.Add(new Months() { monthNumber = "03", dayNumber = 31 });
            monthsList.Add(new Months() { monthNumber = "04", dayNumber = 30 });
            monthsList.Add(new Months() { monthNumber = "05", dayNumber = 31 });
            monthsList.Add(new Months() { monthNumber = "06", dayNumber = 30 });
            monthsList.Add(new Months() { monthNumber = "07", dayNumber = 31 });
            monthsList.Add(new Months() { monthNumber = "08", dayNumber = 31 });
            monthsList.Add(new Months() { monthNumber = "09", dayNumber = 30 });
            monthsList.Add(new Months() { monthNumber = "10", dayNumber = 31 });
            monthsList.Add(new Months() { monthNumber = "11", dayNumber = 30 });
            monthsList.Add(new Months() { monthNumber = "12", dayNumber = 31 });
        }

        private string EditDate(string s)
        {
            if (s.Length == 1)
                s = "0" + s;

            return s;
        }

        private void Day_LostFocus(object sender, EventArgs e)
        {
            day.Text = EditDate(day.Text);
            ChangeDate();
        }

        private void Month_LostFocus(object sender, EventArgs e)
        {
            month.Text = EditDate(month.Text);
            ChangeDate();
        }

        private void Year_LostFocus(object sender, EventArgs e)
        {
            char[] c = year.Text.ToCharArray();

            if (year.Text.Length == 1)
                year.Text = "200" + year.Text;

            if (year.Text.Length == 2)
                year.Text = "20" + year.Text;

            if (year.Text.Length == 3)
                year.Text = "200" + c[0];

            ChangeDate();
        }

        private void ChangeDate()
        {
            int dayNum = 0;
            if(day.Text != "")
                dayNum = Convert.ToInt32(day.Text);

            if (day.Text.Length == 2)
            {
                if (month.Text == "02")
                {
                    if (year.Text.Length == 4)
                    {
                        if (DateTime.IsLeapYear(Convert.ToInt32(year.Text)) == true && dayNum > 29)
                        {
                            day.Text = "29";
                        }

                        if (DateTime.IsLeapYear(Convert.ToInt32(year.Text)) == false && dayNum > 28)
                        {
                            day.Text = "28";
                        }
                    }
                }

                if (month.Text != "02")
                {
                    foreach (var i in monthsList)
                        if (month.Text == i.monthNumber && Convert.ToInt32(day.Text) > i.dayNumber)
                        {
                            day.Text = i.dayNumber.ToString();
                        }
                }
            }
        }

        private void design()
        {
            photoName.Parent = background;
            ready.Parent = background;
            load.Parent = background;
            scrollLeft.Parent = background;
            scrollRight.Parent = background;
            
            login.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            password.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            name.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            surname.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            sex.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            day.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            month.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            year.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            county.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            city.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
        }

        private void UndoDay()
        {
            char[] c = day.Text.ToArray();
            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '0' || i > '9')
                        day.Text = "";
            }

            if (c.Length > 2)
                day.Text = $"{c[0]}{c[1]}";

            if (c.Length > 0 && c[0] > '3')
                day.Text = "";

            if (c.Length == 2)
            {
                if (c[0] == '0' && c[1] == '0')
                    day.Text = c[0].ToString();

                if (c[0] == '3' && c[1] > '1')
                    day.Text = c[0].ToString();
            }
            ChangeDate();
        }

        private void day_TextChanged(object sender, EventArgs e)
        {
            UndoDay();
        }

        private void UndoMonth()
        {
            char[] c = month.Text.ToArray();
            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '0' || i > '9')
                        month.Text = "";
            }

            if (c.Length > 2)
                month.Text = $"{c[0]}{c[1]}";

            if (c.Length > 0 && c[0] > '1')
                month.Text = "";

            if (c.Length == 2)
            {
                if (c[0] == '0' && c[1] == '0')
                    month.Text = c[0].ToString();

                if (c[0] == '1' && c[1] > '2')
                    month.Text = c[0].ToString();
            }
            ChangeDate();
        }

        private void month_TextChanged(object sender, EventArgs e)
        {
            UndoMonth();
        }

        private void UndoYear()
        {
            char[] c = year.Text.ToArray();
            char[] c2 = DateTime.Now.Year.ToString().ToCharArray();

            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '0' || i > '9')
                        year.Text = "";

                if (c[0] > '2')
                    year.Text = "";
            }

            if (c.Length == 2)
            {
                if (c[0] == '1' && c[1] < '9')
                    year.Text = "1";

                if (c[0] == '2' && c[1] > '0')
                    year.Text = "2";
            }

            if (c.Length == 3)
            {
                if (c[0] == '2' && c[1] == '0' && c[2] > c2[2])
                    year.Text = "20";
            }

            if (c.Length == 4)
            {
                if (c[0] == '2' && c[1] == '0' && c[2] == c2[2] && c[3] > c2[3])
                    year.Text = "20" + c[3].ToString();
            }

            if (c.Length > 4)
                 year.Text = $"{c[0]}{c[1]}{c[2]}{c[3]}";

            ChangeDate();
        }

        private void year_TextChanged(object sender, EventArgs e)
        {
            UndoYear();
        }

        private void ready_MouseMove(object sender, MouseEventArgs e)
        {
            ready.Image = Properties.Resources.ready2;
        }

        private void ready_MouseLeave(object sender, EventArgs e)
        {
            ready.Image = Properties.Resources.ready1;
        }

        private void load_MouseMove(object sender, MouseEventArgs e)
        {
            load.Image = Properties.Resources.load2;
        }

        private void load_MouseLeave(object sender, EventArgs e)
        {
            load.Image = Properties.Resources.load1;
        }

        private void SexChanging()
        {
            if (sex.Text == "Чоловіча")
                sex.Text = "Жіноча";

            else
                sex.Text = "Чоловіча";
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

        private void scrollLeft_Click(object sender, EventArgs e)
        {
            SexChanging();
        }

        private void scrollRight_Click(object sender, EventArgs e)
        {
            SexChanging();
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                format = "";
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Відкрити зображення";
                    dlg.Filter = "All files (*.*)|*.*|Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        avatar.Visible = true;
                        if (avatar.Image != null) avatar.Image.Dispose();
                        avatar.Image = System.Drawing.Image.FromFile(dlg.FileName);
                        string[] split = dlg.FileName.Split('\\');
                        photoName.Text = split[split.Length - 1];

                        char[] charArray = photoName.Text.ToCharArray();
                        for (int i = 0; i < charArray.Length; i++)
                            if (i >= charArray.Length - 4)
                                format += charArray[i];

                        path = dlg.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void LoginChecking()
        {
            bool userChecking = false;
            try
            {
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    var au = db.Users.ToList();
                    foreach (var a in au)
                    {
                        if (login.Text == a.Login)
                        {
                            userChecking = true;
                        }

                        if (userChecking == true)
                            break;
                    }

                    if (userChecking == false)
                    {
                        SaveUser();
                        SavePhoto();

                        MessageBox.Show("Реєстрація пройшла успішно.", "Акаунт створено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (avatar.Image != null)
                            avatar.Image.Dispose();
                        this.Hide();
                    }
                    else MessageBox.Show("Акаунт з таким логіном вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void SaveUser()
        {
            try
            {
                DateTime dob = Convert.ToDateTime($"{day.Text}.{month.Text}.{year.Text}");
                using (TalkToMeEntities db = new TalkToMeEntities())
                {
                    Users u = new Users()
                    {
                        Login = login.Text,
                        Password = password.Text,
                        Name = name.Text,
                        Surname = surname.Text,
                        Sex = sex.Text,
                        DateOfBirth = dob,
                        Country = county.Text,
                        City = city.Text,
                        DateOfReg = DateTime.Now,
                        Role = "User",
                        Status = "Offline"
                    };
                    db.Users.Add(u);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void SavePhoto()
        {
            if (avatar.Image != null)
            {
                try
                {
                    using (TalkToMeEntities db = new TalkToMeEntities())
                    {
                        byte[] imageData;
                        avatar.Image.Dispose();
                        using (FileStream fs = new FileStream(path, FileMode.Open))
                        {
                            imageData = new byte[fs.Length];
                            fs.Read(imageData, 0, imageData.Length);
                        }

                        Photos p = new Photos()
                        {
                            FileName = login.Text + format,
                            Login = login.Text,
                            ImageData = imageData
                        };
                        db.Photos.Add(p);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (avatar.Image != null)
                avatar.Image.Dispose();
            background.Image.Dispose();
        }

        private void LoadInfo()
        {
            using (TalkToMeEntities db = new TalkToMeEntities())
            {
                var au = db.Users.ToList();
                try
                {
                    foreach (var a in au)
                    {
                        if (a.Login == yourNickname)
                        {
                            password.Text = a.Password;
                            name.Text = a.Name;
                            surname.Text = a.Surname;
                            sex.Text = a.Sex;

                            string[] spl = a.DateOfBirth.ToString().Split('.');

                            day.Text = spl[0];
                            month.Text = spl[1];
                            year.Text = spl[2];
                            county.Text = a.Country;
                            city.Text = a.City;
                        }
                    }
                } 
                catch(Exception ex) 
                { 
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private string LoadPhoto(string lgn1, string lgn2)
        {
            Image images = new Image();
            if (images.LoadImage(lgn1, lgn2) != "")
            {
                return images.LoadImage(lgn1, lgn2);
            }
            else
                return "";
        }

        private void Registration_Activated(object sender, EventArgs e)
        {
            if (activated == true)
            {
                if (yourNickname != "")
                {
                    this.Text = "Talk To Me - Редагування";
                    login.ReadOnly = true;
                    LoadInfo();
                    if (LoadPhoto(login.Text, yourNickname) != "")
                    {
                        avatar.Visible = true;
                        avatar.Image = System.Drawing.Image.FromFile(LoadPhoto(login.Text, yourNickname));
                        string[] split = LoadPhoto(login.Text, yourNickname).Split('/');
                        photoName.Text = split[split.Length - 1];
                        avatarName = photoName.Text;
                        path = LoadPhoto(login.Text, yourNickname);
                        background.Image = Properties.Resources.profileChanging_background;
                    }
                }
                else
                    this.Text = "Talk To Me - Реєстрація";
            }
            activated = false;
        }

        private void ChangeInfo()
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
                            a.Password = password.Text;
                            a.Name = name.Text;
                            a.Surname = surname.Text;
                            a.Sex = sex.Text;
                            a.DateOfBirth = Convert.ToDateTime($"{day.Text}.{month.Text}.{year.Text}");


                            a.Country = county.Text;
                            a.City = city.Text;
                            db.SaveChanges();
                            break;
                        }
                    }
                    if (avatar.Image != null)
                    {
                        var ph = db.Photos.ToList();

                        foreach (var a in ph)
                        {
                            if (a.Login == login.Text)
                            {
                                db.Photos.Remove(a);
                                db.SaveChanges();
                            }
                        }

                        if (photoName.Text != avatarName)
                        {
                            SavePhoto();
                            File.Delete($"{login.Text}/Photos/{login.Text}{format}");
                        }
                        else
                            SavePhoto();


                        if (avatar.Image != null)
                            avatar.Image.Dispose();
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Ви успішно редагували свій профіль.", "Інформацію змінено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void ready_Click(object sender, EventArgs e)
        {
            int fullFields = 0;

            if (login.Text != "" && login.Text != " ") fullFields++;
            if (password.Text != "" && password.Text != " ") fullFields++;
            if (name.Text != "" && name.Text != " ") fullFields++;
            if (surname.Text != "" && surname.Text != " ") fullFields++;
            if (day.Text != "" && day.Text != " ") fullFields++;
            if (month.Text != "" && month.Text != " ") fullFields++;
            if (year.Text != "" && year.Text != " ") fullFields++;
            if (county.Text != "" && county.Text != " ") fullFields++;
            if (city.Text != "" && city.Text != " ") fullFields++;

            try
            {
                if (fullFields < 9)
                {
                    MessageBox.Show("Усі поля повинні бути заповнені.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (login.ReadOnly == false)
                        LoginChecking();

                    else
                        ChangeInfo();
                }
            }
            catch (Exception) { };
        }
    }
}
