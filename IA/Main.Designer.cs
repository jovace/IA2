namespace IA
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
            this.txtRutaDistancias = new System.Windows.Forms.TextBox();
            this.btnAbrirDistancias = new System.Windows.Forms.Button();
            this.lblDistancias = new System.Windows.Forms.Label();
            this.txtRutaGrafo = new System.Windows.Forms.TextBox();
            this.btnAbrirGrafo = new System.Windows.Forms.Button();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.tabSimple = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileGrafo = new System.Windows.Forms.OpenFileDialog();
            this.openFileDistancias = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainTabControl.SuspendLayout();
            this.tabConfiguracion.SuspendLayout();
            this.tabSimple.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabConfiguracion);
            this.mainTabControl.Controls.Add(this.tabSimple);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(908, 594);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabConfiguracion
            // 
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
            this.tabConfiguracion.Size = new System.Drawing.Size(900, 568);
            this.tabConfiguracion.TabIndex = 0;
            this.tabConfiguracion.Text = "Configuracion";
            this.tabConfiguracion.UseVisualStyleBackColor = true;
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
            this.tabSimple.Controls.Add(this.panel1);
            this.tabSimple.Location = new System.Drawing.Point(4, 22);
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimple.Size = new System.Drawing.Size(900, 568);
            this.tabSimple.TabIndex = 1;
            this.tabSimple.Text = "Vista simple";
            this.tabSimple.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 527);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(9, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 488);
            this.panel2.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 618);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Main";
            this.Text = "Main";
            this.mainTabControl.ResumeLayout(false);
            this.tabConfiguracion.ResumeLayout(false);
            this.tabConfiguracion.PerformLayout();
            this.tabSimple.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

