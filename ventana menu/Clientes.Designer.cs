namespace ventana_menu
{
    partial class Clientes
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
            button1 = new Button();
            menu = new Button();
            panel2 = new Panel();
            vScrollBar1 = new VScrollBar();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panelregistrarcliente = new Panel();
            dtpFecha = new DateTimePicker();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDomicilio = new TextBox();
            txtRFC = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            buttonhistorial = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelregistrarcliente.SuspendLayout();
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
            panel1.Controls.Add(button1);
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
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(3, 76);
            button1.Name = "button1";
            button1.Size = new Size(184, 36);
            button1.TabIndex = 1;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(buttonhistorial);
            panel2.Controls.Add(vScrollBar1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(194, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 373);
            panel2.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(407, 31);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(21, 334);
            vScrollBar1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(380, 328);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Ventas recientes";
            // 
            // panelregistrarcliente
            // 
            panelregistrarcliente.BackColor = Color.White;
            panelregistrarcliente.Controls.Add(dtpFecha);
            panelregistrarcliente.Controls.Add(txtTelefono);
            panelregistrarcliente.Controls.Add(txtCorreo);
            panelregistrarcliente.Controls.Add(txtDomicilio);
            panelregistrarcliente.Controls.Add(txtRFC);
            panelregistrarcliente.Controls.Add(txtNombre);
            panelregistrarcliente.Controls.Add(btnCancelar);
            panelregistrarcliente.Controls.Add(btnGuardar);
            panelregistrarcliente.Controls.Add(label7);
            panelregistrarcliente.Controls.Add(label6);
            panelregistrarcliente.Controls.Add(label5);
            panelregistrarcliente.Controls.Add(label4);
            panelregistrarcliente.Controls.Add(label3);
            panelregistrarcliente.Controls.Add(label2);
            panelregistrarcliente.Location = new Point(643, 12);
            panelregistrarcliente.Name = "panelregistrarcliente";
            panelregistrarcliente.Size = new Size(293, 282);
            panelregistrarcliente.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(135, 189);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(155, 27);
            dtpFecha.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(87, 153);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(186, 27);
            txtTelefono.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(87, 119);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(186, 27);
            txtCorreo.TabIndex = 12;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(87, 85);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(186, 27);
            txtDomicilio.TabIndex = 11;
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(87, 52);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(186, 27);
            txtRFC.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 27);
            txtNombre.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(158, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(18, 236);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 189);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 6;
            label7.Text = "Fecha nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 122);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 156);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Teléfonos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 88);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Domicilio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 59);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "RFC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 22);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(210, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(400, 27);
            txtBuscar.TabIndex = 4;
            txtBuscar.Text = "Buscar clientes por rfc";
            // 
            // buttonhistorial
            // 
            buttonhistorial.Location = new Point(210, 4);
            buttonhistorial.Name = "buttonhistorial";
            buttonhistorial.Size = new Size(156, 29);
            buttonhistorial.TabIndex = 7;
            buttonhistorial.Text = "Historial de compras";
            buttonhistorial.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(948, 450);
            Controls.Add(txtBuscar);
            Controls.Add(panelregistrarcliente);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            Click += Clientes_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelregistrarcliente.ResumeLayout(false);
            panelregistrarcliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private Button menu;
        private Panel panel2;
        private Panel panelregistrarcliente;
        private TextBox txtBuscar;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonhistorial;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtCorreo;
        private TextBox txtDomicilio;
        private TextBox txtRFC;
        private TextBox txtTelefono;
        private DataGridView dataGridView1;
        private VScrollBar vScrollBar1;
        private DateTimePicker dtpFecha;
    }
}