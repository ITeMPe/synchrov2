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
       
        private double lastChange = 0;
        private float procentSzerokosciOkna_ { get; set; } = 0.4f;
        public double ProcentSzerokosciOkna { get; private set; }
        List<MyComplex> ListaPunktowKonstekacji = new List<MyComplex>();
        List<MyComplex> ListaPunktowKonstekacji2 = new List<MyComplex>();
        List<Color> listColor = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            InitializeColorTab();
            ListaPunktowKonstekacji = StworzPunktyKonstelacji();
            WstawKonstelacje(chart1, ListaPunktowKonstekacji);   
            SetupChart(chart1);
            SetupChart(chart2);

        }

        private void InitializeColorTab()
        {
            int r=0, g=0, b=0;
            for(int i = 0; i <=64; i ++)
            {
                switch (i%3)
                {
                    case 0:
                        r += 21;
                        g += 39;
                        break;
                    case 1:
                        g += 39;
                        b += 124;
                        break;
                    case 2:
                        b += 87;
                        r += 39;
                        break;                            
                }
                        b = b % 245;
                        g = g % 245;
                        r = r % 245;
                var c = Color.FromArgb(180,10+r, 10+g, 10+b);
                listColor.Add(c);
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
                MarkerSize = 10,
                MarkerStyle = MarkerStyle.Circle ,
                MarkerBorderWidth = 2,
                MarkerBorderColor = Color.Black
            };
            int i = 0;
          
            foreach (var s in konstelacja)
            {
                constelationSeries.Points.AddXY(s.Real, s.Imagine);
                if (i < 64) constelationSeries.Points[i].MarkerColor = listColor[i];
                i++;
            }
            chart.Series.Add(constelationSeries);
            ZmienKolor(chart1);
        }

        public void dodajKonstelacje(Chart chart, List<MyComplex> konstelacja)
        {

            var constelationSeries = new Series()
            {
                ChartType = SeriesChartType.Point,
                MarkerSize = 10,
                MarkerStyle = MarkerStyle.Circle,
                MarkerBorderWidth = 1,
                MarkerBorderColor = Color.Black
            };
            int i = 0;
            foreach (var s in konstelacja)
            {
                constelationSeries.Points.AddXY(s.Real, s.Imagine);
                if (i < 64) constelationSeries.Points[i].MarkerColor = listColor[i];
                i++;
            }
            chart.Series.Add(constelationSeries);
          
        }


        public void ZmienKolor(Chart chart, double x, double y, Color color)
        {
            var foo = chart.Series[0].Points.Where(r => r.XValue == x && r.YValues[0] == y).FirstOrDefault();
            foo.Color = color;
        }

        public void ZmienKolor(Chart chart,int index, Color color)
        {          
            foreach(var s in chart.Series)
            {
                s.Points[index].Color = color;
            }                 
        }

        public void ZmienKolor(Chart chart)
        {
            foreach (var s in chart.Series)
            {
                int i = 0;
                foreach(var r in s.Points)
                {
                    if (i > 64) i = 0;
                r.Color = listColor[i];
                    i++;
                }

            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + "°";
            double phase = trackBar1.Value * Math.PI / 180;
            if (checkBoxFaza.Checked && checkBoxCzestotliwosc.Checked ==false)
            {
                wplywFazyNaKOnstelacje(phase);
            }
            wplywFazyNaKOnstelacje_Faza_and_Czestot();
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
            ZmienKolor(chart2);
            lastChange = phase;
        }

        private void wplywFazyNaKOnstelacje_Faza_and_Czestot()
        {
            if(checkBoxCzestotliwosc.Checked && checkBoxFaza.Checked)
            {
            chart2.Series.Clear();
            for (double t = 0; t < (double)numericUpDown1.Value * 5; t += (double)numericUpDown1.Value)
            {
            List<MyComplex> result = new List<MyComplex>();
            if (lastChange < trackBar1.Value * Math.PI / 180)
            {

                foreach (var s in ListaPunktowKonstekacji)
                {
                    result.Add(new MyComplex
                    {
                        Imagine = s.Imagine,
                        Real = s.Real,
                        Phase = s.Phase + trackBar1.Value * Math.PI / 180 + trackBarCzestotliwosc.Value * t
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
                        Phase = s.Phase - trackBar1.Value * Math.PI / 180 + trackBarCzestotliwosc.Value * t
                    }
                   );

                }
            dodajKonstelacje(chart2, result);
                      
            }
        }
        }
            lastChange = trackBar1.Value * Math.PI / 180;
        }

        private void trackBarCzestotliwosc_ValueChanged(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            if (checkBoxCzestotliwosc.Checked && checkBoxFaza.Checked)
            {
                wplywFazyNaKOnstelacje_Faza_and_Czestot();
                return;
            }
                label2.Text = trackBarCzestotliwosc.Value.ToString() + "Hz";
            if (checkBoxCzestotliwosc.Checked && checkBoxFaza.Checked ==false)
            {
            for (double t = 0; t <= (double)numericUpDown1.Value*5; t += (double)numericUpDown1.Value)
            {
            List<MyComplex> result = new List<MyComplex>();
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
}
