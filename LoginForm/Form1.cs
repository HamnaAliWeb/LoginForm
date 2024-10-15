namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.Compare(txt_user.Text, "Hamna_Ali") == 0 && String.Compare(txt_pass.Text, "22011556-021") == 0)
            {
                MessageBox.Show("Correct Login Password");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}