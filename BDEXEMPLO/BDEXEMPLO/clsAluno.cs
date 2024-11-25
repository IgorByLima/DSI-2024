using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BDEXEMPLO {
    internal class clsAluno {
        public int Codigo { get; set; }
        public string? Nome { get; set; }


        Dados objDados = new Dados();



        public DataTable Consultar() {
            return objDados.ConvertSqlToDataTable("SELECT * FROM ALUNO");
        }
        public DataTable Pesquisar() {
            return objDados.ConvertSqlToDataTable(
                "SELECT * FROM ALUNO WHERE CODIGO = ?Codigo",
                new MySqlParameter("?Codigo", Codigo));
        }
        public void Incluir() {
            if (objDados.ConvertSqlToInt(@"INSERT INTO ALUNO(CODIGO,NOME) VALUES(?CODIGO,?NOME)",
                new MySqlParameter("?CODIGO", Codigo),
                new MySqlParameter("?NOME", Nome)) != 0) {
                MessageBox.Show("Registro Incluido");
            } else {
                MessageBox.Show("Erro ao incluir o registro");
            }

        }
        public void Alterar() {
            if (objDados.ConvertSqlToInt(@"UPDATE ALUNO SET NOME = ?Nome WHERE CODIGO = ?Codigo",
                new MySqlParameter("?Codigo", Codigo),
                new MySqlParameter("?Nome", Nome)) != 0) {
                MessageBox.Show("Registro Alterado com sucesso.");

            } else {
                MessageBox.Show("Erro ao alterar");
            }



        }

        public void Excluir() {
            if (objDados.ConvertSqlToInt("DELETE FROM ALUNO WHERE CODIGO = ?CODIGO", new MySqlParameter("CODIGO", Codigo)) != 0)
                MessageBox.Show($"Registro excluído!");
            else {
                MessageBox.Show("Erro ao excluir");
            }

        }

 public DataTable PesquisarNome() {
            return objDados.ConvertSqlToDataTable(
                 "SELECT * FROM ALUNO WHERE NOME LIKE ?NOME",
                 new MySqlParameter("?Nome", Nome + "%"));

        }

    }
}
