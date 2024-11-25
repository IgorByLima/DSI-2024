namespace BDEXEMPLO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsAluno objAluno = new clsAluno();
                

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           objAluno.Nome = txtNome.Text;
           objAluno.Codigo = int.Parse(txtCodigo.Text);

           objAluno.Incluir();        

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtGridAluno.DataSource = objAluno.Consultar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            objAluno.Codigo = int.Parse(txtCodigo.Text);
            dtGridAluno.DataSource = objAluno.Pesquisar();
            txtNome.Text = $"{objAluno.Pesquisar().Rows[0]["Nome"]}";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            objAluno.Nome = txtNome.Text;
            objAluno.Codigo = int.Parse(txtCodigo.Text);

            objAluno.Alterar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           objAluno.Codigo = int.Parse(txtCodigo.Text) ;
            dtGridAluno.DataSource = objAluno.Pesquisar();
            txtNome.Text = $"{objAluno.Pesquisar().Rows[0]["Nome"]}";

            if (MessageBox.Show($"Deseja realmente excluir o registro de {txtNome.Text} ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                objAluno.Excluir();
                MessageBox.Show($"Registro de {txtNome.Text} excluído com sucesso!");
            }
        }

        // dublo clique na linha do grid
        private void dtGridAluno_DoubleClick(object sender, EventArgs e)
        {
           txtCodigo.Text = $"{dtGridAluno.CurrentRow.Cells[0].Value}";
            txtNome.Text = $"{dtGridAluno.CurrentRow.Cells[1].Value}";
        }

        // pesquisa por inicial do nome ao digitar
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            objAluno.Nome = txtNome.Text;

            var linhasRetornadas = objAluno.PesquisarNome();

            // SE QTDE DE LINHAS "ENCONTRADAS" FOR MAIOR 0
            if (linhasRetornadas.Rows.Count > 0)

                dtGridAluno.DataSource = linhasRetornadas;

            if (txtNome.Text == "") {
                dtGridAluno.DataSource = null;
            }
        }

       
    }
}