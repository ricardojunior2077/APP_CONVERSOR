using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERSOR_TEMPERATURA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnConveter_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(TxtTemperatura.Text);
            COnverterCK(t);
            ConvertCF(t);
            ConvertKF(t);
            ConvertInvalida(t);
        }
        private void ConvertInvalida(double t)
        {
            if (RbC.Checked && RbToC.Checked || RbF.Checked && RbToF.Checked || RbK.Checked && RbToK.Checked)
            {
                LbResposta.Text = $"Conversão Inválida";
            }
        }

        private void ConvertKF(double t)
        {
            if (RbF.Checked && RbToK.Checked)
            {
                double k = (t-32) * 5/9 + 273.15;
                LbResposta.Text = $"{t:N2}F = {k:N2}K";
            }
            if (RbK.Checked && RbToF.Checked)
            {
                double f = (t-273.15) * 1.8 + 32;
                LbResposta.Text = $"{t:N2}K = {f:N2}F";
            }
        }

        private void ConvertCF(double t)
        {
            if (RbC.Checked && RbToF.Checked)
            {
                double f = t * 1.8 + 32;
                LbResposta.Text = $"{t:N2}°C = {f:N2}F";
            }
            if (RbF.Checked && RbToC.Checked)
            {
                double c = (t - 32) / 1.8;
                LbResposta.Text = $"{t:N2}F = {c:N2}°C";
            }
        }

        private void COnverterCK(double t)
        {
            if (RbC.Checked && RbToK.Checked)
            {
                double k = t + 273.15;
                LbResposta.Text = $"{t:N2}°C = {k:N2}K";
            }
            if (RbK.Checked && RbToC.Checked)
            {
                double c = t - 273.15;
                LbResposta.Text = $"{t:N2}K = {c:N2}°C";
            }
        }
    }
          
}
