
namespace EllonMuskWindowsForm
{
    partial class Main
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
            this.btn_tela1 = new System.Windows.Forms.Button();
            this.btn_tela2 = new System.Windows.Forms.Button();
            this.btn_tela3 = new System.Windows.Forms.Button();
            this.btn_tela4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tela1
            // 
            this.btn_tela1.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_tela1.FlatAppearance.BorderSize = 0;
            this.btn_tela1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tela1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tela1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tela1.Location = new System.Drawing.Point(40, 303);
            this.btn_tela1.Name = "btn_tela1";
            this.btn_tela1.Size = new System.Drawing.Size(277, 65);
            this.btn_tela1.TabIndex = 0;
            this.btn_tela1.Text = "Tela 1";
            this.btn_tela1.UseVisualStyleBackColor = false;
            this.btn_tela1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tela2
            // 
            this.btn_tela2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_tela2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tela2.FlatAppearance.BorderSize = 0;
            this.btn_tela2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tela2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tela2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tela2.Location = new System.Drawing.Point(40, 374);
            this.btn_tela2.Name = "btn_tela2";
            this.btn_tela2.Size = new System.Drawing.Size(277, 65);
            this.btn_tela2.TabIndex = 1;
            this.btn_tela2.Text = "Tela 2";
            this.btn_tela2.UseVisualStyleBackColor = false;
            this.btn_tela2.Click += new System.EventHandler(this.btn_tela2_Click);
            // 
            // btn_tela3
            // 
            this.btn_tela3.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_tela3.FlatAppearance.BorderSize = 0;
            this.btn_tela3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tela3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tela3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tela3.Location = new System.Drawing.Point(40, 232);
            this.btn_tela3.Name = "btn_tela3";
            this.btn_tela3.Size = new System.Drawing.Size(277, 65);
            this.btn_tela3.TabIndex = 2;
            this.btn_tela3.Text = "Tela 3";
            this.btn_tela3.UseVisualStyleBackColor = false;
            this.btn_tela3.Click += new System.EventHandler(this.tela3_Click);
            // 
            // btn_tela4
            // 
            this.btn_tela4.BackColor = System.Drawing.Color.Green;
            this.btn_tela4.FlatAppearance.BorderSize = 0;
            this.btn_tela4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tela4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tela4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tela4.Location = new System.Drawing.Point(350, 232);
            this.btn_tela4.Name = "btn_tela4";
            this.btn_tela4.Size = new System.Drawing.Size(277, 207);
            this.btn_tela4.TabIndex = 3;
            this.btn_tela4.Text = "Tela 4";
            this.btn_tela4.UseVisualStyleBackColor = false;
            this.btn_tela4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(119, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione a tela desejada";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(671, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tela4);
            this.Controls.Add(this.btn_tela3);
            this.Controls.Add(this.btn_tela2);
            this.Controls.Add(this.btn_tela1);
            this.Name = "Main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tela1;
        private System.Windows.Forms.Button btn_tela2;
        private System.Windows.Forms.Button btn_tela3;
        private System.Windows.Forms.Button btn_tela4;
        private System.Windows.Forms.Label label1;
    }
}

