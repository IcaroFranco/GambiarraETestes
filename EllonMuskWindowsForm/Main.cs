using System;
using System.Windows.Forms;

namespace EllonMuskWindowsForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){ }

        private void button1_Click(object sender, EventArgs e)
        {
            string euSou = "Banco 1";
            GenericTela tela1 = new GenericTela(euSou);
            tela1.ShowDialog();
        }
        private void btn_tela2_Click(object sender, EventArgs e)
        {
            string euSou = "Banco 2";

            GenericTela tela2 = new GenericTela(euSou);
            tela2.ShowDialog();
        }
        private void tela3_Click(object sender, EventArgs e)
        {
            string euSou = "Banco 3";

            GenericTela tela3 = new GenericTela(euSou);
            tela3.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string euSou = "Banco 4";

            GenericTela tela4 = new GenericTela(euSou);
            tela4.ShowDialog();
        }
    }
}
