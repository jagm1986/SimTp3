namespace TP3_SIM
{
    partial class Histograma_Datos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_hist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listValores = new System.Windows.Forms.ListBox();
            this.listIntervalos = new System.Windows.Forms.ListBox();
            this.btn_SalirHist = new System.Windows.Forms.Button();
            this.lbl_Distrib_Hist = new System.Windows.Forms.Label();
            this.textBoxNuevoIntervalo = new System.Windows.Forms.TextBox();
            this.lblNuevoIntervalo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.labelResultadoChi = new System.Windows.Forms.Label();
            this.labelResChiTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_hist)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_hist
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 5;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisY.LabelStyle.Interval = 0D;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.Name = "ChartArea1";
            this.chart_hist.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_hist.Legends.Add(legend1);
            this.chart_hist.Location = new System.Drawing.Point(385, 40);
            this.chart_hist.Name = "chart_hist";
            this.chart_hist.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecuencia Observada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Frecuencia Esperada";
            this.chart_hist.Series.Add(series1);
            this.chart_hist.Series.Add(series2);
            this.chart_hist.Size = new System.Drawing.Size(700, 389);
            this.chart_hist.TabIndex = 0;
            this.chart_hist.Text = "grafico";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.BackColor = System.Drawing.Color.White;
            title1.BorderColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Hostograma";
            title1.Text = "Histograma";
            this.chart_hist.Titles.Add(title1);
            this.chart_hist.Click += new System.EventHandler(this.chart_hist_Click);
            // 
            // listValores
            // 
            this.listValores.FormattingEnabled = true;
            this.listValores.Location = new System.Drawing.Point(6, 37);
            this.listValores.Name = "listValores";
            this.listValores.Size = new System.Drawing.Size(93, 420);
            this.listValores.TabIndex = 1;
            // 
            // listIntervalos
            // 
            this.listIntervalos.FormattingEnabled = true;
            this.listIntervalos.Location = new System.Drawing.Point(105, 37);
            this.listIntervalos.Name = "listIntervalos";
            this.listIntervalos.Size = new System.Drawing.Size(274, 420);
            this.listIntervalos.TabIndex = 2;
            this.listIntervalos.SelectedIndexChanged += new System.EventHandler(this.listIntervalos_SelectedIndexChanged);
            // 
            // btn_SalirHist
            // 
            this.btn_SalirHist.Location = new System.Drawing.Point(967, 432);
            this.btn_SalirHist.Name = "btn_SalirHist";
            this.btn_SalirHist.Size = new System.Drawing.Size(75, 23);
            this.btn_SalirHist.TabIndex = 3;
            this.btn_SalirHist.Text = "Salir";
            this.btn_SalirHist.UseVisualStyleBackColor = true;
            this.btn_SalirHist.Click += new System.EventHandler(this.btn_SalirHist_Click);
            // 
            // lbl_Distrib_Hist
            // 
            this.lbl_Distrib_Hist.AutoSize = true;
            this.lbl_Distrib_Hist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distrib_Hist.Location = new System.Drawing.Point(13, 12);
            this.lbl_Distrib_Hist.Name = "lbl_Distrib_Hist";
            this.lbl_Distrib_Hist.Size = new System.Drawing.Size(119, 20);
            this.lbl_Distrib_Hist.TabIndex = 4;
            this.lbl_Distrib_Hist.Text = "Distribucion:  ";
            // 
            // textBoxNuevoIntervalo
            // 
            this.textBoxNuevoIntervalo.Location = new System.Drawing.Point(951, 208);
            this.textBoxNuevoIntervalo.Name = "textBoxNuevoIntervalo";
            this.textBoxNuevoIntervalo.Size = new System.Drawing.Size(110, 20);
            this.textBoxNuevoIntervalo.TabIndex = 5;
            this.textBoxNuevoIntervalo.Text = "10";
            this.textBoxNuevoIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNuevoIntervalo.TextChanged += new System.EventHandler(this.TextBoxNuevoIntervalo_TextChanged);
            // 
            // lblNuevoIntervalo
            // 
            this.lblNuevoIntervalo.AutoSize = true;
            this.lblNuevoIntervalo.Location = new System.Drawing.Point(948, 180);
            this.lblNuevoIntervalo.Name = "lblNuevoIntervalo";
            this.lblNuevoIntervalo.Size = new System.Drawing.Size(113, 13);
            this.lblNuevoIntervalo.TabIndex = 6;
            this.lblNuevoIntervalo.Text = "Cantidad de Intervalos";
            this.lblNuevoIntervalo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(967, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Location = new System.Drawing.Point(951, 278);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(123, 13);
            this.lblChiCuadrado.TabIndex = 8;
            this.lblChiCuadrado.Text = "Prueba de Chi Cuadrado";
            // 
            // labelResultadoChi
            // 
            this.labelResultadoChi.AutoSize = true;
            this.labelResultadoChi.Location = new System.Drawing.Point(949, 312);
            this.labelResultadoChi.Name = "labelResultadoChi";
            this.labelResultadoChi.Size = new System.Drawing.Size(122, 13);
            this.labelResultadoChi.TabIndex = 9;
            this.labelResultadoChi.Text = "Resultado Chi Cuadrado";
            // 
            // labelResChiTexto
            // 
            this.labelResChiTexto.AutoSize = true;
            this.labelResChiTexto.Location = new System.Drawing.Point(951, 352);
            this.labelResChiTexto.Name = "labelResChiTexto";
            this.labelResChiTexto.Size = new System.Drawing.Size(99, 13);
            this.labelResChiTexto.TabIndex = 10;
            this.labelResChiTexto.Text = "Hipotesis Aceptada";
            // 
            // Histograma_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 469);
            this.Controls.Add(this.labelResChiTexto);
            this.Controls.Add(this.labelResultadoChi);
            this.Controls.Add(this.lblChiCuadrado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNuevoIntervalo);
            this.Controls.Add(this.textBoxNuevoIntervalo);
            this.Controls.Add(this.lbl_Distrib_Hist);
            this.Controls.Add(this.btn_SalirHist);
            this.Controls.Add(this.listIntervalos);
            this.Controls.Add(this.listValores);
            this.Controls.Add(this.chart_hist);
            this.Name = "Histograma_Datos";
            this.Text = "Histograma_Datos";
            ((System.ComponentModel.ISupportInitialize)(this.chart_hist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_hist;
        private System.Windows.Forms.ListBox listValores;
        private System.Windows.Forms.ListBox listIntervalos;
        private System.Windows.Forms.Button btn_SalirHist;
        private System.Windows.Forms.Label lbl_Distrib_Hist;
        private System.Windows.Forms.TextBox textBoxNuevoIntervalo;
        private System.Windows.Forms.Label lblNuevoIntervalo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Label labelResultadoChi;
        private System.Windows.Forms.Label labelResChiTexto;
    }
}