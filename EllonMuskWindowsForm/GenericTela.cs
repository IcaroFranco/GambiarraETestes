using System;
using System.Windows.Forms;

namespace EllonMuskWindowsForm
{
    public partial class GenericTela : Form
    {
        public GenericTela()
        {
            InitializeComponent();
        }

        public GenericTela(string valor)
        {
            InitializeComponent();

            recebeValor.Text = valor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarAnexo_Click(object sender, EventArgs e)
        {
            FormAnexos formAnexos = new FormAnexos(this);

            formAnexos.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
