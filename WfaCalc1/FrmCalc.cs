using ClContas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCalc1
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void rdbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "X";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            rdbSomar.Checked = true;
            txtNum1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Contas contas = new Contas();
            string resp = "";
            try
            {
                contas.Num1 = Convert.ToDouble(txtNum1.Text);
                contas.Num2 = Convert.ToDouble(txtNum2.Text);
                if (rdbSomar.Checked)
                {
                    resp = contas.Somar();
                }
                else if (rdbSubtrair.Checked)
                {
                    resp = contas.Subtrair();
                }
                else if (rdbMultiplicar.Checked)
                {
                    resp = contas.Multiplicar();
                }
                else
                {
                    resp = contas.Dividir();
                }
                MessageBox.Show(resp, "Resposta:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // luiz.flalmeida@sp.senac.br
        }

        private void FrmCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            // O MessageBox retorna um DialogResult, que pode ser "No", "Yes", "Cancel", "Ok", "Retry"
            // (Aparece traduzido no idioma do windows)
            // No caso abaixo, estamos comparando o que retornou do MessageBox com "Não" (No), e caso seja,
            // Cancela o encerramento do Form
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção:", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                // O "e" da linha abaixo está declarado como parametro em FormClosing,
                // ele é do tipo FormClosingEventArgs, daí vem o Cancel.
                // Quando cancel é true, cancela o encerramento do Form
                e.Cancel = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
