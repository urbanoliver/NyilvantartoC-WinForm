namespace SoldierDesktopApp
{
    partial class NewSold
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

        private TextBox id;
        private TextBox name;
        private TextBox rank;
        private TextBox age;
        private TextBox bos;
        private Button btnInsert;
        private Button btnReset;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblID = new Label();
            lblName = new Label();
            lblRank = new Label();
            lblAge = new Label();
            lblBoS = new Label();
            id = new TextBox();
            name = new TextBox();
            rank = new TextBox();
            age = new TextBox();
            bos = new TextBox();
            btnInsert = new Button();
            btnReset = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.Font = new Font("Tahoma", 12F);
            lblID.ForeColor = Color.FromArgb(0, 255, 0);
            lblID.Location = new Point(149, 17);
            lblID.Name = "lblID";
            lblID.Size = new Size(98, 27);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Tahoma", 12F);
            lblName.ForeColor = Color.FromArgb(0, 255, 0);
            lblName.Location = new Point(149, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 27);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblRank
            // 
            lblRank.Font = new Font("Tahoma", 12F);
            lblRank.ForeColor = Color.FromArgb(0, 255, 0);
            lblRank.Location = new Point(151, 89);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(98, 27);
            lblRank.TabIndex = 2;
            lblRank.Text = "Rank:";
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Tahoma", 12F);
            lblAge.ForeColor = Color.FromArgb(0, 255, 0);
            lblAge.Location = new Point(149, 127);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(98, 27);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // lblBoS
            // 
            lblBoS.Font = new Font("Tahoma", 12F);
            lblBoS.ForeColor = Color.FromArgb(0, 255, 0);
            lblBoS.Location = new Point(149, 168);
            lblBoS.Name = "lblBoS";
            lblBoS.Size = new Size(170, 27);
            lblBoS.TabIndex = 4;
            lblBoS.Text = "Begin of Service:";
            // 
            // id
            // 
            id.Location = new Point(260, 17);
            id.Name = "id";
            id.Size = new Size(83, 27);
            id.TabIndex = 5;
            // 
            // name
            // 
            name.Location = new Point(260, 53);
            name.Name = "name";
            name.Size = new Size(185, 27);
            name.TabIndex = 6;
            // 
            // rank
            // 
            rank.Location = new Point(260, 89);
            rank.Name = "rank";
            rank.Size = new Size(185, 27);
            rank.TabIndex = 7;
            // 
            // age
            // 
            age.Location = new Point(260, 128);
            age.Name = "age";
            age.Size = new Size(59, 27);
            age.TabIndex = 8;
            // 
            // bos
            // 
            bos.Location = new Point(325, 169);
            bos.Name = "bos";
            bos.Size = new Size(135, 27);
            bos.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(0, 255, 0);
            btnInsert.Location = new Point(171, 248);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(104, 36);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += BtnInsert_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Lime;
            btnReset.Location = new Point(325, 248);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 36);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 0, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(245, 335);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 13;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NewSold
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 128);
            ClientSize = new Size(593, 399);
            Controls.Add(button1);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblRank);
            Controls.Add(lblAge);
            Controls.Add(lblBoS);
            Controls.Add(id);
            Controls.Add(name);
            Controls.Add(rank);
            Controls.Add(age);
            Controls.Add(bos);
            Controls.Add(btnInsert);
            Controls.Add(btnReset);
            Name = "NewSold";
            Text = "Soldier Registry System";
            Load += NewSold_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblName;
        private Label lblRank;
        private Label lblAge;
        private Label lblBoS;
        private Button button1;
    }
}