using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_1;

namespace TP_Analisis_Numerico
{
    public partial class FormPrincipal : Form
    {
        private MetodoUnidad1 Logica;
        public FormPrincipal()
        {
            InitializeComponent();
            Logica = new MetodoUnidad1();
        }

        private void btnObtener_Biseccion_Click(object sender, EventArgs e)
        {
            if (tbxFuncion.Text!="" && tbxTolerancia.Text != "" && tbxMaxIteraciones.Text != "" && tbxLI.Text != "" && tbxLD.Text != "")
            {
                Salida resultado = Logica.ObtenerRaiz("Biseccion", int.Parse(tbxMaxIteraciones.Text), double.Parse(tbxTolerancia.Text), double.Parse(tbxLI.Text), double.Parse(tbxLD.Text));
                if (resultado==null)
                {
                    MessageBox.Show("Volver a ingresar límites.");
                    tbxLI.Clear();
                    tbxLD.Clear();
                }
                else
                {
                    lblIteraciones_Biseccion.Text = $"{resultado.IteracionesRealizadas}";
                    lblErrorRelativo_Biseccion.Text = $"{resultado.ErrorRelativo}";
                    lblSolucionRaiz_Biseccion.Text = $"{resultado.RaizEncontrada}";
                }
            }
        }

        private void btnObtener_RF_Click(object sender, EventArgs e)
        {
            if (tbxFuncion.Text != "" && tbxTolerancia.Text != "" && tbxMaxIteraciones.Text != "" && tbxLI.Text != "" && tbxLD.Text != "")
            {
                Salida resultado = Logica.ObtenerRaiz("Regla Falsa", int.Parse(tbxMaxIteraciones.Text), double.Parse(tbxTolerancia.Text), double.Parse(tbxLI.Text), double.Parse(tbxLD.Text));
                if (resultado == null)
                {
                    MessageBox.Show("Volver a ingresar límites.");
                    tbxLI.Clear();
                    tbxLD.Clear();
                }
                else
                {
                    lblIteraciones_RF.Text = $"{resultado.IteracionesRealizadas}";
                    lblErrorRelativo_RF.Text = $"{resultado.ErrorRelativo}";
                    lblSolucionRaiz_RF.Text = $"{resultado.RaizEncontrada}";
                }
            }
        }
    }
}
