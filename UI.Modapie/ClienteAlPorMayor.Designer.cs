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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdClienteInvisible = new System.Windows.Forms.TextBox();
            this.txtCorreoClienteAlxMayor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtCedulaClienteAlxMayor = new System.Windows.Forms.TextBox();
            this.btnEditarCAXM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoClienteAlxMayor = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.txtNombreClientealxMayor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Modapie.Properties.Resources.MODAPIECopia1;
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdClienteInvisible);
            this.panel1.Controls.Add(this.txtCorreoClienteAlxMayor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.txtCedulaClienteAlxMayor);
            this.panel1.Controls.Add(this.btnEditarCAXM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefonoClienteAlxMayor);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.txtNombreClientealxMayor);
            this.panel1.Location = new System.Drawing.Point(-8, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 479);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(679, 132);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(101, 20);
            this.txtEstado.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(635, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Estado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdClienteInvisible
            // 
            this.txtIdClienteInvisible.Location = new System.Drawing.Point(570, 49);
            this.txtIdClienteInvisible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdClienteInvisible.Name = "txtIdClienteInvisible";
            this.txtIdClienteInvisible.Size = new System.Drawing.Size(78, 20);
            this.txtIdClienteInvisible.TabIndex = 24;
            this.txtIdClienteInvisible.Visible = false;
            // 
            // txtCorreoClienteAlxMayor
            // 
            this.txtCorreoClienteAlxMayor.Location = new System.Drawing.Point(415, 146);
            this.txtCorreoClienteAlxMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoClienteAlxMayor.Name = "txtCorreoClienteAlxMayor";
            this.txtCorreoClienteAlxMayor.Size = new System.Drawing.Size(186, 20);
            this.txtCorreoClienteAlxMayor.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(350, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Correo";
            // 
            // button1
            // 
            this.button1.Image = global::UI.Modapie.Properties.Resources.UndoRed48x48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(643, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(26, 240);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(755, 216);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::UI.Modapie.Properties.Resources.Refresh_48x48;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(492, 193);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(127, 43);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::UI.Modapie.Properties.Resources.cancelar32x32;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(341, 193);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(127, 43);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Cambiar estado";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCedulaClienteAlxMayor
            // 
            this.txtCedulaClienteAlxMayor.Location = new System.Drawing.Point(157, 113);
            this.txtCedulaClienteAlxMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCedulaClienteAlxMayor.Name = "txtCedulaClienteAlxMayor";
            this.txtCedulaClienteAlxMayor.Size = new System.Drawing.Size(186, 20);
            this.txtCedulaClienteAlxMayor.TabIndex = 10;
            // 
            // btnEditarCAXM
            // 
            this.btnEditarCAXM.Image = global::UI.Modapie.Properties.Resources.Edit_48x48;
            this.btnEditarCAXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCAXM.Location = new System.Drawing.Point(190, 193);
            this.btnEditarCAXM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCAXM.Name = "btnEditarCAXM";
            this.btnEditarCAXM.Size = new System.Drawing.Size(127, 43);
            this.btnEditarCAXM.TabIndex = 6;
            this.btnEditarCAXM.Text = "Editar Cliente";
            this.btnEditarCAXM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCAXM.UseVisualStyleBackColor = true;
            this.btnEditarCAXM.Click += new System.EventHandler(this.btnEditarCAXM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cedula";
            // 
            // txtTelefonoClienteAlxMayor
            // 
            this.txtTelefonoClienteAlxMayor.Location = new System.Drawing.Point(415, 113);
            this.txtTelefonoClienteAlxMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoClienteAlxMayor.Name = "txtTelefonoClienteAlxMayor";
            this.txtTelefonoClienteAlxMayor.Size = new System.Drawing.Size(186, 20);
            this.txtTelefonoClienteAlxMayor.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Image = global::UI.Modapie.Properties.Resources.Registrar48x48;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(40, 193);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Registrar Cliente";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.IngresarClienteAlxMayor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Location = new System.Drawing.Point(347, 117);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(49, 13);
            this.l.TabIndex = 2;
            this.l.Text = "Telefono";
            // 
            // txtNombreClientealxMayor
            // 
            this.txtNombreClientealxMayor.Location = new System.Drawing.Point(157, 146);
            this.txtNombreClientealxMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreClientealxMayor.Name = "txtNombreClientealxMayor";
            this.txtNombreClientealxMayor.Size = new System.Drawing.Size(186, 20);
            this.txtNombreClientealxMayor.TabIndex = 1;
            // 
            // ClienteAlPorMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 459);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClienteAlPorMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteAlPorMayor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClienteAlPorMayor_FormClosed);
            this.Load += new System.EventHandler(this.ClienteAlPorMayor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreClientealxMayor;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtTelefonoClienteAlxMayor;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaClienteAlxMayor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCorreoClienteAlxMayor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarCAXM;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtIdClienteInvisible;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
    }
}