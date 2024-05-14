using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = this.txtUsername;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "Puji" && txtPasswd.Text == "13 January 2006")
                {
                    this.Hide();
                    MessageBox.Show("Login Berhasil", "True", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Login lg = new Login();
                    lg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Salah Woe", "Wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPasswd.Text = "";
                    txtUsername.Focus();
                }
                
            }catch (Exception ex)
            {
                throw new Exception("Errror bang",ex);
            }


        }
    }
}
