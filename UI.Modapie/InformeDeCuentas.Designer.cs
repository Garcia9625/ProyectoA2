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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeDeCuentas));
            this.btnInfXC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(321, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 42);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InformeDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInfXC);
            this.Name = "InformeDeCuentas";
            this.Text = "InformeDeCuentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfXC;
        private System.Windows.Forms.Button button1;
    }
}