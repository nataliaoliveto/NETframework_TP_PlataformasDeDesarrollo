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
using System.Data.SqlClient;
using System.Linq;


namespace TP2Grupo2_AgenciaDeViajes
{

    public partial class UserAlojamientos : Form
    {

        private AgenciaManager agenciaManager;
        private Usuario usuario;
        private int indexRow;
        string idioma; 

        public UserAlojamientos(AgenciaManager agenciaManager, Usuario usuario, string idioma)
        {
            this.agenciaManager = agenciaManager;
            this.usuario = usuario;
            this.idioma = idioma;
            InitializeComponent();
            setIdioma();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var query = from aloj in agenciaManager.miAgencia.misAlojamientos.AsEnumerable()
                        group aloj by aloj.aCiudad into a
                        select a;

            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            foreach (var ciudad in query)
            {
                MyCollection.Add(ciudad.Key);
            }                       
            textBoxCiudad.AutoCompleteCustomSource = MyCollection;
           
            estilarDGBAloajmientos();
        }


        private void populateDGVAlojamientos(string Ciudad, string fdesdeStr, string fhastaStr, int cantPersonas, string tipoAlojamiento)
        {
            DateTime fdesde = Convert.ToDateTime(fdesdeStr);
            DateTime fhasta = Convert.ToDateTime(fhastaStr);           
            dataGridViewAlojamientos.Rows.Clear();            

            string[][] rows = agenciaManager.generarArrayAlojamientosUsuario(Ciudad, fdesde, fhasta, cantPersonas, tipoAlojamiento);

            foreach (string[] rowArray in rows)
            {
                dataGridViewAlojamientos.Rows.Add(rowArray);
            }
        }

        private void buttonAlojamientoAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ciudad = "";
            int cantPersonas = 0;
            string tipoAlojamiento = "";

            try
            {
                cantPersonas = Int32.Parse(textBoxCantPersonas.Text);
            }
            catch
            {
                MessageBox.Show(idioma == "Español" ? "La cantidad de personas es un dato numérico." : "The number of people is a numerical data.");
                return;
            }

            DateTime fDesde = dateTimePickerFDesde.Value;
            DateTime fHasta = dateTimePickerFHasta.Value;

            bool todoOk = true;
            ciudad = textBoxCiudad.Text;

            errorProvider1.SetError(dateTimePickerFDesde, "");
            if (fDesde.Date < DateTime.Now.Date)
            {
                errorProvider1.SetError(dateTimePickerFDesde, idioma == "Español" ? "La fecha desde no puede ser anterior a la fecha actual." : "The date from cannot be earlier than the current date.");
                todoOk = false;
            }
            else if (fDesde.Date > fHasta.Date)
            {
                errorProvider1.SetError(dateTimePickerFDesde, idioma == "Español" ? "La fecha desde no puede ser mayor a la fecha hasta." : "The date from cannot be greater than the date to.");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxCantPersonas, "");
            if (cantPersonas <= 0)
            {
                errorProvider1.SetError(textBoxCantPersonas, idioma == "Español" ? "Ingrese Cantidad de Personas" : "Enter Number of People");
                todoOk = false;
            }

            errorProvider1.SetError(comboBoxTipoAlojamiento, "");
            tipoAlojamiento = comboBoxTipoAlojamiento.Text == "Cabaña" ? "Cabania" : comboBoxTipoAlojamiento.Text;

            if (tipoAlojamiento != "Ambos" && tipoAlojamiento != "Hotel" && tipoAlojamiento != "Cabania")
            {
                errorProvider1.SetError(comboBoxTipoAlojamiento, idioma == "Español" ? "Ingrese Tipo de Alojamiento" : "Enter Lodging Type");
                todoOk = false;
            }

            if (todoOk)
            {                
                textBoxCiudad.Enabled = false;
                dateTimePickerFDesde.Enabled = false;
                dateTimePickerFHasta.Enabled = false;
                textBoxCantPersonas.Enabled = false;
                comboBoxTipoAlojamiento.Enabled = false;

                populateDGVAlojamientos(ciudad, fDesde.Date.ToString(), fHasta.Date.ToString(), cantPersonas, tipoAlojamiento);
            }

        }

