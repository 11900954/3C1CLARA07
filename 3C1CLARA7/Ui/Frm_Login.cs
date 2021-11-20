using _3C1CLARA7.Code.BLL;
using _3C1CLARA7.Code.DTO;
using _3C1CLARA7.Ui;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace _3C1CLARA7
{
    public partial class Frm_Login : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Frm_SBH sorvetes = new Frm_SBH();
                sorvetes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
