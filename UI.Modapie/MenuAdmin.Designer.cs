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
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(214, 49);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClientesPMa
            // 
            this.btnClientesPMa.Location = new System.Drawing.Point(165, 115);
            this.btnClientesPMa.Name = "btnClientesPMa";
            this.btnClientesPMa.Size = new System.Drawing.Size(178, 23);
            this.btnClientesPMa.TabIndex = 1;
            this.btnClientesPMa.Text = "Clientes al por mayor";
            this.btnClientesPMa.UseVisualStyleBackColor = true;
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(214, 188);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(75, 23);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 260);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnClientesPMa);
            this.Controls.Add(this.btnProductos);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientesPMa;
        private System.Windows.Forms.Button btnInformes;
    }
}