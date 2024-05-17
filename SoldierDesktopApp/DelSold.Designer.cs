namespace SoldierDesktopApp
{
    partial class DelSold
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

        private Button btnClose;
        private DataGridView table;


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnClose = new Button();
            elementsBindingSource = new BindingSource(components);
            btnDel = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)elementsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 0, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(487, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // elementsBindingSource
            // 
            elementsBindingSource.DataSource = typeof(Elements);
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(0, 255, 0);
            btnDel.ForeColor = Color.Black;
            btnDel.Location = new Point(278, 370);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(98, 36);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += BtnDel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(79, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(704, 330);
            dataGridView1.TabIndex = 5;
            // 
            // DelSold
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 128);
            ClientSize = new Size(837, 418);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnDel);
            Name = "DelSold";
            Text = "Soldier Registry System";
            Load += DelSold_Load;
            ((System.ComponentModel.ISupportInitialize)elementsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Rank;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn BoS;
        private BindingSource elementsBindingSource;
        private Button btnDel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beginOfServiceDataGridViewTextBoxColumn;
    }
}