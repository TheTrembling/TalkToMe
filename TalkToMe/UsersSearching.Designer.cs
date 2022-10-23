namespace TalkToMe
{
    partial class UsersSearching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersSearching));
            this.userList = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.yearOfBirth = new System.Windows.Forms.TextBox();
            this.idCb = new System.Windows.Forms.CheckBox();
            this.loginCb = new System.Windows.Forms.CheckBox();
            this.nameCb = new System.Windows.Forms.CheckBox();
            this.surnameCb = new System.Windows.Forms.CheckBox();
            this.countryCb = new System.Windows.Forms.CheckBox();
            this.cityCb = new System.Windows.Forms.CheckBox();
            this.sexCb = new System.Windows.Forms.CheckBox();
            this.yearCb = new System.Windows.Forms.CheckBox();
            this.removeUser = new System.Windows.Forms.PictureBox();
            this.editUser = new System.Windows.Forms.PictureBox();
            this.scrollRight = new System.Windows.Forms.PictureBox();
            this.scrollLeft = new System.Windows.Forms.PictureBox();
            this.addToFriendlist = new System.Windows.Forms.PictureBox();
            this.openProfile = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.removeUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToFriendlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 19;
            this.userList.Location = new System.Drawing.Point(82, 415);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(399, 361);
            this.userList.TabIndex = 18;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.id.Location = new System.Drawing.Point(71, 100);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(186, 19);
            this.id.TabIndex = 1;
            this.id.Text = "1";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login.Location = new System.Drawing.Point(307, 100);
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Size = new System.Drawing.Size(186, 19);
            this.login.TabIndex = 2;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.name.Location = new System.Drawing.Point(71, 166);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(186, 19);
            this.name.TabIndex = 3;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surname
            // 
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.surname.Location = new System.Drawing.Point(307, 166);
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Size = new System.Drawing.Size(186, 19);
            this.surname.TabIndex = 4;
            this.surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // country
            // 
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.country.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.country.Location = new System.Drawing.Point(71, 232);
            this.country.Name = "country";
            this.country.ReadOnly = true;
            this.country.Size = new System.Drawing.Size(186, 19);
            this.country.TabIndex = 5;
            this.country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // city
            // 
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.city.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.city.Location = new System.Drawing.Point(307, 232);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(186, 19);
            this.city.TabIndex = 6;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sex
            // 
            this.sex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sex.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sex.Location = new System.Drawing.Point(71, 298);
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Size = new System.Drawing.Size(186, 19);
            this.sex.TabIndex = 7;
            this.sex.Text = "Чоловіча";
            this.sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearOfBirth
            // 
            this.yearOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearOfBirth.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearOfBirth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yearOfBirth.Location = new System.Drawing.Point(307, 298);
            this.yearOfBirth.Name = "yearOfBirth";
            this.yearOfBirth.ReadOnly = true;
            this.yearOfBirth.Size = new System.Drawing.Size(186, 19);
            this.yearOfBirth.TabIndex = 8;
            this.yearOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearOfBirth.TextChanged += new System.EventHandler(this.yearOfBirth_TextChanged);
            // 
            // idCb
            // 
            this.idCb.AutoSize = true;
            this.idCb.BackColor = System.Drawing.Color.Transparent;
            this.idCb.Checked = true;
            this.idCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idCb.Location = new System.Drawing.Point(72, 73);
            this.idCb.Name = "idCb";
            this.idCb.Size = new System.Drawing.Size(15, 14);
            this.idCb.TabIndex = 21;
            this.idCb.UseVisualStyleBackColor = false;
            this.idCb.CheckedChanged += new System.EventHandler(this.idCb_CheckedChanged);
            // 
            // loginCb
            // 
            this.loginCb.AutoSize = true;
            this.loginCb.BackColor = System.Drawing.Color.Transparent;
            this.loginCb.Location = new System.Drawing.Point(478, 73);
            this.loginCb.Name = "loginCb";
            this.loginCb.Size = new System.Drawing.Size(15, 14);
            this.loginCb.TabIndex = 22;
            this.loginCb.UseVisualStyleBackColor = false;
            this.loginCb.CheckedChanged += new System.EventHandler(this.loginCb_CheckedChanged);
            // 
            // nameCb
            // 
            this.nameCb.AutoSize = true;
            this.nameCb.BackColor = System.Drawing.Color.Transparent;
            this.nameCb.Location = new System.Drawing.Point(72, 136);
            this.nameCb.Name = "nameCb";
            this.nameCb.Size = new System.Drawing.Size(15, 14);
            this.nameCb.TabIndex = 23;
            this.nameCb.UseVisualStyleBackColor = false;
            this.nameCb.CheckedChanged += new System.EventHandler(this.nameCb_CheckedChanged);
            // 
            // surnameCb
            // 
            this.surnameCb.AutoSize = true;
            this.surnameCb.BackColor = System.Drawing.Color.Transparent;
            this.surnameCb.Location = new System.Drawing.Point(478, 136);
            this.surnameCb.Name = "surnameCb";
            this.surnameCb.Size = new System.Drawing.Size(15, 14);
            this.surnameCb.TabIndex = 24;
            this.surnameCb.UseVisualStyleBackColor = false;
            this.surnameCb.CheckedChanged += new System.EventHandler(this.surnameCb_CheckedChanged);
            // 
            // countryCb
            // 
            this.countryCb.AutoSize = true;
            this.countryCb.BackColor = System.Drawing.Color.Transparent;
            this.countryCb.Location = new System.Drawing.Point(71, 202);
            this.countryCb.Name = "countryCb";
            this.countryCb.Size = new System.Drawing.Size(15, 14);
            this.countryCb.TabIndex = 25;
            this.countryCb.UseVisualStyleBackColor = false;
            this.countryCb.CheckedChanged += new System.EventHandler(this.countryCb_CheckedChanged);
            // 
            // cityCb
            // 
            this.cityCb.AutoSize = true;
            this.cityCb.BackColor = System.Drawing.Color.Transparent;
            this.cityCb.Location = new System.Drawing.Point(478, 202);
            this.cityCb.Name = "cityCb";
            this.cityCb.Size = new System.Drawing.Size(15, 14);
            this.cityCb.TabIndex = 26;
            this.cityCb.UseVisualStyleBackColor = false;
            this.cityCb.CheckedChanged += new System.EventHandler(this.cityCb_CheckedChanged);
            // 
            // sexCb
            // 
            this.sexCb.AutoSize = true;
            this.sexCb.BackColor = System.Drawing.Color.Transparent;
            this.sexCb.Location = new System.Drawing.Point(72, 269);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(15, 14);
            this.sexCb.TabIndex = 27;
            this.sexCb.UseVisualStyleBackColor = false;
            // 
            // yearCb
            // 
            this.yearCb.AutoSize = true;
            this.yearCb.BackColor = System.Drawing.Color.Transparent;
            this.yearCb.Location = new System.Drawing.Point(478, 269);
            this.yearCb.Name = "yearCb";
            this.yearCb.Size = new System.Drawing.Size(15, 14);
            this.yearCb.TabIndex = 28;
            this.yearCb.UseVisualStyleBackColor = false;
            this.yearCb.CheckedChanged += new System.EventHandler(this.yearCb_CheckedChanged);
            // 
            // removeUser
            // 
            this.removeUser.BackColor = System.Drawing.Color.Transparent;
            this.removeUser.Image = global::TalkToMe.Properties.Resources.delete_friend1;
            this.removeUser.Location = new System.Drawing.Point(182, 799);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(82, 65);
            this.removeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.removeUser.TabIndex = 33;
            this.removeUser.TabStop = false;
            this.removeUser.Visible = false;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            this.removeUser.MouseLeave += new System.EventHandler(this.removeUser_MouseLeave);
            this.removeUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.removeUser_MouseMove);
            // 
            // editUser
            // 
            this.editUser.BackColor = System.Drawing.Color.Transparent;
            this.editUser.Image = global::TalkToMe.Properties.Resources.edit_profile1;
            this.editUser.Location = new System.Drawing.Point(293, 799);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(82, 65);
            this.editUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.editUser.TabIndex = 32;
            this.editUser.TabStop = false;
            this.editUser.Visible = false;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            this.editUser.MouseLeave += new System.EventHandler(this.editUser_MouseLeave);
            this.editUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editUser_MouseMove);
            // 
            // scrollRight
            // 
            this.scrollRight.BackColor = System.Drawing.Color.Transparent;
            this.scrollRight.Image = global::TalkToMe.Properties.Resources.right1;
            this.scrollRight.Location = new System.Drawing.Point(261, 293);
            this.scrollRight.Name = "scrollRight";
            this.scrollRight.Size = new System.Drawing.Size(26, 31);
            this.scrollRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scrollRight.TabIndex = 30;
            this.scrollRight.TabStop = false;
            this.scrollRight.Click += new System.EventHandler(this.scrollRight_Click);
            this.scrollRight.MouseLeave += new System.EventHandler(this.scrollRight_MouseLeave);
            this.scrollRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scrollRight_MouseMove);
            // 
            // scrollLeft
            // 
            this.scrollLeft.BackColor = System.Drawing.Color.Transparent;
            this.scrollLeft.Image = global::TalkToMe.Properties.Resources.left1;
            this.scrollLeft.Location = new System.Drawing.Point(43, 293);
            this.scrollLeft.Name = "scrollLeft";
            this.scrollLeft.Size = new System.Drawing.Size(26, 31);
            this.scrollLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scrollLeft.TabIndex = 29;
            this.scrollLeft.TabStop = false;
            this.scrollLeft.Click += new System.EventHandler(this.scrollLeft_Click);
            this.scrollLeft.MouseLeave += new System.EventHandler(this.scrollLeft_MouseLeave);
            this.scrollLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scrollLeft_MouseMove);
            // 
            // addToFriendlist
            // 
            this.addToFriendlist.BackColor = System.Drawing.Color.Transparent;
            this.addToFriendlist.Image = global::TalkToMe.Properties.Resources.addToFriendlist1;
            this.addToFriendlist.Location = new System.Drawing.Point(402, 799);
            this.addToFriendlist.Name = "addToFriendlist";
            this.addToFriendlist.Size = new System.Drawing.Size(82, 65);
            this.addToFriendlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addToFriendlist.TabIndex = 20;
            this.addToFriendlist.TabStop = false;
            this.addToFriendlist.Click += new System.EventHandler(this.addToFriendlist_Click);
            this.addToFriendlist.MouseLeave += new System.EventHandler(this.addToFriendlist_MouseLeave);
            this.addToFriendlist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addToFriendlist_MouseMove);
            // 
            // openProfile
            // 
            this.openProfile.BackColor = System.Drawing.Color.Transparent;
            this.openProfile.Image = global::TalkToMe.Properties.Resources.open_profile1;
            this.openProfile.Location = new System.Drawing.Point(72, 799);
            this.openProfile.Name = "openProfile";
            this.openProfile.Size = new System.Drawing.Size(82, 65);
            this.openProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.openProfile.TabIndex = 19;
            this.openProfile.TabStop = false;
            this.openProfile.Click += new System.EventHandler(this.openProfile_Click);
            this.openProfile.MouseLeave += new System.EventHandler(this.openProfile_MouseLeave);
            this.openProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openProfile_MouseMove);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Image = global::TalkToMe.Properties.Resources.search_user1;
            this.search.Location = new System.Drawing.Point(212, 338);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(135, 55);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.search.TabIndex = 1;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            this.search.MouseMove += new System.Windows.Forms.MouseEventHandler(this.search_MouseMove);
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = global::TalkToMe.Properties.Resources.usersearching_background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(568, 912);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // UsersSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 912);
            this.Controls.Add(this.removeUser);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.scrollRight);
            this.Controls.Add(this.scrollLeft);
            this.Controls.Add(this.yearCb);
            this.Controls.Add(this.sexCb);
            this.Controls.Add(this.cityCb);
            this.Controls.Add(this.countryCb);
            this.Controls.Add(this.surnameCb);
            this.Controls.Add(this.nameCb);
            this.Controls.Add(this.loginCb);
            this.Controls.Add(this.idCb);
            this.Controls.Add(this.yearOfBirth);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.login);
            this.Controls.Add(this.id);
            this.Controls.Add(this.addToFriendlist);
            this.Controls.Add(this.openProfile);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.search);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(584, 951);
            this.MinimumSize = new System.Drawing.Size(584, 951);
            this.Name = "UsersSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talk To Me - Пошук користувачів";
            this.Activated += new System.EventHandler(this.UsersSearching_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.removeUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToFriendlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.PictureBox openProfile;
        private System.Windows.Forms.PictureBox addToFriendlist;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox yearOfBirth;
        private System.Windows.Forms.CheckBox idCb;
        private System.Windows.Forms.CheckBox loginCb;
        private System.Windows.Forms.CheckBox nameCb;
        private System.Windows.Forms.CheckBox surnameCb;
        private System.Windows.Forms.CheckBox countryCb;
        private System.Windows.Forms.CheckBox cityCb;
        private System.Windows.Forms.CheckBox sexCb;
        private System.Windows.Forms.CheckBox yearCb;
        private System.Windows.Forms.PictureBox scrollLeft;
        private System.Windows.Forms.PictureBox scrollRight;
        private System.Windows.Forms.PictureBox editUser;
        private System.Windows.Forms.PictureBox removeUser;
    }
}