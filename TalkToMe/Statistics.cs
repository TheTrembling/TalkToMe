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
    public partial class Statistics : Form
    {
        string login;
        public string yourNickname
        {
            get { return login; }
            set { login = value; }
        }
        private class Friends
        {
            public int friendId { get; set; }
            public string friendLogin { get; set; }
        }
        private class Months
        {
            public string monthNumber { get; set; }
            public int dayNumber { get; set; }
        }

        List<Months> monthsList = new List<Months>();
        
        public Statistics()
        {
            InitializeComponent();
            design();

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

        private void design()
        {
            period.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            day1.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            month1.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            year1.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            day2.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            month2.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            year2.BackColor = BackColor = ColorTranslator.FromHtml("#2c1e1d");
            commStatistics.BackColor = ColorTranslator.FromHtml("#1c1c1a");

            search.Parent = background;
            scrollLeft.Parent = background;
            scrollRight.Parent = background;
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

        private void search_MouseMove(object sender, MouseEventArgs e)
        {
            search.Image = Properties.Resources.search_user2;
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.Image = Properties.Resources.search_user1;
        }

        private void ChangePeriod()
        {
            if (period.Text == "За весь час")
            {
                period.Text = "За певний період";
                day1.ReadOnly = false;
                month1.ReadOnly = false;
                year1.ReadOnly = false;

                day2.ReadOnly = false;
                month2.ReadOnly = false;
                year2.ReadOnly = false;
            }

            else
            {
                period.Text = "За весь час";
                day1.ReadOnly = true;
                month1.ReadOnly = true;
                year1.ReadOnly = true;

                day2.ReadOnly = true;
                month2.ReadOnly = true;
                year2.ReadOnly = true;
            }
        }

        private void scrollLeft_Click(object sender, EventArgs e)
        {
            ChangePeriod();
        }

        private void scrollRight_Click(object sender, EventArgs e)
        {
            ChangePeriod();
        }

        private void LoadStatistics()
        {
            commStatistics.Items.Clear();
            string command;

            string date1 = $"{month1.Text}.{day1.Text}.{year1.Text}";
            string date2 = $"{month2.Text}.{day2.Text}.{year2.Text}";

            if (period.Text == "За весь час")
                command = $"Select Distinct DialogCode, Count(DialogCode) From Messages Where Addressant = '{yourNickname}' Or Addressee = '{yourNickname}' Group By DialogCode Order by Count(DialogCode) DESC";

            else
                command = $"Select Distinct DialogCode, Count(DialogCode) From Messages Where (Addressant = '{yourNickname}' Or Addressee = '{yourNickname}') And (SendDate >= Cast('{date1}' As datetime) And SendDate <= Cast('{date2}' As datetime)) Group By DialogCode Order by Count(DialogCode) DESC";


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=TTM; Integrated Security=SSPI;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(command, connection);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string[] str = sdr[0].ToString().Split(' ');
                        string friendLogin = "";
                        if (str[0].ToString() != yourNickname) friendLogin = str[0].ToString();
                        if (str[2].ToString() != yourNickname) friendLogin = str[2].ToString();

                        commStatistics.Items.Add($"Логін: {friendLogin} | К-ть повідомлень: {sdr[1]}");
                    }
                    sdr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string EditDate(string s)
        {
            if (s.Length == 1)
                s = "0" + s;

            return s;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (period.Text == "За певний період")
            {
                day1.Text = EditDate(day1.Text);
                month1.Text = EditDate(month1.Text);

                day2.Text = EditDate(day2.Text);
                month2.Text = EditDate(month2.Text);

                if (day1.Text != "" && month1.Text != "" && year1.Text != "" && day2.Text != "" && month2.Text != "" && year2.Text != "")
                    LoadStatistics();
                else
                    MessageBox.Show("Будь ласка, заповніть усі вільні поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (period.Text == "За весь час")
                LoadStatistics();
        }

        private string ChangeDate(string day, string month, string year)
        {
            int dayNum = 0;
            if (day != "")
                dayNum = Convert.ToInt32(day);

            if (day.Length == 2)
            {
                if (month == "02")
                {
                    if (year.Length == 4)
                    {
                        if (DateTime.IsLeapYear(Convert.ToInt32(year)) == true && dayNum > 29)
                        {
                            day = "29";
                        }

                        if (DateTime.IsLeapYear(Convert.ToInt32(year)) == false && dayNum > 28)
                        {
                            day = "28";
                        }
                    }
                }

                if (month != "02")
                {
                    foreach (var i in monthsList)
                        if (month == i.monthNumber && Convert.ToInt32(day) > i.dayNumber)
                        {
                            day = i.dayNumber.ToString();
                        }
                }
            }
            return day;
        }

        private string UndoDay(string day)
        {
            char[] c = day.ToArray();
            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '0' || i > '9')
                        day = "";
            }

            if (c.Length > 2)
                day = $"{c[0]}{c[1]}";

            if (c.Length > 0 && c[0] > '3')
                day = "";

            if (c.Length == 2)
            {
                if (c[0] == '0' && c[1] == '0')
                    day = c[0].ToString();

                if (c[0] == '3' && c[1] > '1')
                    day = c[0].ToString();
            }
            return day;
        }

        private string UndoMonth(string month)
        {
            char[] c = month.ToArray();
            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '0' || i > '9')
                        month = "";
            }

            if (c.Length > 2)
                month= $"{c[0]}{c[1]}";

            if (c.Length > 0 && c[0] > '1')
                month = "";

            if (c.Length == 2)
            {
                if (c[0] == '0' && c[1] == '0')
                    month = c[0].ToString();

                if (c[0] == '1' && c[1] > '2')
                    month = c[0].ToString();
            }
            return month;
        }

        private string UndoYear(string year)
        {
            char[] c = year.ToArray();
            char[] c2 = DateTime.Now.Year.ToString().ToCharArray();

            if (c.Length > 0)
            {
                foreach (var i in c)
                    if (i < '0' || i > '9')
                        year = "";

                if (c[0] > '2' || c[0] < '2')
                    year = "";
            }

            if (c.Length == 2)
            {

                if (c[0] == '2' && c[1] > c2[1])
                    year = "2";
            }

            if (c.Length == 3)
            {
                if (c[0] == '2' && c[1] == '0' && c[2] > c2[2])
                    year = "20";
            }

            if (c.Length == 4)
            {
                if (c[0] == '2' && c[1] == '0' && c[2] == c2[2] && c[3] > c2[3])
                    year = "20" + c[3].ToString();
            }

            if (c.Length > 4)
                year = $"{c[0]}{c[1]}{c[2]}{c[3]}";

            return year;
        }

        private void day1_TextChanged(object sender, EventArgs e)
        {
            day1.Text = UndoDay(day1.Text);
            day1.Text = ChangeDate(day1.Text, month1.Text, year1.Text);
        }

        private void month1_TextChanged(object sender, EventArgs e)
        {
            month1.Text = UndoMonth(month1.Text);
            day1.Text = ChangeDate(day1.Text, month1.Text, year1.Text);
        }

        private void year1_TextChanged(object sender, EventArgs e)
        {
            year1.Text = UndoYear(year1.Text);
            day1.Text = ChangeDate(day1.Text, month1.Text, year1.Text);
        }

        private void day2_TextChanged(object sender, EventArgs e)
        {
            day2.Text = UndoDay(day2.Text);
            day2.Text = ChangeDate(day2.Text, month2.Text, year2.Text);
        }

        private void month2_TextChanged(object sender, EventArgs e)
        {
            month2.Text = UndoMonth(month2.Text);
            day2.Text = ChangeDate(day2.Text, month2.Text, year2.Text);
        }

        private void year2_TextChanged(object sender, EventArgs e)
        {
            year2.Text = UndoYear(year2.Text);
            day2.Text = ChangeDate(day2.Text, month2.Text, year2.Text);
        }
    }
}
