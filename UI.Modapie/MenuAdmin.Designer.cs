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
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientesPMa = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.btn_GIAXM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(69, 194);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(216, 26);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Gestion de productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientesPMa
            // 
            this.btnClientesPMa.Location = new System.Drawing.Point(392, 194);
            this.btnClientesPMa.Name = "btnClientesPMa";
            this.btnClientesPMa.Size = new System.Drawing.Size(178, 26);
            this.btnClientesPMa.TabIndex = 1;
            this.btnClientesPMa.Text = "Clientes al por mayor";
            this.btnClientesPMa.UseVisualStyleBackColor = true;
            this.btnClientesPMa.Click += new System.EventHandler(this.btnClientesPMa_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(392, 283);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(178, 26);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion de empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clientes al detalles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gestion de ventas al por mayor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "Gestion de Ventas al detalle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(392, 239);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(178, 26);
            this.btn_NuevoUsuario.TabIndex = 8;
            this.btn_NuevoUsuario.Text = "Registrar nuevo usuario";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = true;
            this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
            // 
            // btn_GIAXM
            // 
            this.btn_GIAXM.Location = new System.Drawing.Point(69, 239);
            this.btn_GIAXM.Name = "btn_GIAXM";
            this.btn_GIAXM.Size = new System.Drawing.Size(216, 26);
            this.btn_GIAXM.TabIndex = 9;
            this.btn_GIAXM.Text = "Gestion Inv. Al por mayor";
            this.btn_GIAXM.UseVisualStyleBackColor = true;
            this.btn_GIAXM.Click += new System.EventHandler(this.btn_GIAXM_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Modapie.Properties.Resources.MODAPIE___copia1;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btn_GIAXM);
            this.panel1.Controls.Add(this.btnClientesPMa);
            this.panel1.Controls.Add(this.btn_NuevoUsuario);
            this.panel1.Controls.Add(this.btnInformes);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 422);
            this.panel1.TabIndex = 12;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsername);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panel1.ResumeLayout(false);
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
    }
}