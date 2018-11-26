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
            this.txtIdClienteInvisible = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(-11, -11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 738);
            this.panel1.TabIndex = 22;
            // 
            // txtCorreoClienteAlxMayor
            // 
            this.txtCorreoClienteAlxMayor.Location = new System.Drawing.Point(626, 188);
            this.txtCorreoClienteAlxMayor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoClienteAlxMayor.Name = "txtCorreoClienteAlxMayor";
            this.txtCorreoClienteAlxMayor.Size = new System.Drawing.Size(276, 26);
            this.txtCorreoClienteAlxMayor.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(528, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Correo";
            // 
            // button1
            // 
            this.button1.Image = global::UI.Modapie.Properties.Resources.UndoRed48x48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(964, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 66);
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
            this.dgvData.Location = new System.Drawing.Point(39, 370);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1133, 332);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::UI.Modapie.Properties.Resources.Refresh_48x48;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(738, 296);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(190, 66);
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
            this.btnBorrar.Location = new System.Drawing.Point(512, 296);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(190, 66);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Cambiar estado";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCedulaClienteAlxMayor
            // 
            this.txtCedulaClienteAlxMayor.Location = new System.Drawing.Point(238, 138);
            this.txtCedulaClienteAlxMayor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedulaClienteAlxMayor.Name = "txtCedulaClienteAlxMayor";
            this.txtCedulaClienteAlxMayor.Size = new System.Drawing.Size(276, 26);
            this.txtCedulaClienteAlxMayor.TabIndex = 10;
            // 
            // btnEditarCAXM
            // 
            this.btnEditarCAXM.Image = global::UI.Modapie.Properties.Resources.Edit_48x48;
            this.btnEditarCAXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCAXM.Location = new System.Drawing.Point(286, 296);
            this.btnEditarCAXM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarCAXM.Name = "btnEditarCAXM";
            this.btnEditarCAXM.Size = new System.Drawing.Size(190, 66);
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
            this.label3.Location = new System.Drawing.Point(146, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cedula";
            // 
            // txtTelefonoClienteAlxMayor
            // 
            this.txtTelefonoClienteAlxMayor.Location = new System.Drawing.Point(626, 138);
            this.txtTelefonoClienteAlxMayor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoClienteAlxMayor.Name = "txtTelefonoClienteAlxMayor";
            this.txtTelefonoClienteAlxMayor.Size = new System.Drawing.Size(276, 26);
            this.txtTelefonoClienteAlxMayor.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Image = global::UI.Modapie.Properties.Resources.Registrar48x48;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(60, 296);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 66);
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
            this.label1.Location = new System.Drawing.Point(77, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Location = new System.Drawing.Point(535, 143);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(71, 20);
            this.l.TabIndex = 2;
            this.l.Text = "Telefono";
            // 
            // txtNombreClientealxMayor
            // 
            this.txtNombreClientealxMayor.Location = new System.Drawing.Point(238, 188);
            this.txtNombreClientealxMayor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreClientealxMayor.Name = "txtNombreClientealxMayor";
            this.txtNombreClientealxMayor.Size = new System.Drawing.Size(276, 26);
            this.txtNombreClientealxMayor.TabIndex = 1;
            // 
            // txtIdClienteInvisible
            // 
            this.txtIdClienteInvisible.Location = new System.Drawing.Point(855, 75);
            this.txtIdClienteInvisible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdClienteInvisible.Name = "txtIdClienteInvisible";
            this.txtIdClienteInvisible.Size = new System.Drawing.Size(115, 26);
            this.txtIdClienteInvisible.TabIndex = 24;
            this.txtIdClienteInvisible.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(955, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Estado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(1021, 166);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(149, 26);
            this.txtEstado.TabIndex = 26;
            // 
            // ClienteAlPorMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 706);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClienteAlPorMayor";
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