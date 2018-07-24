namespace UI.Modapie
{
    partial class ClienteAlPorMayor
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
            this.txtJuridico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFisico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre jurídico";
            // 
            // txtJuridico
            // 
            this.txtJuridico.Location = new System.Drawing.Point(153, 84);
            this.txtJuridico.Name = "txtJuridico";
            this.txtJuridico.Size = new System.Drawing.Size(246, 22);
            this.txtJuridico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Fantasía";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(598, 84);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(246, 22);
            this.txtFantasia.TabIndex = 3;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 195);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(852, 266);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(101, 161);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(117, 28);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(253, 161);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 28);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(405, 161);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(117, 28);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(665, 161);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 28);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre físico";
            // 
            // txtFisico
            // 
            this.txtFisico.Location = new System.Drawing.Point(598, 43);
            this.txtFisico.Name = "txtFisico";
            this.txtFisico.Size = new System.Drawing.Size(246, 22);
            this.txtFisico.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id Cliente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(246, 22);
            this.txtId.TabIndex = 12;
            // 
            // ClienteAlPorMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 474);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFisico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJuridico);
            this.Controls.Add(this.label1);
            this.Name = "ClienteAlPorMayor";
            this.Text = "ClienteAlPorMayor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClienteAlPorMayor_FormClosed);
            this.Load += new System.EventHandler(this.ClienteAlPorMayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJuridico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFisico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
    }
}