using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Conta : Cliente
    {
		private string senhaConta;
		private double saldo;
		private List<string> historico;
		private double dividas;
		private StatusConta statusConta;

		public Conta()
        {

        }
		public Conta(long id, string nome, string cpf, string senhaCliente, int idade, string sexo, string estadoCivil,
			string endereco, string telefone, string senhaConta, double saldo, List<string> historico, double dividas,
				StatusConta statusConta) : base()
		{
			setId(id);
			setNome(nome);
			setCpf(cpf);
			setSenhaCliente(senhaCliente);
			setIdade(idade);
			setSexo(sexo);
			setEstadoCivil(estadoCivil);
			setEndereco(endereco);
			setTelefone(telefone);
			this.senhaConta = senhaConta;
			this.saldo = saldo;
			this.historico = historico;
			this.dividas = dividas;
			this.statusConta = statusConta;
		}

		public string getSenhaConta()
		{
			return senhaConta;
		}

		public void setSenhaConta(string senhaConta)
		{
			this.senhaConta = senhaConta;
		}

		public double getSaldo()
		{
			return saldo;
		}

		public void setSaldo(double saldo)
		{
			this.saldo = saldo;
		}

		public List<string> getHistorico()
		{
			return historico;
		}

		public void setHistorico(List<string> historico)
		{
			this.historico = historico;
		}

		public double getDividas()
		{
			return dividas;
		}

		public void setDividas(double dividas)
		{
			this.dividas = dividas;
		}

		public StatusConta getStatusConta()
		{
			return statusConta;
		}

		public void setStatusConta(StatusConta statusConta)
		{
			this.statusConta = statusConta;
		}
	}
}
