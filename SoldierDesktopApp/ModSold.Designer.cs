
namespace SoldierDesktopApp
{
    partial class ModSold
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
            components = new System.ComponentModel.Container();
            btnMod = new Button();
            elementsBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            button1 = new Button();
            id = new TextBox();
            name = new TextBox();
            rank = new TextBox();
            age = new TextBox();
            bos = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)elementsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(0, 255, 0);
            btnMod.ForeColor = Color.Black;
            btnMod.Location = new Point(250, 359);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(101, 36);
            btnMod.TabIndex = 2;
            btnMod.Text = "Modify";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // elementsBindingSource
            // 
            elementsBindingSource.DataSource = typeof(Elements);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 275);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 0, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(453, 359);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // id
            // 
            id.Location = new Point(139, 293);
            id.Name = "id";
            id.Size = new Size(125, 27);
            id.TabIndex = 5;
            // 
            // name
            // 
            name.Location = new Point(270, 293);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 6;
            // 
            // rank
            // 
            rank.Location = new Point(399, 293);
            rank.Name = "rank";
            rank.Size = new Size(125, 27);
            rank.TabIndex = 7;
            // 
            // age
            // 
            age.Location = new Point(530, 293);
            age.Name = "age";
            age.Size = new Size(125, 27);
            age.TabIndex = 8;
            // 
            // bos
            // 
            bos.Location = new Point(661, 293);
            bos.Name = "bos";
            bos.Size = new Size(125, 27);
            bos.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 295);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 10;
            label1.Text = "New values :";
            // 
            // ModSold
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 128);
            ClientSize = new Size(837, 418);
            Controls.Add(label1);
            Controls.Add(bos);
            Controls.Add(age);
            Controls.Add(rank);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnMod);
            Name = "ModSold";
            Text = "Soldier Registry System";
            ((System.ComponentModel.ISupportInitialize)elementsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView table;
        
        private Button btnMod;
        

#endregion
        private BindingSource elementsBindingSource;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox id;
        private TextBox name;
        private TextBox rank;
        private TextBox age;
        private TextBox bos;
        private Label label1;
    }
}