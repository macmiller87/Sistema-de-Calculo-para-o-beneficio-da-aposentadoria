
namespace p23aula
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.lblAnoEntEmp = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.textBoxAnoNasc = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblRes1 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBoxAnoAdm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistro.Location = new System.Drawing.Point(14, 70);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(260, 19);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Informe Seu Registro Funcional :";
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnoNasc.Location = new System.Drawing.Point(14, 115);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(263, 19);
            this.lblAnoNasc.TabIndex = 1;
            this.lblAnoNasc.Text = "Informe Seu Ano de Nascimento :";
            // 
            // lblAnoEntEmp
            // 
            this.lblAnoEntEmp.AutoSize = true;
            this.lblAnoEntEmp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnoEntEmp.Location = new System.Drawing.Point(14, 160);
            this.lblAnoEntEmp.Name = "lblAnoEntEmp";
            this.lblAnoEntEmp.Size = new System.Drawing.Size(261, 19);
            this.lblAnoEntEmp.TabIndex = 2;
            this.lblAnoEntEmp.Text = "informe O ano da Sua admissão :";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(175, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(199, 26);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxReg
            // 
            this.textBoxReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxReg.Location = new System.Drawing.Point(274, 63);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.Size = new System.Drawing.Size(100, 26);
            this.textBoxReg.TabIndex = 4;
            // 
            // textBoxAnoNasc
            // 
            this.textBoxAnoNasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnoNasc.Location = new System.Drawing.Point(274, 108);
            this.textBoxAnoNasc.Name = "textBoxAnoNasc";
            this.textBoxAnoNasc.Size = new System.Drawing.Size(100, 26);
            this.textBoxAnoNasc.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.Location = new System.Drawing.Point(606, 96);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(108, 38);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRes.ForeColor = System.Drawing.Color.Red;
            this.lblRes.Location = new System.Drawing.Point(14, 248);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 19);
            this.lblRes.TabIndex = 7;
            // 
            // lblRes1
            // 
            this.lblRes1.AutoSize = true;
            this.lblRes1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRes1.ForeColor = System.Drawing.Color.Red;
            this.lblRes1.Location = new System.Drawing.Point(14, 296);
            this.lblRes1.Name = "lblRes1";
            this.lblRes1.Size = new System.Drawing.Size(0, 19);
            this.lblRes1.TabIndex = 8;
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRes2.ForeColor = System.Drawing.Color.Red;
            this.lblRes2.Location = new System.Drawing.Point(14, 345);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(0, 19);
            this.lblRes2.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(680, 391);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 38);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(548, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(13, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(156, 19);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Informe Seu Nome:";
            // 
            // textBoxAnoAdm
            // 
            this.textBoxAnoAdm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnoAdm.Location = new System.Drawing.Point(274, 153);
            this.textBoxAnoAdm.Name = "textBoxAnoAdm";
            this.textBoxAnoAdm.Size = new System.Drawing.Size(100, 26);
            this.textBoxAnoAdm.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxAnoAdm);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.lblRes1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBoxAnoNasc);
            this.Controls.Add(this.textBoxReg);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblAnoEntEmp);
            this.Controls.Add(this.lblAnoNasc);
            this.Controls.Add(this.lblRegistro);
            this.Name = "Form1";
            this.Text = "Algoritmo Para Calcular e Validar  o Beneficio da Aposentadoria.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.Label lblAnoEntEmp;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxReg;
        private System.Windows.Forms.TextBox textBoxAnoNasc;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblRes1;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBoxAnoAdm;
    }
}

