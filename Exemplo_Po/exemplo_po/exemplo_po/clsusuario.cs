using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_po
{
    internal class clsusuario
    {
		private string nome;

		public string Nome
		{
			get { return nome; }
			set {
				if (value.All(char.IsLetter))
					nome = value;
				else
					MessageBox.Show("No campo Nome, digite apenas CARACTERES");
			}
		}
		private string senha;

		public string Senha
		{
			get { return senha; }
			set {
				if (value.Length < 8)
					MessageBox.Show("No campo SENHA informe ao menos 8 caracteres!");
				else
					senha = value;
			}

		}
		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		private string login;

		public string Login
		{
			get { return login; }
			set {
				if (value.Length  >10  && value.Length<4)
				MessageBox.Show("No campo LOGIN infome no minimo 4 e no máximo 10 caracteres");
				else login = value;
				
			}
		}

		public void provarExistencia()
		{
			MessageBox.Show($"Nome:{nome}");
		}

	}
}
