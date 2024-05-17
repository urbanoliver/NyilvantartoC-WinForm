namespace SoldierDesktopApp
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

        private Panel contentPane;
        private TextBox usernameField;
        private TextBox passwField;
        private Button btnSignIn;
        private Button btnReset;
        private Label lblMessage;
        private CheckBox chckbxShowPsw;
        private Button btnExit;



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contentPane = new Panel();
            label2 = new Label();
            label1 = new Label();
            WelcomeTitel = new Label();
            btnExit = new Button();
            lblMessage = new Label();
            chckbxShowPsw = new CheckBox();
            btnReset = new Button();
            btnSignIn = new Button();
            passwField = new TextBox();
            usernameField = new TextBox();
            contentPane.SuspendLayout();
            SuspendLayout();
            // 
            // contentPane
            // 
            contentPane.BackColor = Color.FromArgb(128, 128, 128);
            contentPane.BorderStyle = BorderStyle.FixedSingle;
            contentPane.Controls.Add(label2);
            contentPane.Controls.Add(label1);
            contentPane.Controls.Add(WelcomeTitel);
            contentPane.Controls.Add(btnExit);
            contentPane.Controls.Add(lblMessage);
            contentPane.Controls.Add(chckbxShowPsw);
            contentPane.Controls.Add(btnReset);
            contentPane.Controls.Add(btnSignIn);
            contentPane.Controls.Add(passwField);
            contentPane.Controls.Add(usernameField);
            contentPane.Location = new Point(0, 0);
            contentPane.Margin = new Padding(4, 5, 4, 5);
            contentPane.Name = "contentPane";
            contentPane.Size = new Size(787, 536);
            contentPane.TabIndex = 0;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(163, 165);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(163, 107);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 7;
            label1.Text = "Username:";
            // 
            // WelcomeTitel
            // 
            WelcomeTitel.AutoSize = true;
            WelcomeTitel.Font = new Font("Segoe UI", 17F);
            WelcomeTitel.ForeColor = Color.Lime;
            WelcomeTitel.Location = new Point(134, 28);
            WelcomeTitel.Name = "WelcomeTitel";
            WelcomeTitel.Size = new Size(517, 40);
            WelcomeTitel.TabIndex = 6;
            WelcomeTitel.Text = "Welcome To The Army Registry System!";
            
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 0, 0);
            btnExit.ForeColor = Color.FromArgb(255, 255, 255);
            btnExit.Location = new Point(654, 452);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 35);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(0, 255, 0);
            lblMessage.Location = new Point(178, 355);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(545, 38);
            lblMessage.TabIndex = 3;
            // 
            // chckbxShowPsw
            // 
            chckbxShowPsw.BackColor = Color.FromArgb(128, 128, 128);
            chckbxShowPsw.ForeColor = Color.FromArgb(0, 255, 0);
            chckbxShowPsw.Location = new Point(271, 202);
            chckbxShowPsw.Margin = new Padding(4, 5, 4, 5);
            chckbxShowPsw.Name = "chckbxShowPsw";
            chckbxShowPsw.Size = new Size(188, 35);
            chckbxShowPsw.TabIndex = 2;
            chckbxShowPsw.Text = "Show Password";
            chckbxShowPsw.UseVisualStyleBackColor = false;
            chckbxShowPsw.CheckedChanged += ChckbxShowPsw_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 255, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(446, 285);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 35);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(0, 255, 0);
            btnSignIn.ForeColor = Color.Black;
            btnSignIn.Location = new Point(216, 285);
            btnSignIn.Margin = new Padding(4, 5, 4, 5);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(119, 35);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += BtnSignIn_Click;
            // 
            // passwField
            // 
            passwField.Location = new Point(271, 163);
            passwField.Margin = new Padding(4, 5, 4, 5);
            passwField.Name = "passwField";
            passwField.Size = new Size(280, 27);
            passwField.TabIndex = 1;
            passwField.UseSystemPasswordChar = true;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(271, 108);
            usernameField.Margin = new Padding(4, 5, 4, 5);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(280, 27);
            usernameField.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 498);
            Controls.Add(contentPane);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Soldier Registry System";
            Load += Form1_Load;
            contentPane.ResumeLayout(false);
            contentPane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label WelcomeTitel;
        private Label label1;
        private Label label2;
    }
}
