using Bank.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form3 : Form
    {
        public bool login = false, aux = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificadorDeAcesso.verificarAcesso(txt_CPFLogin.Text, txt_SenhaLogin.Text);
                login = true;
            }
            catch (Exception)
            {
                login = false;
            }

            
            aux = true;
            Close();
        }

        public bool GetLoginStatus()
        {
            return login;
        }
    }
}
