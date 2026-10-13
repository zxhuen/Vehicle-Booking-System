namespace Vehicle_Rent_and_Booking_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            user_id_textbox = new TextBox();
            password_textbox = new TextBox();
            login_btn = new Button();
            SuspendLayout();
            // 
            // user_id_textbox
            // 
            user_id_textbox.Font = new Font("Segoe UI", 20F);
            user_id_textbox.Location = new Point(1165, 462);
            user_id_textbox.MaxLength = 11;
            user_id_textbox.Multiline = true;
            user_id_textbox.Name = "user_id_textbox";
            user_id_textbox.Size = new Size(478, 67);
            user_id_textbox.TabIndex = 0;
            // 
            // password_textbox
            // 
            password_textbox.Font = new Font("Segoe UI", 20F);
            password_textbox.Location = new Point(1165, 588);
            password_textbox.MaxLength = 20;
            password_textbox.Multiline = true;
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(478, 69);
            password_textbox.TabIndex = 1;
            password_textbox.TextChanged += password_textbox_TextChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.OliveDrab;
            login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(1158, 766);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(485, 74);
            login_btn.TabIndex = 2;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(login_btn);
            Controls.Add(password_textbox);
            Controls.Add(user_id_textbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox user_id_textbox;
        private TextBox password_textbox;
        private Button login_btn;
    }
}
