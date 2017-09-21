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
            this.textBoxTransmiter = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxReciver = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzestotliwosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.chart1.Size = new System.Drawing.Size(636, 547);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Location = new System.Drawing.Point(854, 92);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
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
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(1229, 717);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 945);
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
    }
}

