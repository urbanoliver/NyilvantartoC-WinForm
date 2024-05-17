using System;
using System.Windows.Forms;
using CsvHelper;
using Microsoft.VisualBasic;

namespace SoldierDesktopApp
{
    public partial class DelSold : Form
    {
        private Menu menu;

        private Checker c = new Checker();

        private string csvFilePath = "soldiers.csv";

        public DelSold(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            CsvManager.Reader(dataGridView1);
        }

        private void DelSold_Load(object sender, EventArgs e)
        {
            // Any additional initialization code here
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string deletedID = Interaction.InputBox("Type the ID of a soldier, that you want to delete!", "Delete Soldier", "");

            
            CsvManager.Delete(dataGridView1,deletedID);
            
        }


        
    }
}
