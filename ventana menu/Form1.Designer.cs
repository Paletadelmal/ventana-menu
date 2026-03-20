namespace ventana_menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureBox1 = new PictureBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 453);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(169, 64);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(290, 125);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 39);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 6;
            label1.Text = "ventas por mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(493, 39);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 7;
            label2.Text = "Próximos partidos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.5897446F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.4102554F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Location = new Point(493, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.8F));
            tableLayoutPanel1.Size = new Size(280, 125);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(494, 300);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 9;
            label3.Text = "Boletos vendidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(494, 246);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 10;
            label4.Text = "Clientes activos";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(494, 356);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 11;
            label5.Text = "Ingresos totales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(169, 246);
            label6.Name = "label6";
            label6.Size = new Size(114, 22);
            label6.TabIndex = 12;
            label6.Text = "Ventas recientes";
            label6.Click += label6_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.3103447F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.6896553F));
            tableLayoutPanel2.Location = new Point(169, 281);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(290, 51);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 76);
            label8.Name = "label8";
            label8.Size = new Size(68, 23);
            label8.TabIndex = 14;
            label8.Text = "Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 113);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 15;
            label7.Text = "Clientes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 153);
            label9.Name = "label9";
            label9.Size = new Size(74, 23);
            label9.TabIndex = 16;
            label9.Text = "Estadios";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(33, 194);
            label10.Name = "label10";
            label10.Size = new Size(72, 23);
            label10.TabIndex = 17;
            label10.Text = "Partidos";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(33, 235);
            label11.Name = "label11";
            label11.Size = new Size(61, 23);
            label11.TabIndex = 18;
            label11.Text = "Ventas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 309);
            label12.Name = "label12";
            label12.Size = new Size(116, 23);
            label12.TabIndex = 19;
            label12.Text = "Facturaciones";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 271);
            label13.Name = "label13";
            label13.Size = new Size(117, 23);
            label13.TabIndex = 20;
            label13.Text = "Cancelaciones";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(26, 341);
            label14.Name = "label14";
            label14.Size = new Size(77, 23);
            label14.TabIndex = 21;
            label14.Text = "Reportes";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaption;
            label15.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(12, 374);
            label15.Name = "label15";
            label15.Size = new Size(112, 23);
            label15.TabIndex = 22;
            label15.Text = "Cerrar sesión";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(153, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 182);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(480, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 182);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(153, 235);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 182);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(480, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(316, 182);
            panel4.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Location = new Point(25, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(100, 28);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Location = new Point(27, 90);
            panel6.Name = "panel6";
            panel6.Size = new Size(100, 28);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gainsboro;
            panel7.Location = new Point(27, 144);
            panel7.Name = "panel7";
            panel7.Size = new Size(100, 28);
            panel7.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(808, 450);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chart1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}
