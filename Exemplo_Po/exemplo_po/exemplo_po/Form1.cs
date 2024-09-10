using System.DirectoryServices.ActiveDirectory;

namespace exemplo_po
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }
        clsusuario objusuario = new clsusuario();
        private void btnenviar_Click(object sender, EventArgs e)
        {

            objusuario.Nome = txtnome.Text;
            objusuario.Senha = txtsenha.Text;
            objusuario.Email = txtemail.Text;
            objusuario.Login = txtlogin.Text;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            objusuario.provarExistencia();
        }
        
    }
}
