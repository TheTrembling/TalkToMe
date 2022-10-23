namespace TalkToMe
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel = new System.Windows.Forms.Panel();
            this.create = new System.Windows.Forms.PictureBox();
            this.enter = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMinSize = new System.Drawing.Size(300, 500);
            this.panel.Controls.Add(this.create);
            this.panel.Controls.Add(this.enter);
            this.panel.Controls.Add(this.password);
            this.panel.Controls.Add(this.login);
            this.panel.Controls.Add(this.background);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(370, 570);
            this.panel.TabIndex = 0;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Image = global::TalkToMe.Properties.Resources.create1;
            this.create.Location = new System.Drawing.Point(122, 430);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(125, 54);
            this.create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.create.TabIndex = 4;
            this.create.TabStop = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            this.create.MouseLeave += new System.EventHandler(this.create_MouseLeave);
            this.create.MouseMove += new System.Windows.Forms.MouseEventHandler(this.create_MouseMove);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.Image = global::TalkToMe.Properties.Resources.enter1;
            this.enter.Location = new System.Drawing.Point(121, 297);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(125, 54);
            this.enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enter.TabIndex = 3;
            this.enter.TabStop = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            this.enter.MouseLeave += new System.EventHandler(this.enter_MouseLeave);
            this.enter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.enter_MouseMove);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(100, 255);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(169, 21);
            this.password.TabIndex = 2;
            this.password.Text = "adm123";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(100, 182);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(169, 21);
            this.login.TabIndex = 1;
            this.login.Text = "Admin";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(370, 570);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 570);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(386, 609);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talk to Me - Авторизація";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox enter;
        private System.Windows.Forms.PictureBox create;
    }
}

