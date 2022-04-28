using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadradoMagico_CSharp
{
    public partial class CuadradoMagico_Form : Form
    {
        public CuadradoMagico_Form()
        {
            InitializeComponent();
            matriz_textbox = new TextBox[15, 15];
            fuente = new Font("Arial", 11);
            punto = new Point(0, 0);
            tamaño = new Size(40, 40);
            matriz = new int[15, 15];
            btnResolver.Enabled = false;
            btnVerificar.Enabled = false;

        }

        private int[,] matriz;
        private TextBox[,] matriz_textbox;
        private int n;
        private Point punto;
        private Font fuente;
        private TextBox txt;
        private Size tamaño;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnResolver.Enabled = true;
            tmrLlenar.Enabled = false; 
            btnVerificar.Enabled = true;
            if (Convert.ToInt32(txtN.Text) > 0 && Convert.ToInt32(txtN.Text) <= 15 && Convert.ToInt32(txtN.Text) % 2 != 0)
            {
                Eliminar(n);
                CrearTextBox();
            }
            else
            {
                if (Convert.ToInt32(txtN.Text) > 15 || Convert.ToInt32(txtN.Text) <= 0)
                {
                    MessageBox.Show("El tamaño minimo 1 y máximo 15");
                }
                if (Convert.ToInt32(txtN.Text) % 2 == 0)
                {
                    MessageBox.Show("Debe colocar un número impar");
                }

            }

        }
        /// <summary>
        /// Crear TextBox en tiempo de ejecucion
        /// </summary>
        private void CrearTextBox()
        {
            n = Convert.ToInt32(txtN.Text);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    txt = new TextBox();
                    txt.Size = tamaño;
                    txt.Font = fuente;
                    txt.Location = punto;
                    this.matriz_textbox[i, j] = txt;
                    this.matriz_textbox[i, j].Name = "txt" + (i + 1) + (j + 1);
                    this.panel1.Controls.Add(matriz_textbox[i, j]);
                    punto.X += 45;
                }
                punto.X = 0;
                punto.Y += 30;
            }
            punto.Y = 0;

        }

        /// <summary>
        /// Elimana todos los TextBox creados en tiempo de ejecución
        /// </summary>
        /// <param name="n"></param>
        private void Eliminar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    panel1.Controls.Remove(matriz_textbox[i, j]);

                }

            }
            GC.Collect();
        }


        /// <summary>
        /// Boton resolver el cuadrado mediante el algoritmo insertado en el timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResolver_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = 0;
                    matriz_textbox[i, j].Text = "";
                }
            }

            paso = false;
            if (trkbrIntervalo.Value == 10)
            {
                tmrLlenar.Interval = 10;
            }

            if (trkbrIntervalo.Value == 9)
            {
                tmrLlenar.Interval = 100;
            }

            if (trkbrIntervalo.Value == 8)
            {
                tmrLlenar.Interval = 250;
            }

            if (trkbrIntervalo.Value == 7)
            {
                tmrLlenar.Interval = 500;
            }

            if (trkbrIntervalo.Value == 6)
            {
                tmrLlenar.Interval = 600;
            }

            if (trkbrIntervalo.Value == 5)
            {
                tmrLlenar.Interval = 750;
            }

            if (trkbrIntervalo.Value == 4)
            {
                tmrLlenar.Interval = 850;
            }

            if (trkbrIntervalo.Value == 3)
            {
                tmrLlenar.Interval = 1000;
            }

            if (trkbrIntervalo.Value == 2)
            {
                tmrLlenar.Interval = 1500;
            }

            if (trkbrIntervalo.Value == 1)
            {
                tmrLlenar.Interval = 2000;
            }

            tmrLlenar.Enabled = true;
        }


        private int numero;
        private bool paso;
        private int InicioFila;
        private int InicioColumna;

        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrLlenar_Tick(object sender, EventArgs e)
        {
            btnResolver.Enabled = false;
            btnVerificar.Enabled = false;
            if (!paso)
            {
                InicioColumna = n / 2;
                InicioFila = 0;
                numero = 1;
                paso = true;
            }

            if (matriz[InicioFila, InicioColumna] != 0)
            {
                InicioFila += 2;
                InicioColumna--;
                if (InicioFila == n)
                {
                    InicioFila = 0;
                }
                if (InicioFila == n + 1)
                {
                    InicioFila = 1;
                }
                if (InicioColumna == -1)
                {
                    InicioColumna = n - 1;
                }
            }

            matriz[InicioFila, InicioColumna] = numero++;
            matriz_textbox[InicioFila, InicioColumna].Text = "" + matriz[InicioFila, InicioColumna];

            InicioFila--;
            if (InicioFila == -1)
            {
                InicioFila = n - 1;
            }
            if (InicioColumna == n - 1)
            {
                InicioColumna = -1;
            }
            InicioColumna++;


            if (numero == (n * n) + 1)
            {
                btnResolver.Enabled = true;
                btnVerificar.Enabled = true;
                tmrLlenar.Enabled = false;
                paso = false;
            }

        }

        /// <summary>
        /// Sumatoria para verificar las filas, columnas, diagnales;
        /// </summary>
        /// <returns></returns>
        private int Sumatoria()
        {
            return ((n * n) * ((n * n) + 1)) / (2 * n);

        }

        /// <summary>
        /// Verificar si el cuadrado mágico está correcto
        /// </summary>
        /// <returns></returns>
        private Boolean VerificarCuadrado()
        {
            int sumatoria = Sumatoria();
            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz_textbox[i, j].Text.Length != 0)
                    {
                        suma += Convert.ToInt32(matriz_textbox[i, j].Text);
                    }
                    else return false;

                }
                if (suma != sumatoria)
                {
                    return false;
                }
                suma = 0;
                for (int j = 0; j < n; j++)
                {
                    if (matriz_textbox[i, j].Text.Length != 0)
                    {
                        suma += Convert.ToInt32(matriz_textbox[i, j].Text);
                    }else
                    return false;
                }
                if (suma != sumatoria)
                {
                    return false;
                }

                suma = 0;
            }


            for (int i = 0; i < n; i++)
            {
                if ((suma != sumatoria && i == n) || matriz_textbox[i, i].Text.Length == 0)
                {
                    return false;
                }

                suma += Convert.ToInt32(matriz_textbox[i, i].Text);
            }

            return true;
        }

        /// <summary>
        /// Boton verificar, muestra un Cuadro de Dialogo dependiendo del metodo VerificarCuadrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (VerificarCuadrado())
            {
                MessageBox.Show("Buen trabajo");
            }else MessageBox.Show("Lo siento, siga intentando");
        }
    }
}
