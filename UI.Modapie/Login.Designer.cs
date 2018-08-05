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
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pcBInicio = new System.Windows.Forms.PictureBox();
            this.tltInicio = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(292, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(211, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Se me olvidó la contraseña";
            // 
            // Horaa
            // 
            this.Horaa.AutoSize = true;
            this.Horaa.BackColor = System.Drawing.Color.Transparent;
            this.Horaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horaa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Horaa.Location = new System.Drawing.Point(190, 387);
            this.Horaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Horaa.Name = "Horaa";
            this.Horaa.Size = new System.Drawing.Size(80, 32);
            this.Horaa.TabIndex = 17;
            this.Horaa.Text = "Hora";
            // 
            // Fechaa
            // 
            this.Fechaa.AutoSize = true;
            this.Fechaa.BackColor = System.Drawing.Color.Transparent;
            this.Fechaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fechaa.Location = new System.Drawing.Point(190, 428);
            this.Fechaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fechaa.Name = "Fechaa";
            this.Fechaa.Size = new System.Drawing.Size(99, 32);
            this.Fechaa.TabIndex = 8;
            this.Fechaa.Text = "Fecha";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.White;
            this.btn_apagar.Image = ((System.Drawing.Image)(resources.GetObject("btn_apagar.Image")));
            this.btn_apagar.Location = new System.Drawing.Point(14, 401);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(60, 59);
            this.btn_apagar.TabIndex = 16;
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 67);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inicio de sesion.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(74, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(296, 168);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(238, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(296, 218);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(238, 22);
            this.txtContrasena.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AllowDrop = true;
            this.btn_Ingresar.BackColor = System.Drawing.Color.White;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ingresar.Image")));
            this.btn_Ingresar.Location = new System.Drawing.Point(569, 300);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(81, 63);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pcBInicio);
            this.panel2.Controls.Add(this.Horaa);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.Fechaa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_apagar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Ingresar);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 479);
            this.panel2.TabIndex = 5;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Interval = 1000;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // pcBInicio
            // 
            this.pcBInicio.BackColor = System.Drawing.Color.Transparent;
            this.pcBInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBInicio.BackgroundImage")));
            this.pcBInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcBInicio.Location = new System.Drawing.Point(569, 168);
            this.pcBInicio.Name = "pcBInicio";
            this.pcBInicio.Size = new System.Drawing.Size(81, 72);
            this.pcBInicio.TabIndex = 20;
            this.pcBInicio.TabStop = false;
            this.pcBInicio.Click += new System.EventHandler(this.pcBInicio_Click);
            this.pcBInicio.MouseLeave += new System.EventHandler(this.pcBInicio_MouseLeave);
            this.pcBInicio.MouseHover += new System.EventHandler(this.pcBInicio_MouseHover);
            // 
            // tltInicio
            // 
            this.tltInicio.ShowAlways = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 472);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.PictureBox pcBInicio;
        private System.Windows.Forms.ToolTip tltInicio;
    }
}

