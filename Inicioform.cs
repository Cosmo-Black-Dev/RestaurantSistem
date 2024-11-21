namespace Sistema_de_Restaurantes
{
    public partial class Inicioform : Form
    {
        public Inicioform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //User validation
            if( MainClass.isValidUser(txtUser.Text,txtPass.Text)==false)
            {
                MessageBox.Show("invalid username or password");
                return;
            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }
    }
}
