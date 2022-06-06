﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EllonMuskWindowsForm
{
    public partial class GenericTela : Form
    {
        public GenericTela()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        RelacionamentoAnexoService relacionamentoAnexo;
        private void button1_Click(object sender, EventArgs e)
        {
            if (relacionamentoAnexo == null)return;
            

            MessageBox.Show(relacionamentoAnexo.SalvarAnexo());

            Close();
        }

        private void buscarAnexo_Click(object sender, EventArgs e)
        {
            if (relacionamentoAnexo == null)return;
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                relacionamentoAnexo.Anexos.Add(Path.GetFileName(dlg.FileName));
                listBox1.Items.Add(Path.GetFileName(dlg.FileName));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= 0)
                relacionamentoAnexo = new AnexoVisitaService();
            else if (comboBox1.SelectedIndex == 1)
                relacionamentoAnexo = new AnexoSolicitacaoService();
            else
                relacionamentoAnexo = new AnexoClienteService();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (relacionamentoAnexo == null)return;

            if (listBox1.SelectedIndex != -1)
            {
                relacionamentoAnexo.Anexos.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }else MessageBox.Show("selecione um Item antes!");
        }
    }
}
