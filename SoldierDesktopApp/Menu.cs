using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;

namespace SoldierDesktopApp
{
    public partial class Menu : Form
    {
        

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnListSoldiers_Click(object sender, EventArgs e)
        {
            
            SoldList sl = new SoldList(this);
            sl.ShowDialog();
        }

        private void BtnInsertSoldier_Click(object sender, EventArgs e)
        {
            NewSold newsold = new NewSold();
            newsold.ShowDialog();
        }

        private void BtnModifySoldier_Click(object sender, EventArgs e)
        {
            
            ModSold ms = new ModSold(this);
            ms.ShowDialog();
        }

        private void BtnDeleteSoldier_Click(object sender, EventArgs e)
        {
            
            DelSold ds = new DelSold(this);
            ds.ShowDialog();
        }
        private void contentPane_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
