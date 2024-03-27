namespace Aplikasi_Penjualan
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            label1 = new Label();
            textBox_username = new TextBox();
            textBox_Pw = new TextBox();
            label2 = new Label();
            button_login = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(135, 48);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "your username";
            textBox_username.Size = new Size(214, 27);
            textBox_username.TabIndex = 1;
            // 
            // textBox_Pw
            // 
            textBox_Pw.Location = new Point(135, 103);
            textBox_Pw.Name = "textBox_Pw";
            textBox_Pw.PasswordChar = '#';
            textBox_Pw.PlaceholderText = "your password";
            textBox_Pw.Size = new Size(214, 27);
            textBox_Pw.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 104);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // button_login
            // 
            button_login.BackColor = Color.YellowGreen;
            button_login.Location = new Point(66, 183);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(194, 183);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(buttonCancel);
            Controls.Add(button_login);
            Controls.Add(textBox_Pw);
            Controls.Add(label2);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = ":: LOGIN ::";
            Load += Form_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_Pw;
        private Label label2;
        private Button button_login;
        private Button buttonCancel;
    }
}