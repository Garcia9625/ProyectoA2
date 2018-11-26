namespace UI.Modapie
{
    partial class frmEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVentasDet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú de Empleados";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::UI.Modapie.Properties.Resources.User_128x128;
            this.button2.Location = new System.Drawing.Point(388, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 221);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gestión de Usuarios";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVentasDet
            // 
            this.btnVentasDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentasDet.FlatAppearance.BorderSize = 0;
            this.btnVentasDet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVentasDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDet.Image = global::UI.Modapie.Properties.Resources.empleado;
            this.btnVentasDet.Location = new System.Drawing.Point(78, 107);
            this.btnVentasDet.Name = "btnVentasDet";
            this.btnVentasDet.Size = new System.Drawing.Size(293, 221);
            this.btnVentasDet.TabIndex = 2;
            this.btnVentasDet.Text = "Gestión de empleados";
            this.btnVentasDet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentasDet.UseVisualStyleBackColor = true;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVentasDet);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVentasDet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}