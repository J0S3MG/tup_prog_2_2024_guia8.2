namespace Ejercicio1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApeyNom = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.nudCuotas = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.txtVer);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Plan de Pagos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtApeyNom);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaInicio);
            this.groupBox3.Controls.Add(this.nudCuotas);
            this.groupBox3.Controls.Add(this.txtMonto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 114);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido y Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto de la Infraccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "En Cuotas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Inicio Plan: ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(173, 33);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(199, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // txtApeyNom
            // 
            this.txtApeyNom.Location = new System.Drawing.Point(173, 65);
            this.txtApeyNom.Name = "txtApeyNom";
            this.txtApeyNom.Size = new System.Drawing.Size(282, 20);
            this.txtApeyNom.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(144, 30);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(106, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(12, 329);
            this.txtVer.Multiline = true;
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(475, 173);
            this.txtVer.TabIndex = 7;
            // 
            // nudCuotas
            // 
            this.nudCuotas.Location = new System.Drawing.Point(144, 58);
            this.nudCuotas.Name = "nudCuotas";
            this.nudCuotas.Size = new System.Drawing.Size(110, 20);
            this.nudCuotas.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "M/dd/yyyy";
            this.dtpFechaInicio.Location = new System.Drawing.Point(141, 88);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(184, 20);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(553, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 115);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Planes Realizados";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(553, 247);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(110, 115);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver/Editar Feriados";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(129, 293);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(255, 30);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Plan de Pagos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 532);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtApeyNom;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.NumericUpDown nudCuotas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVer;
    }
}

