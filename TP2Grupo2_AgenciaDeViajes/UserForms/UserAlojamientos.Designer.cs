
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class UserAlojamientos
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
            this.dataGridViewAlojamientos = new System.Windows.Forms.DataGridView();
            this.buttonAlojamientoAgregar = new System.Windows.Forms.Button();
            this.panelAgregarAlojamientos = new System.Windows.Forms.Panel();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxCantPersonas = new System.Windows.Forms.TextBox();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.dateTimePickerFHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFDesde = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoAlojamiento = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHotelPrecioxPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCabaniaPrecioxDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCabaniaCantHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCabaniaCantBanios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAlojamientosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlojamientos)).BeginInit();
            this.panelAgregarAlojamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlojamientosGrid
            // 
            this.panelAlojamientosGrid.Controls.Add(this.dataGridViewAlojamientos);
            this.panelAlojamientosGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlojamientosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAlojamientosGrid.Location = new System.Drawing.Point(0, 0);
            this.panelAlojamientosGrid.Name = "panelAlojamientosGrid";
            this.panelAlojamientosGrid.Size = new System.Drawing.Size(1131, 572);
            this.panelAlojamientosGrid.TabIndex = 6;
            // 
            // dataGridViewAlojamientos
            // 
            this.dataGridViewAlojamientos.AllowUserToResizeColumns = false;
            this.dataGridViewAlojamientos.AllowUserToResizeRows = false;
            this.dataGridViewAlojamientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCódigo,
            this.dgvTipoAlojamiento,
            this.dgvCiudad,
            this.dgvBarrio,
            this.dgvEstrellas,
            this.dgvCantPersonas,
            this.dgvTV,
            this.dgvHotelPrecioxPersona,
            this.dgvCabaniaPrecioxDia,
            this.dgvCabaniaCantHabitaciones,
            this.dgvCabaniaCantBanios,
            this.dgvReservar});
            this.dataGridViewAlojamientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewAlojamientos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAlojamientos.Name = "dataGridViewAlojamientos";
            this.dataGridViewAlojamientos.RowHeadersWidth = 50;
            this.dataGridViewAlojamientos.RowTemplate.Height = 25;
            this.dataGridViewAlojamientos.Size = new System.Drawing.Size(1131, 572);
            this.dataGridViewAlojamientos.TabIndex = 0;
            this.dataGridViewAlojamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlojamientos_CellContentClick);
            // 
            // buttonAlojamientoAgregar
            // 
            this.buttonAlojamientoAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAlojamientoAgregar.AutoSize = true;
            this.buttonAlojamientoAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonAlojamientoAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAlojamientoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlojamientoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAlojamientoAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonAlojamientoAgregar.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.add;
            this.buttonAlojamientoAgregar.Location = new System.Drawing.Point(891, 35);
            this.buttonAlojamientoAgregar.Name = "buttonAlojamientoAgregar";
            this.buttonAlojamientoAgregar.Size = new System.Drawing.Size(44, 30);
            this.buttonAlojamientoAgregar.TabIndex = 6;
            this.buttonAlojamientoAgregar.UseVisualStyleBackColor = true;
            this.buttonAlojamientoAgregar.Click += new System.EventHandler(this.buttonAlojamientoAgregar_Click);
            // 
            // panelAgregarAlojamientos
            // 
            this.panelAgregarAlojamientos.Controls.Add(this.textBoxCiudad);
            this.panelAgregarAlojamientos.Controls.Add(this.buttonCancelar);
            this.panelAgregarAlojamientos.Controls.Add(this.textBoxCantPersonas);
            this.panelAgregarAlojamientos.Controls.Add(this.labelFechaHasta);
            this.panelAgregarAlojamientos.Controls.Add(this.labelFechaDesde);
            this.panelAgregarAlojamientos.Controls.Add(this.dateTimePickerFHasta);
            this.panelAgregarAlojamientos.Controls.Add(this.dateTimePickerFDesde);
            this.panelAgregarAlojamientos.Controls.Add(this.comboBoxTipoAlojamiento);
            this.panelAgregarAlojamientos.Controls.Add(this.buttonAlojamientoAgregar);
            this.panelAgregarAlojamientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAgregarAlojamientos.Location = new System.Drawing.Point(0, 578);
            this.panelAgregarAlojamientos.Name = "panelAgregarAlojamientos";
            this.panelAgregarAlojamientos.Size = new System.Drawing.Size(1131, 83);
            this.panelAgregarAlojamientos.TabIndex = 21;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCiudad.Location = new System.Drawing.Point(147, 42);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.PlaceholderText = "Ciudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(145, 21);
            this.textBoxCiudad.TabIndex = 31;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonCancelar.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(932, 35);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(44, 30);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCantPersonas
            // 
            this.textBoxCantPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCantPersonas.Location = new System.Drawing.Point(577, 40);
            this.textBoxCantPersonas.Name = "textBoxCantPersonas";
            this.textBoxCantPersonas.PlaceholderText = "Cantidad Personas";
            this.textBoxCantPersonas.Size = new System.Drawing.Size(145, 21);
            this.textBoxCantPersonas.TabIndex = 28;
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFechaHasta.Location = new System.Drawing.Point(448, 17);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(37, 15);
            this.labelFechaHasta.TabIndex = 26;
            this.labelFechaHasta.Text = "Hasta";
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFechaDesde.Location = new System.Drawing.Point(317, 21);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(39, 15);
            this.labelFechaDesde.TabIndex = 25;
            this.labelFechaDesde.Text = "Desde";
            // 
            // dateTimePickerFHasta
            // 
            this.dateTimePickerFHasta.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerFHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFHasta.Location = new System.Drawing.Point(448, 40);
            this.dateTimePickerFHasta.Name = "dateTimePickerFHasta";
            this.dateTimePickerFHasta.Size = new System.Drawing.Size(94, 23);
            this.dateTimePickerFHasta.TabIndex = 24;
            // 
            // dateTimePickerFDesde
            // 
            this.dateTimePickerFDesde.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerFDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFDesde.Location = new System.Drawing.Point(317, 40);
            this.dateTimePickerFDesde.Name = "dateTimePickerFDesde";
            this.dateTimePickerFDesde.Size = new System.Drawing.Size(96, 23);
            this.dateTimePickerFDesde.TabIndex = 23;
            // 
            // comboBoxTipoAlojamiento
            // 
            this.comboBoxTipoAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipoAlojamiento.FormattingEnabled = true;
            this.comboBoxTipoAlojamiento.Items.AddRange(new object[] {
            "Ambos",
            "Hotel",
            "Cabaña"});
            this.comboBoxTipoAlojamiento.Location = new System.Drawing.Point(757, 39);
            this.comboBoxTipoAlojamiento.Name = "comboBoxTipoAlojamiento";
            this.comboBoxTipoAlojamiento.Size = new System.Drawing.Size(95, 23);
            this.comboBoxTipoAlojamiento.TabIndex = 22;
            this.comboBoxTipoAlojamiento.Text = "Ambos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvCódigo
            // 
            this.dgvCódigo.Frozen = true;
            this.dgvCódigo.HeaderText = "Código";
            this.dgvCódigo.Name = "dgvCódigo";
            // 
            // dgvTipoAlojamiento
            // 
            this.dgvTipoAlojamiento.Frozen = true;
            this.dgvTipoAlojamiento.HeaderText = "Tipo de Alojamiento";
            this.dgvTipoAlojamiento.Name = "dgvTipoAlojamiento";
            this.dgvTipoAlojamiento.Width = 90;
            // 
            // dgvCiudad
            // 
            this.dgvCiudad.Frozen = true;
            this.dgvCiudad.HeaderText = "Ciudad";
            this.dgvCiudad.Name = "dgvCiudad";
            this.dgvCiudad.Width = 130;
            // 
            // dgvBarrio
            // 
            this.dgvBarrio.Frozen = true;
            this.dgvBarrio.HeaderText = "Barrio";
            this.dgvBarrio.Name = "dgvBarrio";
            this.dgvBarrio.Width = 105;
            // 
            // dgvEstrellas
            // 
            this.dgvEstrellas.Frozen = true;
            this.dgvEstrellas.HeaderText = "Estrellas";
            this.dgvEstrellas.Name = "dgvEstrellas";
            this.dgvEstrellas.Width = 60;
            // 
            // dgvCantPersonas
            // 
            this.dgvCantPersonas.Frozen = true;
            this.dgvCantPersonas.HeaderText = "Cantidad de Personas";
            this.dgvCantPersonas.Name = "dgvCantPersonas";
            this.dgvCantPersonas.Width = 70;
            // 
            // dgvTV
            // 
            this.dgvTV.Frozen = true;
            this.dgvTV.HeaderText = "TV";
            this.dgvTV.Name = "dgvTV";
            this.dgvTV.Width = 40;
            // 
            // dgvHotelPrecioxPersona
            // 
            this.dgvHotelPrecioxPersona.Frozen = true;
            this.dgvHotelPrecioxPersona.HeaderText = "Hotel Precio por Persona";
            this.dgvHotelPrecioxPersona.Name = "dgvHotelPrecioxPersona";
            this.dgvHotelPrecioxPersona.Width = 130;
            // 
            // dgvCabaniaPrecioxDia
            // 
            this.dgvCabaniaPrecioxDia.Frozen = true;
            this.dgvCabaniaPrecioxDia.HeaderText = "Cabaña Precio por Dia";
            this.dgvCabaniaPrecioxDia.Name = "dgvCabaniaPrecioxDia";
            this.dgvCabaniaPrecioxDia.Width = 90;
            // 
            // dgvCabaniaCantHabitaciones
            // 
            this.dgvCabaniaCantHabitaciones.Frozen = true;
            this.dgvCabaniaCantHabitaciones.HeaderText = "Cabaña Cantidad Habitaciones";
            this.dgvCabaniaCantHabitaciones.Name = "dgvCabaniaCantHabitaciones";
            this.dgvCabaniaCantHabitaciones.Width = 85;
            // 
            // dgvCabaniaCantBanios
            // 
            this.dgvCabaniaCantBanios.Frozen = true;
            this.dgvCabaniaCantBanios.HeaderText = "Cabaña Cantidad Baños";
            this.dgvCabaniaCantBanios.Name = "dgvCabaniaCantBanios";
            this.dgvCabaniaCantBanios.Width = 85;
            // 
            // dgvReservar
            // 
            this.dgvReservar.Frozen = true;
            this.dgvReservar.HeaderText = "Reservar";
            this.dgvReservar.Name = "dgvReservar";
            this.dgvReservar.Width = 70;
            // 
            // UserAlojamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1131, 661);
            this.Controls.Add(this.panelAgregarAlojamientos);
            this.Controls.Add(this.panelAlojamientosGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UserAlojamientos";
            this.Text = "Precio x Día";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelAlojamientosGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlojamientos)).EndInit();
            this.panelAgregarAlojamientos.ResumeLayout(false);
            this.panelAgregarAlojamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAlojamientosGrid;
        private System.Windows.Forms.DataGridView dataGridViewAlojamientos;
        private System.Windows.Forms.Button buttonAlojamientoAgregar;
        private System.Windows.Forms.Panel panelAgregarAlojamientos;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerFHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDesde;
        private System.Windows.Forms.ComboBox comboBoxTipoAlojamiento;
        private System.Windows.Forms.TextBox textBoxCantPersonas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHotelPrecioxPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCabaniaPrecioxDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCabaniaCantHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCabaniaCantBanios;
        private System.Windows.Forms.DataGridViewButtonColumn dgvReservar;
    }
}