namespace BuildGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudStep = new System.Windows.Forms.NumericUpDown();
            this.nudQ = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.rbShX = new System.Windows.Forms.RadioButton();
            this.rbSqrX = new System.Windows.Forms.RadioButton();
            this.rbExpX = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(13, 73);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(908, 500);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xmin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xmax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Шаг";
            // 
            // nudMin
            // 
            this.nudMin.DecimalPlaces = 1;
            this.nudMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMin.Location = new System.Drawing.Point(13, 32);
            this.nudMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(82, 23);
            this.nudMin.TabIndex = 2;
            this.nudMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            // 
            // nudMax
            // 
            this.nudMax.DecimalPlaces = 1;
            this.nudMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMax.Location = new System.Drawing.Point(128, 32);
            this.nudMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(82, 23);
            this.nudMax.TabIndex = 2;
            this.nudMax.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudStep
            // 
            this.nudStep.DecimalPlaces = 1;
            this.nudStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStep.Location = new System.Drawing.Point(242, 32);
            this.nudStep.Name = "nudStep";
            this.nudStep.Size = new System.Drawing.Size(82, 23);
            this.nudStep.TabIndex = 2;
            this.nudStep.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudQ
            // 
            this.nudQ.DecimalPlaces = 1;
            this.nudQ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudQ.Location = new System.Drawing.Point(344, 32);
            this.nudQ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudQ.Name = "nudQ";
            this.nudQ.Size = new System.Drawing.Size(82, 23);
            this.nudQ.TabIndex = 2;
            this.nudQ.Value = new decimal(new int[] {
            21,
            0,
            0,
            -2147418112});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "q";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(646, 30);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Расчет!";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // rbShX
            // 
            this.rbShX.AutoSize = true;
            this.rbShX.Checked = true;
            this.rbShX.Location = new System.Drawing.Point(455, 32);
            this.rbShX.Name = "rbShX";
            this.rbShX.Size = new System.Drawing.Size(51, 19);
            this.rbShX.TabIndex = 4;
            this.rbShX.TabStop = true;
            this.rbShX.Text = "sh(x)";
            this.rbShX.UseVisualStyleBackColor = true;
            // 
            // rbSqrX
            // 
            this.rbSqrX.AutoSize = true;
            this.rbSqrX.Location = new System.Drawing.Point(512, 32);
            this.rbSqrX.Name = "rbSqrX";
            this.rbSqrX.Size = new System.Drawing.Size(42, 19);
            this.rbSqrX.TabIndex = 4;
            this.rbSqrX.Text = "x*x";
            this.rbSqrX.UseVisualStyleBackColor = true;
            // 
            // rbExpX
            // 
            this.rbExpX.AutoSize = true;
            this.rbExpX.Location = new System.Drawing.Point(563, 32);
            this.rbExpX.Name = "rbExpX";
            this.rbExpX.Size = new System.Drawing.Size(58, 19);
            this.rbExpX.TabIndex = 4;
            this.rbExpX.Text = "exp(x)";
            this.rbExpX.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 585);
            this.Controls.Add(this.rbExpX);
            this.Controls.Add(this.rbSqrX);
            this.Controls.Add(this.rbShX);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.nudQ);
            this.Controls.Add(this.nudStep);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudStep;
        private System.Windows.Forms.NumericUpDown nudQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.RadioButton rbShX;
        private System.Windows.Forms.RadioButton rbSqrX;
        private System.Windows.Forms.RadioButton rbExpX;
    }
}

