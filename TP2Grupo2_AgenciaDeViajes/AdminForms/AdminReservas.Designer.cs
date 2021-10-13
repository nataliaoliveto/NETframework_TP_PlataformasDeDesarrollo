
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class AdminReservas
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
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panelAgregarReservas = new System.Windows.Forms.Panel();
            this.textBoxCantPersonas = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelAccion = new System.Windows.Forms.Label();
            this.textBoxPersonaReserva = new System.Windows.Forms.TextBox();
            this.textBoxPropiedadRerserva = new System.Windows.Forms.TextBox();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.dateTimePickerFHasta = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.dateTimePickerFDesde = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvIDReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPropiedadReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPersonaReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDesdeReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHastaReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvModificarReserva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvEliminarReserva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAlojamientosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.panelAgregarReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlojamientosGrid
            // 
            this.panelAlojamientosGrid.Controls.Add(this.dataGridViewReservas);
            this.panelAlojamientosGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlojamientosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAlojamientosGrid.Location = new System.Drawing.Point(0, 0);
            this.panelAlojamientosGrid.Name = "panelAlojamientosGrid";
            this.panelAlojamientosGrid.Size = new System.Drawing.Size(1131, 587);
            this.panelAlojamientosGrid.TabIndex = 6;
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToResizeColumns = false;
            this.dataGridViewReservas.AllowUserToResizeRows = false;
            this.dataGridViewReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDReservas,
            this.dgvPropiedadReservas,
            this.dgvPersonaReservas,
            this.dgvDesdeReservas,
            this.dgvHastaReservas,
            this.dgvCantPersonas,
            this.dgvPrecioReservas,
            this.dgvModificarReserva,
            this.dgvEliminarReserva});
            this.dataGridViewReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewReservas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.RowHeadersWidth = 50;
            this.dataGridViewReservas.RowTemplate.Height = 25;
            this.dataGridViewReservas.Size = new System.Drawing.Size(1119, 554);
            this.dataGridViewReservas.TabIndex = 0;
            this.dataGridViewReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellContentClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(1056, 35);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(30, 30);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonAgregarAlojamientosCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirmar.AutoSize = true;
            this.buttonConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.buttonConfirmar.Image = global::TP2Grupo2_AgenciaDeViajes.Properties.Resources.add;
            this.buttonConfirmar.Location = new System.Drawing.Point(1005, 34);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(44, 30);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonAlojamientoAgregar_Click);
            // 
            // panelAgregarReservas
            // 
            this.panelAgregarReservas.Controls.Add(this.textBoxCantPersonas);
            this.panelAgregarReservas.Controls.Add(this.textBoxId);
            this.panelAgregarReservas.Controls.Add(this.labelAccion);
            this.panelAgregarReservas.Controls.Add(this.textBoxPersonaReserva);
            this.panelAgregarReservas.Controls.Add(this.textBoxPropiedadRerserva);
            this.panelAgregarReservas.Controls.Add(this.labelFechaHasta);
            this.panelAgregarReservas.Controls.Add(this.dateTimePickerFHasta);
            this.panelAgregarReservas.Controls.Add(this.labelFechaDesde);
            this.panelAgregarReservas.Controls.Add(this.dateTimePickerFDesde);
            this.panelAgregarReservas.Controls.Add(this.buttonCancelar);
            this.panelAgregarReservas.Controls.Add(this.buttonConfirmar);
            this.panelAgregarReservas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAgregarReservas.Location = new System.Drawing.Point(0, 560);
            this.panelAgregarReservas.Name = "panelAgregarReservas";
            this.panelAgregarReservas.Size = new System.Drawing.Size(1131, 101);
            this.panelAgregarReservas.TabIndex = 21;
            this.panelAgregarReservas.Visible = false;
            // 
            // textBoxCantPersonas
            // 
            this.textBoxCantPersonas.Location = new System.Drawing.Point(793, 42);
            this.textBoxCantPersonas.Name = "textBoxCantPersonas";
            this.textBoxCantPersonas.PlaceholderText = "Cant. Personas";
            this.textBoxCantPersonas.Size = new System.Drawing.Size(140, 23);
            this.textBoxCantPersonas.TabIndex = 32;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(73, 40);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PlaceholderText = "Id";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(140, 23);
            this.textBoxId.TabIndex = 31;
            // 
            // labelAccion
            // 
            this.labelAccion.AutoSize = true;
            this.labelAccion.Location = new System.Drawing.Point(613, 43);
            this.labelAccion.Name = "labelAccion";
            this.labelAccion.Size = new System.Drawing.Size(10, 15);
            this.labelAccion.TabIndex = 30;
            this.labelAccion.Text = "l";
            this.labelAccion.Visible = false;
            // 
            // textBoxPersonaReserva
            // 
            this.textBoxPersonaReserva.Location = new System.Drawing.Point(637, 42);
            this.textBoxPersonaReserva.Name = "textBoxPersonaReserva";
            this.textBoxPersonaReserva.PlaceholderText = "Persona";
            this.textBoxPersonaReserva.Size = new System.Drawing.Size(140, 23);
            this.textBoxPersonaReserva.TabIndex = 28;
            // 
            // textBoxPropiedadRerserva
            // 
            this.textBoxPropiedadRerserva.Location = new System.Drawing.Point(463, 42);
            this.textBoxPropiedadRerserva.Name = "textBoxPropiedadRerserva";
            this.textBoxPropiedadRerserva.PlaceholderText = "Propiedad";
            this.textBoxPropiedadRerserva.Size = new System.Drawing.Size(140, 23);
            this.textBoxPropiedadRerserva.TabIndex = 27;
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFechaHasta.Location = new System.Drawing.Point(348, 20);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(37, 15);
            this.labelFechaHasta.TabIndex = 26;
            this.labelFechaHasta.Text = "Hasta";
            // 
            // dateTimePickerFHasta
            // 
            this.dateTimePickerFHasta.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerFHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFHasta.Location = new System.Drawing.Point(347, 41);
            this.dateTimePickerFHasta.Name = "dateTimePickerFHasta";
            this.dateTimePickerFHasta.Size = new System.Drawing.Size(96, 23);
            this.dateTimePickerFHasta.TabIndex = 25;
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFechaDesde.Location = new System.Drawing.Point(231, 20);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(39, 15);
            this.labelFechaDesde.TabIndex = 24;
            this.labelFechaDesde.Text = "Desde";
            // 
            // dateTimePickerFDesde
            // 
            this.dateTimePickerFDesde.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerFDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFDesde.Location = new System.Drawing.Point(230, 41);
            this.dateTimePickerFDesde.Name = "dateTimePickerFDesde";
            this.dateTimePickerFDesde.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerFDesde.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvIDReservas
            // 
            this.dgvIDReservas.Frozen = true;
            this.dgvIDReservas.HeaderText = "ID";
            this.dgvIDReservas.Name = "dgvIDReservas";
            this.dgvIDReservas.Width = 60;
            // 
            // dgvPropiedadReservas
            // 
            this.dgvPropiedadReservas.Frozen = true;
            this.dgvPropiedadReservas.HeaderText = "Propiedad";
            this.dgvPropiedadReservas.Name = "dgvPropiedadReservas";
            this.dgvPropiedadReservas.Width = 200;
            // 
            // dgvPersonaReservas
            // 
            this.dgvPersonaReservas.Frozen = true;
            this.dgvPersonaReservas.HeaderText = "Persona";
            this.dgvPersonaReservas.Name = "dgvPersonaReservas";
            this.dgvPersonaReservas.Width = 200;
            // 
            // dgvDesdeReservas
            // 
            this.dgvDesdeReservas.Frozen = true;
            this.dgvDesdeReservas.HeaderText = "Desde";
            this.dgvDesdeReservas.Name = "dgvDesdeReservas";
            // 
            // dgvHastaReservas
            // 
            this.dgvHastaReservas.Frozen = true;
            this.dgvHastaReservas.HeaderText = "Hasta";
            this.dgvHastaReservas.Name = "dgvHastaReservas";
            // 
            // dgvCantPersonas
            // 
            this.dgvCantPersonas.Frozen = true;
            this.dgvCantPersonas.HeaderText = "Cant. Personas";
            this.dgvCantPersonas.Name = "dgvCantPersonas";
            // 
            // dgvPrecioReservas
            // 
            this.dgvPrecioReservas.Frozen = true;
            this.dgvPrecioReservas.HeaderText = "Precio";
            this.dgvPrecioReservas.Name = "dgvPrecioReservas";
            // 
            // dgvModificarReserva
            // 
            this.dgvModificarReserva.Frozen = true;
            this.dgvModificarReserva.HeaderText = "Modificar";
            this.dgvModificarReserva.Name = "dgvModificarReserva";
            this.dgvModificarReserva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModificarReserva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvModificarReserva.Width = 90;
            // 
            // dgvEliminarReserva
            // 
            this.dgvEliminarReserva.Frozen = true;
            this.dgvEliminarReserva.HeaderText = "Eliminar";
            this.dgvEliminarReserva.Name = "dgvEliminarReserva";
            this.dgvEliminarReserva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEliminarReserva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvEliminarReserva.Width = 90;
            // 
            // AdminReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1131, 661);
            this.Controls.Add(this.panelAgregarReservas);
            this.Controls.Add(this.panelAlojamientosGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminReservas";
            this.Text = "Precio x Día";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelAlojamientosGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.panelAgregarReservas.ResumeLayout(false);
            this.panelAgregarReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAlojamientosGrid;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Panel panelAgregarReservas;
        private System.Windows.Forms.TextBox textBoxPersonaReserva;
        private System.Windows.Forms.TextBox textBoxPropiedadRerserva;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFHasta;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDesde;
        private System.Windows.Forms.Label labelAccion;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPropiedadReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPersonaReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDesdeReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHastaReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioReservas;
        private System.Windows.Forms.DataGridViewButtonColumn dgvModificarReserva;
        private System.Windows.Forms.DataGridViewButtonColumn dgvEliminarReserva;
    }
}