using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AForge.Video;
using AForge.Video.DirectShow;

namespace procesamiento_de_imagenes
{

    public partial class foto : Form
    {

        
        public foto()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice videoCaptureDevice = null;
        
        private void foto_Load(object sender, EventArgs e)
        {
            LoadImageAndPlotRGB(@"C:\Users\Elisa\Pictures\mano.jpeg");

            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterinfocollection)
            {
                comboBox2.Items.Add(filterinfo.Name);
            }
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }

           
        }

        private void LoadImageAndPlotRGB(string imagePath)
        {
            // Cargar imagen
            Bitmap bmp = new Bitmap(imagePath);

            // Inicializar series para los valores R, G, B
            Series redSeries = new Series("Red");
            Series greenSeries = new Series("Green");
            Series blueSeries = new Series("Blue");

            redSeries.ChartType = SeriesChartType.Line;
            greenSeries.ChartType = SeriesChartType.Line;
            blueSeries.ChartType = SeriesChartType.Line;

            // Establecer colores para cada serie
            redSeries.Color = Color.Red;    // Rojo para la serie R
            greenSeries.Color = Color.Green;  // Verde para la serie G
            blueSeries.Color = Color.Blue;   // Azul para la serie B

            // Crear arrays para acumular los valores
            int[] redValues = new int[256];
            int[] greenValues = new int[256];
            int[] blueValues = new int[256];

            // Recorrer cada píxel de la imagen
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    // Contar ocurrencias de cada valor RGB
                    redValues[pixelColor.R]++;
                    greenValues[pixelColor.G]++;
                    blueValues[pixelColor.B]++;
                }
            }

            // Añadir los datos a las series
            for (int i = 0; i < 256; i++)
            {
                redSeries.Points.AddXY(i, redValues[i]);
                greenSeries.Points.AddXY(i, greenValues[i]);
                blueSeries.Points.AddXY(i, blueValues[i]);
            }

            // Agregar las series al chart
            chart1.Series.Clear();

            chart1.Series.Add(redSeries);
            chart1.Series.Add(greenSeries);
            chart1.Series.Add(blueSeries);



            // Ajustar las propiedades del gráfico
            chart1.ChartAreas[0].AxisX.Title = "Valor RGB";
            chart1.ChartAreas[0].AxisY.Title = "Frecuencia";
            chart1.ChartAreas[0].RecalculateAxesScale();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            videoCaptureDevice = new VideoCaptureDevice(filterinfocollection[comboBox2.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

           
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new MethodInvoker(delegate
                {
                    pictureBox1.Image = frame;
                }));
            }
            else
            {
                pictureBox1.Image = frame;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
