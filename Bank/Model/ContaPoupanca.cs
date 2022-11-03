using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
	public class ContaPoupanca : Conta
	{
	private double limitadorSaque;

		public ContaPoupanca(long id, String nome, String cpf, String senhaCliente, int idade, String sexo,
				String estadoCivil, String endereco, String telefone, String senhaConta, double saldo,
				List<String> historico, double dividas, StatusConta statusConta, double limitadorSaque) : base()
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
			setSenhaConta(senhaConta);
			setSaldo(saldo);
			setHistorico(historico);
			setDividas(dividas);
			setStatusConta(statusConta);
			this.limitadorSaque = limitadorSaque;
	}

	public double getLimitadorSaque()
	{
		return limitadorSaque;
	}

	public void setLimitadorSaque(double limitadorSaque)
	{
		this.limitadorSaque = limitadorSaque;
	}

}
}
