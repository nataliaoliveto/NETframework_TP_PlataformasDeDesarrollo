
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class AdminUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.panelAlojamientosGrid = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.labelAccion = new System.Windows.Forms.Label();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCancelarUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonConfirmarUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvModificarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvEliminarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvCambiarContrasenia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDesbloquearUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxPassDNI = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassNuevaRep = new System.Windows.Forms.TextBox();
            this.textBoxPassNueva = new System.Windows.Forms.TextBox();
            this.buttonCancelarPass = new System.Windows.Forms.Button();
            this.buttonConfirmarPass = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAlojamientosGrid.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlojamientosGrid
            // 
            this.panelAlojamientosGrid.Controls.Add(this.panelUsuario);
            this.panelAlojamientosGrid.Controls.Add(this.dataGridViewUsuarios);
            this.panelAlojamientosGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlojamientosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAlojamientosGrid.Location = new System.Drawing.Point(0, 0);
            this.panelAlojamientosGrid.Name = "panelAlojamientosGrid";
            this.panelAlojamientosGrid.Size = new System.Drawing.Size(1131, 587);
            this.panelAlojamientosGrid.TabIndex = 6;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.labelAccion);
            this.panelUsuario.Controls.Add(this.checkBoxAdmin);
            this.panelUsuario.Controls.Add(this.textBoxMail);
            this.panelUsuario.Controls.Add(this.textBoxNombre);
            this.panelUsuario.Controls.Add(this.buttonCancelarUsuario);
            this.panelUsuario.Controls.Add(this.button1);
            this.panelUsuario.Controls.Add(this.buttonConfirmarUsuario);
            this.panelUsuario.Controls.Add(this.button2);
            this.panelUsuario.Controls.Add(this.textBoxDNI);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUsuario.Location = new System.Drawing.Point(0, 519);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(1131, 68);
            this.panelUsuario.TabIndex = 22;
            // 
            // labelAccion
            // 
            this.labelAccion.AutoSize = true;
            this.labelAccion.Location = new System.Drawing.Point(884, 22);
            this.labelAccion.Name = "labelAccion";
            this.labelAccion.Size = new System.Drawing.Size(10, 15);
            this.labelAccion.TabIndex = 24;
            this.labelAccion.Text = "l";
            this.labelAccion.Visible = false;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxAdmin.Location = new System.Drawing.Point(745, 20);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(133, 19);
            this.checkBoxAdmin.TabIndex = 23;
            this.checkBoxAdmin.Text = "¿Es Administrador?";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMail.Location = new System.Drawing.Point(492, 19);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.PlaceholderText = "e-Mail";
            this.textBoxMail.Size = new System.Drawing.Size(214, 21);
            this.textBoxMail.TabIndex = 22;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(253, 18);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(214, 21);
            this.textBoxNombre.TabIndex = 21;
            // 
            // buttonCancelarUsuario
            // 
            this.buttonCancelarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelarUsuario.AutoSize = true;
            this.buttonCancelarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonCancelarUsuario.FlatAppearance.BorderSize = 0;
            this.buttonCancelarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelarUsuario.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelarUsuario.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.cancel;
            this.buttonCancelarUsuario.Location = new System.Drawing.Point(979, 19);
            this.buttonCancelarUsuario.Name = "buttonCancelarUsuario";
            this.buttonCancelarUsuario.Size = new System.Drawing.Size(30, 30);
            this.buttonCancelarUsuario.TabIndex = 20;
            this.buttonCancelarUsuario.UseVisualStyleBackColor = true;
            this.buttonCancelarUsuario.Click += new System.EventHandler(this.buttonAgregarAlojamientosCancelar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(1438, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmarUsuario
            // 
            this.buttonConfirmarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirmarUsuario.AutoSize = true;
            this.buttonConfirmarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonConfirmarUsuario.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonConfirmarUsuario.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.add;
            this.buttonConfirmarUsuario.Location = new System.Drawing.Point(929, 19);
            this.buttonConfirmarUsuario.Name = "buttonConfirmarUsuario";
            this.buttonConfirmarUsuario.Size = new System.Drawing.Size(44, 30);
            this.buttonConfirmarUsuario.TabIndex = 6;
            this.buttonConfirmarUsuario.UseVisualStyleBackColor = true;
            this.buttonConfirmarUsuario.Click += new System.EventHandler(this.buttonAlojamientoAgregar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button2.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.add;
            this.button2.Location = new System.Drawing.Point(1387, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 30);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDNI.Location = new System.Drawing.Point(19, 19);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.PlaceholderText = "DNI";
            this.textBoxDNI.Size = new System.Drawing.Size(214, 21);
            this.textBoxDNI.TabIndex = 8;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToResizeColumns = false;
            this.dataGridViewUsuarios.AllowUserToResizeRows = false;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDNI,
            this.dgvNombre,
            this.dgvemail,
            this.dgvEstadoUser,
            this.dgvEsAdmin,
            this.dgvModificarUsuario,
            this.dgvEliminarUsuario,
            this.dgvCambiarContrasenia,
            this.dgvDesbloquearUsuario});
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersWidth = 50;
            this.dataGridViewUsuarios.RowTemplate.Height = 25;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1131, 587);
            this.dataGridViewUsuarios.TabIndex = 0;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // dgvDNI
            // 
            this.dgvDNI.Frozen = true;
            this.dgvDNI.HeaderText = "DNI";
            this.dgvDNI.Name = "dgvDNI";
            this.dgvDNI.ReadOnly = true;
            this.dgvDNI.Width = 110;
            // 
            // dgvNombre
            // 
            this.dgvNombre.Frozen = true;
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            this.dgvNombre.Width = 200;
            // 
            // dgvemail
            // 
            this.dgvemail.Frozen = true;
            this.dgvemail.HeaderText = "e-mail";
            this.dgvemail.Name = "dgvemail";
            this.dgvemail.ReadOnly = true;
            this.dgvemail.Width = 200;
            // 
            // dgvEstadoUser
            // 
            this.dgvEstadoUser.Frozen = true;
            this.dgvEstadoUser.HeaderText = "Bloqueado";
            this.dgvEstadoUser.Name = "dgvEstadoUser";
            this.dgvEstadoUser.ReadOnly = true;
            this.dgvEstadoUser.Width = 90;
            // 
            // dgvEsAdmin
            // 
            this.dgvEsAdmin.Frozen = true;
            this.dgvEsAdmin.HeaderText = "Admin";
            this.dgvEsAdmin.Name = "dgvEsAdmin";
            this.dgvEsAdmin.ReadOnly = true;
            // 
            // dgvModificarUsuario
            // 
            this.dgvModificarUsuario.Frozen = true;
            this.dgvModificarUsuario.HeaderText = "Modificar";
            this.dgvModificarUsuario.Name = "dgvModificarUsuario";
            this.dgvModificarUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModificarUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvModificarUsuario.Width = 90;
            // 
            // dgvEliminarUsuario
            // 
            this.dgvEliminarUsuario.Frozen = true;
            this.dgvEliminarUsuario.HeaderText = "Eliminar";
            this.dgvEliminarUsuario.Name = "dgvEliminarUsuario";
            this.dgvEliminarUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEliminarUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvEliminarUsuario.Width = 90;
            // 
            // dgvCambiarContrasenia
            // 
            this.dgvCambiarContrasenia.Frozen = true;
            this.dgvCambiarContrasenia.HeaderText = "Cambiar Contraseña";
            this.dgvCambiarContrasenia.Name = "dgvCambiarContrasenia";
            // 
            // dgvDesbloquearUsuario
            // 
            this.dgvDesbloquearUsuario.Frozen = true;
            this.dgvDesbloquearUsuario.HeaderText = "Desbloquear";
            this.dgvDesbloquearUsuario.Name = "dgvDesbloquearUsuario";
            this.dgvDesbloquearUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesbloquearUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvDesbloquearUsuario.Width = 90;
            // 
            // textBoxPassDNI
            // 
            this.textBoxPassDNI.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassDNI.Enabled = false;
            this.textBoxPassDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassDNI.Location = new System.Drawing.Point(19, 19);
            this.textBoxPassDNI.Name = "textBoxPassDNI";
            this.textBoxPassDNI.PlaceholderText = "DNI";
            this.textBoxPassDNI.ReadOnly = true;
            this.textBoxPassDNI.Size = new System.Drawing.Size(214, 21);
            this.textBoxPassDNI.TabIndex = 8;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.textBoxPassNuevaRep);
            this.panelPassword.Controls.Add(this.textBoxPassNueva);
            this.panelPassword.Controls.Add(this.buttonCancelarPass);
            this.panelPassword.Controls.Add(this.buttonConfirmarPass);
            this.panelPassword.Controls.Add(this.textBoxPassDNI);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPassword.Location = new System.Drawing.Point(0, 593);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(1131, 68);
            this.panelPassword.TabIndex = 21;
            this.panelPassword.Visible = false;
            // 
            // textBoxPassNuevaRep
            // 
            this.textBoxPassNuevaRep.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassNuevaRep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassNuevaRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassNuevaRep.Location = new System.Drawing.Point(485, 19);
            this.textBoxPassNuevaRep.Name = "textBoxPassNuevaRep";
            this.textBoxPassNuevaRep.PasswordChar = '*';
            this.textBoxPassNuevaRep.PlaceholderText = "Repita Nueva Contraseña";
            this.textBoxPassNuevaRep.Size = new System.Drawing.Size(214, 21);
            this.textBoxPassNuevaRep.TabIndex = 26;
            // 
            // textBoxPassNueva
            // 
            this.textBoxPassNueva.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassNueva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassNueva.Location = new System.Drawing.Point(253, 19);
            this.textBoxPassNueva.Name = "textBoxPassNueva";
            this.textBoxPassNueva.PasswordChar = '*';
            this.textBoxPassNueva.PlaceholderText = "Ingrese Nueva Contraseña";
            this.textBoxPassNueva.Size = new System.Drawing.Size(214, 21);
            this.textBoxPassNueva.TabIndex = 25;
            // 
            // buttonCancelarPass
            // 
            this.buttonCancelarPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelarPass.AutoSize = true;
            this.buttonCancelarPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonCancelarPass.FlatAppearance.BorderSize = 0;
            this.buttonCancelarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelarPass.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelarPass.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.cancel;
            this.buttonCancelarPass.Location = new System.Drawing.Point(771, 14);
            this.buttonCancelarPass.Name = "buttonCancelarPass";
            this.buttonCancelarPass.Size = new System.Drawing.Size(30, 30);
            this.buttonCancelarPass.TabIndex = 24;
            this.buttonCancelarPass.UseVisualStyleBackColor = true;
            this.buttonCancelarPass.Click += new System.EventHandler(this.buttonCancelarPass_Click);
            // 
            // buttonConfirmarPass
            // 
            this.buttonConfirmarPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirmarPass.AutoSize = true;
            this.buttonConfirmarPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonConfirmarPass.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonConfirmarPass.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.add;
            this.buttonConfirmarPass.Location = new System.Drawing.Point(721, 14);
            this.buttonConfirmarPass.Name = "buttonConfirmarPass";
            this.buttonConfirmarPass.Size = new System.Drawing.Size(44, 30);
            this.buttonConfirmarPass.TabIndex = 23;
            this.buttonConfirmarPass.UseVisualStyleBackColor = true;
            this.buttonConfirmarPass.Click += new System.EventHandler(this.buttonConfirmarPass_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1131, 661);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelAlojamientosGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUsuarios";
            this.Text = "Precio x Día";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelAlojamientosGrid.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAlojamientosGrid;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonCancelarUsuario;
        private System.Windows.Forms.TextBox textBoxPassDNI;
        private System.Windows.Forms.Button buttonConfirmarUsuario;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button buttonCancelarPass;
        private System.Windows.Forms.Button buttonConfirmarPass;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.TextBox textBoxPassNuevaRep;
        private System.Windows.Forms.TextBox textBoxPassNueva;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEsAdmin;
        private System.Windows.Forms.DataGridViewButtonColumn dgvModificarUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn dgvEliminarUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCambiarContrasenia;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDesbloquearUsuario;
    }
}