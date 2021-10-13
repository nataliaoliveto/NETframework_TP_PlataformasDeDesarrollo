
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelIntentos = new System.Windows.Forms.Label();
            this.labelFormatoInvalido = new System.Windows.Forms.Label();
            this.labelPasswordRepe = new System.Windows.Forms.Label();
            this.textBoxContraseniaRepe = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(290, 54);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.PlaceholderText = "DNI";
            this.textBoxDNI.Size = new System.Drawing.Size(199, 23);
            this.textBoxDNI.TabIndex = 0;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonConfirmar.Location = new System.Drawing.Point(290, 360);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(82, 26);
            this.buttonConfirmar.TabIndex = 1;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDNI.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelDNI.Location = new System.Drawing.Point(250, 57);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(29, 15);
            this.labelDNI.TabIndex = 2;
            this.labelDNI.Text = "DNI";
            this.labelDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelPassword.Location = new System.Drawing.Point(212, 225);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Contraseña";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContrasenia.Location = new System.Drawing.Point(290, 221);
            this.textBoxContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.PasswordChar = '*';
            this.textBoxContrasenia.PlaceholderText = "Contraseña";
            this.textBoxContrasenia.Size = new System.Drawing.Size(199, 23);
            this.textBoxContrasenia.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancelar.Location = new System.Drawing.Point(407, 360);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 26);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancel";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 415);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.alojamiento;
            this.pictureBox3.Location = new System.Drawing.Point(10, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // labelIntentos
            // 
            this.labelIntentos.AutoSize = true;
            this.labelIntentos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIntentos.ForeColor = System.Drawing.Color.Red;
            this.labelIntentos.Location = new System.Drawing.Point(290, 422);
            this.labelIntentos.Name = "labelIntentos";
            this.labelIntentos.Size = new System.Drawing.Size(0, 18);
            this.labelIntentos.TabIndex = 9;
            // 
            // labelFormatoInvalido
            // 
            this.labelFormatoInvalido.AutoSize = true;
            this.labelFormatoInvalido.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormatoInvalido.ForeColor = System.Drawing.Color.Red;
            this.labelFormatoInvalido.Location = new System.Drawing.Point(293, 87);
            this.labelFormatoInvalido.Name = "labelFormatoInvalido";
            this.labelFormatoInvalido.Size = new System.Drawing.Size(0, 18);
            this.labelFormatoInvalido.TabIndex = 10;
            // 
            // labelPasswordRepe
            // 
            this.labelPasswordRepe.AutoSize = true;
            this.labelPasswordRepe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordRepe.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelPasswordRepe.Location = new System.Drawing.Point(167, 282);
            this.labelPasswordRepe.Name = "labelPasswordRepe";
            this.labelPasswordRepe.Size = new System.Drawing.Size(114, 15);
            this.labelPasswordRepe.TabIndex = 12;
            this.labelPasswordRepe.Text = "Repetir Contraseña";
            this.labelPasswordRepe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxContraseniaRepe
            // 
            this.textBoxContraseniaRepe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContraseniaRepe.Location = new System.Drawing.Point(290, 278);
            this.textBoxContraseniaRepe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContraseniaRepe.Name = "textBoxContraseniaRepe";
            this.textBoxContraseniaRepe.PasswordChar = '*';
            this.textBoxContraseniaRepe.PlaceholderText = "Repetir Contraseña";
            this.textBoxContraseniaRepe.Size = new System.Drawing.Size(199, 23);
            this.textBoxContraseniaRepe.TabIndex = 11;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelNombre.Location = new System.Drawing.Point(228, 111);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(53, 15);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(290, 107);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(199, 23);
            this.textBoxNombre.TabIndex = 13;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMail.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelMail.Location = new System.Drawing.Point(247, 170);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(30, 15);
            this.labelMail.TabIndex = 16;
            this.labelMail.Text = "Mail";
            this.labelMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(290, 165);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.PlaceholderText = "Mail";
            this.textBoxMail.Size = new System.Drawing.Size(199, 23);
            this.textBoxMail.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(587, 415);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelPasswordRepe);
            this.Controls.Add(this.textBoxContraseniaRepe);
            this.Controls.Add(this.labelFormatoInvalido);
            this.Controls.Add(this.labelIntentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Label labelIntentos;
        private System.Windows.Forms.Button buttonContrasenia;
        private System.Windows.Forms.Label labelFormatoInvalido;
        private System.Windows.Forms.Label labelPasswordRepe;
        private System.Windows.Forms.TextBox textBoxContraseniaRepe;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

