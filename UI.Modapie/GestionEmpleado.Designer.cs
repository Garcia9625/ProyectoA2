namespace UI.Modapie
{
    partial class GestionEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.rtbDireccion = new System.Windows.Forms.RichTextBox();
            this.dtpFContratacion = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo Electronico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección de Domicilio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Salario Mensual:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha de Contratación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Estado:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(77, 35);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(167, 20);
            this.txtDni.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(339, 83);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(140, 20);
            this.txtApellido1.TabIndex = 13;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(610, 83);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(160, 20);
            this.txtApellido2.TabIndex = 14;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(77, 131);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(167, 20);
            this.txtCelular.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(339, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(115, 307);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(129, 20);
            this.txtSalario.TabIndex = 18;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(649, 306);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 20;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(611, 126);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(159, 20);
            this.txtCorreo.TabIndex = 21;
            // 
            // rtbDireccion
            // 
            this.rtbDireccion.Location = new System.Drawing.Point(170, 184);
            this.rtbDireccion.Name = "rtbDireccion";
            this.rtbDireccion.Size = new System.Drawing.Size(439, 99);
            this.rtbDireccion.TabIndex = 22;
            this.rtbDireccion.Text = "";
            // 
            // dtpFContratacion
            // 
            this.dtpFContratacion.Location = new System.Drawing.Point(387, 307);
            this.dtpFContratacion.Name = "dtpFContratacion";
            this.dtpFContratacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFContratacion.TabIndex = 23;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(27, 420);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(743, 225);
            this.dgvData.TabIndex = 24;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(27, 368);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(137, 23);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "Ingresar Empleado";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(236, 368);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 23);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar Empleado";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(436, 368);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(136, 23);
            this.btnEstado.TabIndex = 27;
            this.btnEstado.Text = "Cambiar Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Location = new System.Drawing.Point(634, 368);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(136, 23);
            this.btnActualizarTabla.TabIndex = 28;
            this.btnActualizarTabla.Text = "ActualizarTabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(339, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar Empleado";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GestionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtpFContratacion);
            this.Controls.Add(this.rtbDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionEmpleado";
            this.Text = "Gestion de Empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionEmpleado_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.RichTextBox rtbDireccion;
        private System.Windows.Forms.DateTimePicker dtpFContratacion;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnBuscar;
    }
}