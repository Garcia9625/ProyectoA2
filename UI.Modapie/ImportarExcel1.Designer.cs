﻿namespace UI.Modapie
{
    partial class ImportarExcel1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_ImportExcel = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_ImportExcel
            // 
            this.BTN_ImportExcel.Location = new System.Drawing.Point(875, 480);
            this.BTN_ImportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ImportExcel.Name = "BTN_ImportExcel";
            this.BTN_ImportExcel.Size = new System.Drawing.Size(238, 74);
            this.BTN_ImportExcel.TabIndex = 1;
            this.BTN_ImportExcel.Text = "Importar";
            this.BTN_ImportExcel.UseVisualStyleBackColor = true;
            this.BTN_ImportExcel.Click += new System.EventHandler(this.BTN_ImportExcel_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(881, 585);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(232, 78);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // ImportarExcel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 687);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.BTN_ImportExcel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImportarExcel1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ImportarExcel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_ImportExcel;
        private System.Windows.Forms.Button btn_Guardar;
    }
}