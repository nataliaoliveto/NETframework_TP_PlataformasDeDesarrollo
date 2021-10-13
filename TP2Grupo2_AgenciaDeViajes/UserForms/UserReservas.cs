using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TP2Grupo2_AgenciaDeViajes.Clases;


namespace TP2Grupo2_AgenciaDeViajes
{

    public partial class UserReservas : Form
    {

        private AgenciaManager agenciaManager;
        private int indexRow;
        private Usuario usuario;
        private string idioma;

        public UserReservas(AgenciaManager agenciaManager, Usuario usuario, string idioma)
        {
            this.agenciaManager = agenciaManager;
            this.usuario = usuario;
            this.idioma = idioma;
            InitializeComponent();
            setIdioma();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populateDGVReservas(usuario.DNI);
            estilarDGVReservas();
        }

        private void populateDGVReservas(int dni)
        {
            dataGridViewReservasUsuarios.Rows.Clear();
            string[][] rows = agenciaManager.generarArrayReservas(usuario.DNI);

            foreach (string[] rowArray in rows)
            {
                dataGridViewReservasUsuarios.Rows.Add(rowArray);
            }
        }

        private void dataGridViewReservasUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridView senderGrid = (DataGridView)sender;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewReservasUsuarios.Rows[indexRow];
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string caption = idioma == "Español" ? "Eliminar Reserva" : "Delete Booking";
                string message;

                if (idioma == "Español")
                {
                    message = "¿Confirmar eliminación de la Reserva para: ID " + id + " | " + row.Cells[1].Value.ToString()
                                   + ", desde el " + row.Cells[2].Value.ToString()
                                   + " hasta el " + row.Cells[3].Value.ToString() + "?";
                }
                else
                {
                    message = "Confirm delete of Booking for: ID " + id + " | " + row.Cells[1].Value.ToString()
                                   + ", from " + row.Cells[2].Value.ToString()
                                   + " to " + row.Cells[3].Value.ToString() + "?";
                }
               
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bool todoOk = agenciaManager.eliminarReserva(id);                    

                    if (todoOk)
                    {
                        MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                        populateDGVReservas(usuario.DNI);
                    }
                    else
                    {
                        MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                    }
                }
            }
        }
                
        private void estilarDGVReservas()
        {
            dataGridViewReservasUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewReservasUsuarios.RowsDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewReservasUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewReservasUsuarios.BackgroundColor = Color.FromArgb(33, 34, 36);
            dataGridViewReservasUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridViewReservasUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewReservasUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewReservasUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
            dataGridViewReservasUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewReservasUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(166, 236, 245);
            dataGridViewReservasUsuarios.ForeColor = Color.White;
        }

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":
                    dgvIDReservas.HeaderText = "ID";
                    dgvPropiedadReservas.HeaderText = "Propiedad";                    
                    dgvDesdeReservas.HeaderText = "Desde";
                    dgvHastaReservas.HeaderText = "Hasta";
                    dgvCantPersonas.HeaderText = "Cant. Personas";
                    dgvPrecioReservas.HeaderText = "Precio";                    
                    dgvEliminarReserva.HeaderText = "Eliminar";                    
                    break;


                case "English":
                    dgvIDReservas.HeaderText = "ID";
                    dgvPropiedadReservas.HeaderText = "Lodging";                    
                    dgvDesdeReservas.HeaderText = "From";
                    dgvHastaReservas.HeaderText = "To";
                    dgvCantPersonas.HeaderText = "Guest Qty.";
                    dgvPrecioReservas.HeaderText = "Amount";                    
                    dgvEliminarReserva.HeaderText = "Delete";
                    break;
            }
        }

    }
}
