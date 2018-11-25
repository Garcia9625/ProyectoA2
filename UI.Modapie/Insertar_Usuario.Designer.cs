namespace UI.Modapie
{
    partial class Insertar_Usuario
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pcbCancelar = new System.Windows.Forms.PictureBox();
            this.pcbRegistrar = new System.Windows.Forms.PictureBox();
            this.tltUsuario = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(50, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 125);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cedula Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(227, 28);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(112, 26);
            this.txtEmpleado.TabIndex = 65;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "1"});
            this.cmbRol.Location = new System.Drawing.Point(512, 71);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(112, 28);
            this.cmbRol.TabIndex = 63;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nombre de usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(512, 24);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(112, 26);
            this.txtContrasena.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 26);
            this.txtNombre.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Rol";
            // 
            // pcbCancelar
            // 
            this.pcbCancelar.BackgroundImage = global::UI.Modapie.Properties.Resources.cancelar;
            this.pcbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCancelar.Location = new System.Drawing.Point(453, 248);
            this.pcbCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbCancelar.Name = "pcbCancelar";
            this.pcbCancelar.Size = new System.Drawing.Size(70, 74);
            this.pcbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCancelar.TabIndex = 61;
            this.pcbCancelar.TabStop = false;
            this.pcbCancelar.Click += new System.EventHandler(this.pcbCancelar_Click);
            this.pcbCancelar.MouseLeave += new System.EventHandler(this.pcbCancelar_MouseLeave);
            this.pcbCancelar.MouseHover += new System.EventHandler(this.pcbCancelar_MouseHover);
            // 
            // pcbRegistrar
            // 
            this.pcbRegistrar.BackgroundImage = global::UI.Modapie.Properties.Resources.Aceptar;
            this.pcbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbRegistrar.Location = new System.Drawing.Point(207, 248);
            this.pcbRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbRegistrar.Name = "pcbRegistrar";
            this.pcbRegistrar.Size = new System.Drawing.Size(70, 74);
            this.pcbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRegistrar.TabIndex = 58;
            this.pcbRegistrar.TabStop = false;
            this.pcbRegistrar.Click += new System.EventHandler(this.pcbRegistrar_Click);
            this.pcbRegistrar.MouseLeave += new System.EventHandler(this.pcbRegistrar_MouseLeave);
            this.pcbRegistrar.MouseHover += new System.EventHandler(this.pcbRegistrar_MouseHover);
            // 
            // Insertar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 345);
            this.Controls.Add(this.pcbCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Insertar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar_Usuario";
            this.Load += new System.EventHandler(this.Insertar_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegistrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbCancelar;
        private System.Windows.Forms.ToolTip tltUsuario;
    }
}