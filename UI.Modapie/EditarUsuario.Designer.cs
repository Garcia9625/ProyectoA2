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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(53, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar usuario";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(81, 158);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(212, 22);
            this.txtPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(408, 156);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(176, 24);
            this.cmbRol.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(87, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 17);
            this.lblNombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cédula:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(471, 68);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(0, 17);
            this.lblCedula.TabIndex = 8;
            // 
            // pcbCancelar
            // 
            this.pcbCancelar.BackgroundImage = global::UI.Modapie.Properties.Resources.cancelar;
            this.pcbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCancelar.Location = new System.Drawing.Point(466, 279);
            this.pcbCancelar.Name = "pcbCancelar";
            this.pcbCancelar.Size = new System.Drawing.Size(62, 59);
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
            this.pcbRegistrar.Location = new System.Drawing.Point(247, 279);
            this.pcbRegistrar.Name = "pcbRegistrar";
            this.pcbRegistrar.Size = new System.Drawing.Size(62, 59);
            this.pcbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRegistrar.TabIndex = 62;
            this.pcbRegistrar.TabStop = false;
            this.pcbRegistrar.MouseLeave += new System.EventHandler(this.pcbRegistrar_MouseLeave);
            this.pcbRegistrar.MouseHover += new System.EventHandler(this.pcbRegistrar_MouseHover);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 380);
            this.Controls.Add(this.pcbCancelar);
            this.Controls.Add(this.pcbRegistrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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