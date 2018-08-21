namespace UI.Modapie
{
    partial class InfromedeVentasalxMayor
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
            this.btn_BuscarPorCliente = new System.Windows.Forms.Button();
            this.cmb_clientesAlxMayor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BuscarPorCliente
            // 
            this.btn_BuscarPorCliente.Location = new System.Drawing.Point(476, 83);
            this.btn_BuscarPorCliente.Name = "btn_BuscarPorCliente";
            this.btn_BuscarPorCliente.Size = new System.Drawing.Size(156, 38);
            this.btn_BuscarPorCliente.TabIndex = 0;
            this.btn_BuscarPorCliente.Text = "Buscar";
            this.btn_BuscarPorCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarPorCliente.Click += new System.EventHandler(this.btn_BuscarPorCliente_Click);
            // 
            // cmb_clientesAlxMayor
            // 
            this.cmb_clientesAlxMayor.FormattingEnabled = true;
            this.cmb_clientesAlxMayor.Location = new System.Drawing.Point(253, 89);
            this.cmb_clientesAlxMayor.Name = "cmb_clientesAlxMayor";
            this.cmb_clientesAlxMayor.Size = new System.Drawing.Size(202, 28);
            this.cmb_clientesAlxMayor.TabIndex = 1;
            this.cmb_clientesAlxMayor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Cliente";
            // 
            // InfromedeVentasalxMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_clientesAlxMayor);
            this.Controls.Add(this.btn_BuscarPorCliente);
            this.Name = "InfromedeVentasalxMayor";
            this.Text = "InfromedeVentasalxMayor";
            this.Load += new System.EventHandler(this.InfromedeVentasalxMayor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarPorCliente;
        private System.Windows.Forms.ComboBox cmb_clientesAlxMayor;
        private System.Windows.Forms.Label label1;
    }
}