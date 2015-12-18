namespace Examen
{
    partial class Angajat
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
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtProcent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjusteaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProduse
            // 
            this.lstProduse.FormattingEnabled = true;
            this.lstProduse.Location = new System.Drawing.Point(12, 27);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(190, 173);
            this.lstProduse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista produselor";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(12, 226);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(190, 20);
            this.txtDenumire.TabIndex = 2;
            // 
            // txtProcent
            // 
            this.txtProcent.Location = new System.Drawing.Point(12, 272);
            this.txtProcent.Name = "txtProcent";
            this.txtProcent.Size = new System.Drawing.Size(190, 20);
            this.txtProcent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumirea categoriei";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Procent ajustarii";
            // 
            // btnAjusteaza
            // 
            this.btnAjusteaza.Location = new System.Drawing.Point(12, 298);
            this.btnAjusteaza.Name = "btnAjusteaza";
            this.btnAjusteaza.Size = new System.Drawing.Size(190, 23);
            this.btnAjusteaza.TabIndex = 6;
            this.btnAjusteaza.Text = "Ajusteaza";
            this.btnAjusteaza.UseVisualStyleBackColor = true;
            this.btnAjusteaza.Click += new System.EventHandler(this.btnAjusteaza_Click);
            // 
            // Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 326);
            this.Controls.Add(this.btnAjusteaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProcent);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProduse);
            this.Name = "Angajat";
            this.Text = "Angajat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProduse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtProcent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjusteaza;
    }
}