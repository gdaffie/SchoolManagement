namespace SchoolManagement
{
    partial class LoginForm
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
            btn_clear = new Button();
            button_login = new Button();
            text_password = new TextBox();
            text_username = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            btn_show = new CheckBox();
            label1 = new Label();
            create_link = new LinkLabel();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.ForeColor = SystemColors.Highlight;
            btn_clear.Location = new Point(45, 284);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(248, 32);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.Highlight;
            button_login.ForeColor = SystemColors.Control;
            button_login.Location = new Point(44, 250);
            button_login.Name = "button_login";
            button_login.Size = new Size(248, 28);
            button_login.TabIndex = 12;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // text_password
            // 
            text_password.Location = new Point(45, 180);
            text_password.Name = "text_password";
            text_password.Size = new Size(248, 23);
            text_password.TabIndex = 11;
            // 
            // text_username
            // 
            text_username.Location = new Point(45, 121);
            text_username.Name = "text_username";
            text_username.Size = new Size(248, 23);
            text_username.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(45, 157);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 9;
            label14.Text = "Password :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(45, 98);
            label13.Name = "label13";
            label13.Size = new Size(82, 20);
            label13.TabIndex = 8;
            label13.Text = "Username :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(114, 35);
            label11.Name = "label11";
            label11.Size = new Size(109, 28);
            label11.TabIndex = 7;
            label11.Text = "Get started";
            // 
            // btn_show
            // 
            btn_show.AutoSize = true;
            btn_show.Location = new Point(44, 209);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(108, 19);
            btn_show.TabIndex = 14;
            btn_show.Text = "Show Password";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.CheckedChanged += btn_show_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 347);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 15;
            label1.Text = "Don't have an account?";
            // 
            // create_link
            // 
            create_link.AutoSize = true;
            create_link.Location = new Point(125, 377);
            create_link.Name = "create_link";
            create_link.Size = new Size(89, 15);
            create_link.TabIndex = 16;
            create_link.TabStop = true;
            create_link.Text = "Create Account";
            create_link.LinkClicked += create_link_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(create_link);
            Controls.Add(label1);
            Controls.Add(btn_show);
            Controls.Add(btn_clear);
            Controls.Add(button_login);
            Controls.Add(text_password);
            Controls.Add(text_username);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clear;
        private Button button_login;
        private TextBox text_password;
        private TextBox text_username;
        private Label label14;
        private Label label13;
        private Label label11;
        private CheckBox btn_show;
        private Label label1;
        private LinkLabel create_link;
    }
}