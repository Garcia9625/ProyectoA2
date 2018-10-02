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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfXC
            // 
            this.btnInfXC.Location = new System.Drawing.Point(180, 110);
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
            this.button1.Location = new System.Drawing.Point(488, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 42);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Modapie.Properties.Resources.MODAPIE2;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInfXC);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 198);
            this.panel1.TabIndex = 47;
            // 
            // InformeDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 184);
            this.Controls.Add(this.panel1);
            this.Name = "InformeDeCuentas";
            this.Text = "InformeDeCuentas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfXC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}