namespace Taller_12_04_2018
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
            this.components = new System.ComponentModel.Container();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombredelPaciente = new System.Windows.Forms.TextBox();
            this.cbTipodeDocumento = new System.Windows.Forms.ComboBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.txtNumerodeDocumento = new System.Windows.Forms.TextBox();
            this.cbRango = new System.Windows.Forms.ComboBox();
            this.txtCostoServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalcularPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(115, 303);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(230, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombredelPaciente
            // 
            this.txtNombredelPaciente.Location = new System.Drawing.Point(178, 51);
            this.txtNombredelPaciente.Name = "txtNombredelPaciente";
            this.txtNombredelPaciente.Size = new System.Drawing.Size(176, 20);
            this.txtNombredelPaciente.TabIndex = 2;
            // 
            // cbTipodeDocumento
            // 
            this.cbTipodeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipodeDocumento.FormattingEnabled = true;
            this.cbTipodeDocumento.Location = new System.Drawing.Point(178, 92);
            this.cbTipodeDocumento.Name = "cbTipodeDocumento";
            this.cbTipodeDocumento.Size = new System.Drawing.Size(176, 21);
            this.cbTipodeDocumento.TabIndex = 3;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(178, 150);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnFemenino.TabIndex = 4;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "&Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(269, 150);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 5;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "&Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNumerodeDocumento
            // 
            this.txtNumerodeDocumento.Location = new System.Drawing.Point(178, 184);
            this.txtNumerodeDocumento.Name = "txtNumerodeDocumento";
            this.txtNumerodeDocumento.Size = new System.Drawing.Size(176, 20);
            this.txtNumerodeDocumento.TabIndex = 6;
            // 
            // cbRango
            // 
            this.cbRango.FormattingEnabled = true;
            this.cbRango.Location = new System.Drawing.Point(178, 223);
            this.cbRango.Name = "cbRango";
            this.cbRango.Size = new System.Drawing.Size(176, 21);
            this.cbRango.TabIndex = 7;
            // 
            // txtCostoServicio
            // 
            this.txtCostoServicio.Location = new System.Drawing.Point(178, 261);
            this.txtCostoServicio.Name = "txtCostoServicio";
            this.txtCostoServicio.Size = new System.Drawing.Size(176, 20);
            this.txtCostoServicio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Nombre del paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero de &documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "&Rango";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cos&to servicio";
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // btnCalcularPago
            // 
            this.btnCalcularPago.Location = new System.Drawing.Point(136, 334);
            this.btnCalcularPago.Name = "btnCalcularPago";
            this.btnCalcularPago.Size = new System.Drawing.Size(146, 23);
            this.btnCalcularPago.TabIndex = 15;
            this.btnCalcularPago.Text = "Calcular Pago";
            this.btnCalcularPago.UseVisualStyleBackColor = true;
            this.btnCalcularPago.Click += new System.EventHandler(this.btnCalcularPago_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 369);
            this.Controls.Add(this.btnCalcularPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostoServicio);
            this.Controls.Add(this.cbRango);
            this.Controls.Add(this.txtNumerodeDocumento);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.cbTipodeDocumento);
            this.Controls.Add(this.txtNombredelPaciente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Registro de prestación de servicios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombredelPaciente;
        private System.Windows.Forms.ComboBox cbTipodeDocumento;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.TextBox txtNumerodeDocumento;
        private System.Windows.Forms.ComboBox cbRango;
        private System.Windows.Forms.TextBox txtCostoServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.Button btnCalcularPago;
    }
}

