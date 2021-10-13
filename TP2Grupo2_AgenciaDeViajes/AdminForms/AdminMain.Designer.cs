
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class AdminMain
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
            this.panelMenuIzquierdo = new System.Windows.Forms.Panel();
            this.buttonDesconectarse = new System.Windows.Forms.Button();
            this.buttonReservas = new System.Windows.Forms.Button();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonAlojamientos = new System.Windows.Forms.Button();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAdminAlojamientos = new System.Windows.Forms.Panel();
            this.panelMenuIzquierdo.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuIzquierdo
            // 
            this.panelMenuIzquierdo.AutoScroll = true;
            this.panelMenuIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.panelMenuIzquierdo.Controls.Add(this.buttonDesconectarse);
            this.panelMenuIzquierdo.Controls.Add(this.buttonReservas);
            this.panelMenuIzquierdo.Controls.Add(this.buttonUsuarios);
            this.panelMenuIzquierdo.Controls.Add(this.buttonAlojamientos);
            this.panelMenuIzquierdo.Controls.Add(this.panelMenuLogo);
            this.panelMenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzquierdo.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelMenuIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzquierdo.Name = "panelMenuIzquierdo";
            this.panelMenuIzquierdo.Size = new System.Drawing.Size(153, 661);
            this.panelMenuIzquierdo.TabIndex = 0;
            this.panelMenuIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonDesconectarse
            // 
            this.buttonDesconectarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.buttonDesconectarse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDesconectarse.FlatAppearance.BorderSize = 0;
            this.buttonDesconectarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconectarse.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDesconectarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.buttonDesconectarse.Location = new System.Drawing.Point(0, 641);
            this.buttonDesconectarse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDesconectarse.Name = "buttonDesconectarse";
            this.buttonDesconectarse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDesconectarse.Size = new System.Drawing.Size(153, 20);
            this.buttonDesconectarse.TabIndex = 4;
            this.buttonDesconectarse.Text = "DESCONECTARSE";
            this.buttonDesconectarse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesconectarse.UseVisualStyleBackColor = false;
            this.buttonDesconectarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReservas
            // 
            this.buttonReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.buttonReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReservas.FlatAppearance.BorderSize = 0;
            this.buttonReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.buttonReservas.Location = new System.Drawing.Point(0, 220);
            this.buttonReservas.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReservas.Name = "buttonReservas";
            this.buttonReservas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonReservas.Size = new System.Drawing.Size(153, 40);
            this.buttonReservas.TabIndex = 3;
            this.buttonReservas.Text = "RESERVAS";
            this.buttonReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservas.UseVisualStyleBackColor = false;
            this.buttonReservas.Click += new System.EventHandler(this.buttonReservas_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.buttonUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsuarios.FlatAppearance.BorderSize = 0;
            this.buttonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.buttonUsuarios.Location = new System.Drawing.Point(0, 180);
            this.buttonUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonUsuarios.Size = new System.Drawing.Size(153, 40);
            this.buttonUsuarios.TabIndex = 2;
            this.buttonUsuarios.Text = "USUARIOS";
            this.buttonUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuarios.UseVisualStyleBackColor = false;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonAlojamientos
            // 
            this.buttonAlojamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.buttonAlojamientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlojamientos.FlatAppearance.BorderSize = 0;
            this.buttonAlojamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlojamientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.buttonAlojamientos.Location = new System.Drawing.Point(0, 140);
            this.buttonAlojamientos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAlojamientos.Name = "buttonAlojamientos";
            this.buttonAlojamientos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAlojamientos.Size = new System.Drawing.Size(153, 40);
            this.buttonAlojamientos.TabIndex = 1;
            this.buttonAlojamientos.Text = "ALOJAMIENTOS";
            this.buttonAlojamientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlojamientos.UseVisualStyleBackColor = false;
            this.buttonAlojamientos.Click += new System.EventHandler(this.buttonAlojamientos_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Controls.Add(this.pictureBox1);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(153, 140);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.alojamiento;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelAdminAlojamientos
            // 
            this.panelAdminAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminAlojamientos.Location = new System.Drawing.Point(153, 0);
            this.panelAdminAlojamientos.Name = "panelAdminAlojamientos";
            this.panelAdminAlojamientos.Size = new System.Drawing.Size(1131, 661);
            this.panelAdminAlojamientos.TabIndex = 1;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panelAdminAlojamientos);
            this.Controls.Add(this.panelMenuIzquierdo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travelinci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenuIzquierdo.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzquierdo;
        private System.Windows.Forms.Button buttonAlojamientos;
        private System.Windows.Forms.Panel panelMenuLogo;
        private System.Windows.Forms.Button buttonDesconectarse;
        private System.Windows.Forms.Button buttonReservas;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Panel panelAdminAlojamientos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

