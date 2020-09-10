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
using Unidad_2;

namespace TP_Analisis_Numerico
{
    public partial class FormPrincipal : Form
    {
        private MetodoUnidad1 Logica;
        private MetodoUnidad2 Logica2;
        public FormPrincipal()
        {
            InitializeComponent();
            Logica = new MetodoUnidad1();
            Logica2 = new MetodoUnidad2();
        }
        
        // UNIDAD 1
        private void btnObtener_Biseccion_Click(object sender, EventArgs e)
        {
            if (tbxFuncion.Text!="" && tbxTolerancia.Text != "" && tbxMaxIteraciones.Text != "" && tbxLI.Text != "" && tbxLD.Text != "")
            {
                Salida resultado = Logica.ObtenerRaizMetodosCerrados("Biseccion", int.Parse(tbxMaxIteraciones.Text), double.Parse(tbxTolerancia.Text), double.Parse(tbxLI.Text), double.Parse(tbxLD.Text));
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
                    lblSolucionRaiz_Biseccion.Text = $"{Math.Round(resultado.RaizEncontrada, 4)}";
                    if (resultado.IteracionesRealizadas >= int.Parse(tbxMaxIteraciones.Text))
                    {
                        lblConverge_Biseccion.Text = "NO";
                    }
                    else
                    {
                        lblConverge_Biseccion.Text = "SI";
                    }
                }
                
            }
        }

