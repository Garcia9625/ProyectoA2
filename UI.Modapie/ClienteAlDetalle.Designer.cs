namespace UI.Modapie
{
    partial class ClienteAlDetalle
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgvCAD = new System.Windows.Forms.DataGridView();
            this.btnMostrarCAD = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Modapie.Properties.Resources.MODAPIE2;
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Controls.Add(this.dgvCAD);
            this.panel1.Controls.Add(this.btnMostrarCAD);
            this.panel1.Controls.Add(this.btnEditarCliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 574);
            this.panel1.TabIndex = 21;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::UI.Modapie.Properties.Resources.Search32x32;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(572, 48);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(94, 50);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgvCAD
            // 
            this.dgvCAD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCAD.Location = new System.Drawing.Point(22, 356);
            this.dgvCAD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCAD.Name = "dgvCAD";
            this.dgvCAD.Size = new System.Drawing.Size(944, 204);
            this.dgvCAD.TabIndex = 16;
            this.dgvCAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCAD_CellContentClick);
            // 
            // btnMostrarCAD
            // 
            this.btnMostrarCAD.Image = global::UI.Modapie.Properties.Resources.Window_48x48;
            this.btnMostrarCAD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarCAD.Location = new System.Drawing.Point(531, 294);
            this.btnMostrarCAD.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarCAD.Name = "btnMostrarCAD";
            this.btnMostrarCAD.Size = new System.Drawing.Size(174, 50);
            this.btnMostrarCAD.TabIndex = 19;
            this.btnMostrarCAD.Text = "Mostrar Clientes";
            this.btnMostrarCAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarCAD.UseVisualStyleBackColor = true;
            this.btnMostrarCAD.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Image = global::UI.Modapie.Properties.Resources.Edit_48x48;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(304, 293);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(174, 50);
            this.btnEditarCliente.TabIndex = 18;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // button1
            // 
            this.button1.Image = global::UI.Modapie.Properties.Resources.UndoRed48x48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(758, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::UI.Modapie.Properties.Resources.Registrar48x48;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(77, 293);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(174, 50);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "Registrar Cliente";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(271, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(335, 62);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(225, 22);
            this.txtCedula.TabIndex = 1;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(229, 236);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(225, 22);
            this.txtApellido2.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(642, 236);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(225, 22);
            this.txtCorreo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(642, 195);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(225, 22);
            this.txtTelefono.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(80, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primer Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(543, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(80, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Segundo Apellido:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(642, 152);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(223, 22);
            this.txtCelular.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(543, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Correo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(229, 152);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(543, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Celular:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(229, 195);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(225, 22);
            this.txtApellido1.TabIndex = 10;
            // 
            // ClienteAlDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 573);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteAlDetalle";
            this.Text = "Gestión Cliente al Detalle";
            this.Load += new System.EventHandler(this.ClienteAlDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvCAD;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnMostrarCAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}