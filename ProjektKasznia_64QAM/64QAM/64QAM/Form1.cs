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
        double timeGlobal = 0;
        private double lastChange = 0;
        private float procentSzerokosciOkna_ { get; set; } = 0.4f;
        public double ProcentSzerokosciOkna { get; private set; }
        //POtrzebne do jednego punktu i animacji 
        List<MyComplex> OrginalnaKonstelacja = new List<MyComplex>();
        List<MyComplex> ListaPunktowKonstekacji = new List<MyComplex>();  //konstelacja uzywana do operacji 
        List<List<MyComplex>> resultListmore = new List<List<MyComplex>>();
        Random random = new Random();
        //koneic tego co powyzej
        List<MyComplex> ListaPunktowKonstekacji2 = new List<MyComplex>();
        List<Color> listColor = new List<Color>();
        #region punkty_konstelacji
        List<byte> ConstelationPoints = new List<byte>() {
            0x00,0x08,0x18,0x10,0x30,0x38,0x28,0x20,
            0x01,0x09,0x19,0x11,0x31,0x39,0x29,0x21,
            0x03,0x0b,0x1b,0x13,0x33,0x3b,0x2b,0x23,
            0x02,0x0a,0x1a,0x12,0x32,0x3a,0x2a,0x22,
            0x06,0x0e,0x1e,0x16,0x36,0x3e,0x2e,0x26,
            0x07,0x0f,0x1f,0x17,0x37,0x3f,0x2f,0x27,
            0x05,0x0d,0x1d,0x15,0x35,0x3d,0x2d,0x25,
            0x04,0x0c,0x1c,0x14,0x34,0x3c,0x2c,0x24
        };
        #endregion

        public Form1()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeColorTab();
            OrginalnaKonstelacja = StworzPunktyKonstelacji();
            ListaPunktowKonstekacji = OrginalnaKonstelacja;
            
            SetupChart(chart1);
            SetupChart(chart2);

        }

        private void InitializeColorTab()
        {
            int r = 0, g = 0, b = 0;
            for (int i = 0; i <= 64; i++)
            {
                switch (i % 3)
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
                var c = Color.FromArgb(180, 10 + r, 10 + g, 10 + b);
                listColor.Add(c);
            }
        }

        public void SetupChart(Chart chart)
        {
            #region Grid
            chart.ChartAreas[0].AxisX.Maximum = 12;
            chart.ChartAreas[0].AxisX.Minimum = -12;
            chart.ChartAreas[0].AxisY.Maximum = 12;
            chart.ChartAreas[0].AxisY.Minimum = -12;

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
            int k = 0;
            var list = new List<MyComplex>();
            for (int i = -7; i <= 7; i = i + 2)
            {
                for (int j = -7; j <= 7; j = j + 2)
                {
                    list.Add(new MyComplex(i, j, ConstelationPoints[k]));
                    k++;
                }
            }
            return list;
        }

        public void WstawKonstelacje(Chart chart, List<MyComplex> konstelacja)
        {
           // chart.Series.Clear();
            var constelationSeries = new Series()
            {
                ChartType = SeriesChartType.Point,
                MarkerSize = 10,
                MarkerStyle = MarkerStyle.Circle,
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
                MarkerSize = 20,
                MarkerStyle = MarkerStyle.Circle,
                MarkerBorderWidth = 1,
                MarkerColor = Color.Red
            };
            int i = 0;
            foreach (var s in konstelacja)
            {
                constelationSeries.Points.AddXY(s.Real, s.Imagine);
                if (i < 64) constelationSeries.Points[i].MarkerColor = listColor[i];
                i++;
            }
            constelationSeries.Points.First().MarkerColor = Color.Red;
            chart.Series.Add(constelationSeries);
        }


        public void ZmienKolor(Chart chart, double x, double y, Color color)
        {
            //var foo = chart.Series[0].Points.Where(r => r.XValue == x && r.YValues[0] == y).FirstOrDefault();
            //foo.Color = color;
        }

        public void ZmienKolor(Chart chart, int index, Color color)
        {
            //foreach (var s in chart.Series)
            //{
            //    s.Points[index].Color = color;
            //}
        }

        public void ZmienKolor(Chart chart)
        {
            //foreach (var s in chart.Series)
            //{
            //    int i = 0;
            //    foreach (var r in s.Points)
            //    {
            //        if (i > 64) i = 0;
            //        r.Color = listColor[i];
            //        i++;
            //    }

            //}
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            label1.Text = trackBar1.Value.ToString() + "°";
            //double phase = trackBar1.Value * Math.PI / 180;
            //if (checkBoxFaza.Checked && checkBoxCzestotliwosc.Checked == false)
            //{
            //    wplywFazyNaKOnstelacje(phase);
            //}
            //wplywFazyNaKOnstelacje_Faza_and_Czestot();
        }

        private void wplywFazyNaKOnstelacje(double phase)
        {

            //List<MyComplex> result = new List<MyComplex>();


            //if (lastChange < phase)
            //{

            //    foreach (var s in ListaPunktowKonstekacji)
            //    {

            //        result.Add(new MyComplex
            //        {
            //            Imagine = s.Imagine,
            //            Real = s.Real,
            //            Phase = s.Phase + phase
            //        });
            //    }



            //}

            //else
            //{
            //    foreach (var s in ListaPunktowKonstekacji)
            //    {
            //        result.Add(new MyComplex
            //        {
            //            Imagine = s.Imagine,
            //            Real = s.Real,
            //            Phase = s.Phase - phase
            //        }
            //       );

            //    }
            //}
            //WstawKonstelacje(chart2, result);
            //ZmienKolor(chart2);
            //lastChange = phase;
        }

        private void wplywFazyNaKOnstelacje_Faza_and_Czestot()
        {
            licznik = 0;
            if (checkBoxCzestotliwosc.Checked && checkBoxFaza.Checked)
            {
                resultListmore = new List<List<MyComplex>>();

                List<MyComplex> result = new List<MyComplex>();
                if (lastChange < trackBar1.Value * Math.PI / 180)
                {

                    foreach (var s in ListaPunktowKonstekacji)
                    {
                        result.Add(new MyComplex
                        {
                            Imagine = s.Imagine,
                            Real = s.Real,
                            Phase = s.Phase + trackBar1.Value * Math.PI / 180 + trackBarCzestotliwosc.Value * timeGlobal
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
                            Phase = s.Phase - trackBar1.Value * Math.PI / 180 + trackBarCzestotliwosc.Value * timeGlobal
                        }
                       );   
                    }

                }              
                dodajKonstelacje(chart2, result);
            }

            timeGlobal += (double)numericUpDown1.Value / 100;
            lastChange = trackBar1.Value * Math.PI / 180;
        }

        private void trackBarCzestotliwosc_ValueChanged(object sender, EventArgs e)
        {
            //licznik = 0;
            label2.Text = trackBarCzestotliwosc.Value.ToString() + "Hz";
            //chart2.Series.Clear();
            //if (checkBoxCzestotliwosc.Checked && checkBoxFaza.Checked)
            //{
            //    wplywFazyNaKOnstelacje_Faza_and_Czestot();
            //    return;
            //}

            //if (checkBoxCzestotliwosc.Checked && checkBoxFaza.Checked == false)
            //{
            //    for (double t = 0; t <= (double)numericUpDown1.Value * (double)numericUpDownpointAnimation.Value / 100; t += (double)numericUpDown1.Value / 100)
            //    {
            //        List<MyComplex> result = new List<MyComplex>();
            //        foreach (var s in ListaPunktowKonstekacji)
            //        {
            //            result.Add(new MyComplex
            //            {
            //                Imagine = s.Imagine,
            //                Real = s.Real,
            //                Phase = s.Phase + trackBarCzestotliwosc.Value * t
            //            }
            //           );

            //        }
            //        dodajKonstelacje(chart2, result);
            //    }
            //}

        }


        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            ListaPunktowKonstekacji = StworzPunktyKonstelacji();
           // WstawKonstelacje(chart1, ListaPunktowKonstekacji);
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 4 &&
                            Math.Abs(pos.Y - pointYPixel) < 4)
                        {
                            numericUpDownX.Value = (decimal)prop.XValue;
                            numericUpDownY.Value = (decimal)prop.YValues[0];
                            licznik = 0;

                        }
                    }
                }
            }
          //  checkBoxPoint_CheckedChanged(null, null);
            trackBarCzestotliwosc_ValueChanged(null, null);


        }
        Color OldColorMarker;

      
        int licznik = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {     
            var punkt = OrginalnaKonstelacja[random.Next(0, 63)];
            dodajKonstelacje(chart1, new List<MyComplex> { new MyComplex(punkt.Real,punkt.Imagine,0x00)});
            numericUpDownX.Value = (decimal)punkt.Real;
            numericUpDownY.Value = (decimal)punkt.Imagine;
            ListaPunktowKonstekacji = new List<MyComplex>() { new MyComplex(punkt.Real, punkt.Imagine, 0x00) };
          
            timer1.Enabled = false;
            timerek.Enabled = true;
            //foo.MarkerSize = 20;
            //var R = foo.MarkerColor.R + 10;
            //var G = foo.MarkerColor.G + 10;
            //var B = foo.MarkerColor.B + 10;
            //if (R > 255) R = OldColorMarker.R;
            //if (G > 255) G = OldColorMarker.G;
            //if (B > 255) B = OldColorMarker.B;
            //foo.MarkerColor = Color.FromArgb(255, R, G, B);


        }

        private void numericUpDownX_Click(object sender, EventArgs e)
        {
            licznik = 0;
            //checkBoxPoint_CheckedChanged(null, null);
            trackBarCzestotliwosc_ValueChanged(null, null);
            ListaPunktowKonstekacji = StworzPunktyKonstelacji();
           // WstawKonstelacje(chart1, ListaPunktowKonstekacji);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        bool flagAnimation = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //if (flagAnimation == false)
            //{
            //    flagAnimation = true;
            //    button1.BackColor = Color.Red;
            //    timer2.Enabled = true;
            //    wplywFazyNaKOnstelacje_Faza_and_Czestot();
            //}
            //else
            //{

            //    flagAnimation = false;
            //    button1.BackColor = Color.LawnGreen;
            //    timer2.Enabled = false;
            //}
        }

        private void numericUpDownTimer_ValueChanged(object sender, EventArgs e)
        {
           // timer2.Interval = (int)numericUpDownTimer.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void timerek_Tick(object sender, EventArgs e)
        {
            wplywFazyNaKOnstelacje_Faza_and_Czestot();    
            timerek.Enabled = false; timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            chart1.Series.Last().Points.First().MarkerColor = Color.Blue;
            chart1.Series.Last().MarkerSize = 10;
            chart2.Series.Last().Points.First().MarkerColor = Color.Blue;
            chart2.Series.Last().MarkerSize = 10;
            timer3.Enabled = false;
            timer1.Enabled = true;
        }
    }
}
