using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Descontos_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;            
            notifyIcon1.BalloonTipText = "Em Execução";
            notifyIcon1.ShowBalloonTip(6000);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            const double irs = 0.15;
            const double segSocial = 0.12;
            double valorSalarioBruto = 0;
            double valorSalarioFinal = 0;
            double descSS, descIrs;

            valorSalarioBruto = double.Parse(txtSalario.Text);
            descIrs = valorSalarioBruto * irs;
            descSS = valorSalarioBruto * segSocial;

            valorSalarioFinal = valorSalarioBruto - descIrs - descSS;

            lblIrs.Text = descIrs.ToString("C2");
            lblSs.Text = descSS.ToString("C2");
            lblSalFinal.Text = valorSalarioFinal.ToString("C2");

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
