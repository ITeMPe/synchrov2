using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace _64QAM
{
    public partial class Form1 : Form
    {
        private int ograniczenie = 0;
        private double lastChange = 0;
        private float procentSzerokosciOkna_ { get; set; } = 0.4f;
        public double ProcentSzerokosciOkna { get; private set; }
        List<MyComplex> ListaPunktowKonstekacji = new List<MyComplex>();
        List<MyComplex> ListaPunktowKonstekacji2 = new List<MyComplex>();
        List<Color> colorTab = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            ListaPunktowKonstekacji = StworzPunktyKonstelacji();
            WstawKonstelacje(chart1, ListaPunktowKonstekacji);   
            SetupChart(chart1);
            SetupChart(chart2);
            InitializeColorTab();

        }

        private void InitializeColorTab()
        {
            for(int i = 0; i <=64; i ++)
            {

            }
        }

        public void SetupChart(Chart chart)
        {
            #region Grid
            chart.ChartAreas[0].AxisX.Maximum = 11;
            chart.ChartAreas[0].AxisX.Minimum = -11;
            chart.ChartAreas[0].AxisY.Maximum = 11;
            chart.ChartAreas[0].AxisY.Minimum = -11;

            chart.ChartAreas[0].AxisX.Interval = 2;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;

            chart.ChartAreas[0].AxisY.Interval = 2;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Black;
            #endregion

            #region Dodanie_Poczatku_Ukladow_wspolrzednych
            StripLine striplineY = new StripLine();
            striplineY.Interval = 0;
            striplineY.IntervalOffset = -0.05;
            striplineY.StripWidth = 0.1;
            striplineY.BackColor = Color.Black;
            chart.ChartAreas[0].AxisY.StripLines.Add(striplineY);
            StripLine striplineX = new StripLine();
            striplineX.Interval = 0;
            striplineX.IntervalOffset = -0.05;
            striplineX.StripWidth = 0.1;
            striplineX.BackColor = Color.Black;
            chart.ChartAreas[0].AxisX.StripLines.Add(striplineX);
            #endregion
        }

        public List<MyComplex> StworzPunktyKonstelacji()
        {
            var list = new List<MyComplex>();
            for (int i = -7; i <= 7; i = i + 2)
            {
                for (int j = -7; j <= 7; j = j + 2)
                {
                    list.Add(new MyComplex(i, j));
                }
            }
            return list;
        }

        public void WstawKonstelacje(Chart chart, List<MyComplex> konstelacja)
        {
            chart.Series.Clear();
            var constelationSeries = new Series()
            {
                ChartType = SeriesChartType.Point,
                MarkerSize = 7,
                MarkerStyle = MarkerStyle.Circle
            };

            foreach (var s in konstelacja)
            {
                constelationSeries.Points.AddXY(s.Real, s.Imagine);
            }
            chart.Series.Add(constelationSeries);
         
        }

        public void dodajKonstelacje(Chart chart, List<MyComplex> konstelacja)
        {
            if (ograniczenie++ > 5)
            {
                chart.Series.Clear();
                ograniczenie = 0;
            }
            var constelationSeries = new Series()
            {
                ChartType = SeriesChartType.Point,
                MarkerSize = 7,
                MarkerStyle = MarkerStyle.Circle,
                MarkerColor = Color.Black 
            };

            foreach (var s in konstelacja)
            {
                constelationSeries.Points.AddXY(s.Real, s.Imagine);
            }
            chart.Series.Add(constelationSeries);
        }


        public void ZmienKolor(Chart chart, double x, double y, Color color)
        {
            var foo = chart.Series.Select(s => s.Points.Where(r => r.XValue == x && r.YValues[0] == y).FirstOrDefault()).FirstOrDefault();
            foo.Color = color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + "°";
            double phase = trackBar1.Value * Math.PI / 180;
            if (checkBoxFaza.Checked)
            {
                wplywFazyNaKOnstelacje(phase);
            }
        }

        private void wplywFazyNaKOnstelacje(double phase)
        {
            List<MyComplex> result = new List<MyComplex>();


            if (lastChange < phase)
            {

                foreach (var s in ListaPunktowKonstekacji)
                {
                    result.Add(new MyComplex
                    {
                        Imagine = s.Imagine,
                        Real = s.Real,
                        Phase = s.Phase + phase
                    }
                   );

                }
            }
            else
            {
                foreach (var s in ListaPunktowKonstekacji)
                {
                    result.Add(new MyComplex
                    {
                        Imagine = s.Imagine,
                        Real = s.Real,
                        Phase = s.Phase - phase
                    }
                   );

                }
            }
            WstawKonstelacje(chart2, result);
            lastChange = phase;
        }

        private void trackBarCzestotliwosc_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBarCzestotliwosc.Value.ToString() + "Hz";
            
            List<MyComplex> result = new List<MyComplex>();
            for (double t = 0; t < (double)numericUpDown1.Value*5; t += (double)numericUpDown1.Value)
            {



                foreach (var s in ListaPunktowKonstekacji)
                {
                    result.Add(new MyComplex
                    {
                        Imagine = s.Imagine,
                        Real = s.Real,
                        Phase = s.Phase + trackBarCzestotliwosc.Value * t
                    }
                   );
                   
                }
                    dodajKonstelacje(chart2, result);
            }
           
        }
    }
}
