
namespace BuscaCEPWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuscaCEP = new System.Windows.Forms.Label();
            this.maskCep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogodouro = new System.Windows.Forms.TextBox();
            this.txtNumêro = new System.Windows.Forms.TextBox();
            this.txtComplemonto = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemonto2 = new System.Windows.Forms.TextBox();
            this.txtMunicipo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.Label();
            this.txtComplemento2 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuscaCEP
            // 
            this.BuscaCEP.AutoSize = true;
            this.BuscaCEP.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BuscaCEP.Location = new System.Drawing.Point(21, 9);
            this.BuscaCEP.Name = "BuscaCEP";
            this.BuscaCEP.Size = new System.Drawing.Size(366, 32);
            this.BuscaCEP.TabIndex = 0;
            this.BuscaCEP.Text = "BUSCA CEP - EVOLUTION SENAI";
            this.BuscaCEP.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskCep
            // 
            this.maskCep.Location = new System.Drawing.Point(130, 88);
            this.maskCep.Mask = "00000-000";
            this.maskCep.Name = "maskCep";
            this.maskCep.Size = new System.Drawing.Size(148, 23);
            this.maskCep.TabIndex = 1;
            this.maskCep.Leave += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "CEP";
            // 
            // txtLogodouro
            // 
            this.txtLogodouro.Location = new System.Drawing.Point(130, 128);
            this.txtLogodouro.Name = "txtLogodouro";
            this.txtLogodouro.Size = new System.Drawing.Size(148, 23);
            this.txtLogodouro.TabIndex = 3;
            // 
            // txtNumêro
            // 
            this.txtNumêro.Location = new System.Drawing.Point(130, 175);
            this.txtNumêro.Name = "txtNumêro";
            this.txtNumêro.Size = new System.Drawing.Size(148, 23);
            this.txtNumêro.TabIndex = 4;
            // 
            // txtComplemonto
            // 
            this.txtComplemonto.Location = new System.Drawing.Point(130, 228);
            this.txtComplemonto.Name = "txtComplemonto";
            this.txtComplemonto.Size = new System.Drawing.Size(148, 23);
            this.txtComplemonto.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(130, 277);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(148, 23);
            this.txtBairro.TabIndex = 6;
            // 
            // txtComplemonto2
            // 
            this.txtComplemonto2.Location = new System.Drawing.Point(130, 324);
            this.txtComplemonto2.Name = "txtComplemonto2";
            this.txtComplemonto2.Size = new System.Drawing.Size(148, 23);
            this.txtComplemonto2.TabIndex = 7;
            this.txtComplemonto2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtMunicipo
            // 
            this.txtMunicipo.Location = new System.Drawing.Point(130, 365);
            this.txtMunicipo.Name = "txtMunicipo";
            this.txtMunicipo.Size = new System.Drawing.Size(148, 23);
            this.txtMunicipo.TabIndex = 8;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(130, 412);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(148, 23);
            this.txtEstado.TabIndex = 9;
            // 
            // txtUF
            // 
            this.txtUF.AutoSize = true;
            this.txtUF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtUF.Location = new System.Drawing.Point(55, 414);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(29, 21);
            this.txtUF.TabIndex = 10;
            this.txtUF.Text = "UF";
            // 
            // txtNumero
            // 
            this.txtNumero.AutoSize = true;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(34, 173);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 21);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.Text = "Numero";
            // 
            // txtComplemento
            // 
            this.txtComplemento.AutoSize = true;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.Location = new System.Drawing.Point(12, 226);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(108, 21);
            this.txtComplemento.TabIndex = 12;
            this.txtComplemento.Text = "complemento";
            // 
            // txtBarrio
            // 
            this.txtBarrio.AutoSize = true;
            this.txtBarrio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtBarrio.Location = new System.Drawing.Point(47, 275);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(55, 21);
            this.txtBarrio.TabIndex = 13;
            this.txtBarrio.Text = "Barrio";
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.AutoSize = true;
            this.txtComplemento2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtComplemento2.Location = new System.Drawing.Point(8, 326);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(116, 21);
            this.txtComplemento2.TabIndex = 14;
            this.txtComplemento2.Text = "complemento2";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.AutoSize = true;
            this.txtMunicipio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtMunicipio.Location = new System.Drawing.Point(30, 363);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(82, 21);
            this.txtMunicipio.TabIndex = 15;
            this.txtMunicipio.Text = "Municipio";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.AutoSize = true;
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.Location = new System.Drawing.Point(27, 126);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(93, 21);
            this.txtLogradouro.TabIndex = 16;
            this.txtLogradouro.Text = "Logradouro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 559);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtComplemento2);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtMunicipo);
            this.Controls.Add(this.txtComplemonto2);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemonto);
            this.Controls.Add(this.txtNumêro);
            this.Controls.Add(this.txtLogodouro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskCep);
            this.Controls.Add(this.BuscaCEP);
            this.Name = "Form1";
            this.Text = "Buscar CEP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuscaCEP;
        private System.Windows.Forms.MaskedTextBox maskCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogodouro;
        private System.Windows.Forms.TextBox txtNumêro;
        private System.Windows.Forms.TextBox txtComplemonto;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemonto2;
        private System.Windows.Forms.TextBox txtMunicipo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label txtUF;
        private System.Windows.Forms.Label txtNumero;
        private System.Windows.Forms.Label txtComplemento;
        private System.Windows.Forms.Label txtBarrio;
        private System.Windows.Forms.Label txtComplemento2;
        private System.Windows.Forms.Label txtMunicipio;
        private System.Windows.Forms.Label txtLogradouro;
    }
}

