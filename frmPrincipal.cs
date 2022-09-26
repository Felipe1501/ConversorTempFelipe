using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe1felipeDS
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			this.Text = "Exemplo 1";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double v1, res;
			v1 = double.Parse(txtValor1.Text);
			res = v1/5 * 9 + 32 ;
			MessageBox.Show("A Conversão é : " + res,
			"RESULTADO",MessageBoxButtons.OK, MessageBoxIcon.Information);


		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtValor1.Text = "";
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			double v1, res;
			v1 = double.Parse(txtValor1.Text);
			res = v1/5 * 5 + 273;
			MessageBox.Show("A Conversão é : " + res,
			"RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			double v1, res;
			v1 = double.Parse(txtValor1.Text);
			res = (v1-32)/9 * 5;
			MessageBox.Show("A Conversão é : " + res,
			"RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			double v1, res;
			v1 = double.Parse(txtValor1.Text);
			res = (v1 - 32)/9 * 5 + 273;
			MessageBox.Show("A Conversão é : " + res,
			"RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			double v1, res;
			v1 = double.Parse(txtValor1.Text);
			res = (v1 - 273)/5 * 5;
			MessageBox.Show("A Conversão é : " + res,
			"RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			double v1, res;
			v1 = double.Parse(txtValor1.Text);
			res = (v1 - 273)/5 * 9 + 32 ;
			MessageBox.Show("A conversão é : " + res,
			"RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
