﻿namespace _64QAM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.checkBoxPoint = new System.Windows.Forms.CheckBox();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownpointAnimation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerek = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzestotliwosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpointAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(12, 92);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(713, 641);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Location = new System.Drawing.Point(931, 92);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(716, 641);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(190, 739);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(480, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(688, 739);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "0°";
            // 
            // checkBoxFaza
            // 
            this.checkBoxFaza.AutoSize = true;
            this.checkBoxFaza.Checked = true;
            this.checkBoxFaza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFaza.Location = new System.Drawing.Point(771, 154);
            this.checkBoxFaza.Name = "checkBoxFaza";
            this.checkBoxFaza.Size = new System.Drawing.Size(61, 21);
            this.checkBoxFaza.TabIndex = 5;
            this.checkBoxFaza.Text = "Faza";
            this.checkBoxFaza.UseVisualStyleBackColor = true;
            this.checkBoxFaza.Visible = false;
            // 
            // checkBoxCzestotliwosc
            // 
            this.checkBoxCzestotliwosc.AutoSize = true;
            this.checkBoxCzestotliwosc.Checked = true;
            this.checkBoxCzestotliwosc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCzestotliwosc.Location = new System.Drawing.Point(771, 194);
            this.checkBoxCzestotliwosc.Name = "checkBoxCzestotliwosc";
            this.checkBoxCzestotliwosc.Size = new System.Drawing.Size(114, 21);
            this.checkBoxCzestotliwosc.TabIndex = 6;
            this.checkBoxCzestotliwosc.Text = "Czestotliwosc";
            this.checkBoxCzestotliwosc.UseVisualStyleBackColor = true;
            this.checkBoxCzestotliwosc.Visible = false;
            // 
            // trackBarCzestotliwosc
            // 
            this.trackBarCzestotliwosc.Location = new System.Drawing.Point(1202, 739);
            this.trackBarCzestotliwosc.Maximum = 500;
            this.trackBarCzestotliwosc.Name = "trackBarCzestotliwosc";
            this.trackBarCzestotliwosc.Size = new System.Drawing.Size(381, 56);
            this.trackBarCzestotliwosc.TabIndex = 7;
            this.trackBarCzestotliwosc.ValueChanged += new System.EventHandler(this.trackBarCzestotliwosc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1589, 739);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "0Hz";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(758, 603);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 22);
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
            this.labelKonst_Pocz.Location = new System.Drawing.Point(12, 35);
            this.labelKonst_Pocz.Name = "labelKonst_Pocz";
            this.labelKonst_Pocz.Size = new System.Drawing.Size(396, 42);
            this.labelKonst_Pocz.TabIndex = 10;
            this.labelKonst_Pocz.Text = "SYGNAŁ NADAWANY";
            // 
            // label3KOnst_Wyjs
            // 
            this.label3KOnst_Wyjs.AutoSize = true;
            this.label3KOnst_Wyjs.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3KOnst_Wyjs.Location = new System.Drawing.Point(924, 35);
            this.label3KOnst_Wyjs.Name = "label3KOnst_Wyjs";
            this.label3KOnst_Wyjs.Size = new System.Drawing.Size(400, 42);
            this.label3KOnst_Wyjs.TabIndex = 11;
            this.label3KOnst_Wyjs.Text = "SYGNAŁ ODEBRANY ";
            // 
            // checkBoxPoint
            // 
            this.checkBoxPoint.AutoSize = true;
            this.checkBoxPoint.Location = new System.Drawing.Point(771, 241);
            this.checkBoxPoint.Name = "checkBoxPoint";
            this.checkBoxPoint.Size = new System.Drawing.Size(108, 21);
            this.checkBoxPoint.TabIndex = 15;
            this.checkBoxPoint.Text = "Jeden punkt";
            this.checkBoxPoint.UseVisualStyleBackColor = true;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX.Location = new System.Drawing.Point(785, 282);
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
            this.label3.Location = new System.Drawing.Point(754, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(753, 313);
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
            this.numericUpDownY.Location = new System.Drawing.Point(792, 322);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDownpointAnimation
            // 
            this.numericUpDownpointAnimation.Location = new System.Drawing.Point(759, 482);
            this.numericUpDownpointAnimation.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownpointAnimation.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownpointAnimation.Name = "numericUpDownpointAnimation";
            this.numericUpDownpointAnimation.Size = new System.Drawing.Size(126, 22);
            this.numericUpDownpointAnimation.TabIndex = 21;
            this.numericUpDownpointAnimation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTimer.Location = new System.Drawing.Point(759, 536);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(126, 22);
            this.numericUpDownTimer.TabIndex = 22;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTimer.ValueChanged += new System.EventHandler(this.numericUpDownTimer_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(731, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 56);
            this.button1.TabIndex = 23;
            this.button1.Text = "Animacja";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(755, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Liczba punktów:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(755, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Interwał timera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(853, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(755, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kwant czasu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 743);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Przesunięcie Fazy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(926, 743);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Przesunięcie Częstotliwości";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1676, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // timerek
            // 
            this.timerek.Interval = 700;
            this.timerek.Tick += new System.EventHandler(this.timerek_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1676, 843);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.numericUpDownpointAnimation);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.checkBoxPoint);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "64 QAM simulation program";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzestotliwosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpointAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownpointAnimation;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.Timer timerek;
        private System.Windows.Forms.Timer timer3;
    }
}

