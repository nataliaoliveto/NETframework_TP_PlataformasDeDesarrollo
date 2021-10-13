
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class UserPerfil
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
            this.panelAlojamientosGrid = new System.Windows.Forms.Panel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.textBoxPassDNI = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassNuevaRep = new System.Windows.Forms.TextBox();
            this.textBoxPassNueva = new System.Windows.Forms.TextBox();
            this.buttonCancelarPass = new System.Windows.Forms.Button();
            this.buttonConfirmarPass = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.dgvDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCambiarContrasenia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAlojamientosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlojamientosGrid
            // 
            this.panelAlojamientosGrid.Controls.Add(this.dataGridViewUsuarios);
            this.panelAlojamientosGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlojamientosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAlojamientosGrid.Location = new System.Drawing.Point(0, 0);
            this.panelAlojamientosGrid.Name = "panelAlojamientosGrid";
            this.panelAlojamientosGrid.Size = new System.Drawing.Size(1131, 587);
            this.panelAlojamientosGrid.TabIndex = 6;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToResizeColumns = false;
            this.dataGridViewUsuarios.AllowUserToResizeRows = false;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDNI,
            this.dgvUserName,
            this.dgvemail,
            this.dgvEstadoUser,
            this.dgvEsAdmin,
            this.dgvCambiarContrasenia});
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
            this.panelPassword.Controls.Add(this.textBoxPass);
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
            this.textBoxPassNuevaRep.Location = new System.Drawing.Point(724, 21);
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
            this.textBoxPassNueva.Location = new System.Drawing.Point(492, 21);
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
            this.buttonCancelarPass.Location = new System.Drawing.Point(1030, 19);
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
            this.buttonConfirmarPass.Location = new System.Drawing.Point(980, 19);
            this.buttonConfirmarPass.Name = "buttonConfirmarPass";
            this.buttonConfirmarPass.Size = new System.Drawing.Size(44, 30);
            this.buttonConfirmarPass.TabIndex = 23;
            this.buttonConfirmarPass.UseVisualStyleBackColor = true;
            this.buttonConfirmarPass.Click += new System.EventHandler(this.buttonConfirmarPass_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass.Location = new System.Drawing.Point(253, 20);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.PlaceholderText = "Ingrese Contraseña";
            this.textBoxPass.Size = new System.Drawing.Size(214, 21);
            this.textBoxPass.TabIndex = 21;
            // 
            // dgvDNI
            // 
            this.dgvDNI.Frozen = true;
            this.dgvDNI.HeaderText = "DNI";
            this.dgvDNI.Name = "dgvDNI";
            this.dgvDNI.ReadOnly = true;
            this.dgvDNI.Width = 110;
            // 
            // dgvUserName
            // 
            this.dgvUserName.Frozen = true;
            this.dgvUserName.HeaderText = "Nombre";
            this.dgvUserName.Name = "dgvUserName";
            this.dgvUserName.ReadOnly = true;
            this.dgvUserName.Width = 200;
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
            // dgvCambiarContrasenia
            // 
            this.dgvCambiarContrasenia.Frozen = true;
            this.dgvCambiarContrasenia.HeaderText = "Cambiar Contraseña";
            this.dgvCambiarContrasenia.Name = "dgvCambiarContrasenia";
            // 
            // UserPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1131, 661);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelAlojamientosGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPerfil";
            this.Text = "Precio x Día";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelAlojamientosGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAlojamientosGrid;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TextBox textBoxPassDNI;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonCancelarPass;
        private System.Windows.Forms.Button buttonConfirmarPass;
        private System.Windows.Forms.TextBox textBoxPassNuevaRep;
        private System.Windows.Forms.TextBox textBoxPassNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEsAdmin;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCambiarContrasenia;
    }
}