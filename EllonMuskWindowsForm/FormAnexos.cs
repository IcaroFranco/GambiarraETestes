using System;
using System.Windows.Forms;

namespace EllonMuskWindowsForm
{
    public partial class FormAnexos : Form
    {
        public FormAnexos()
        {
            InitializeComponent();
        }

        GenericTela GenericTela = new GenericTela();

        public FormAnexos(GenericTela genericTela)
        {
            InitializeComponent();

            GenericTela = genericTela;
        }

        private void FormAnexos_Load(object sender, EventArgs e)
        {

        }

        private void retornoAnexo_Click(object sender, EventArgs e)
        {
            string teste = "Dados do Anexo";

            GenericTela.label3.Text = teste;

            Close();
        }
    }
}
