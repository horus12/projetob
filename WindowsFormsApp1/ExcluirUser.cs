using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.usecases;

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
            User user = null;

            try
            {
                user = loginUsecase.Login(tbCpf.Text, tbSenha.Text);
                if (user == null) throw new Exception();

                gbLogin.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar"+ ex.Message);
            }


            if (user != null)
            {
                DialogResult response = MessageBox.Show("Deseja realmente excluir seu usuario?", "Excluir user", MessageBoxButtons.OKCancel);

                if (response == DialogResult.OK)
                {

                    ExcluirUserUseCase excluirUserUseCase = new ExcluirUserUseCase();

                    var res = excluirUserUseCase.DeletarUser(tbCpf.Text);

                    if (res == Status.OK)
                    {

                        

                        var a = Application.OpenForms;
                        try
                        {
                            foreach (Form f in a)
                            {
                                if (!f.Name.Equals("Login"))
                                    f.Dispose();
                                else
                                    f.Show();
                            }
                        }
                        catch (Exception ex) {
                        }
                        MessageBox.Show("Conta Excluida com sucesso");



                    }
                    else if (res == Status.NOTFOUND)
                    {
                        
                        gbLogin.Show();
                        MessageBox.Show("usuario nao existente");

                    }
                    else {

                        
                        gbLogin.Show();
                        MessageBox.Show("Erro");
                    }
                }
                else
                {

                    this.Dispose();

                }


            }


        }

        private void tbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ExclusaoUser_Load(object sender, EventArgs e)
        {

        }
    }
}
