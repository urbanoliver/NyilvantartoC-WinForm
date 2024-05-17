

namespace SoldierDesktopApp
{
    public partial class SoldList : Form
    {
        private Menu menu;


        public SoldList(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
           
            CsvManager.Reader(dataGridView1);
        }


        private void SoldList_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void actionPerformed(object sender, EventArgs e)
        {
            // Method not implemented
        }

      
    }
}
