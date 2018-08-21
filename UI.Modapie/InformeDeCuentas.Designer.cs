namespace UI.Modapie
{
    partial class InformeDeCuentas
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
            this.btnInfXC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfXC
            // 
            this.btnInfXC.Location = new System.Drawing.Point(29, 39);
            this.btnInfXC.Name = "btnInfXC";
            this.btnInfXC.Size = new System.Drawing.Size(218, 67);
            this.btnInfXC.TabIndex = 0;
            this.btnInfXC.Text = "Informe de cuentas por cobrar";
            this.btnInfXC.UseVisualStyleBackColor = true;
            this.btnInfXC.Click += new System.EventHandler(this.btnInfXC_Click);
            // 
            // InformeDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 166);
            this.Controls.Add(this.btnInfXC);
            this.Name = "InformeDeCuentas";
            this.Text = "InformeDeCuentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfXC;
    }
}