﻿namespace IA
{
    partial class Main
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabConfiguracion = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRutaDistancias = new System.Windows.Forms.TextBox();
            this.btnAbrirDistancias = new System.Windows.Forms.Button();
            this.lblDistancias = new System.Windows.Forms.Label();
            this.txtRutaGrafo = new System.Windows.Forms.TextBox();
            this.btnAbrirGrafo = new System.Windows.Forms.Button();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.tabSimple = new System.Windows.Forms.TabPage();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempoRuta = new System.Windows.Forms.Label();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cbEstacionFinal = new System.Windows.Forms.ComboBox();
            this.cbEstacionInicio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDetallado = new System.Windows.Forms.TabPage();
            this.btnDetalleVariables = new System.Windows.Forms.Button();
            this.btnDetPaso = new System.Windows.Forms.Button();
            this.txtDetDescripcion = new System.Windows.Forms.TextBox();
            this.picMapaDetallado = new System.Windows.Forms.PictureBox();
            this.btnDetComenzar = new System.Windows.Forms.Button();
            this.lblDetFinal = new System.Windows.Forms.Label();
            this.lblDetInicio = new System.Windows.Forms.Label();
            this.txtDetFinal = new System.Windows.Forms.ComboBox();
            this.txtDetInicio = new System.Windows.Forms.ComboBox();
            this.openFileGrafo = new System.Windows.Forms.OpenFileDialog();
            this.openFileDistancias = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl.SuspendLayout();
            this.tabConfiguracion.SuspendLayout();
            this.tabSimple.SuspendLayout();
            this.tabDetallado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMapaDetallado)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabConfiguracion);
            this.mainTabControl.Controls.Add(this.tabSimple);
            this.mainTabControl.Controls.Add(this.tabDetallado);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(984, 705);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.Controls.Add(this.btnStart);
            this.tabConfiguracion.Controls.Add(this.btnDibujar);
            this.tabConfiguracion.Controls.Add(this.panel2);
            this.tabConfiguracion.Controls.Add(this.txtRutaDistancias);
            this.tabConfiguracion.Controls.Add(this.btnAbrirDistancias);
            this.tabConfiguracion.Controls.Add(this.lblDistancias);
            this.tabConfiguracion.Controls.Add(this.txtRutaGrafo);
            this.tabConfiguracion.Controls.Add(this.btnAbrirGrafo);
            this.tabConfiguracion.Controls.Add(this.lblGrafo);
            this.tabConfiguracion.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracion.Size = new System.Drawing.Size(976, 679);
            this.tabConfiguracion.TabIndex = 0;
            this.tabConfiguracion.Text = "Configuracion";
            this.tabConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(482, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 48);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Empezar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(389, 20);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(86, 48);
            this.btnDibujar.TabIndex = 7;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(9, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 599);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // txtRutaDistancias
            // 
            this.txtRutaDistancias.Location = new System.Drawing.Point(134, 22);
            this.txtRutaDistancias.Name = "txtRutaDistancias";
            this.txtRutaDistancias.Size = new System.Drawing.Size(167, 20);
            this.txtRutaDistancias.TabIndex = 5;
            // 
            // btnAbrirDistancias
            // 
            this.btnAbrirDistancias.Location = new System.Drawing.Point(304, 20);
            this.btnAbrirDistancias.Name = "btnAbrirDistancias";
            this.btnAbrirDistancias.Size = new System.Drawing.Size(78, 23);
            this.btnAbrirDistancias.TabIndex = 4;
            this.btnAbrirDistancias.Text = "Abrir";
            this.btnAbrirDistancias.UseVisualStyleBackColor = true;
            this.btnAbrirDistancias.Click += new System.EventHandler(this.btnAbrirDistancias_Click);
            // 
            // lblDistancias
            // 
            this.lblDistancias.AutoSize = true;
            this.lblDistancias.Location = new System.Drawing.Point(6, 25);
            this.lblDistancias.Name = "lblDistancias";
            this.lblDistancias.Size = new System.Drawing.Size(108, 13);
            this.lblDistancias.TabIndex = 3;
            this.lblDistancias.Text = "Archivo de distancias";
            // 
            // txtRutaGrafo
            // 
            this.txtRutaGrafo.Location = new System.Drawing.Point(134, 48);
            this.txtRutaGrafo.Name = "txtRutaGrafo";
            this.txtRutaGrafo.Size = new System.Drawing.Size(167, 20);
            this.txtRutaGrafo.TabIndex = 2;
            // 
            // btnAbrirGrafo
            // 
            this.btnAbrirGrafo.Location = new System.Drawing.Point(304, 46);
            this.btnAbrirGrafo.Name = "btnAbrirGrafo";
            this.btnAbrirGrafo.Size = new System.Drawing.Size(78, 23);
            this.btnAbrirGrafo.TabIndex = 1;
            this.btnAbrirGrafo.Text = "Abrir";
            this.btnAbrirGrafo.UseVisualStyleBackColor = true;
            this.btnAbrirGrafo.Click += new System.EventHandler(this.btnAbrirGrafo_Click);
            // 
            // lblGrafo
            // 
            this.lblGrafo.AutoSize = true;
            this.lblGrafo.Location = new System.Drawing.Point(6, 51);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(85, 13);
            this.lblGrafo.TabIndex = 0;
            this.lblGrafo.Text = "Archivo de grafo";
            // 
            // tabSimple
            // 
            this.tabSimple.Controls.Add(this.txtTiempo);
            this.tabSimple.Controls.Add(this.lblTiempoRuta);
            this.tabSimple.Controls.Add(this.btnCalcularRuta);
            this.tabSimple.Controls.Add(this.lblFinal);
            this.tabSimple.Controls.Add(this.lblInicio);
            this.tabSimple.Controls.Add(this.cbEstacionFinal);
            this.tabSimple.Controls.Add(this.cbEstacionInicio);
            this.tabSimple.Controls.Add(this.panel1);
            this.tabSimple.Location = new System.Drawing.Point(4, 22);
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimple.Size = new System.Drawing.Size(976, 679);
            this.tabSimple.TabIndex = 1;
            this.tabSimple.Text = "Vista simple";
            this.tabSimple.UseVisualStyleBackColor = true;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(545, 13);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(88, 20);
            this.txtTiempo.TabIndex = 14;
            // 
            // lblTiempoRuta
            // 
            this.lblTiempoRuta.AutoSize = true;
            this.lblTiempoRuta.Location = new System.Drawing.Point(438, 15);
            this.lblTiempoRuta.Name = "lblTiempoRuta";
            this.lblTiempoRuta.Size = new System.Drawing.Size(101, 13);
            this.lblTiempoRuta.TabIndex = 13;
            this.lblTiempoRuta.Text = "Tiempo de trayecto:";
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.Location = new System.Drawing.Point(342, 11);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(89, 23);
            this.btnCalcularRuta.TabIndex = 12;
            this.btnCalcularRuta.Text = "Calcular Ruta";
            this.btnCalcularRuta.UseVisualStyleBackColor = true;
            this.btnCalcularRuta.Click += new System.EventHandler(this.btnCalcularRuta_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(657, 16);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(70, 13);
            this.lblFinal.TabIndex = 11;
            this.lblFinal.Text = "Estacion final";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(6, 16);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(75, 13);
            this.lblInicio.TabIndex = 10;
            this.lblInicio.Text = "Estacion inicio";
            // 
            // cbEstacionFinal
            // 
            this.cbEstacionFinal.FormattingEnabled = true;
            this.cbEstacionFinal.Location = new System.Drawing.Point(738, 13);
            this.cbEstacionFinal.Name = "cbEstacionFinal";
            this.cbEstacionFinal.Size = new System.Drawing.Size(231, 21);
            this.cbEstacionFinal.TabIndex = 9;
            // 
            // cbEstacionInicio
            // 
            this.cbEstacionInicio.FormattingEnabled = true;
            this.cbEstacionInicio.Location = new System.Drawing.Point(87, 13);
            this.cbEstacionInicio.Name = "cbEstacionInicio";
            this.cbEstacionInicio.Size = new System.Drawing.Size(231, 21);
            this.cbEstacionInicio.TabIndex = 8;
            this.cbEstacionInicio.SelectedIndexChanged += new System.EventHandler(this.cbEstacionInicio_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 599);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // tabDetallado
            // 
            this.tabDetallado.Controls.Add(this.btnDetalleVariables);
            this.tabDetallado.Controls.Add(this.btnDetPaso);
            this.tabDetallado.Controls.Add(this.txtDetDescripcion);
            this.tabDetallado.Controls.Add(this.picMapaDetallado);
            this.tabDetallado.Controls.Add(this.btnDetComenzar);
            this.tabDetallado.Controls.Add(this.lblDetFinal);
            this.tabDetallado.Controls.Add(this.lblDetInicio);
            this.tabDetallado.Controls.Add(this.txtDetFinal);
            this.tabDetallado.Controls.Add(this.txtDetInicio);
            this.tabDetallado.Location = new System.Drawing.Point(4, 22);
            this.tabDetallado.Name = "tabDetallado";
            this.tabDetallado.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetallado.Size = new System.Drawing.Size(976, 679);
            this.tabDetallado.TabIndex = 2;
            this.tabDetallado.Text = "Vista detallada";
            this.tabDetallado.UseVisualStyleBackColor = true;
            // 
            // btnDetalleVariables
            // 
            this.btnDetalleVariables.Location = new System.Drawing.Point(438, 7);
            this.btnDetalleVariables.Name = "btnDetalleVariables";
            this.btnDetalleVariables.Size = new System.Drawing.Size(121, 23);
            this.btnDetalleVariables.TabIndex = 26;
            this.btnDetalleVariables.Text = "Detalle variables";
            this.btnDetalleVariables.UseVisualStyleBackColor = true;
            this.btnDetalleVariables.Click += new System.EventHandler(this.btnDetalleVariables_Click);
            // 
            // btnDetPaso
            // 
            this.btnDetPaso.Location = new System.Drawing.Point(565, 7);
            this.btnDetPaso.Name = "btnDetPaso";
            this.btnDetPaso.Size = new System.Drawing.Size(87, 23);
            this.btnDetPaso.TabIndex = 25;
            this.btnDetPaso.Text = "Siguiente paso";
            this.btnDetPaso.UseVisualStyleBackColor = true;
            this.btnDetPaso.Click += new System.EventHandler(this.btnDetPaso_Click);
            // 
            // txtDetDescripcion
            // 
            this.txtDetDescripcion.Location = new System.Drawing.Point(10, 645);
            this.txtDetDescripcion.Name = "txtDetDescripcion";
            this.txtDetDescripcion.Size = new System.Drawing.Size(960, 20);
            this.txtDetDescripcion.TabIndex = 24;
            // 
            // picMapaDetallado
            // 
            this.picMapaDetallado.Location = new System.Drawing.Point(10, 40);
            this.picMapaDetallado.Name = "picMapaDetallado";
            this.picMapaDetallado.Size = new System.Drawing.Size(961, 599);
            this.picMapaDetallado.TabIndex = 23;
            this.picMapaDetallado.TabStop = false;
            this.picMapaDetallado.Paint += new System.Windows.Forms.PaintEventHandler(this.picMapaDetallado_Paint);
            this.picMapaDetallado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMapaDetallado_MouseDown);
            // 
            // btnDetComenzar
            // 
            this.btnDetComenzar.Location = new System.Drawing.Point(343, 7);
            this.btnDetComenzar.Name = "btnDetComenzar";
            this.btnDetComenzar.Size = new System.Drawing.Size(89, 23);
            this.btnDetComenzar.TabIndex = 20;
            this.btnDetComenzar.Text = "Comenzar";
            this.btnDetComenzar.UseVisualStyleBackColor = true;
            this.btnDetComenzar.Click += new System.EventHandler(this.btnDetComenzar_Click);
            // 
            // lblDetFinal
            // 
            this.lblDetFinal.AutoSize = true;
            this.lblDetFinal.Location = new System.Drawing.Point(658, 12);
            this.lblDetFinal.Name = "lblDetFinal";
            this.lblDetFinal.Size = new System.Drawing.Size(70, 13);
            this.lblDetFinal.TabIndex = 19;
            this.lblDetFinal.Text = "Estacion final";
            // 
            // lblDetInicio
            // 
            this.lblDetInicio.AutoSize = true;
            this.lblDetInicio.Location = new System.Drawing.Point(7, 12);
            this.lblDetInicio.Name = "lblDetInicio";
            this.lblDetInicio.Size = new System.Drawing.Size(75, 13);
            this.lblDetInicio.TabIndex = 18;
            this.lblDetInicio.Text = "Estacion inicio";
            // 
            // txtDetFinal
            // 
            this.txtDetFinal.FormattingEnabled = true;
            this.txtDetFinal.Location = new System.Drawing.Point(739, 9);
            this.txtDetFinal.Name = "txtDetFinal";
            this.txtDetFinal.Size = new System.Drawing.Size(231, 21);
            this.txtDetFinal.TabIndex = 17;
            this.txtDetFinal.SelectedIndexChanged += new System.EventHandler(this.txtDetFinal_SelectedIndexChanged);
            // 
            // txtDetInicio
            // 
            this.txtDetInicio.FormattingEnabled = true;
            this.txtDetInicio.Location = new System.Drawing.Point(88, 9);
            this.txtDetInicio.Name = "txtDetInicio";
            this.txtDetInicio.Size = new System.Drawing.Size(231, 21);
            this.txtDetInicio.TabIndex = 16;
            this.txtDetInicio.SelectedIndexChanged += new System.EventHandler(this.txtDetInicio_SelectedIndexChanged);
            // 
            // openFileGrafo
            // 
            this.openFileGrafo.FileName = "openFileDialog1";
            this.openFileGrafo.InitialDirectory = "./";
            this.openFileGrafo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDistancias
            // 
            this.openFileDistancias.FileName = "openFileDialog1";
            this.openFileDistancias.InitialDirectory = "./";
            this.openFileDistancias.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDistancias_FileOk);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Main";
            this.Text = "IA - Algoritmo de búsqueda A*";
            this.mainTabControl.ResumeLayout(false);
            this.tabConfiguracion.ResumeLayout(false);
            this.tabConfiguracion.PerformLayout();
            this.tabSimple.ResumeLayout(false);
            this.tabSimple.PerformLayout();
            this.tabDetallado.ResumeLayout(false);
            this.tabDetallado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMapaDetallado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabConfiguracion;
        private System.Windows.Forms.TabPage tabSimple;
        private System.Windows.Forms.Label lblGrafo;
        private System.Windows.Forms.OpenFileDialog openFileGrafo;
        private System.Windows.Forms.TextBox txtRutaGrafo;
        private System.Windows.Forms.Button btnAbrirGrafo;
        private System.Windows.Forms.TextBox txtRutaDistancias;
        private System.Windows.Forms.Button btnAbrirDistancias;
        private System.Windows.Forms.Label lblDistancias;
        private System.Windows.Forms.OpenFileDialog openFileDistancias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.ComboBox cbEstacionFinal;
        private System.Windows.Forms.ComboBox cbEstacionInicio;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempoRuta;
        private System.Windows.Forms.TabPage tabDetallado;
        private System.Windows.Forms.PictureBox picMapaDetallado;
        private System.Windows.Forms.Button btnDetComenzar;
        private System.Windows.Forms.Label lblDetFinal;
        private System.Windows.Forms.Label lblDetInicio;
        private System.Windows.Forms.ComboBox txtDetFinal;
        private System.Windows.Forms.ComboBox txtDetInicio;
        private System.Windows.Forms.TextBox txtDetDescripcion;
        private System.Windows.Forms.Button btnDetPaso;
        private System.Windows.Forms.Button btnDetalleVariables;
    }
}

