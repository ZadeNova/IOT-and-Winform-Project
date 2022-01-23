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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SoundChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Filterby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoundChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SoundChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SoundChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SoundChart.Legends.Add(legend2);
            this.SoundChart.Location = new System.Drawing.Point(42, 46);
            this.SoundChart.Name = "SoundChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SoundChart.Series.Add(series2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter by";
            // 
            // GraphData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filterby);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.SoundChart);
            this.Name = "GraphData";
            this.Text = "GraphData";
            this.Load += new System.EventHandler(this.GraphData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoundChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SoundChart;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.ComboBox Filterby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}