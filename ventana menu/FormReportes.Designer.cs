namespace ventana_menu
{
    partial class FormReportes
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
            panel1.SuspendLayout();
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
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormReportes";
            Text = "FormReportes";
            panel1.ResumeLayout(false);
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
    }
}