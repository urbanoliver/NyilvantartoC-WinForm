
namespace SoldierDesktopApp
{
    partial class Menu
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
            contentPane = new Panel();
            btnQuit = new Button();
            btnListSoldiers = new Button();
            btnInsertSoldier = new Button();
            btnModifySoldier = new Button();
            btnDeleteSoldier = new Button();
            SuspendLayout();
            // 
            // contentPane
            // 
            contentPane.BackColor = Color.FromArgb(128, 128, 128);
            contentPane.BorderStyle = BorderStyle.FixedSingle;
            contentPane.Location = new Point(0, 0);
            contentPane.Margin = new Padding(4, 5, 4, 5);
            contentPane.Name = "contentPane";
            contentPane.Size = new Size(778, 547);
            contentPane.TabIndex = 0;
            contentPane.Paint += contentPane_Paint;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(255, 0, 0);
            btnQuit.ForeColor = Color.FromArgb(255, 255, 255);
            btnQuit.Location = new Point(313, 435);
            btnQuit.Margin = new Padding(4, 5, 4, 5);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(119, 35);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += BtnQuit_Click;
            // 
            // btnListSoldiers
            // 
            btnListSoldiers.BackColor = Color.FromArgb(0, 255, 0);
            btnListSoldiers.ForeColor = Color.FromArgb(0, 0, 0);
            btnListSoldiers.Location = new Point(272, 120);
            btnListSoldiers.Margin = new Padding(4, 5, 4, 5);
            btnListSoldiers.Name = "btnListSoldiers";
            btnListSoldiers.Size = new Size(203, 38);
            btnListSoldiers.TabIndex = 3;
            btnListSoldiers.Text = "List Soldiers";
            btnListSoldiers.UseVisualStyleBackColor = false;
            btnListSoldiers.Click += BtnListSoldiers_Click;
            // 
            // btnInsertSoldier
            // 
            btnInsertSoldier.BackColor = Color.FromArgb(0, 255, 0);
            btnInsertSoldier.ForeColor = Color.FromArgb(0, 0, 0);
            btnInsertSoldier.Location = new Point(272, 175);
            btnInsertSoldier.Margin = new Padding(4, 5, 4, 5);
            btnInsertSoldier.Name = "btnInsertSoldier";
            btnInsertSoldier.Size = new Size(203, 38);
            btnInsertSoldier.TabIndex = 2;
            btnInsertSoldier.Text = "Insert New Soldier";
            btnInsertSoldier.UseVisualStyleBackColor = false;
            btnInsertSoldier.Click += BtnInsertSoldier_Click;
            // 
            // btnModifySoldier
            // 
            btnModifySoldier.BackColor = Color.FromArgb(0, 255, 0);
            btnModifySoldier.ForeColor = Color.FromArgb(0, 0, 0);
            btnModifySoldier.Location = new Point(272, 231);
            btnModifySoldier.Margin = new Padding(4, 5, 4, 5);
            btnModifySoldier.Name = "btnModifySoldier";
            btnModifySoldier.Size = new Size(203, 38);
            btnModifySoldier.TabIndex = 1;
            btnModifySoldier.Text = "Modify Soldier";
            btnModifySoldier.UseVisualStyleBackColor = false;
            btnModifySoldier.Click += BtnModifySoldier_Click;
            // 
            // btnDeleteSoldier
            // 
            btnDeleteSoldier.BackColor = Color.FromArgb(0, 255, 0);
            btnDeleteSoldier.ForeColor = Color.FromArgb(0, 0, 0);
            btnDeleteSoldier.Location = new Point(272, 286);
            btnDeleteSoldier.Margin = new Padding(4, 5, 4, 5);
            btnDeleteSoldier.Name = "btnDeleteSoldier";
            btnDeleteSoldier.Size = new Size(203, 38);
            btnDeleteSoldier.TabIndex = 0;
            btnDeleteSoldier.Text = "Delete Soldier";
            btnDeleteSoldier.UseVisualStyleBackColor = false;
            btnDeleteSoldier.Click += BtnDeleteSoldier_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 548);
            Controls.Add(btnDeleteSoldier);
            Controls.Add(btnModifySoldier);
            Controls.Add(btnInsertSoldier);
            Controls.Add(btnListSoldiers);
            Controls.Add(btnQuit);
            Controls.Add(contentPane);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Soldier Registry System";
            
            ResumeLayout(false);
        }





        #endregion

        private Button btnMenu;
        private Button btnInsertSoldier;
        private Button btnModifySoldier;
        private Button btnDeleteSoldier;
        private Panel contentPane;
        private Button btnQuit;
        private Button btnListSoldiers;
    }
}