namespace _64QAM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFaza = new System.Windows.Forms.CheckBox();
            this.checkBoxCzestotliwosc = new System.Windows.Forms.CheckBox();
            this.trackBarCzestotliwosc = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelKonst_Pocz = new System.Windows.Forms.Label();
            this.label3KOnst_Wyjs = new System.Windows.Forms.Label();
            this.textBoxTransmiter = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxReciver = new System.Windows.Forms.TextBox();
            this.checkBoxPoint = new System.Windows.Forms.CheckBox();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzestotliwosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Location = new System.Drawing.Point(12, 92);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(636, 547);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.Location = new System.Drawing.Point(854, 92);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(620, 547);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(55, 648);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(464, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(513, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // checkBoxFaza
            // 
            this.checkBoxFaza.AutoSize = true;
            this.checkBoxFaza.Location = new System.Drawing.Point(694, 169);
            this.checkBoxFaza.Name = "checkBoxFaza";
            this.checkBoxFaza.Size = new System.Drawing.Size(61, 21);
            this.checkBoxFaza.TabIndex = 5;
            this.checkBoxFaza.Text = "Faza";
            this.checkBoxFaza.UseVisualStyleBackColor = true;
            // 
            // checkBoxCzestotliwosc
            // 
            this.checkBoxCzestotliwosc.AutoSize = true;
            this.checkBoxCzestotliwosc.Location = new System.Drawing.Point(694, 209);
            this.checkBoxCzestotliwosc.Name = "checkBoxCzestotliwosc";
            this.checkBoxCzestotliwosc.Size = new System.Drawing.Size(114, 21);
            this.checkBoxCzestotliwosc.TabIndex = 6;
            this.checkBoxCzestotliwosc.Text = "Czestotliwosc";
            this.checkBoxCzestotliwosc.UseVisualStyleBackColor = true;
            // 
            // trackBarCzestotliwosc
            // 
            this.trackBarCzestotliwosc.Location = new System.Drawing.Point(854, 648);
            this.trackBarCzestotliwosc.Maximum = 500;
            this.trackBarCzestotliwosc.Name = "trackBarCzestotliwosc";
            this.trackBarCzestotliwosc.Size = new System.Drawing.Size(464, 56);
            this.trackBarCzestotliwosc.TabIndex = 7;
            this.trackBarCzestotliwosc.ValueChanged += new System.EventHandler(this.trackBarCzestotliwosc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1324, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "x";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(1229, 717);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelKonst_Pocz
            // 
            this.labelKonst_Pocz.AutoSize = true;
            this.labelKonst_Pocz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKonst_Pocz.Location = new System.Drawing.Point(48, 35);
            this.labelKonst_Pocz.Name = "labelKonst_Pocz";
            this.labelKonst_Pocz.Size = new System.Drawing.Size(565, 42);
            this.labelKonst_Pocz.TabIndex = 10;
            this.labelKonst_Pocz.Text = "KONSTELACJA POCZĄTKOWA";
            // 
            // label3KOnst_Wyjs
            // 
            this.label3KOnst_Wyjs.AutoSize = true;
            this.label3KOnst_Wyjs.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3KOnst_Wyjs.Location = new System.Drawing.Point(899, 35);
            this.label3KOnst_Wyjs.Name = "label3KOnst_Wyjs";
            this.label3KOnst_Wyjs.Size = new System.Drawing.Size(538, 42);
            this.label3KOnst_Wyjs.TabIndex = 11;
            this.label3KOnst_Wyjs.Text = "KONSTELACJA WYJŚCIOWA ";
            // 
            // textBoxTransmiter
            // 
            this.textBoxTransmiter.Location = new System.Drawing.Point(55, 710);
            this.textBoxTransmiter.Multiline = true;
            this.textBoxTransmiter.Name = "textBoxTransmiter";
            this.textBoxTransmiter.Size = new System.Drawing.Size(335, 103);
            this.textBoxTransmiter.TabIndex = 12;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(407, 790);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxReciver
            // 
            this.textBoxReciver.Location = new System.Drawing.Point(55, 847);
            this.textBoxReciver.Multiline = true;
            this.textBoxReciver.Name = "textBoxReciver";
            this.textBoxReciver.Size = new System.Drawing.Size(335, 97);
            this.textBoxReciver.TabIndex = 14;
            // 
            // checkBoxPoint
            // 
            this.checkBoxPoint.AutoSize = true;
            this.checkBoxPoint.Location = new System.Drawing.Point(694, 256);
            this.checkBoxPoint.Name = "checkBoxPoint";
            this.checkBoxPoint.Size = new System.Drawing.Size(108, 21);
            this.checkBoxPoint.TabIndex = 15;
            this.checkBoxPoint.Text = "Jeden punkt";
            this.checkBoxPoint.UseVisualStyleBackColor = true;
            this.checkBoxPoint.CheckedChanged += new System.EventHandler(this.checkBoxPoint_CheckedChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX.Location = new System.Drawing.Point(708, 297);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownX.TabIndex = 17;
            this.numericUpDownX.Value = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Click += new System.EventHandler(this.numericUpDownX_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(677, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(676, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "y";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownY.Location = new System.Drawing.Point(708, 337);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownY.TabIndex = 20;
            this.numericUpDownY.Value = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownX_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 920);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1509, 25);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 20);
            this.toolStripStatusLabel1.Text = "cos";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 945);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.checkBoxPoint);
            this.Controls.Add(this.textBoxReciver);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxTransmiter);
            this.Controls.Add(this.label3KOnst_Wyjs);
            this.Controls.Add(this.labelKonst_Pocz);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarCzestotliwosc);
            this.Controls.Add(this.checkBoxCzestotliwosc);
            this.Controls.Add(this.checkBoxFaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzestotliwosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFaza;
        private System.Windows.Forms.CheckBox checkBoxCzestotliwosc;
        private System.Windows.Forms.TrackBar trackBarCzestotliwosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelKonst_Pocz;
        private System.Windows.Forms.Label label3KOnst_Wyjs;
        private System.Windows.Forms.TextBox textBoxTransmiter;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxReciver;
        private System.Windows.Forms.CheckBox checkBoxPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

