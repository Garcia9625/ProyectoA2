﻿namespace UI.Modapie
{
    partial class frmVentaUsuario
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
            this.btnVentasDet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menú de Ventas";
            // 
            // btnVentasDet
            // 
            this.btnVentasDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentasDet.FlatAppearance.BorderSize = 0;
            this.btnVentasDet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVentasDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDet.Image = global::UI.Modapie.Properties.Resources.Shopping_Cart_128x128;
            this.btnVentasDet.Location = new System.Drawing.Point(235, 137);
            this.btnVentasDet.Name = "btnVentasDet";
            this.btnVentasDet.Size = new System.Drawing.Size(293, 221);
            this.btnVentasDet.TabIndex = 7;
            this.btnVentasDet.Text = "Venta al Detalle";
            this.btnVentasDet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentasDet.UseVisualStyleBackColor = true;
            // 
            // frmVentaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVentasDet);
            this.Name = "frmVentaUsuario";
            this.Text = "frmVentaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVentasDet;
    }
}