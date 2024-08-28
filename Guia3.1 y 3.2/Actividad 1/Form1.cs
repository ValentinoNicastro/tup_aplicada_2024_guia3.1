using Actividad_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Evaluador ev = null;

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            tbDepreciacion.Enabled = false;
            tbVidaUtil.Enabled = true;
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            tbDepreciacion.Enabled = true;
            tbVidaUtil.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Moto vehiculo = new Moto(tbMarca.Text, Convert.ToInt32(nupModelo.Value), Convert.ToInt32(nupValorProd.Value));

            if(rbLineal.Checked)
            {
                ev = new EvaluadorLineal(vehiculo, Convert.ToInt32(nupAñoCalcular.Value), Convert.ToInt32(tbVidaUtil.Text));
            }
            else
            {
                ev = new EvaluadorAnual(vehiculo, Convert.ToInt32(nupAñoCalcular.Value), Convert.ToDouble(tbDepreciacion.Text));
            }

            if(ev != null)
            {
                fResultados form2 = new fResultados();

                form2.tbResultados.Text = ev.VerDescripcion();

                form2.ShowDialog();
            }
        }
    }
}
