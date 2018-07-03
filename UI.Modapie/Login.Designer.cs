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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(328, 334);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(272, 25);
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
            this.Horaa.Location = new System.Drawing.Point(264, 468);
            this.Horaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Horaa.Name = "Horaa";
            this.Horaa.Size = new System.Drawing.Size(92, 38);
            this.Horaa.TabIndex = 17;
            this.Horaa.Text = "Hora";
            // 
            // Fechaa
            // 
            this.Fechaa.AutoSize = true;
            this.Fechaa.BackColor = System.Drawing.Color.Transparent;
            this.Fechaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fechaa.Location = new System.Drawing.Point(264, 508);
            this.Fechaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fechaa.Name = "Fechaa";
            this.Fechaa.Size = new System.Drawing.Size(113, 38);
            this.Fechaa.TabIndex = 8;
            this.Fechaa.Text = "Fecha";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.White;
            this.btn_apagar.Image = ((System.Drawing.Image)(resources.GetObject("btn_apagar.Image")));
            this.btn_apagar.Location = new System.Drawing.Point(16, 509);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(55, 66);
            this.btn_apagar.TabIndex = 16;
            this.btn_apagar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(207, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 81);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inicio de sesion.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(93, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(333, 210);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(267, 26);
            this.txtID.TabIndex = 0;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(333, 272);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(267, 26);
            this.txtContrasena.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AllowDrop = true;
            this.btn_Ingresar.BackColor = System.Drawing.Color.White;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ingresar.Image")));
            this.btn_Ingresar.Location = new System.Drawing.Point(626, 222);
            this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(69, 66);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 599);
            this.panel2.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 590);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

