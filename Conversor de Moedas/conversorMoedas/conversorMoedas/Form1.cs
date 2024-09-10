using Microsoft.VisualBasic;
using System.Drawing;

namespace conversorMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbpara_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor = 0, valorConvertido = 0;

            if (txtvalor.Text != null)
                try
                {

                    valor = double.Parse(txtvalor.Text);
                    // ORDEM SEGUE EURO DOLAR REAL PESO NO INDEX
                    // Euro
                    if (cbbde.SelectedIndex == 0 && cbbpara.SelectedIndex == 1)
                        valorConvertido = valor * 1.11;
                    else if (cbbde.SelectedIndex == 0 && cbbpara.SelectedIndex == 2)
                        valorConvertido = valor * 6.19;
                    else if (cbbde.SelectedIndex == 0 && cbbpara.SelectedIndex == 3)
                        valorConvertido = valor * 1050.10;
                    //Dolar
                    else if (cbbde.SelectedIndex == 1 && cbbpara.SelectedIndex == 0)
                        valorConvertido = valor / 1.11;
                    else if (cbbde.SelectedIndex == 1 && cbbpara.SelectedIndex == 2)
                        valorConvertido = valor * 5.57;
                    else if (cbbde.SelectedIndex == 1 && cbbpara.SelectedIndex == 3)
                        valorConvertido = valor * 945.25;
                    //Real
                    else if (cbbde.SelectedIndex == 2 && cbbpara.SelectedIndex == 0)
                        valorConvertido = valor / 6.19;
                    else if (cbbde.SelectedIndex == 2 && cbbpara.SelectedIndex == 1)
                        valorConvertido = valor / 5.57;
                    else if (cbbde.SelectedIndex == 2 && cbbpara.SelectedIndex == 3)
                        valorConvertido = valor * 169.59;
                    //Peso
                    else if (cbbde.SelectedIndex == 3 && cbbpara.SelectedIndex == 0)
                        valorConvertido = valor / 1050.10;
                    else if (cbbde.SelectedIndex == 3 && cbbpara.SelectedIndex == 1)
                        valorConvertido = valor / 945.25;
                    else if (cbbde.SelectedIndex == 3 && cbbpara.SelectedIndex == 2)
                        valorConvertido = valor / 169.59;
                    //Mesmo moeda
                    else valorConvertido = valor;
                    //moeda

                    if (cbbpara.SelectedIndex == 0)
                        txtconvertido.Text = $"€ {valorConvertido}";

                    else if (cbbpara.SelectedIndex == 1)
                        txtconvertido.Text = $"US$ {valorConvertido}";

                    else if (cbbpara.SelectedIndex == 2)
                        txtconvertido.Text = $"R$ {valorConvertido}";
                    else if (cbbpara.SelectedIndex == 3)
                        txtconvertido.Text = $"$ {valorConvertido}";
                }
                catch (Exception) { }



        }

        private void btnnovo_Click(object sender, EventArgs e)
        {

            txtvalor.Clear();
            cbbde.SelectedIndex = -1;
            cbbpara.SelectedIndex = -1;
            txtconvertido.Clear();


        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) { 
Application.Exit(); 
            } 
        }
    }
}
    