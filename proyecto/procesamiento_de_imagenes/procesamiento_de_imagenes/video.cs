﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace procesamiento_de_imagenes
{
    public partial class video : Form
    {
        public video()
        {
            InitializeComponent();
        }

        private void video_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"C:\Users\USER\Pictures\roca.gif");
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //pictureBox2.Image = Image.FromFile(@"C:\Users\USER\Pictures\apoco.gif");
            //pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            //LoadImageAndPlotRGB(@"C:\Users\Elisa\Pictures\cargando.jpeg");
        }
        private void LoadImageAndPlotRGB(string imagePath)
        {
            //// Cargar imagen
            //Bitmap bmp = new Bitmap(imagePath);

            //// Inicializar series para los valores R, G, B
            //Series redSeries = new Series("Red");
            //Series greenSeries = new Series("Green");
            //Series blueSeries = new Series("Blue");

            //redSeries.ChartType = SeriesChartType.Line;
            //greenSeries.ChartType = SeriesChartType.Line;
            //blueSeries.ChartType = SeriesChartType.Line;

            //// Establecer colores para cada serie
            //redSeries.Color = Color.Red;    // Rojo para la serie R
            //greenSeries.Color = Color.Green;  // Verde para la serie G
            //blueSeries.Color = Color.Blue;   // Azul para la serie B

            //// Crear arrays para acumular los valores
            //int[] redValues = new int[256];
            //int[] greenValues = new int[256];
            //int[] blueValues = new int[256];

            //// Recorrer cada píxel de la imagen
            //for (int y = 0; y < bmp.Height; y++)
            //{
            //    for (int x = 0; x < bmp.Width; x++)
            //    {
            //        Color pixelColor = bmp.GetPixel(x, y);

            //        // Contar ocurrencias de cada valor RGB
            //        redValues[pixelColor.R]++;
            //        greenValues[pixelColor.G]++;
            //        blueValues[pixelColor.B]++;
            //    }
            //}

            //// Añadir los datos a las series
            //for (int i = 0; i < 256; i++)
            //{
            //    redSeries.Points.AddXY(i, redValues[i]);
            //    greenSeries.Points.AddXY(i, greenValues[i]);
            //    blueSeries.Points.AddXY(i, blueValues[i]);
            //}

            //// Agregar las series al chart
            //chart1.Series.Clear();
          
            //chart1.Series.Add(redSeries);
            //chart1.Series.Add(greenSeries);
            //chart1.Series.Add(blueSeries);



            //// Ajustar las propiedades del gráfico
            //chart1.ChartAreas[0].AxisX.Title = "Valor RGB";
            //chart1.ChartAreas[0].AxisY.Title = "Frecuencia";
            //chart1.ChartAreas[0].RecalculateAxesScale();
           
          
        }
    
    private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
