using Bank.Model;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controller
{
	public class VerificadoresDeExceptions
	{
		//throws ContaInexistenteException
		public static void verificarExistenciaDeUsuarioParaBusca(String acesso, String senha, List<Cliente> teste)
 			
		{
			List<string> aux2 = new List<string>();
		foreach (Cliente cliente in teste) {

			aux2.Add(cliente.getSenhaCliente());

			aux2.Add(cliente.getCpf());
			
		}

		if (!aux2.Contains(acesso) || !aux2.Contains(senha))
{
	throw new System.Exception("Essa conta não existe");
}

	}

	public static void verificarExistenciaDeUsuarioParaCadastro(String acesso, String senha)
{
	List<Cliente> teste = DadosUsuario.Listar();
	List<String> aux2 = new List<string>();

foreach (Cliente cliente in teste)
{

	aux2.Add(cliente.getSenhaCliente());

	
	aux2.Add(cliente.getCpf());

		}

		if (aux2.Contains(acesso) && (aux2.Contains(senha)))
{
	throw new System.Exception("Essa conta não pode ser cadastrada pois já existe");
}

	}
	
	
}
}
