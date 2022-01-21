namespace WinFormIOTProject
{
    partial class GraphData
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
            this.SoundChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SoundChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SoundChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SoundChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SoundChart.Legends.Add(legend1);
            this.SoundChart.Location = new System.Drawing.Point(42, 46);
            this.SoundChart.Name = "SoundChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SoundChart.Series.Add(series1);
            this.SoundChart.Size = new System.Drawing.Size(439, 249);
            this.SoundChart.TabIndex = 0;
            this.SoundChart.Text = "chart1";
            // 
            // GraphData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.SoundChart);
            this.Name = "GraphData";
            this.Text = "GraphData";
            this.Load += new System.EventHandler(this.GraphData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoundChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SoundChart;
    }
}