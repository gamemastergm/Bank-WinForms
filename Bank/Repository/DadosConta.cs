using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository
{
	public class DadosContas
	{
		private static List<Conta> contasBanco = new List<Conta>();

		public static void adicionarConta(Conta a)
		{
			contasBanco.Add(a);
		}

		public static void removerConta(Conta r)
		{
			contasBanco.Remove(r);
		}

		public static List<Conta> listarConta()
		{
			return contasBanco;
		}

	}
}
