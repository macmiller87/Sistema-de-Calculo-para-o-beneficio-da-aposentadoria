using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p23aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string lblNome;
            int lblRegistro, lblAnoNasc, lblAnoEntEmp, SubTempTrab, SubIdade;
            int AnoAtual = DateTime.Now.Year;


            if (textBoxNome.Text == "" || textBoxReg.Text == "" ||
                textBoxAnoNasc.Text == "" || textBoxAnoAdm.Text == "") {

                lblRes1.Text = "Preencha Todos Os Dados Para Fazer A Verificação!";

            } else {

                lblNome = (textBoxNome.Text);
                lblRegistro = Convert.ToInt32(textBoxReg.Text);
                lblAnoNasc = Convert.ToInt32(textBoxAnoNasc.Text);
                lblAnoEntEmp = Convert.ToInt32(textBoxAnoAdm.Text);

                SubTempTrab = AnoAtual - lblAnoEntEmp;
                SubIdade = AnoAtual - lblAnoNasc;


                if (SubIdade >= 60 && SubTempTrab >= 25) {

                    lblRes.Text = "Olá " + lblNome + " Você Tem " + SubIdade + " De Idade, E " + SubTempTrab + " Anos de Trabalho!";
                    lblRes1.Text = "Requer Aposentadoria!";

                } else if (SubIdade >= 65 || SubTempTrab >= 30) {
                    
                    lblRes.Text = "Olá " + lblNome + " Você Tem " + SubIdade + " De Idade, E " + SubTempTrab + " Anos de Trabalho!";
                    lblRes1.Text = "Requer Aposentadoria!";

                } else {

                    lblRes2.Text = "Olá " + lblNome + " , Não Requerer Aposentadoria!";
                }
            }   
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxAnoAdm.Clear();
            textBoxNome.Clear();
            textBoxReg.Clear();
            textBoxAnoNasc.Clear();
            lblRes.Text = " ";
            lblRes1.Text = " ";
            lblRes2.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