        private void btnObtener_RF_Click(object sender, EventArgs e)
        {
            if (tbxFuncion.Text != "" && tbxTolerancia.Text != "" && tbxMaxIteraciones.Text != "" && tbxLI.Text != "" && tbxLD.Text != "")
            {
                Salida resultado = Logica.ObtenerRaizMetodosCerrados("Regla Falsa", int.Parse(tbxMaxIteraciones.Text), double.Parse(tbxTolerancia.Text), double.Parse(tbxLI.Text), double.Parse(tbxLD.Text));
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
                    lblSolucionRaiz_RF.Text = $"{Math.Round(resultado.RaizEncontrada,4)}";
                    if (resultado.IteracionesRealizadas >= int.Parse(tbxMaxIteraciones.Text))
                    {
                        lblConverge_RF.Text = "NO";
                    }
                    else
                    {
                        lblConverge_RF.Text = "SI";
                    }
                }
                
            }
        }

        private void btnObtener_NR_Click(object sender, EventArgs e)
        {
            if (tbxFuncion.Text != "" && tbxTolerancia.Text != "" && tbxMaxIteraciones.Text != "" && tbxPuntoInicial.Text != "")
            {
                Salida resultado = Logica.ObtenerRaizMetodoNewtonRaphson(int.Parse(tbxMaxIteraciones.Text), double.Parse(tbxTolerancia.Text), double.Parse(tbxPuntoInicial.Text));
                lblIteraciones_NR.Text = $"{resultado.IteracionesRealizadas}";
                lblErrorRelativo_NR.Text = $"{resultado.ErrorRelativo}";
                lblSolucionRaiz_NR.Text = $"{Math.Round(resultado.RaizEncontrada, 4)}";
                lblMensaje_NR.Text = $"{resultado.Mensaje}";

                if (resultado.IteracionesRealizadas >= int.Parse(tbxMaxIteraciones.Text) || lblMensaje_NR.Text!="")
                {
                    lblConverge_NR.Text = "NO";
                }
                else
                {
                    lblConverge_NR.Text = "SI";
                }
            }

        }

        private void btnObtener_Secante_Click(object sender, EventArgs e)
        {
            if (tbxFuncion.Text != "" && tbxTolerancia.Text != "" && tbxMaxIteraciones.Text != "" && tbxPuntoInicial.Text != "" && tbxX2.Text != "")
            {
                Salida resultado = Logica.ObtenerRaizMetodoSecante(int.Parse(tbxMaxIteraciones.Text), double.Parse(tbxTolerancia.Text), double.Parse(tbxPuntoInicial.Text), double.Parse(tbxX2.Text));
                lblIteraciones_Secante.Text = $"{resultado.IteracionesRealizadas}";
                lblErrorRelativo_Secante.Text = $"{resultado.ErrorRelativo}";
                lblSolucionRaiz_Secante.Text = $"{Math.Round(resultado.RaizEncontrada, 4)}";
                lblMensaje_Secante.Text = $"{resultado.Mensaje}";

                if (resultado.IteracionesRealizadas >= int.Parse(tbxMaxIteraciones.Text) || lblMensaje_Secante.Text != "")
                {
                    lblConverge_Secante.Text = "NO";
                }
                else
                {
                    lblConverge_Secante.Text = "SI";
                }
            }
        }

        private void tabMetodos_Click(object sender, EventArgs e)
        {
            if(tabMetodos.SelectedTab.Name=="tabNewtonRaphson" || tabMetodos.SelectedTab.Name == "tabSecante")
            {
                lblLI.Visible = false;
                lblLD.Visible = false;
                tbxLI.Visible = false;
                tbxLD.Visible = false;
                lblPuntoInicial.Visible = true;
                tbxPuntoInicial.Visible = true;
                if (tabMetodos.SelectedTab.Name == "tabSecante")
                {
                    lblX2.Visible = true;
                    tbxX2.Visible = true;
                }
                else
                {
                    lblX2.Visible = false;
                    tbxX2.Visible = false;
                }
            }
            else
            {
                lblLI.Visible = true;
                lblLD.Visible = true;
                tbxLI.Visible = true;
                tbxLD.Visible = true;
                lblPuntoInicial.Visible = false;
                tbxPuntoInicial.Visible = false;
                lblX2.Visible = false;
                tbxX2.Visible = false;
            }
        }
        
        //UNIDAD 2
        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            int dimension = int.Parse(tbxDimension.Text);
            int puntoX = 30;
            int puntoY = 30;
            panelMatriz.Controls.Clear();
            for (int i = 0; i < dimension + 1; i++)
            {
                for (int j = 0; j < dimension  ; j++)
                {
                    string nombre = "(" + j.ToString() + "," + i.ToString() + ")";
                    TextBox elemento = new TextBox();
                    elemento.Name = nombre;
                    elemento.Location = new Point(puntoX, puntoY);
                    elemento.Size = new Size(65, 55);
                    elemento.Font = new Font(elemento.Font.Name, 13, elemento.Font.Style, elemento.Font.Unit);
                    if (i==dimension)
                    {
                        elemento.BackColor = Color.LightSkyBlue;
                    }
                    panelMatriz.Controls.Add(elemento);
                    panelMatriz.Show();
                    puntoY += 35;
                }
                puntoX += 70;
                puntoY = 30;
            }
        }

        public double[,] GuardarMatriz(int dimension)
        {
            double[,] matriz = new double[dimension, dimension + 1];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension+1; j++)
                {

                    Control tbx= panelMatriz.Controls.Find("(" + i.ToString() + "," + j.ToString() + ")", true).First();
                    matriz[i, j] = double.Parse((tbx as TextBox).Text);
                }
            }
            return matriz;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dimension = int.Parse(tbxDimension.Text);
            double[,] matriz = GuardarMatriz(dimension);
            MessageBox.Show("Matriz cargada con exito");
            double[,] matrizresultado = new double[dimension,dimension+1];
            switch (cbxMetodo.SelectedIndex)
            {
                case 0:
                    matrizresultado = Logica2.MetodoGaussJordan(dimension, matriz);
                    for (int i = 0; i < dimension; i++)
                    {
                        for (int j = 0; j < dimension + 1; j++)
                        {
                            Control tbx = panelMatriz.Controls.Find("(" + i.ToString() + "," + j.ToString() + ")", true).First();
                            tbx.Text = matrizresultado[i, j].ToString();
                        }
                    }
                    break;
                case 1:
                    matrizresultado = Logica2.MetodoGaussSeidel();
                    break;
            }
            
        }

        
    }
}
