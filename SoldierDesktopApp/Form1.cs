using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoldierDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string userText = usernameField.Text;
            string pwdText = passwField.Text;

            if (userText.Equals("admin") && pwdText.Equals("admin"))
            {
                //lblMessage.Text = "You successfully logged in!";
                
                Menu menu = new Menu();
                menu.Show();
                
                this.Hide();
                
            }
            else
            {
                //lblMessage.Text = "Invalid username or password!";
                MessageBoxButtons btnOK = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Wrong username or password!", "Information", btnOK, MessageBoxIcon.Information);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            usernameField.Text = null;
            passwField.Text = null;
        }

        private void ChckbxShowPsw_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxShowPsw.Checked)
            {
                passwField.UseSystemPasswordChar = false;
            }
            else
            {
                passwField.UseSystemPasswordChar = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}

