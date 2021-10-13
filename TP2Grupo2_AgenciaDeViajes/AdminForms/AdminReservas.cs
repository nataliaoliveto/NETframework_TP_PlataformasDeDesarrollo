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

    public partial class AdminReservas : Form
    {

        private AgenciaManager agenciaManager;
        private int indexRow;
        private string idioma;
        public AdminReservas(AgenciaManager agenciaManager, string idioma)
        {
            this.agenciaManager = agenciaManager;
            this.idioma = idioma;
            InitializeComponent();
            setIdioma();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populateDGVReservas();
            estilarDGVReservas();
        }

        private void populateDGVReservas()
        {
            dataGridViewReservas.Rows.Clear();
            string[][] rows = agenciaManager.generarArrayReservas();

            foreach (string[] rowArray in rows)
            {
                dataGridViewReservas.Rows.Add(rowArray);
            }
        }

        private void buttonAgregarAlojamientosCancelar_Click(object sender, EventArgs e)
        {
            resetForm();
            panelAgregarReservas.Visible = false;
            labelAccion.Text = "";
        }

        private void buttonAlojamientoAgregar_Click(object sender, EventArgs e)
        {
            bool todoOk = false;

            if (labelAccion.Text == "DELETE")
            {
                int id = Int32.Parse(textBoxId.Text);                
                todoOk = agenciaManager.eliminarReserva(id);

                if (todoOk)
                {
                    MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                    populateDGVReservas();                                        
                    resetForm();
                    panelAgregarReservas.Visible = false;
                }
                else
                {
                    MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                }
                resetForm();
                labelAccion.Text = "";
            }
            else
            {
                errorProvider1.Clear();

                int id = 0;
                int codPropiedad = 0;
                int dni = 0;
                int cantPersonas = 0;

                try
                {
                    codPropiedad = Int32.Parse(textBoxPropiedadRerserva.Text);
                    dni = Int32.Parse(textBoxPersonaReserva.Text);
                    cantPersonas = Int32.Parse(textBoxCantPersonas.Text);
                }
                catch
                {
                    MessageBox.Show(idioma == "Español" ? "Se debe ingresar un valor númerico en los campos Propiedad, Persona y Cantidad de Personas." : "A numerical value must be entered in the Property, Person and Number of People fields.");
                    MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                    return;
                }

                id = Int32.Parse(textBoxId.Text);
                DateTime fDesde = dateTimePickerFDesde.Value;
                DateTime fHasta = dateTimePickerFHasta.Value;

                todoOk = true;
                
                errorProvider1.SetError(dateTimePickerFDesde, "");
                if (fDesde.Date < DateTime.Now.Date)
                {
                    errorProvider1.SetError(dateTimePickerFDesde, idioma == "Español" ? "La fecha desde no puede ser anterior a la fecha actual." : "The date from cannot be earlier than the current date.");
                    todoOk = false;
                } else if (fDesde.Date > fHasta.Date) {
                    errorProvider1.SetError(dateTimePickerFDesde, idioma == "Español" ? "La fecha desde no puede ser mayor a la fecha hasta." : "The date from cannot be greater than the date to.");
                    todoOk = false;
                }            

                errorProvider1.SetError(textBoxPropiedadRerserva, "");
                if (codPropiedad <= 0)
                {
                    errorProvider1.SetError(textBoxPropiedadRerserva, idioma == "Español" ? "Ingrese Código Propiedad" : "Enter Lodging Code");
                    todoOk = false;
                } else if (agenciaManager.devolverAlojamiento(codPropiedad) == null){
                    errorProvider1.SetError(textBoxPropiedadRerserva, idioma == "Español" ? "El Código Propiedad ingresado no es válido." : "The Lodging Code entered is not valid.");
                    todoOk = false;
                }

                errorProvider1.SetError(textBoxPersonaReserva, "");
                if (dni <= 0)
                {
                    errorProvider1.SetError(textBoxPersonaReserva, idioma == "Español" ? "Ingrese DNI Persona" : "Enter Guest DNI");
                    todoOk = false;
                }
                else if (agenciaManager.devolverUsuario(dni) == null)
                {
                    errorProvider1.SetError(textBoxPersonaReserva, idioma == "Español" ? "El DNI ingresado no es válido." : "The DNI entered is not valid.");
                    todoOk = false;
                }

                errorProvider1.SetError(textBoxCantPersonas, "");
                if (cantPersonas <= 0)
                {
                    errorProvider1.SetError(textBoxCantPersonas, idioma == "Español" ? "Ingrese la Cantidad de Personas." : "Enter Number of Guests.");
                    todoOk = false;
                }
                else if (todoOk && agenciaManager.devolverAlojamiento(codPropiedad).aCantPersonas < cantPersonas)
                {
                    errorProvider1.SetError(textBoxCantPersonas, idioma == "Español" ? "La Cantidad de Personas ingresadas es superior al máximo admitido del Alojamiento." : "The Number of Guests admitted is higher than the maximum admitted of the Lodging.");
                    todoOk = false;
                }

                if (todoOk)
                {
                    float precio = agenciaManager.calcularPrecioReserva(codPropiedad, fDesde, fHasta, cantPersonas);
                    todoOk = agenciaManager.modificarReserva(id, fDesde, fHasta, codPropiedad, dni, precio, cantPersonas);

                    if (todoOk)
                    {
                        MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                        resetForm();
                        panelAgregarReservas.Visible = false;
                        populateDGVReservas();                        
                    }
                    else
                    {
                        MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                    }
                }
                else
                {
                    MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                }
            }
        }

        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panelAgregarReservas.Visible = true;
            resetForm();
            labelAccion.Text = "";
            DataGridView senderGrid = (DataGridView)sender;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewReservas.Rows[indexRow];            

            textBoxId.Text = row.Cells[0].Value.ToString();
            textBoxPropiedadRerserva.Text = agenciaManager.devolverReserva(Int32.Parse(textBoxId.Text)).propiedad.aCodigo.ToString();
            textBoxPersonaReserva.Text = agenciaManager.devolverReserva(Int32.Parse(textBoxId.Text)).persona.DNI.ToString();
            textBoxCantPersonas.Text = agenciaManager.devolverReserva(Int32.Parse(textBoxId.Text)).cantPersonas.ToString();
            dateTimePickerFDesde.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            dateTimePickerFHasta.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());    

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8)
            {
                labelAccion.Text = "DELETE";
                
                textBoxPropiedadRerserva.Enabled = false;
                textBoxPersonaReserva.Enabled = false;
                dateTimePickerFDesde.Enabled = false;
                dateTimePickerFHasta.Enabled = false;           
            }

        }

        private void resetForm()
        {
            textBoxPropiedadRerserva.Enabled = true;
            textBoxPersonaReserva.Enabled = true;
            dateTimePickerFDesde.Enabled = true;
            dateTimePickerFHasta.Enabled = true;
            textBoxCantPersonas.Enabled = true;
            textBoxPropiedadRerserva.Text = "";
            textBoxPersonaReserva.Text = "";
            textBoxCantPersonas.Text = "";
            dateTimePickerFDesde.Value = DateTime.Now;
            dateTimePickerFHasta.Value = DateTime.Now;         

        }

        private void estilarDGVReservas()
        {
            dataGridViewReservas.BorderStyle = BorderStyle.None;
            dataGridViewReservas.RowsDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewReservas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewReservas.BackgroundColor = Color.FromArgb(33, 34, 36);
            dataGridViewReservas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridViewReservas.EnableHeadersVisualStyles = false;
            dataGridViewReservas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(166, 236, 245);
            dataGridViewReservas.ForeColor = Color.White;
        }

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":
                    dgvIDReservas.HeaderText = "ID";
                    dgvPropiedadReservas.HeaderText = "Propiedad";
                    dgvPersonaReservas.HeaderText = "Persona";
                    dgvDesdeReservas.HeaderText = "Desde";
                    dgvHastaReservas.HeaderText = "Hasta";
                    dgvCantPersonas.HeaderText = "Cant. Personas";
                    dgvPrecioReservas.HeaderText = "Precio";
                    dgvModificarReserva.HeaderText = "Modificar";
                    dgvEliminarReserva.HeaderText = "Eliminar";
                    textBoxId.PlaceholderText = "ID";
                    labelFechaDesde.Text = "Desde";
                    labelFechaHasta.Text = "Hasta";
                    textBoxPropiedadRerserva.PlaceholderText = "Propiedad";
                    textBoxPersonaReserva.PlaceholderText = "Persona";
                    textBoxCantPersonas.PlaceholderText = "Cant. Personas";
                    break;


                case "English":
                    dgvIDReservas.HeaderText = "ID";
                    dgvPropiedadReservas.HeaderText = "Lodging";
                    dgvPersonaReservas.HeaderText = "Guest";
                    dgvDesdeReservas.HeaderText = "From";
                    dgvHastaReservas.HeaderText = "To";
                    dgvCantPersonas.HeaderText = "Guest Qty.";
                    dgvPrecioReservas.HeaderText = "Amount";
                    dgvModificarReserva.HeaderText = "Update";
                    dgvEliminarReserva.HeaderText = "Delete";
                    textBoxId.PlaceholderText = "ID";
                    labelFechaDesde.Text = "From";
                    labelFechaHasta.Text = "To";
                    textBoxPropiedadRerserva.PlaceholderText = "Lodging";
                    textBoxPersonaReserva.PlaceholderText = "Guest";
                    textBoxCantPersonas.PlaceholderText = "Guest Qty.";
                    break;
            }
        }

    }
}
