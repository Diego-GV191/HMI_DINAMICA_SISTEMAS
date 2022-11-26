namespace DINAMICA_SISTEMAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnConexion = new System.Windows.Forms.Button();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 189);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Value";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(723, 205);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.Location = new System.Drawing.Point(12, 45);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(113, 26);
            this.lblBaudRate.TabIndex = 1;
            this.lblBaudRate.Text = "BaudRate:";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPort
            // 
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(12, 94);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(113, 24);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "PORT:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(131, 43);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 32);
            this.cmbBaudRate.TabIndex = 2;
            this.cmbBaudRate.Text = "9600";
            // 
            // cmbPort
            // 
            this.cmbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(131, 91);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 32);
            this.cmbPort.TabIndex = 2;
            // 
            // btnConexion
            // 
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.Location = new System.Drawing.Point(267, 43);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(136, 32);
            this.btnConexion.TabIndex = 3;
            this.btnConexion.Text = "Escanear";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexion.Location = new System.Drawing.Point(267, 91);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(136, 24);
            this.lblEstadoConexion.TabIndex = 1;
            this.lblEstadoConexion.Text = "OFFLINE";
            this.lblEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.lblEstadoConexion);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Dinamica de Sistemas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label lblEstadoConexion;
    }
}

