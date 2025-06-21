namespace SchoolManagement
{
    partial class RegisterPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            back_link = new LinkLabel();
            text_username = new TextBox();
            text_password = new TextBox();
            text_confirm_password = new TextBox();
            btn_show = new CheckBox();
            btn_register = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(100, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 65);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 122);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 175);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 340);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 4;
            label5.Text = "Already have an account?";
            // 
            // back_link
            // 
            back_link.AutoSize = true;
            back_link.Location = new Point(100, 369);
            back_link.Name = "back_link";
            back_link.Size = new Size(84, 15);
            back_link.TabIndex = 5;
            back_link.TabStop = true;
            back_link.Text = "Back to LOGIN";
            back_link.LinkClicked += back_link_LinkClicked;
            // 
            // text_username
            // 
            text_username.Location = new Point(58, 83);
            text_username.Name = "text_username";
            text_username.Size = new Size(183, 23);
            text_username.TabIndex = 6;
            // 
            // text_password
            // 
            text_password.Location = new Point(58, 140);
            text_password.Name = "text_password";
            text_password.Size = new Size(183, 23);
            text_password.TabIndex = 7;
            // 
            // text_confirm_password
            // 
            text_confirm_password.Location = new Point(58, 193);
            text_confirm_password.Name = "text_confirm_password";
            text_confirm_password.Size = new Size(183, 23);
            text_confirm_password.TabIndex = 8;
            // 
            // btn_show
            // 
            btn_show.AutoSize = true;
            btn_show.Location = new Point(58, 222);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(108, 19);
            btn_show.TabIndex = 9;
            btn_show.Text = "Show Password";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.CheckedChanged += show_password_CheckedChanged;
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.Highlight;
            btn_register.ForeColor = SystemColors.Control;
            btn_register.Location = new Point(58, 262);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(183, 24);
            btn_register.TabIndex = 10;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.ForeColor = SystemColors.Highlight;
            btn_clear.Location = new Point(58, 292);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(183, 24);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(btn_show);
            Controls.Add(text_confirm_password);
            Controls.Add(text_password);
            Controls.Add(text_username);
            Controls.Add(back_link);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterPage";
            Text = "SignUp";
            Load += RegisterPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel back_link;
        private TextBox text_username;
        private TextBox text_password;
        private TextBox text_confirm_password;
        private CheckBox btn_show;
        private Button btn_register;
        private Button btn_clear;
    }
}