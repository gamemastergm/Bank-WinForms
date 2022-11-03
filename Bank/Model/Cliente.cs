using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Cliente
    {

		private long id { get;  set; }
		private string nome { get;  set; }
		private string cpf { get;  set; }
		private string senhaCliente { get;  set; }
		private int idade { get;  set; }
		private string sexo { get;  set; }
		private string estadoCivil { get;  set; }
		private string endereco { get;  set; }
		private string telefone { get;  set; }

		public Cliente()
        {

        }
		public Cliente(long id, string nome, string cpf, string senhaCliente, int idade, string sexo, string estadoCivil,
				string endereco, string telefone)
		{
			this.id = id;
			this.nome = nome;
			this.cpf = cpf;
			this.senhaCliente = senhaCliente;
			this.idade = idade;
			this.sexo = sexo;
			this.estadoCivil = estadoCivil;
			this.endereco = endereco;
			this.telefone = telefone;
		}

		public long getId()
		{
			return id;
		}

		public void setId(long id)
		{
			this.id = id;
		}

		public string getNome()
		{
			return nome;
		}

		public void setNome(string nome)
		{
			this.nome = nome;
		}

		public string getCpf()
		{
			return cpf;
		}

		public void setCpf(string cpf)
		{
			this.cpf = cpf;
		}

		public string getSenhaCliente()
		{
			return senhaCliente;
		}

		public void setSenhaCliente(string senhaCliente)
		{
			this.senhaCliente = senhaCliente;
		}

		public int getIdade()
		{
			return idade;
		}

		public void setIdade(int idade)
		{
			this.idade = idade;
		}

		public string getSexo()
		{
			return sexo;
		}

		public void setSexo(string sexo)
		{
			this.sexo = sexo;
		}

		public string getEstadoCivil()
		{
			return estadoCivil;
		}

		public void setEstadoCivil(string estadoCivil)
		{
			this.estadoCivil = estadoCivil;
		}

		public string getEndereco()
		{
			return endereco;
		}

		public void setEndereco(string endereco)
		{
			this.endereco = endereco;
		}

		public string getTelefone()
		{
			return telefone;
		}

		public void setTelefone(string telefone)
		{
			this.telefone = telefone;
		}
	}
}
