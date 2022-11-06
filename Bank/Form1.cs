using Bank.Controller;
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
        Cliente clienteAtual;

        public Form1()
        {
            InitializeComponent();
            groupClienteCadastro.Visible = false;
            groupClienteCadastro.Enabled = false;
            groupConta.Visible = false;
            groupConta.Enabled = false;
            group_Null.Enabled = true;
            group_Null.Visible = true;
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

        private void CadastroContaCliente(object sender, EventArgs e)
        {
            id++;
            List<string> extrato = new List<string>();

            Cliente dCliente = new Cliente (id, txt_Nome.Text, txt_CPF.Text, txt_Senha.Text, Convert.ToInt32(txt_Idade.Text), cbox_Sexo.Text, cbox_StatusCivil.Text,
            txt_Endereco.Text, txt_Telefone.Text);

           // VerificadoresDeExceptions.verificarExistenciaDeUsuarioParaCadastro(cpf, senha);

           DadosUsuario.adicionar(dCliente);

            ContaCorrente contaC = new ContaCorrente(dCliente.getId(), dCliente.getNome(), dCliente.getCpf(), dCliente.getSenhaCliente(), dCliente.getIdade(), dCliente.getSexo(), 
                dCliente.getEstadoCivil(), dCliente.getEndereco(), dCliente.getTelefone(), dCliente.getSenhaCliente(), 0, extrato, 0, StatusConta.DESBLOQUEADA);

            DadosContas.adicionarConta(contaC);

            ContaPoupanca contaP = new ContaPoupanca(dCliente.getId(), dCliente.getNome(), dCliente.getCpf(), dCliente.getSenhaCliente(), dCliente.getIdade(), dCliente.getSexo(),
                dCliente.getEstadoCivil(), dCliente.getEndereco(), dCliente.getTelefone(), dCliente.getSenhaCliente(), 0, extrato, 0, StatusConta.DESBLOQUEADA, 3);

            DadosContas.adicionarConta(contaP);


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
                label12.Text = $"Bem vindo {FuncoesConta.informar()}";
            }
            else
            {
                groupConta.Visible = false;
                groupConta.Enabled = false;
                groupClienteCadastro.Visible = false;
                groupClienteCadastro.Enabled = false;
                group_Null.Enabled = true;
                group_Null.Visible = true;
                label12.Text = "";
            }
            
        }

        private void acessarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupClienteCadastro.Visible = true;
            groupClienteCadastro.Enabled = true;
            groupConta.Visible = false;
            groupConta.Enabled = false;
            group_Null.Enabled = false;
            group_Null.Visible = false;
        }

        private void CallInput(string tipo)
        {
            Form3 form3 = new Form3(tipo);

            form3.ShowDialog();

            UpdateLogin(form3.GetLoginStatus());
            form3.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CallInput("CORRENTE");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CallInput("POUPANCA");
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void correnteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallInput("CORRENTE");
        }

        private void poupancaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
