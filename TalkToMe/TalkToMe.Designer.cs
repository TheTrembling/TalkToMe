namespace TalkToMe
{
    partial class TalkToMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkToMe));
            this.friendLogin = new System.Windows.Forms.Label();
            this.friendStatus = new System.Windows.Forms.Label();
            this.yourLogin = new System.Windows.Forms.Label();
            this.yourStatus = new System.Windows.Forms.Label();
            this.lastVisit = new System.Windows.Forms.Label();
            this.yourMessageText = new System.Windows.Forms.RichTextBox();
            this.id = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.friendSearching = new System.Windows.Forms.TextBox();
            this.friendList = new System.Windows.Forms.ListBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.yourProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.allRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.usersSearching = new System.Windows.Forms.ToolStripMenuItem();
            this.statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.search2 = new System.Windows.Forms.TextBox();
            this.symbolsLimit = new System.Windows.Forms.Label();
            this.messages = new System.Windows.Forms.Panel();
            this.friendAvatar = new System.Windows.Forms.PictureBox();
            this.yourAvatar = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.friendProfile = new System.Windows.Forms.PictureBox();
            this.deleteFriend = new System.Windows.Forms.PictureBox();
            this.sendMessage = new System.Windows.Forms.PictureBox();
            this.closeChat = new System.Windows.Forms.PictureBox();
            this.openChat = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // friendLogin
            // 
            this.friendLogin.BackColor = System.Drawing.Color.Transparent;
            this.friendLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.friendLogin.Location = new System.Drawing.Point(887, 136);
            this.friendLogin.Name = "friendLogin";
            this.friendLogin.Size = new System.Drawing.Size(97, 23);
            this.friendLogin.TabIndex = 4;
            this.friendLogin.Text = "Friend";
            this.friendLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendStatus
            // 
            this.friendStatus.BackColor = System.Drawing.Color.Transparent;
            this.friendStatus.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.friendStatus.Location = new System.Drawing.Point(887, 256);
            this.friendStatus.Name = "friendStatus";
            this.friendStatus.Size = new System.Drawing.Size(97, 23);
            this.friendStatus.TabIndex = 5;
            this.friendStatus.Text = "Offline";
            this.friendStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourLogin
            // 
            this.yourLogin.BackColor = System.Drawing.Color.Transparent;
            this.yourLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yourLogin.Location = new System.Drawing.Point(887, 388);
            this.yourLogin.Name = "yourLogin";
            this.yourLogin.Size = new System.Drawing.Size(97, 23);
            this.yourLogin.TabIndex = 6;
            this.yourLogin.Text = "Administrator";
            this.yourLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourStatus
            // 
            this.yourStatus.BackColor = System.Drawing.Color.Transparent;
            this.yourStatus.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourStatus.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.yourStatus.Location = new System.Drawing.Point(887, 508);
            this.yourStatus.Name = "yourStatus";
            this.yourStatus.Size = new System.Drawing.Size(97, 23);
            this.yourStatus.TabIndex = 7;
            this.yourStatus.Text = "Online";
            this.yourStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastVisit
            // 
            this.lastVisit.BackColor = System.Drawing.Color.Transparent;
            this.lastVisit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastVisit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lastVisit.Location = new System.Drawing.Point(395, 564);
            this.lastVisit.Name = "lastVisit";
            this.lastVisit.Size = new System.Drawing.Size(483, 23);
            this.lastVisit.TabIndex = 8;
            this.lastVisit.Text = "Заходив 21.02.2022 у 16:00";
            this.lastVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourMessageText
            // 
            this.yourMessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourMessageText.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourMessageText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yourMessageText.Location = new System.Drawing.Point(400, 602);
            this.yourMessageText.Name = "yourMessageText";
            this.yourMessageText.Size = new System.Drawing.Size(472, 86);
            this.yourMessageText.TabIndex = 9;
            this.yourMessageText.Text = "";
            this.yourMessageText.TextChanged += new System.EventHandler(this.yourMessageText_TextChanged);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.id.Location = new System.Drawing.Point(86, 37);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(132, 23);
            this.id.TabIndex = 14;
            this.id.Text = "ID: 1";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login.Location = new System.Drawing.Point(52, 209);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(202, 23);
            this.login.TabIndex = 15;
            this.login.Text = "Administrator";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendSearching
            // 
            this.friendSearching.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friendSearching.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendSearching.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.friendSearching.Location = new System.Drawing.Point(52, 297);
            this.friendSearching.Name = "friendSearching";
            this.friendSearching.Size = new System.Drawing.Size(202, 19);
            this.friendSearching.TabIndex = 16;
            this.friendSearching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.friendSearching.Visible = false;
            this.friendSearching.TextChanged += new System.EventHandler(this.friendSearching_TextChanged);
            // 
            // friendList
            // 
            this.friendList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friendList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.friendList.FormattingEnabled = true;
            this.friendList.ItemHeight = 19;
            this.friendList.Location = new System.Drawing.Point(57, 333);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(192, 342);
            this.friendList.TabIndex = 17;
            this.friendList.SelectedIndexChanged += new System.EventHandler(this.friendList_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourProfile,
            this.allRequests,
            this.statistics});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(308, 24);
            this.menu.TabIndex = 18;
            this.menu.Text = "menuStrip1";
            // 
            // yourProfile
            // 
            this.yourProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfile,
            this.editProfile,
            this.toolStripSeparator1,
            this.exit});
            this.yourProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yourProfile.Name = "yourProfile";
            this.yourProfile.Size = new System.Drawing.Size(67, 20);
            this.yourProfile.Text = "Профіль";
            // 
            // myProfile
            // 
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(187, 22);
            this.myProfile.Text = "Мій профіль";
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
            // 
            // editProfile
            // 
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(187, 22);
            this.editProfile.Text = "Редагувати профиль";
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(187, 22);
            this.exit.Text = "Вийти";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // allRequests
            // 
            this.allRequests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestsToAdd,
            this.usersSearching});
            this.allRequests.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.allRequests.Name = "allRequests";
            this.allRequests.Size = new System.Drawing.Size(58, 20);
            this.allRequests.Text = "Запити";
            // 
            // requestsToAdd
            // 
            this.requestsToAdd.Name = "requestsToAdd";
            this.requestsToAdd.Size = new System.Drawing.Size(188, 22);
            this.requestsToAdd.Text = "Заявки у друзі";
            this.requestsToAdd.Click += new System.EventHandler(this.requestsToAdd_Click);
            // 
            // usersSearching
            // 
            this.usersSearching.Name = "usersSearching";
            this.usersSearching.Size = new System.Drawing.Size(188, 22);
            this.usersSearching.Text = "Пошук користувачів";
            this.usersSearching.Click += new System.EventHandler(this.usersSearching_Click);
            // 
            // statistics
            // 
            this.statistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(80, 20);
            this.statistics.Text = "Статистика";
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // search2
            // 
            this.search2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search2.Location = new System.Drawing.Point(52, 297);
            this.search2.Name = "search2";
            this.search2.ReadOnly = true;
            this.search2.Size = new System.Drawing.Size(202, 19);
            this.search2.TabIndex = 19;
            this.search2.Text = "Пошук";
            this.search2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // symbolsLimit
            // 
            this.symbolsLimit.BackColor = System.Drawing.Color.Transparent;
            this.symbolsLimit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolsLimit.ForeColor = System.Drawing.Color.LightGreen;
            this.symbolsLimit.Location = new System.Drawing.Point(395, 720);
            this.symbolsLimit.Name = "symbolsLimit";
            this.symbolsLimit.Size = new System.Drawing.Size(356, 23);
            this.symbolsLimit.TabIndex = 20;
            this.symbolsLimit.Text = "Кількість символів: 0";
            this.symbolsLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messages
            // 
            this.messages.AutoScroll = true;
            this.messages.BackColor = System.Drawing.Color.Transparent;
            this.messages.Location = new System.Drawing.Point(387, 115);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(496, 445);
            this.messages.TabIndex = 13;
            // 
            // friendAvatar
            // 
            this.friendAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.friendAvatar.Location = new System.Drawing.Point(898, 165);
            this.friendAvatar.Name = "friendAvatar";
            this.friendAvatar.Size = new System.Drawing.Size(73, 86);
            this.friendAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendAvatar.TabIndex = 30;
            this.friendAvatar.TabStop = false;
            // 
            // yourAvatar
            // 
            this.yourAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yourAvatar.Location = new System.Drawing.Point(898, 417);
            this.yourAvatar.Name = "yourAvatar";
            this.yourAvatar.Size = new System.Drawing.Size(73, 86);
            this.yourAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourAvatar.TabIndex = 29;
            this.yourAvatar.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avatar.Location = new System.Drawing.Point(75, 71);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(155, 128);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 27;
            this.avatar.TabStop = false;
            this.avatar.Visible = false;
            // 
            // friendProfile
            // 
            this.friendProfile.BackColor = System.Drawing.Color.Transparent;
            this.friendProfile.Image = global::TalkToMe.Properties.Resources.open_profile1;
            this.friendProfile.Location = new System.Drawing.Point(44, 707);
            this.friendProfile.Name = "friendProfile";
            this.friendProfile.Size = new System.Drawing.Size(73, 56);
            this.friendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.friendProfile.TabIndex = 12;
            this.friendProfile.TabStop = false;
            this.friendProfile.Click += new System.EventHandler(this.friendProfile_Click);
            this.friendProfile.MouseLeave += new System.EventHandler(this.friendProfile_MouseLeave);
            this.friendProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.friendProfile_MouseMove);
            // 
            // deleteFriend
            // 
            this.deleteFriend.BackColor = System.Drawing.Color.Transparent;
            this.deleteFriend.Image = global::TalkToMe.Properties.Resources.delete_friend1;
            this.deleteFriend.Location = new System.Drawing.Point(116, 707);
            this.deleteFriend.Name = "deleteFriend";
            this.deleteFriend.Size = new System.Drawing.Size(73, 56);
            this.deleteFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deleteFriend.TabIndex = 11;
            this.deleteFriend.TabStop = false;
            this.deleteFriend.Click += new System.EventHandler(this.deleteFriend_Click);
            this.deleteFriend.MouseLeave += new System.EventHandler(this.deleteFriend_MouseLeave);
            this.deleteFriend.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteFriend_MouseMove);
            // 
            // sendMessage
            // 
            this.sendMessage.BackColor = System.Drawing.Color.Transparent;
            this.sendMessage.Image = global::TalkToMe.Properties.Resources.send1;
            this.sendMessage.Location = new System.Drawing.Point(767, 709);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(125, 54);
            this.sendMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sendMessage.TabIndex = 10;
            this.sendMessage.TabStop = false;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            this.sendMessage.MouseLeave += new System.EventHandler(this.sendMessage_MouseLeave);
            this.sendMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sendMessage_MouseMove);
            // 
            // closeChat
            // 
            this.closeChat.BackColor = System.Drawing.Color.Transparent;
            this.closeChat.Image = global::TalkToMe.Properties.Resources.close_chat1;
            this.closeChat.Location = new System.Drawing.Point(922, 16);
            this.closeChat.Name = "closeChat";
            this.closeChat.Size = new System.Drawing.Size(73, 62);
            this.closeChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeChat.TabIndex = 3;
            this.closeChat.TabStop = false;
            this.closeChat.Click += new System.EventHandler(this.closeChat_Click);
            this.closeChat.MouseLeave += new System.EventHandler(this.closeChat_MouseLeave);
            this.closeChat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closeChat_MouseMove);
            // 
            // openChat
            // 
            this.openChat.BackColor = System.Drawing.Color.Transparent;
            this.openChat.Image = global::TalkToMe.Properties.Resources.open_chat1;
            this.openChat.Location = new System.Drawing.Point(189, 707);
            this.openChat.Name = "openChat";
            this.openChat.Size = new System.Drawing.Size(73, 56);
            this.openChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.openChat.TabIndex = 2;
            this.openChat.TabStop = false;
            this.openChat.Click += new System.EventHandler(this.openChat_Click);
            this.openChat.MouseLeave += new System.EventHandler(this.openChat_MouseLeave);
            this.openChat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openChat_MouseMove);
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 23);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1038, 862);
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // TalkToMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 823);
            this.Controls.Add(this.friendAvatar);
            this.Controls.Add(this.yourAvatar);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.symbolsLimit);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.friendList);
            this.Controls.Add(this.friendSearching);
            this.Controls.Add(this.login);
            this.Controls.Add(this.id);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.friendProfile);
            this.Controls.Add(this.deleteFriend);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.yourMessageText);
            this.Controls.Add(this.lastVisit);
            this.Controls.Add(this.yourStatus);
            this.Controls.Add(this.yourLogin);
            this.Controls.Add(this.friendStatus);
            this.Controls.Add(this.friendLogin);
            this.Controls.Add(this.closeChat);
            this.Controls.Add(this.openChat);
            this.Controls.Add(this.background);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(324, 862);
            this.MinimumSize = new System.Drawing.Size(324, 862);
            this.Name = "TalkToMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TalkToMe";
            this.Activated += new System.EventHandler(this.TalkToMe_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TalkToMe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TalkToMe_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox openChat;
        private System.Windows.Forms.PictureBox closeChat;
        private System.Windows.Forms.Label friendLogin;
        private System.Windows.Forms.Label friendStatus;
        private System.Windows.Forms.Label yourLogin;
        private System.Windows.Forms.Label yourStatus;
        private System.Windows.Forms.Label lastVisit;
        private System.Windows.Forms.RichTextBox yourMessageText;
        private System.Windows.Forms.PictureBox sendMessage;
        private System.Windows.Forms.PictureBox deleteFriend;
        private System.Windows.Forms.PictureBox friendProfile;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox friendSearching;
        private System.Windows.Forms.ListBox friendList;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TextBox search2;
        private System.Windows.Forms.ToolStripMenuItem yourProfile;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label symbolsLimit;
        private System.Windows.Forms.Panel messages;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.ToolStripMenuItem myProfile;
        private System.Windows.Forms.PictureBox yourAvatar;
        private System.Windows.Forms.PictureBox friendAvatar;
        private System.Windows.Forms.ToolStripMenuItem allRequests;
        private System.Windows.Forms.ToolStripMenuItem requestsToAdd;
        private System.Windows.Forms.ToolStripMenuItem usersSearching;
        private System.Windows.Forms.ToolStripMenuItem editProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem statistics;
    }
}