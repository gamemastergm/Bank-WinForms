using Bank.Controller;
using Bank.Model;
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
        //public Conta conta; 
        string tipo;
        public Form3(string tipoConta)
        {
            InitializeComponent();
            //this.conta = conta;
            tipo = tipoConta;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificadorDeAcesso.verificarAcesso(txt_CPFLogin.Text, txt_SenhaLogin.Text, tipo);
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
