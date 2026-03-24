namespace ventana_menu
{
    partial class FormPartidos
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
            panel1 = new Panel();
            cerrar = new Button();
            reportes = new Button();
            facturaciones = new Button();
            cancelaciones = new Button();
            ventas = new Button();
            partidos = new Button();
            estadios = new Button();
            clientes = new Button();
            menu = new Button();
            panel6 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btncrearnuevopartido = new Button();
            dgvPartidos = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            buscarpartido = new TextBox();
            vScrollBar1 = new VScrollBar();
            label3 = new Label();
            paneltotalpartidos = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            panelcancelado = new Panel();
            label8 = new Label();
            panelenproceso = new Panel();
            label7 = new Label();
            panelproximos = new Panel();
            label6 = new Label();
            panelfinalizados = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            paneltotalpartidos.SuspendLayout();
            panel7.SuspendLayout();
            panelcancelado.SuspendLayout();
            panelenproceso.SuspendLayout();
            panelproximos.SuspendLayout();
            panelfinalizados.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(cerrar);
            panel1.Controls.Add(reportes);
            panel1.Controls.Add(facturaciones);
            panel1.Controls.Add(cancelaciones);
            panel1.Controls.Add(ventas);
            panel1.Controls.Add(partidos);
            panel1.Controls.Add(estadios);
            panel1.Controls.Add(clientes);
            panel1.Controls.Add(menu);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 464);
            panel1.TabIndex = 1;
            // 
            // cerrar
            // 
            cerrar.BackColor = SystemColors.ActiveCaption;
            cerrar.Location = new Point(3, 370);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(184, 36);
            cerrar.TabIndex = 3;
            cerrar.Text = "Cerrar sesión";
            cerrar.UseVisualStyleBackColor = false;
            // 
            // reportes
            // 
            reportes.BackColor = SystemColors.ActiveCaption;
            reportes.Location = new Point(3, 328);
            reportes.Name = "reportes";
            reportes.Size = new Size(184, 36);
            reportes.TabIndex = 3;
            reportes.Text = "Reportes";
            reportes.UseVisualStyleBackColor = false;
            // 
            // facturaciones
            // 
            facturaciones.BackColor = SystemColors.ActiveCaption;
            facturaciones.Location = new Point(3, 286);
            facturaciones.Name = "facturaciones";
            facturaciones.Size = new Size(184, 36);
            facturaciones.TabIndex = 2;
            facturaciones.Text = "Facturaciones";
            facturaciones.UseVisualStyleBackColor = false;
            // 
            // cancelaciones
            // 
            cancelaciones.BackColor = SystemColors.ActiveCaption;
            cancelaciones.Location = new Point(3, 244);
            cancelaciones.Name = "cancelaciones";
            cancelaciones.Size = new Size(184, 36);
            cancelaciones.TabIndex = 1;
            cancelaciones.Text = "Cancelaciones";
            cancelaciones.UseVisualStyleBackColor = false;
            // 
            // ventas
            // 
            ventas.BackColor = SystemColors.ActiveCaption;
            ventas.Location = new Point(3, 202);
            ventas.Name = "ventas";
            ventas.Size = new Size(184, 36);
            ventas.TabIndex = 1;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = false;
            // 
            // partidos
            // 
            partidos.BackColor = SystemColors.ActiveCaption;
            partidos.Location = new Point(3, 160);
            partidos.Name = "partidos";
            partidos.Size = new Size(184, 36);
            partidos.TabIndex = 1;
            partidos.Text = "Partidos";
            partidos.UseVisualStyleBackColor = false;
            // 
            // estadios
            // 
            estadios.BackColor = SystemColors.ActiveCaption;
            estadios.Location = new Point(3, 118);
            estadios.Name = "estadios";
            estadios.Size = new Size(184, 36);
            estadios.TabIndex = 1;
            estadios.Text = "Estadios";
            estadios.UseVisualStyleBackColor = false;
            // 
            // clientes
            // 
            clientes.BackColor = SystemColors.ActiveCaption;
            clientes.Location = new Point(3, 76);
            clientes.Name = "clientes";
            clientes.Size = new Size(184, 36);
            clientes.TabIndex = 1;
            clientes.Text = "Clientes";
            clientes.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ActiveCaption;
            menu.Location = new Point(3, 34);
            menu.Name = "menu";
            menu.Size = new Size(184, 36);
            menu.TabIndex = 0;
            menu.Text = "Menu ";
            menu.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(btncrearnuevopartido);
            panel6.Controls.Add(dgvPartidos);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(comboBox2);
            panel6.Controls.Add(buscarpartido);
            panel6.Controls.Add(vScrollBar1);
            panel6.Location = new Point(207, 34);
            panel6.Name = "panel6";
            panel6.Size = new Size(816, 268);
            panel6.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 1);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 37;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 1);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 36;
            label1.Text = "competencia";
            // 
            // btncrearnuevopartido
            // 
            btncrearnuevopartido.Location = new Point(623, 22);
            btncrearnuevopartido.Name = "btncrearnuevopartido";
            btncrearnuevopartido.Size = new Size(157, 29);
            btncrearnuevopartido.TabIndex = 35;
            btncrearnuevopartido.Text = "Crear nuevo partido";
            btncrearnuevopartido.UseVisualStyleBackColor = true;
            // 
            // dgvPartidos
            // 
            dgvPartidos.BackgroundColor = Color.Aquamarine;
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(26, 70);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.RowHeadersWidth = 51;
            dgvPartidos.Size = new Size(718, 188);
            dgvPartidos.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(332, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 28);
            comboBox1.TabIndex = 33;
            comboBox1.Text = "Todos,próximo,finalizado,cancelado";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(164, 24);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(162, 28);
            comboBox2.TabIndex = 32;
            comboBox2.Text = "Liga, copa, amistoso";
            // 
            // buscarpartido
            // 
            buscarpartido.Location = new Point(3, 24);
            buscarpartido.Name = "buscarpartido";
            buscarpartido.Size = new Size(155, 27);
            buscarpartido.TabIndex = 31;
            buscarpartido.Text = "Buscar partido";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(773, 70);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 192);
            vScrollBar1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(196, 10);
            label3.Name = "label3";
            label3.Size = new Size(217, 20);
            label3.TabIndex = 12;
            label3.Text = "Resumen de estado de Partidos";
            // 
            // paneltotalpartidos
            // 
            paneltotalpartidos.BackColor = Color.LightGreen;
            paneltotalpartidos.Controls.Add(label4);
            paneltotalpartidos.Location = new Point(317, 347);
            paneltotalpartidos.Name = "paneltotalpartidos";
            paneltotalpartidos.Size = new Size(98, 81);
            paneltotalpartidos.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 13);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 0;
            label4.Text = "Total partidos";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panelcancelado);
            panel7.Controls.Add(panelenproceso);
            panel7.Controls.Add(panelproximos);
            panel7.Controls.Add(panelfinalizados);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(292, 308);
            panel7.Name = "panel7";
            panel7.Size = new Size(644, 130);
            panel7.TabIndex = 31;
            // 
            // panelcancelado
            // 
            panelcancelado.BackColor = Color.Chartreuse;
            panelcancelado.Controls.Add(label8);
            panelcancelado.Location = new Point(506, 39);
            panelcancelado.Name = "panelcancelado";
            panelcancelado.Size = new Size(90, 81);
            panelcancelado.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 16);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 2;
            label8.Text = "cancelados";
            // 
            // panelenproceso
            // 
            panelenproceso.BackColor = Color.YellowGreen;
            panelenproceso.Controls.Add(label7);
            panelenproceso.Location = new Point(387, 39);
            panelenproceso.Name = "panelenproceso";
            panelenproceso.Size = new Size(90, 81);
            panelenproceso.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 2;
            label7.Text = "En proceso";
            // 
            // panelproximos
            // 
            panelproximos.BackColor = Color.LimeGreen;
            panelproximos.Controls.Add(label6);
            panelproximos.Location = new Point(277, 39);
            panelproximos.Name = "panelproximos";
            panelproximos.Size = new Size(90, 81);
            panelproximos.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 16);
            label6.Name = "label6";
            label6.Size = new Size(63, 17);
            label6.TabIndex = 1;
            label6.Text = "próximos";
            // 
            // panelfinalizados
            // 
            panelfinalizados.BackColor = Color.GreenYellow;
            panelfinalizados.Controls.Add(label5);
            panelfinalizados.Location = new Point(151, 39);
            panelfinalizados.Name = "panelfinalizados";
            panelfinalizados.Size = new Size(90, 81);
            panelfinalizados.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 16);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 1;
            label5.Text = "Finalizados";
            // 
            // FormPartidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(paneltotalpartidos);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Name = "FormPartidos";
            Text = "FormPartidos";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            paneltotalpartidos.ResumeLayout(false);
            paneltotalpartidos.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelcancelado.ResumeLayout(false);
            panelcancelado.PerformLayout();
            panelenproceso.ResumeLayout(false);
            panelenproceso.PerformLayout();
            panelproximos.ResumeLayout(false);
            panelproximos.PerformLayout();
            panelfinalizados.ResumeLayout(false);
            panelfinalizados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cerrar;
        private Button reportes;
        private Button facturaciones;
        private Button cancelaciones;
        private Button ventas;
        private Button partidos;
        private Button estadios;
        private Button clientes;
        private Button menu;
        private Panel panel6;
        private VScrollBar vScrollBar1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox buscarpartido;
        private DataGridView dgvPartidos;
        private Button btncrearnuevopartido;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel paneltotalpartidos;
        private Label label4;
        private Panel panel7;
        private Panel panelcancelado;
        private Label label8;
        private Panel panelenproceso;
        private Label label7;
        private Panel panelproximos;
        private Label label6;
        private Panel panelfinalizados;
        private Label label5;
    }
}