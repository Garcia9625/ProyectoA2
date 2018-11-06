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
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ventas = new System.Windows.Forms.GroupBox();
            this.Productos = new System.Windows.Forms.Button();
            this.btn_GIAXM = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.GroupBox();
            this.InsertarUser = new System.Windows.Forms.Button();
            this.btn_editarUser = new System.Windows.Forms.Button();
            this.Mantenimientos = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClientesPMa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_xDetalle = new System.Windows.Forms.Button();
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
            this.panel1.BackgroundImage = global::UI.Modapie.Properties.Resources.MODAPIECopia;
            this.panel1.Controls.Add(this.Configuracion);
            this.panel1.Controls.Add(this.ventas);
            this.panel1.Controls.Add(this.Empleados);
            this.panel1.Controls.Add(this.Mantenimientos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 689);
            this.panel1.TabIndex = 12;
            // 
            // Configuracion
            // 
            this.Configuracion.BackColor = System.Drawing.Color.White;
            this.Configuracion.Controls.Add(this.btn_NuevoUsuario);
            this.Configuracion.Controls.Add(this.button1);
            this.Configuracion.Location = new System.Drawing.Point(431, 398);
            this.Configuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Configuracion.Size = new System.Drawing.Size(309, 273);
            this.Configuracion.TabIndex = 12;
            this.Configuracion.TabStop = false;
            this.Configuracion.Text = "Configuración";
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.Image = global::UI.Modapie.Properties.Resources.User_32x32;
            this.btn_NuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(33, 138);
            this.btn_NuevoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(247, 41);
            this.btn_NuevoUsuario.TabIndex = 8;
            this.btn_NuevoUsuario.Text = "Usuarios";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = true;
            this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
            // 
            // button1
            // 
            this.button1.Image = global::UI.Modapie.Properties.Resources.User_32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(33, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion de empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.White;
            this.ventas.Controls.Add(this.Productos);
            this.ventas.Controls.Add(this.btn_GIAXM);
            this.ventas.Controls.Add(this.btnInformes);
            this.ventas.Controls.Add(this.button4);
            this.ventas.Controls.Add(this.button3);
            this.ventas.Location = new System.Drawing.Point(431, 116);
            this.ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ventas.Name = "ventas";
            this.ventas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ventas.Size = new System.Drawing.Size(309, 276);
            this.ventas.TabIndex = 12;
            this.ventas.TabStop = false;
            this.ventas.Text = "Ventas";
            // 
            // Productos
            // 
            this.Productos.Image = global::UI.Modapie.Properties.Resources.carro_de_entregas;
            this.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.Location = new System.Drawing.Point(33, 214);
            this.Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(247, 43);
            this.Productos.TabIndex = 15;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // btn_GIAXM
            // 
            this.btn_GIAXM.Image = global::UI.Modapie.Properties.Resources.Folder_24x24;
            this.btn_GIAXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GIAXM.Location = new System.Drawing.Point(33, 165);
            this.btn_GIAXM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GIAXM.Name = "btn_GIAXM";
            this.btn_GIAXM.Size = new System.Drawing.Size(247, 43);
            this.btn_GIAXM.TabIndex = 9;
            this.btn_GIAXM.Text = "Gestion Inv. Al por mayor";
            this.btn_GIAXM.UseVisualStyleBackColor = true;
            this.btn_GIAXM.Click += new System.EventHandler(this.btn_GIAXM_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Image = global::UI.Modapie.Properties.Resources.Edit_32x32;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(33, 26);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(247, 41);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // button4
            // 
            this.button4.Image = global::UI.Modapie.Properties.Resources.simbolo_del_dolar_americano;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(33, 73);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "Gest. Ventas al detalle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::UI.Modapie.Properties.Resources.simbolo_del_dolar_americano;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(33, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gest. Ventas al por mayor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Empleados
            // 
            this.Empleados.BackColor = System.Drawing.Color.White;
            this.Empleados.Controls.Add(this.InsertarUser);
            this.Empleados.Controls.Add(this.btn_editarUser);
            this.Empleados.Location = new System.Drawing.Point(64, 398);
            this.Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empleados.Name = "Empleados";
            this.Empleados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empleados.Size = new System.Drawing.Size(309, 276);
            this.Empleados.TabIndex = 11;
            this.Empleados.TabStop = false;
            this.Empleados.Text = "Empleados";
            // 
            // InsertarUser
            // 
            this.InsertarUser.Image = global::UI.Modapie.Properties.Resources.Users_Edit_48x48;
            this.InsertarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertarUser.Location = new System.Drawing.Point(32, 138);
            this.InsertarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertarUser.Name = "InsertarUser";
            this.InsertarUser.Size = new System.Drawing.Size(247, 41);
            this.InsertarUser.TabIndex = 13;
            this.InsertarUser.Text = "Insertar nuevo usuario";
            this.InsertarUser.UseVisualStyleBackColor = true;
            this.InsertarUser.Click += new System.EventHandler(this.InsertarUser_Click);
            // 
            // btn_editarUser
            // 
            this.btn_editarUser.Image = global::UI.Modapie.Properties.Resources.Users_Edit_48x48;
            this.btn_editarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarUser.Location = new System.Drawing.Point(32, 91);
            this.btn_editarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editarUser.Name = "btn_editarUser";
            this.btn_editarUser.Size = new System.Drawing.Size(247, 41);
            this.btn_editarUser.TabIndex = 13;
            this.btn_editarUser.Text = "Editar usuario";
            this.btn_editarUser.UseVisualStyleBackColor = true;
            this.btn_editarUser.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Mantenimientos
            // 
            this.Mantenimientos.BackColor = System.Drawing.Color.White;
            this.Mantenimientos.Controls.Add(this.button2);
            this.Mantenimientos.Controls.Add(this.btnClientesPMa);
            this.Mantenimientos.Controls.Add(this.button5);
            this.Mantenimientos.Controls.Add(this.btn_xDetalle);
            this.Mantenimientos.Controls.Add(this.btnProductos);
            this.Mantenimientos.Location = new System.Drawing.Point(64, 116);
            this.Mantenimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mantenimientos.Size = new System.Drawing.Size(309, 276);
            this.Mantenimientos.TabIndex = 10;
            this.Mantenimientos.TabStop = false;
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // button2
            // 
            this.button2.Image = global::UI.Modapie.Properties.Resources.User_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(32, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clientes al detalles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientesPMa
            // 
            this.btnClientesPMa.Image = global::UI.Modapie.Properties.Resources.User_32;
            this.btnClientesPMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesPMa.Location = new System.Drawing.Point(32, 73);
            this.btnClientesPMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientesPMa.Name = "btnClientesPMa";
            this.btnClientesPMa.Size = new System.Drawing.Size(247, 37);
            this.btnClientesPMa.TabIndex = 1;
            this.btnClientesPMa.Text = "Clientes al por mayor";
            this.btnClientesPMa.UseVisualStyleBackColor = true;
            this.btnClientesPMa.Click += new System.EventHandler(this.btnClientesPMa_Click);
            // 
            // button5
            // 
            this.button5.Image = global::UI.Modapie.Properties.Resources.carro_de_entregas;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(32, 214);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "Mod. productos al detalle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // btn_xDetalle
            // 
            this.btn_xDetalle.Image = global::UI.Modapie.Properties.Resources.Search_32;
            this.btn_xDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xDetalle.Location = new System.Drawing.Point(32, 116);
            this.btn_xDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xDetalle.Name = "btn_xDetalle";
            this.btn_xDetalle.Size = new System.Drawing.Size(247, 43);
            this.btn_xDetalle.TabIndex = 14;
            this.btn_xDetalle.Text = "Busqueda cli. al detalle";
            this.btn_xDetalle.UseVisualStyleBackColor = true;
            this.btn_xDetalle.Click += new System.EventHandler(this.btn_xDetalle_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Image = global::UI.Modapie.Properties.Resources.Folder_24x24;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(32, 165);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(247, 43);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Excel de inventario";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú principal.";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuAdmin_FormClosing);
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
        private System.Windows.Forms.Button btn_editarUser;
        private System.Windows.Forms.Button btn_xDetalle;
        private System.Windows.Forms.Button InsertarUser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Productos;
    }
}