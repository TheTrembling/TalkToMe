namespace TalkToMe
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.background = new System.Windows.Forms.PictureBox();
            this.period = new System.Windows.Forms.TextBox();
            this.day1 = new System.Windows.Forms.TextBox();
            this.month1 = new System.Windows.Forms.TextBox();
            this.year1 = new System.Windows.Forms.TextBox();
            this.day2 = new System.Windows.Forms.TextBox();
            this.month2 = new System.Windows.Forms.TextBox();
            this.year2 = new System.Windows.Forms.TextBox();
            this.scrollLeft = new System.Windows.Forms.PictureBox();
            this.scrollRight = new System.Windows.Forms.PictureBox();
            this.commStatistics = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = global::TalkToMe.Properties.Resources.communicationstatistics_background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(568, 738);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // period
            // 
            this.period.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.period.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.period.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.period.Location = new System.Drawing.Point(168, 96);
            this.period.Name = "period";
            this.period.ReadOnly = true;
            this.period.Size = new System.Drawing.Size(234, 19);
            this.period.TabIndex = 3;
            this.period.Text = "За весь час";
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // day1
            // 
            this.day1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.day1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.day1.Location = new System.Drawing.Point(61, 166);
            this.day1.Name = "day1";
            this.day1.ReadOnly = true;
            this.day1.Size = new System.Drawing.Size(53, 19);
            this.day1.TabIndex = 4;
            this.day1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day1.TextChanged += new System.EventHandler(this.day1_TextChanged);
            // 
            // month1
            // 
            this.month1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.month1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.month1.Location = new System.Drawing.Point(135, 166);
            this.month1.Name = "month1";
            this.month1.ReadOnly = true;
            this.month1.Size = new System.Drawing.Size(53, 19);
            this.month1.TabIndex = 5;
            this.month1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month1.TextChanged += new System.EventHandler(this.month1_TextChanged);
            // 
            // year1
            // 
            this.year1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.year1.Location = new System.Drawing.Point(209, 166);
            this.year1.Name = "year1";
            this.year1.ReadOnly = true;
            this.year1.Size = new System.Drawing.Size(53, 19);
            this.year1.TabIndex = 6;
            this.year1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year1.TextChanged += new System.EventHandler(this.year1_TextChanged);
            // 
            // day2
            // 
            this.day2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.day2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.day2.Location = new System.Drawing.Point(305, 166);
            this.day2.Name = "day2";
            this.day2.ReadOnly = true;
            this.day2.Size = new System.Drawing.Size(53, 19);
            this.day2.TabIndex = 7;
            this.day2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day2.TextChanged += new System.EventHandler(this.day2_TextChanged);
            // 
            // month2
            // 
            this.month2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.month2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.month2.Location = new System.Drawing.Point(379, 166);
            this.month2.Name = "month2";
            this.month2.ReadOnly = true;
            this.month2.Size = new System.Drawing.Size(53, 19);
            this.month2.TabIndex = 8;
            this.month2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month2.TextChanged += new System.EventHandler(this.month2_TextChanged);
            // 
            // year2
            // 
            this.year2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.year2.Location = new System.Drawing.Point(453, 166);
            this.year2.Name = "year2";
            this.year2.ReadOnly = true;
            this.year2.Size = new System.Drawing.Size(53, 19);
            this.year2.TabIndex = 9;
            this.year2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year2.TextChanged += new System.EventHandler(this.year2_TextChanged);
            // 
            // scrollLeft
            // 
            this.scrollLeft.BackColor = System.Drawing.Color.Transparent;
            this.scrollLeft.Image = global::TalkToMe.Properties.Resources.left1;
            this.scrollLeft.Location = new System.Drawing.Point(132, 92);
            this.scrollLeft.Name = "scrollLeft";
            this.scrollLeft.Size = new System.Drawing.Size(26, 31);
            this.scrollLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scrollLeft.TabIndex = 20;
            this.scrollLeft.TabStop = false;
            this.scrollLeft.Click += new System.EventHandler(this.scrollLeft_Click);
            this.scrollLeft.MouseLeave += new System.EventHandler(this.scrollLeft_MouseLeave);
            this.scrollLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scrollLeft_MouseMove);
            // 
            // scrollRight
            // 
            this.scrollRight.BackColor = System.Drawing.Color.Transparent;
            this.scrollRight.Image = global::TalkToMe.Properties.Resources.right1;
            this.scrollRight.Location = new System.Drawing.Point(414, 92);
            this.scrollRight.Name = "scrollRight";
            this.scrollRight.Size = new System.Drawing.Size(26, 31);
            this.scrollRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scrollRight.TabIndex = 21;
            this.scrollRight.TabStop = false;
            this.scrollRight.Click += new System.EventHandler(this.scrollRight_Click);
            this.scrollRight.MouseLeave += new System.EventHandler(this.scrollRight_MouseLeave);
            this.scrollRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scrollRight_MouseMove);
            // 
            // commStatistics
            // 
            this.commStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commStatistics.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commStatistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.commStatistics.FormattingEnabled = true;
            this.commStatistics.ItemHeight = 19;
            this.commStatistics.Location = new System.Drawing.Point(83, 234);
            this.commStatistics.Name = "commStatistics";
            this.commStatistics.Size = new System.Drawing.Size(399, 361);
            this.commStatistics.TabIndex = 22;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Image = global::TalkToMe.Properties.Resources.search_user1;
            this.search.Location = new System.Drawing.Point(209, 626);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(135, 55);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.search.TabIndex = 23;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            this.search.MouseMove += new System.Windows.Forms.MouseEventHandler(this.search_MouseMove);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 738);
            this.Controls.Add(this.search);
            this.Controls.Add(this.commStatistics);
            this.Controls.Add(this.scrollRight);
            this.Controls.Add(this.scrollLeft);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.month2);
            this.Controls.Add(this.day2);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.month1);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.period);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(584, 777);
            this.MinimumSize = new System.Drawing.Size(584, 777);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talk To Me - Статистика спілкування";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TextBox period;
        private System.Windows.Forms.TextBox day1;
        private System.Windows.Forms.TextBox month1;
        private System.Windows.Forms.TextBox year1;
        private System.Windows.Forms.TextBox day2;
        private System.Windows.Forms.TextBox month2;
        private System.Windows.Forms.TextBox year2;
        private System.Windows.Forms.PictureBox scrollLeft;
        private System.Windows.Forms.PictureBox scrollRight;
        private System.Windows.Forms.ListBox commStatistics;
        private System.Windows.Forms.PictureBox search;
    }
}