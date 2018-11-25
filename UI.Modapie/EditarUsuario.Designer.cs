namespace UI.Modapie
{
    partial class EditarUsuario
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
            this.lblCedula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pcbCancelar = new System.Windows.Forms.PictureBox();
            this.pcbRegistrar = new System.Windows.Forms.PictureBox();
            this.tltModificarUsuario = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Location = new System.Drawing.Point(60, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(780, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar usuario";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(530, 85);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(0, 20);
            this.lblCedula.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cédula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(98, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 20);
            this.lblNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de usuario:";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(459, 195);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(198, 28);
            this.cmbRol.TabIndex = 4;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(91, 198);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(238, 26);
            this.txtPass.TabIndex = 0;
            // 
            // pcbCancelar
            // 
            this.pcbCancelar.BackgroundImage = global::UI.Modapie.Properties.Resources.cancelar;
            this.pcbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCancelar.Location = new System.Drawing.Point(524, 349);
            this.pcbCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbCancelar.Name = "pcbCancelar";
            this.pcbCancelar.Size = new System.Drawing.Size(70, 74);
            this.pcbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCancelar.TabIndex = 63;
            this.pcbCancelar.TabStop = false;
            this.pcbCancelar.Click += new System.EventHandler(this.pcbCancelar_Click);
            this.pcbCancelar.MouseLeave += new System.EventHandler(this.pcbCancelar_MouseLeave);
            this.pcbCancelar.MouseHover += new System.EventHandler(this.pcbCancelar_MouseHover);
            // 
            // pcbRegistrar
            // 
            this.pcbRegistrar.BackgroundImage = global::UI.Modapie.Properties.Resources.Aceptar;
            this.pcbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbRegistrar.Location = new System.Drawing.Point(278, 349);
            this.pcbRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbRegistrar.Name = "pcbRegistrar";
            this.pcbRegistrar.Size = new System.Drawing.Size(70, 74);
            this.pcbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRegistrar.TabIndex = 62;
            this.pcbRegistrar.TabStop = false;
            this.pcbRegistrar.Click += new System.EventHandler(this.pcbRegistrar_Click);
            this.pcbRegistrar.MouseLeave += new System.EventHandler(this.pcbRegistrar_MouseLeave);
            this.pcbRegistrar.MouseHover += new System.EventHandler(this.pcbRegistrar_MouseHover);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 475);
            this.Controls.Add(this.pcbCancelar);
            this.Controls.Add(this.pcbRegistrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegistrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pcbCancelar;
        private System.Windows.Forms.PictureBox pcbRegistrar;
        private System.Windows.Forms.ToolTip tltModificarUsuario;
    }
}