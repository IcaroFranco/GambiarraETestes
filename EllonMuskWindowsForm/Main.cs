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
            GenericTela tela1 = new GenericTela();
            tela1.ShowDialog();
        }
        private void btn_tela2_Click(object sender, EventArgs e)
        {
            GenericTela tela2 = new GenericTela();
            tela2.ShowDialog();
        }
        private void tela3_Click(object sender, EventArgs e)
        {
            GenericTela tela3 = new GenericTela();
            tela3.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GenericTela tela4 = new GenericTela();
            tela4.ShowDialog();
        }
    }
}
