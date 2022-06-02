
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
            this.SuspendLayout();
            // 
            // btn_tela1
            // 
            this.btn_tela1.Location = new System.Drawing.Point(119, 161);
            this.btn_tela1.Name = "btn_tela1";
            this.btn_tela1.Size = new System.Drawing.Size(166, 96);
            this.btn_tela1.TabIndex = 0;
            this.btn_tela1.Text = "tela1";
            this.btn_tela1.UseVisualStyleBackColor = true;
            this.btn_tela1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tela2
            // 
            this.btn_tela2.Location = new System.Drawing.Point(319, 161);
            this.btn_tela2.Name = "btn_tela2";
            this.btn_tela2.Size = new System.Drawing.Size(166, 96);
            this.btn_tela2.TabIndex = 1;
            this.btn_tela2.Text = "tela2";
            this.btn_tela2.UseVisualStyleBackColor = true;
            this.btn_tela2.Click += new System.EventHandler(this.btn_tela2_Click);
            // 
            // btn_tela3
            // 
            this.btn_tela3.Location = new System.Drawing.Point(532, 161);
            this.btn_tela3.Name = "btn_tela3";
            this.btn_tela3.Size = new System.Drawing.Size(166, 96);
            this.btn_tela3.TabIndex = 2;
            this.btn_tela3.Text = "tela3";
            this.btn_tela3.UseVisualStyleBackColor = true;
            this.btn_tela3.Click += new System.EventHandler(this.tela3_Click);
            // 
            // btn_tela4
            // 
            this.btn_tela4.Location = new System.Drawing.Point(731, 161);
            this.btn_tela4.Name = "btn_tela4";
            this.btn_tela4.Size = new System.Drawing.Size(166, 96);
            this.btn_tela4.TabIndex = 3;
            this.btn_tela4.Text = "tela4";
            this.btn_tela4.UseVisualStyleBackColor = true;
            this.btn_tela4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 449);
            this.Controls.Add(this.btn_tela4);
            this.Controls.Add(this.btn_tela3);
            this.Controls.Add(this.btn_tela2);
            this.Controls.Add(this.btn_tela1);
            this.Name = "Main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tela1;
        private System.Windows.Forms.Button btn_tela2;
        private System.Windows.Forms.Button btn_tela3;
        private System.Windows.Forms.Button btn_tela4;
    }
}

