using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository
{
	public class DadosUsuario
	{
		private static List<Cliente> cadastroCliente = new List<Cliente>();

		public static void adicionar(Cliente a)
		{
			cadastroCliente.Add(a);

		}

		public static void remover(Cliente r)
		{
			cadastroCliente.Remove(r);
		}

		public static List<Cliente> Listar()
		{
			return cadastroCliente;
		}

	}
}
