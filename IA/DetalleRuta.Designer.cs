namespace IA
{
    partial class DetalleRuta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Paso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HayTransbordo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paso,
            this.Estacion,
            this.DistanciaAc,
            this.DistanciaInt,
            this.TiempoAc,
            this.TiempoInt,
            this.HayTransbordo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información de la ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paradas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transbordos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiempo total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Distancia total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // Paso
            // 
            this.Paso.HeaderText = "Paso";
            this.Paso.Name = "Paso";
            this.Paso.ReadOnly = true;
            this.Paso.Width = 35;
            // 
            // Estacion
            // 
            this.Estacion.HeaderText = "Estación";
            this.Estacion.Name = "Estacion";
            this.Estacion.ReadOnly = true;
            this.Estacion.Width = 140;
            // 
            // DistanciaAc
            // 
            this.DistanciaAc.HeaderText = "Distancia Acumulada";
            this.DistanciaAc.Name = "DistanciaAc";
            this.DistanciaAc.ReadOnly = true;
            // 
            // DistanciaInt
            // 
            this.DistanciaInt.HeaderText = "Distancia Intervalo";
            this.DistanciaInt.Name = "DistanciaInt";
            this.DistanciaInt.ReadOnly = true;
            // 
            // TiempoAc
            // 
            this.TiempoAc.HeaderText = "Tiempo acumulado";
            this.TiempoAc.Name = "TiempoAc";
            this.TiempoAc.ReadOnly = true;
            // 
            // TiempoInt
            // 
            this.TiempoInt.HeaderText = "Tiempo Intervalo";
            this.TiempoInt.Name = "TiempoInt";
            this.TiempoInt.ReadOnly = true;
            // 
            // HayTransbordo
            // 
            this.HayTransbordo.HeaderText = "¿Hay Transbordo?";
            this.HayTransbordo.Name = "HayTransbordo";
            this.HayTransbordo.ReadOnly = true;
            // 
            // DetalleRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 580);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DetalleRuta";
            this.Text = "Detalle Ruta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HayTransbordo;
    }
}