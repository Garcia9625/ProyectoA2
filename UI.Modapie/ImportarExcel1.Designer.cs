namespace UI.Modapie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarExcel1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_ImportExcel = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_ImportExcel
            // 
            this.BTN_ImportExcel.Location = new System.Drawing.Point(778, 384);
            this.BTN_ImportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ImportExcel.Name = "BTN_ImportExcel";
            this.BTN_ImportExcel.Size = new System.Drawing.Size(212, 59);
            this.BTN_ImportExcel.TabIndex = 1;
            this.BTN_ImportExcel.Text = "Importar";
            this.BTN_ImportExcel.UseVisualStyleBackColor = true;
            this.BTN_ImportExcel.Click += new System.EventHandler(this.BTN_ImportExcel_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(783, 468);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(206, 62);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 42);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ImportarExcel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 550);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}