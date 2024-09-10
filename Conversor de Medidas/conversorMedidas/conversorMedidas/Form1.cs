using System;
using System.Windows.Forms;

namespace conversorMedidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbpara_SelectedIndexChanged(object sender, EventArgs e)
        {
            double medida = 0, total = 0;

            try
            {
                medida = double.Parse(txtmedida.Text);

                if (cbbde.SelectedIndex == 0) // Convertendo de metros
                {
                    switch (cbbpara.SelectedIndex)
                    {
                        case 1: total = medida / 100; break; // Para cent�metros
                        case 2: total = medida / 1000; break; // Para mil�metros
                        default: total = medida; break; // Para metros
                    }
                }
                else if (cbbde.SelectedIndex == 1) // Convertendo de cent�metros
                {
                    switch (cbbpara.SelectedIndex)
                    {
                        case 0: total = medida * 100; break; // Para metros
                        case 2: total = medida / 10; break; // Para mil�metros
                        default: total = medida; break; // Para cent�metros
                    }
                }
                else if (cbbde.SelectedIndex == 2) // Convertendo de mil�metros
                {
                    switch (cbbpara.SelectedIndex)
                    {
                        case 0: total = medida / 1000; break; // Para metros
                        case 1: total = medida / 10; break; // Para cent�metros
                        default: total = medida; break; // Para mil�metros
                    }
                }
            }
            catch (Exception )
            { }
          
            {
                txtconvertida.Text = total.ToString();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtconvertida.Clear();
            txtmedida.Clear();
            cbbde.SelectedIndex = -1;
            cbbpara.SelectedIndex = -1;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
