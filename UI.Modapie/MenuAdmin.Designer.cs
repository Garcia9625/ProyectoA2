namespace UI.Modapie
{
    partial class MenuAdmin
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Configuracion = new System.Windows.Forms.GroupBox();
            this.ventas = new System.Windows.Forms.GroupBox();
            this.btnInformes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.Mantenimientos = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClientesPMa = new System.Windows.Forms.Button();
            this.btn_GIAXM = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Configuracion.SuspendLayout();
            this.ventas.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.Mantenimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(61, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 29);
            this.lblUsername.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Configuracion);
            this.panel1.Controls.Add(this.ventas);
            this.panel1.Controls.Add(this.Empleados);
            this.panel1.Controls.Add(this.Mantenimientos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 689);
            this.panel1.TabIndex = 12;
            // 
            // Configuracion
            // 
            this.Configuracion.BackColor = System.Drawing.Color.White;
            this.Configuracion.Controls.Add(this.button7);
            this.Configuracion.Controls.Add(this.btn_NuevoUsuario);
            this.Configuracion.Location = new System.Drawing.Point(405, 373);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(310, 220);
            this.Configuracion.TabIndex = 12;
            this.Configuracion.TabStop = false;
            this.Configuracion.Text = "Configuración";
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.White;
            this.ventas.Controls.Add(this.btnInformes);
            this.ventas.Controls.Add(this.button4);
            this.ventas.Controls.Add(this.button3);
            this.ventas.Location = new System.Drawing.Point(405, 122);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(310, 220);
            this.ventas.TabIndex = 12;
            this.ventas.TabStop = false;
            this.ventas.Text = "Ventas";
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(37, 55);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(178, 26);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "Gestion de Ventas al detalle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gestion de ventas al por mayor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Empleados
            // 
            this.Empleados.BackColor = System.Drawing.Color.White;
            this.Empleados.Controls.Add(this.button1);
            this.Empleados.Location = new System.Drawing.Point(38, 373);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(310, 220);
            this.Empleados.TabIndex = 11;
            this.Empleados.TabStop = false;
            this.Empleados.Text = "Empleados";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(54, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 25);
            this.button7.TabIndex = 13;
            this.button7.Text = "Registro usuario";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion de empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(54, 82);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(178, 26);
            this.btn_NuevoUsuario.TabIndex = 8;
            this.btn_NuevoUsuario.Text = "Registrar nuevo usuario";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = true;
            this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
            // 
            // Mantenimientos
            // 
            this.Mantenimientos.BackColor = System.Drawing.Color.White;
            this.Mantenimientos.Controls.Add(this.button6);
            this.Mantenimientos.Controls.Add(this.button2);
            this.Mantenimientos.Controls.Add(this.btnClientesPMa);
            this.Mantenimientos.Controls.Add(this.btn_GIAXM);
            this.Mantenimientos.Controls.Add(this.btnProductos);
            this.Mantenimientos.Location = new System.Drawing.Point(38, 122);
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Size = new System.Drawing.Size(310, 220);
            this.Mantenimientos.TabIndex = 10;
            this.Mantenimientos.TabStop = false;
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Producto detalle";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clientes al detalles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientesPMa
            // 
            this.btnClientesPMa.Location = new System.Drawing.Point(35, 78);
            this.btnClientesPMa.Name = "btnClientesPMa";
            this.btnClientesPMa.Size = new System.Drawing.Size(178, 26);
            this.btnClientesPMa.TabIndex = 1;
            this.btnClientesPMa.Text = "Clientes al por mayor";
            this.btnClientesPMa.UseVisualStyleBackColor = true;
            this.btnClientesPMa.Click += new System.EventHandler(this.btnClientesPMa_Click);
            // 
            // btn_GIAXM
            // 
            this.btn_GIAXM.Location = new System.Drawing.Point(35, 110);
            this.btn_GIAXM.Name = "btn_GIAXM";
            this.btn_GIAXM.Size = new System.Drawing.Size(216, 26);
            this.btn_GIAXM.TabIndex = 9;
            this.btn_GIAXM.Text = "Gestion Inv. Al por mayor";
            this.btn_GIAXM.UseVisualStyleBackColor = true;
            this.btn_GIAXM.Click += new System.EventHandler(this.btn_GIAXM_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(35, 188);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(216, 26);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Gestion de productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú principal.";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsername);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.Configuracion.ResumeLayout(false);
            this.ventas.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Mantenimientos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientesPMa;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_NuevoUsuario;
        private System.Windows.Forms.Button btn_GIAXM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Empleados;
        private System.Windows.Forms.GroupBox Mantenimientos;
        private System.Windows.Forms.GroupBox Configuracion;
        private System.Windows.Forms.GroupBox ventas;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}