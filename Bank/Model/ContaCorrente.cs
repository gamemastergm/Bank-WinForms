using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
	public class ContaCorrente : Conta
	{

		public ContaCorrente(long id, String nome, String cpf, String senhaCliente, int idade, String sexo,
				String estadoCivil, String endereco, String telefone, String senhaConta, double saldo,
				List<String> historico, double dividas, StatusConta statusConta) : base(id, nome, cpf, senhaCliente, idade, sexo, estadoCivil, endereco, telefone, senhaConta, saldo, historico, dividas, statusConta)
        {

        }

	}


}

