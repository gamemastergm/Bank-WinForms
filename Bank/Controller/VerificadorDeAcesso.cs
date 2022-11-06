using Bank.Model;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controller
{
	public class VerificadorDeAcesso
	{
		//throw ContaBloqueadaException, ContaInexistenteException

		public static void verificarAcesso(String cpf, String chave, string tipo)
		{
			List<Cliente> teste = DadosUsuario.Listar();
			Cliente aux = null;

			VerificadoresDeExceptions.verificarExistenciaDeUsuarioParaBusca(cpf, chave, teste);

			foreach (Cliente cliente in teste)
			{

				if (cliente.getCpf().Equals(cpf) && cliente.getSenhaCliente().Equals(chave))
				{
					aux = cliente;


					buscarConta(cliente, tipo);



				}

			}


			if (aux == null)
			{
				throw new System.Exception("Essa conta nao existe");
			}

		}

		public static void buscarConta(Cliente cliente, string tipo)
		{
			if (cliente == null)
			{
				throw new System.Exception("Essa conta nao existe");
			}


			List<Conta> teste = DadosContas.listarConta();
			foreach (Conta conta in teste)
			{
				if (conta.getCpf().Equals(cliente.getCpf()))
				{

					if (conta.getStatusConta() == StatusConta.BLOQUEADA)
					{
						throw new System.Exception("Esta conta está Bloqueada");
					}
                    switch (tipo)
                    {
						case "CORRENTE":
							if(conta is ContaCorrente)
                            {
								FuncoesConta.pegarConta(conta);
							}
							break;

						case "POUPANCA":
							if (conta is ContaPoupanca)
							{
								FuncoesConta.pegarConta(conta);
							}
							break;
                    }
					

				}

			}
		}

		public static Status buscarContaCPF(String cpf)
		{
			List<Conta> teste = DadosContas.listarConta();
			List<Cliente> usuarios = DadosUsuario.Listar();
			bool aux = false;

			foreach (Conta conta in teste)
			{

				Cliente cliente = (Cliente)conta;
				if (cliente.getCpf().Equals(cpf))
				{
					FuncoesConta.pegarConta(conta);
					return Status.VALIDO;

				}

			}

			if (!aux)
			{
				//Status.INVALIDO.imprimirAcesso();
				return Status.INVALIDO;
			}
			return Status.INC;

		}

	}

}
