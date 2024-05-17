using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoldierDesktopApp
{
    public partial class NewSold : Form
    {
        public NewSold()
        {
            InitializeComponent();
        }

        private void NewSold_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Checker c = new Checker();
            if (c.IsNumber(this.id, "ID"))
            {
                if (c.IsEmpty(this.name, "Name"))
                {
                    if (c.IsEmpty(this.rank, "Rank"))
                    {
                        if (c.IsEmpty(this.age, "Age"))
                        {
                            if (c.IsValidDate(this.bos, "Begin of Service"))
                            {

                                CsvManager.Insert(RTF(this.id), RTF(this.name), RTF(this.rank), RTF(this.age), RTF(this.bos));
                                c.SuccesfullInsert();
                            }
                        }
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.id.Text = null;
            this.name.Text = null;
            this.rank.Text = null;
            this.age.Text = null;
            this.bos.Text = null;
        }

        

        public string RTF(TextBox jtf)
        {
            return jtf.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
