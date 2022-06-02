
namespace EllonMuskWindowsForm
{
    partial class GenericTela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recebeValor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarAnexo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eu sou o Component Generic";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "O componente que me chamou foi :";
            // 
            // recebeValor
            // 
            this.recebeValor.AutoSize = true;
            this.recebeValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recebeValor.Location = new System.Drawing.Point(167, 422);
            this.recebeValor.Name = "recebeValor";
            this.recebeValor.Size = new System.Drawing.Size(24, 25);
            this.recebeValor.TabIndex = 2;
            this.recebeValor.Text = "x";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscarAnexo
            // 
            this.buscarAnexo.Location = new System.Drawing.Point(537, 230);
            this.buscarAnexo.Name = "buscarAnexo";
            this.buscarAnexo.Size = new System.Drawing.Size(70, 61);
            this.buscarAnexo.TabIndex = 4;
            this.buscarAnexo.Text = "Buscar Anexo";
            this.buscarAnexo.UseVisualStyleBackColor = true;
            this.buscarAnexo.Click += new System.EventHandler(this.buscarAnexo_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(127, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 164);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GenericTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buscarAnexo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recebeValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenericTela";
            this.Text = "GenericTela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label recebeValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buscarAnexo;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label label3;
    }
}