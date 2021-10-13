
namespace TP2Grupo2_AgenciaDeViajes
{
    partial class UserReservas
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
            this.dataGridViewReservasUsuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvIDReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPropiedadReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDesdeReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHastaReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEliminarReserva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAlojamientosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlojamientosGrid
            // 
            this.panelAlojamientosGrid.Controls.Add(this.dataGridViewReservasUsuarios);
            this.panelAlojamientosGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlojamientosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAlojamientosGrid.Location = new System.Drawing.Point(0, 0);
            this.panelAlojamientosGrid.Name = "panelAlojamientosGrid";
            this.panelAlojamientosGrid.Size = new System.Drawing.Size(1131, 587);
            this.panelAlojamientosGrid.TabIndex = 6;
            // 
            // dataGridViewReservasUsuarios
            // 
            this.dataGridViewReservasUsuarios.AllowUserToResizeColumns = false;
            this.dataGridViewReservasUsuarios.AllowUserToResizeRows = false;
            this.dataGridViewReservasUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewReservasUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservasUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDReservas,
            this.dgvPropiedadReservas,
            this.dgvDesdeReservas,
            this.dgvHastaReservas,
            this.dgvCantPersonas,
            this.dgvPrecioReservas,
            this.dgvEliminarReserva});
            this.dataGridViewReservasUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.dataGridViewReservasUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReservasUsuarios.Name = "dataGridViewReservasUsuarios";
            this.dataGridViewReservasUsuarios.RowHeadersWidth = 50;
            this.dataGridViewReservasUsuarios.RowTemplate.Height = 25;
            this.dataGridViewReservasUsuarios.Size = new System.Drawing.Size(1119, 554);
            this.dataGridViewReservasUsuarios.TabIndex = 0;
            this.dataGridViewReservasUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservasUsuarios_CellContentClick);
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
            this.dgvCantPersonas.ReadOnly = true;
            // 
            // dgvPrecioReservas
            // 
            this.dgvPrecioReservas.Frozen = true;
            this.dgvPrecioReservas.HeaderText = "Precio";
            this.dgvPrecioReservas.Name = "dgvPrecioReservas";
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
            // UserReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1131, 661);
            this.Controls.Add(this.panelAlojamientosGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserReservas";
            this.Text = "Precio x Día";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelAlojamientosGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAlojamientosGrid;
        private System.Windows.Forms.DataGridView dataGridViewReservasUsuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPropiedadReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDesdeReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHastaReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioReservas;
        private System.Windows.Forms.DataGridViewButtonColumn dgvEliminarReserva;
    }
}