using Bank.Model;
using Bank.Repository;
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
    public partial class Form1 : Form
    {
        long id;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            groupClienteCadastro.Visible = true;
            groupClienteCadastro.Enabled = true;
            groupConta.Visible = false;
            groupConta.Enabled = false;
            group_Null.Enabled = false;
            group_Null.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            
                form3.ShowDialog();
                
            UpdateLogin(form3.GetLoginStatus());
            form3.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupClienteCadastro.Visible = false;
            groupClienteCadastro.Enabled = false;
            groupConta.Visible = false;
            groupConta.Enabled = false;
            group_Null.Enabled = true;
            group_Null.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            id++;
           
            Cliente dCliente = new Cliente (id, txt_Nome.Text, txt_CPF.Text, txt_Senha.Text, Convert.ToInt32(txt_Idade.Text), cbox_Sexo.Text, cbox_StatusCivil.Text,
            txt_Endereco.Text, txt_Telefone.Text);

           // VerificadoresDeExceptions.verificarExistenciaDeUsuarioParaCadastro(cpf, senha);

           DadosUsuario.adicionar(dCliente);



            groupClienteCadastro.Enabled = false;
            groupClienteCadastro.Visible = false;
            groupConta.Visible = false;
            groupConta.Enabled = false;
            group_Null.Enabled = true;
            group_Null.Visible = true;
        }

        private void btn_Deposito_Click(object sender, EventArgs e)
        {

        }
        public void UpdateLogin(bool login)
        {
            if (login)
            {
                groupConta.Visible = true;
                groupConta.Enabled = true;
                groupClienteCadastro.Visible = false;
                groupClienteCadastro.Enabled = false;
                group_Null.Enabled = false;
                group_Null.Visible = false;
            }
            else
            {
                groupConta.Visible = false;
                groupConta.Enabled = false;
                groupClienteCadastro.Visible = false;
                groupClienteCadastro.Enabled = false;
                group_Null.Enabled = true;
                group_Null.Visible = true;
            }
            
        }
    }
}
