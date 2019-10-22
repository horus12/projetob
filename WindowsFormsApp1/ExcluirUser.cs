using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ExclusaoUser : Form
    {
        public ExclusaoUser()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUsecase loginUsecase = new LoginUsecase();


            try
            {
                User user = loginUsecase.Login(tbCpf.Text, tbSenha.Text);
                if (user==null) throw new Exception();

                gbLogin.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar");
            }
        }
    }
}
