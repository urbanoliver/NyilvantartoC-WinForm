using Microsoft.VisualBasic;



namespace SoldierDesktopApp
{
    public partial class ModSold : Form
    {
        private Menu menu;


        public ModSold(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            CsvManager.Reader(dataGridView1);


        }


        private void btnMod_Click(object sender, EventArgs e)
        {
            CsvManager csvManager = new CsvManager();
            string modifiedID = Interaction.InputBox("Type the ID of a soldier, that you want to modify!", "Modify Soldier", "");
            csvManager.Modify(dataGridView1, modifiedID, id, name, rank, age, bos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }


}