        private void dataGridViewAlojamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewAlojamientos.Rows[indexRow];

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 11)
            {

                int codAloj = Int32.Parse(row.Cells[0].Value.ToString());
                int dni = this.usuario.DNI;
                int cantPersonas = Int32.Parse(textBoxCantPersonas.Text);
                float precio = agenciaManager.calcularPrecioReserva(codAloj, dateTimePickerFDesde.Value, dateTimePickerFHasta.Value, cantPersonas);

                string caption = idioma == "Español" ? "Confirmar Reserva" : "Confirm Booking";
                string message;

                if (idioma == "Español")
                {
                    message = "¿Confirmar Reserva para: código " + row.Cells[0].Value.ToString() + " | " + row.Cells[1].Value.ToString()
                                    + ", desde el " + dateTimePickerFDesde.Value.ToString("dd/MM/yyyy")
                                    + " hasta el " + dateTimePickerFHasta.Value.ToString("dd/MM/yyyy") + ", para " + cantPersonas + " personas, por un total de $" + precio + "?";
                }
                else
                {
                    message = "Confirm Booking for: code " + row.Cells[0].Value.ToString() + " | " + row.Cells[1].Value.ToString()
                                    + ", from " + dateTimePickerFDesde.Value.ToString("dd/MM/yyyy")
                                    + " to " + dateTimePickerFHasta.Value.ToString("dd/MM/yyyy") + ", for " + cantPersonas + " guests, for $" + precio + "?";
                }
                
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bool todoOk = agenciaManager.insertarReserva(dateTimePickerFDesde.Value, dateTimePickerFHasta.Value, codAloj, dni, precio, cantPersonas);

                    if (todoOk)
                    {
                        MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                        dataGridViewAlojamientos.Rows.Clear();

                        textBoxCiudad.Text = "";
                        textBoxCantPersonas.Text = "";
                        comboBoxTipoAlojamiento.SelectedIndex = -1;
                        comboBoxTipoAlojamiento.Text = "Ambos";
                        dateTimePickerFDesde.Value = DateTime.Now;
                        dateTimePickerFHasta.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                    }
                }

                textBoxCiudad.Enabled = true;
                dateTimePickerFDesde.Enabled = true;
                dateTimePickerFHasta.Enabled = true;
                textBoxCantPersonas.Enabled = true;
                comboBoxTipoAlojamiento.Enabled = true;            
            }
        }
      
        private void estilarDGBAloajmientos()
        {
            dataGridViewAlojamientos.BorderStyle = BorderStyle.None;
            dataGridViewAlojamientos.RowsDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewAlojamientos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAlojamientos.BackgroundColor = Color.FromArgb(33, 34, 36);
            dataGridViewAlojamientos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridViewAlojamientos.EnableHeadersVisualStyles = false;
            dataGridViewAlojamientos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAlojamientos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
            dataGridViewAlojamientos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewAlojamientos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(166, 236, 245);
            dataGridViewAlojamientos.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCiudad.Enabled = true;
            dateTimePickerFDesde.Enabled = true;
            dateTimePickerFHasta.Enabled = true;
            textBoxCantPersonas.Enabled = true;
            comboBoxTipoAlojamiento.Enabled = true;
            textBoxCiudad.Text = "";
            textBoxCantPersonas.Text = "1";
            comboBoxTipoAlojamiento.SelectedIndex = -1;
            comboBoxTipoAlojamiento.Text = "Ambos";
            dateTimePickerFDesde.Value = DateTime.Now;
            dateTimePickerFHasta.Value = DateTime.Now;
            dataGridViewAlojamientos.Rows.Clear();
        }

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":
                    dgvCódigo.HeaderText = "Código";
                    dgvTipoAlojamiento.HeaderText = "Tipo de Alojamiento";
                    dgvCiudad.HeaderText = "Ciudad";
                    dgvBarrio.HeaderText = "Barrio";
                    dgvEstrellas.HeaderText = "Estrellas";
                    dgvCantPersonas.HeaderText = "Cantidad de Personas";
                    dgvTV.HeaderText = "TV";
                    dgvHotelPrecioxPersona.HeaderText = "Hotel Precio por Persona";
                    dgvCabaniaPrecioxDia.HeaderText = "Cabaña Precio por Día";
                    dgvCabaniaCantHabitaciones.HeaderText = "Cabaña Cantidad Habitaciones";
                    dgvCabaniaCantBanios.HeaderText = "Cabaña Cantidad Baños";
                    dgvReservar.HeaderText = "Reservar";
                    textBoxCiudad.PlaceholderText = "Ciudad";
                    textBoxCantPersonas.PlaceholderText = "Cantidad Personas";
                    labelFechaDesde.Text = "Desde";
                    labelFechaHasta.Text = "Hasta";
                    break;


                case "English":
                    dgvCódigo.HeaderText = "Code";
                    dgvTipoAlojamiento.HeaderText = "Type of Lodging";
                    dgvCiudad.HeaderText = "City";
                    dgvBarrio.HeaderText = "Neighborhood";
                    dgvEstrellas.HeaderText = "Stars";
                    dgvCantPersonas.HeaderText = "Number of Guests";
                    dgvTV.HeaderText = "TV";
                    dgvHotelPrecioxPersona.HeaderText = "Amount per Guest";
                    dgvCabaniaPrecioxDia.HeaderText = "Amount per Day";
                    dgvCabaniaCantHabitaciones.HeaderText = "Bedrooms";
                    dgvCabaniaCantBanios.HeaderText = "Bathrooms";
                    dgvReservar.HeaderText = "Book";
                    textBoxCiudad.PlaceholderText = "City";
                    textBoxCantPersonas.PlaceholderText = "Guests Qty.";
                    labelFechaDesde.Text = "From";
                    labelFechaHasta.Text = "To";
                    break;
            }
        }

    }
}
