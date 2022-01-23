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
            this.FilterBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Filterby = new System.Windows.Forms.ComboBox();
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
            this.SoundChart.Click += new System.EventHandler(this.SoundChart_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(42, 414);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 23);
            this.FilterBtn.TabIndex = 1;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 23, 2, 11, 53, 0);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(281, 336);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDateTimePicker.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filterby
            // 
            this.Filterby.FormattingEnabled = true;
            this.Filterby.Items.AddRange(new object[] {
            "Seconds",
            "Minute",
            "Days",
            "Month",
            "Year"});
            this.Filterby.Location = new System.Drawing.Point(513, 336);
            this.Filterby.Name = "Filterby";
            this.Filterby.Size = new System.Drawing.Size(121, 21);
            this.Filterby.TabIndex = 5;
            // 
            // GraphData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.Filterby);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.SoundChart);
            this.Name = "GraphData";
            this.Text = "GraphData";
            this.Load += new System.EventHandler(this.GraphData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoundChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SoundChart;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Filterby;
    }
}