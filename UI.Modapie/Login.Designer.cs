namespace UI.Modapie
{
    partial class Login
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
            //hhhhhh
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Horaa = new System.Windows.Forms.Label();
            this.Fechaa = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcBInicio = new System.Windows.Forms.PictureBox();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.tltInicio = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(208, 262);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Se me olvidó la contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AbrirRecuperación);
            // 
            // Horaa
            // 
            this.Horaa.AutoSize = true;
            this.Horaa.BackColor = System.Drawing.Color.Transparent;
            this.Horaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horaa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Horaa.Location = new System.Drawing.Point(417, 44);
            this.Horaa.Name = "Horaa";
            this.Horaa.Size = new System.Drawing.Size(63, 26);
            this.Horaa.TabIndex = 17;
            this.Horaa.Text = "Hora";
            // 
            // Fechaa
            // 
            this.Fechaa.AutoSize = true;
            this.Fechaa.BackColor = System.Drawing.Color.Transparent;
            this.Fechaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Fechaa.Location = new System.Drawing.Point(410, 18);
            this.Fechaa.Name = "Fechaa";
            this.Fechaa.Size = new System.Drawing.Size(77, 26);
            this.Fechaa.TabIndex = 8;
            this.Fechaa.Text = "Fecha";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.White;
            this.btn_apagar.Image = ((System.Drawing.Image)(resources.GetObject("btn_apagar.Image")));
            this.btn_apagar.Location = new System.Drawing.Point(10, 300);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(45, 48);
            this.btn_apagar.TabIndex = 16;
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(138, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 53);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inicio de sesión.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(45, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(45, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(212, 182);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(212, 223);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(180, 20);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BackgroundImage = global::UI.Modapie.Properties.Resources.MODAPIE1;
            this.panel2.Controls.Add(this.pcBInicio);
            this.panel2.Controls.Add(this.Horaa);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.Fechaa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_apagar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 374);
            this.panel2.TabIndex = 5;
            // 
            // pcBInicio
            // 
            this.pcBInicio.BackColor = System.Drawing.Color.Transparent;
            this.pcBInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBInicio.BackgroundImage")));
            this.pcBInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcBInicio.Location = new System.Drawing.Point(416, 182);
            this.pcBInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcBInicio.Name = "pcBInicio";
            this.pcBInicio.Size = new System.Drawing.Size(61, 58);
            this.pcBInicio.TabIndex = 20;
            this.pcBInicio.TabStop = false;
            this.pcBInicio.Click += new System.EventHandler(this.pcBInicio_Click);
            this.pcBInicio.MouseLeave += new System.EventHandler(this.pcBInicio_MouseLeave);
            this.pcBInicio.MouseHover += new System.EventHandler(this.pcBInicio_MouseHover);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Interval = 1000;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // tltInicio
            // 
            this.tltInicio.ShowAlways = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 358);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Horaa;
        private System.Windows.Forms.Label Fechaa;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.PictureBox pcBInicio;
        private System.Windows.Forms.ToolTip tltInicio;
    }
}

