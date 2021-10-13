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

    public partial class AdminAlojamientos : Form
    {
        private AgenciaManager agenciaManager;
        private int indexRow;
        private string idioma;
        public AdminAlojamientos(AgenciaManager agenciaManager, string idioma)
        {
            this.agenciaManager = agenciaManager;
            this.idioma = idioma;
            InitializeComponent();
            labelCantMaxAloj.Text = idioma == "Español"? "(*) Cantidad máxima de alojamientos: " + agenciaManager.miAgencia.getMaxAlojamientos() : "(*) Maximum number of lodgings: " + agenciaManager.miAgencia.getMaxAlojamientos();
            comboBoxEstrellas.Text = idioma == "Español" ? "Estrellas" : "Stars";
            setIdioma();
        }

        private void buttonAlojamientosVolver_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populateDGVAlojamientos();
            estilarDGBAloajmientos();            
        }


        private void populateDGVAlojamientos()
        {
            dataGridViewAlojamientos.Rows.Clear();
            string[][] rows = agenciaManager.generarArrayAlojamientos();

            foreach (string[] rowArray in rows)
            {
                dataGridViewAlojamientos.Rows.Add(rowArray);                
            }
        }

        private void buttonAlojamientosAgregarHotel_Click(object sender, EventArgs e)
        {
            if (!agenciaManager.miAgencia.estaLlena())
            {
                panelAgregarAlojamientos.Visible = true;
                panelAlojamientosAgregarHotel.Visible = true;
                panelAlojamientosAgregarCabania.Visible = false;
                buttonAlojamientosAgregarCabania.Enabled = false;
            }
            else
            {
                MessageBox.Show(idioma == "Español"? "No se pueden agregar más Hoteles, la Agencia está llena." : "No more hotels can be added, the Agency is full.");
            }                
        }

        private void buttonAlojamientosAgregarCabania_Click(object sender, EventArgs e)
        {
            if (!agenciaManager.miAgencia.estaLlena())
            {
                panelAgregarAlojamientos.Visible = true;
                panelAlojamientosAgregarHotel.Visible = false;
                panelAlojamientosAgregarCabania.Visible = true;
                buttonAlojamientosAgregarHotel.Enabled = false;
            } 
            else
            {
                MessageBox.Show(idioma == "Español" ? "No se pueden agregar más Cabañas, la Agencia está llena." : "No more cottages can be added, the Agency is full.");
            }
        }


        private void buttonAgregarAlojamientosCancelar_Click(object sender, EventArgs e)
        {            
            resetForm();
            labelAccion.Text = "";
        }

        private void buttonAlojamientoAgregar_Click(object sender, EventArgs e)
        {
            bool todoOk;
            if (labelAccion.Text == "DELETE")   
            {
                int codigo = Int32.Parse(textBoxCodigo.Text);
                int cantReservas = agenciaManager.cantReservasAlojamiento(codigo);
                string caption = idioma == "Español" ? "Confirmar Eliminación de Alojamiento" : "Confirm Removal of Lodging";
                string message;

                if (idioma == "Español")
                {
                    message = cantReservas > 0 ? "El Alojamiento que desea eliminar tiene Reservas hechas. Si lo elimina, se eliminarán también sus Reservas ¿Desea eliminarlo de todas formas?" : "¿Confirma que desea eliminar el Alojamiento?";
                }
                else
                {
                    message = cantReservas > 0 ? "The Lodging you want to delete has Reservations made. If you delete it, your Reservations will also be deleted. Do you want to delete it anyway?" : "Do you confirm that you want to delete the Lodging?";
                }                
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    todoOk = agenciaManager.eliminarAlojamiento(codigo);

                    if (todoOk)
                    {
                        populateDGVAlojamientos();
                        MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                    }
                    else
                    {
                        MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                    }
                    resetForm();
                    labelAccion.Text = "";
                }
               
            }
            else
            {
                todoOk = alojamientosAdd();
                if (todoOk)
                {
                    if (!buttonAlojamientosAgregarHotel.Enabled)
                    {
                        buttonAlojamientosAgregarHotel.Enabled = true;
                    }
                    else if (!buttonAlojamientosAgregarCabania.Enabled)
                    {
                        buttonAlojamientosAgregarCabania.Enabled = true;
                    }
                    resetForm();
                    labelAccion.Text = "";
                    MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                }  
                else
                {
                    MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                }
            }            
        }

        private void resetAlojamientosAdd()
        {
            textBoxCodigo.Text = "";
            textBoxCiudad.Text = "";
            textBoxBarrio.Text = "";
            comboBoxEstrellas.SelectedIndex = -1;
            comboBoxEstrellas.Text = idioma == "Español"? "Estrellas" : "Stars";
            textBoxCantPersonas.Text = "";
            checkBoxTieneTV.Checked = false;
            textBoxPrecioxPersona.Text = "";
            textBoxCantHabitaciones.Text = "";
            textBoxCantBanios.Text = "";
            textBoxPrecioxDia.Text = "";
        }

        private bool alojamientosAdd()
        {
            errorProvider1.Clear();
            
            bool esHotel = panelAlojamientosAgregarHotel.Visible? true : false;

            int codigo = 0;
            String ciudad = "";
            String barrio = "";
            int estrella = 0;
            int cantPersonas = 0;
            double precioxDia = 0;
            int cantHabitacion = 0;
            int cantBanios = 0;            
            double precioxPersona = 0;
            
            try
            {
                codigo = Int32.Parse(textBoxCodigo.Text);
                estrella = Int32.Parse(comboBoxEstrellas.Text);
                cantPersonas = Int32.Parse(textBoxCantPersonas.Text);
                if (esHotel)
                {
                    precioxPersona = double.Parse(textBoxPrecioxPersona.Text.Trim());
                }
                else
                {
                    cantHabitacion = Int32.Parse(textBoxCantHabitaciones.Text);
                    cantBanios = Int32.Parse(textBoxCantBanios.Text);
                    precioxDia = double.Parse(textBoxPrecioxDia.Text);
                }               
            }
            catch (FormatException)
            {
                if (esHotel)
                {
                    MessageBox.Show(idioma == "Español" ? "Se debe ingresar un valor númerico en los campos Código, Estrellas, Cantidad de Personas y Precio por persona." : "A numerical value must be entered in the Code, Stars, Number of People and Price per person fields.");
                }
                else
                {
                    MessageBox.Show(idioma == "Español" ? "Se debe ingresar un valor númerico en los campos Código, Estrellas, Cantidad de Personas y Precio por día, Habitaciones y Baños." : "A numerical value must be entered in the fields Code, Stars, Number of People and Price per day, Rooms and Bathrooms.");
                }
                return false;
            }

            bool todoOk = true;
            ciudad = textBoxCiudad.Text;
            barrio = textBoxBarrio.Text;

            bool tv = checkBoxTieneTV.Checked;

            errorProvider1.SetError(textBoxCodigo, "");
            if (codigo <= 0)
            {
                errorProvider1.SetError(textBoxCodigo, idioma == "Español" ? "Ingrese Código" : "Enter Code");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxCiudad, "");
            if (ciudad == "")
            {
                errorProvider1.SetError(textBoxCiudad, idioma == "Español" ? "Ingrese Ciudad" : "Enter City");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxBarrio, "");
            if (barrio == "")
            {
                errorProvider1.SetError(textBoxBarrio, idioma == "Español" ? "Ingrese Barrio" : "Enter Neighborhood");
                todoOk = false;
            }

            errorProvider1.SetError(comboBoxEstrellas, "");
            if (estrella <= 0 || estrella >= 6)
            {
                errorProvider1.SetError(comboBoxEstrellas, idioma == "Español" ? "La cantidad de estrellas debe ser un número del 1 al 5" : "The number of stars must be a number from 1 to 5");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxCantPersonas, "");
            if (cantPersonas <= 0)
            {
                errorProvider1.SetError(textBoxCantPersonas, idioma == "Español" ? "Ingrese Cantidad de Personas" : "Enter Number of Guests");
                todoOk = false;
            }

            if (esHotel)
            {
                errorProvider1.SetError(textBoxPrecioxPersona, "");
                if (precioxPersona <= 0)
                {
                    errorProvider1.SetError(textBoxPrecioxPersona, idioma == "Español" ? "Ingrese Precio por Persona" : "Enter Amount per Guest");
                    todoOk = false;
                }
            }
            else
            {
                errorProvider1.SetError(textBoxPrecioxDia, "");
                if (precioxDia <= 0)
                {
                    errorProvider1.SetError(textBoxPrecioxDia, idioma == "Español" ? "Ingrese Precio por Día" : "Enter Amount per Day");
                    todoOk = false;
                }

                errorProvider1.SetError(textBoxCantHabitaciones, "");
                if (cantHabitacion <= 0)
                {
                    errorProvider1.SetError(textBoxCantHabitaciones, idioma == "Español" ? "Ingrese Cantidad de Habitaciones" : "Enter Bedrooms Quantity");
                    todoOk = false;
                }

                errorProvider1.SetError(textBoxCantBanios, "");
                if (cantBanios <= 0)
                {
                    errorProvider1.SetError(textBoxCantBanios, idioma == "Español" ? "Ingrese Cantidad de Baños" : "Enter Bathrooms Quantity");
                    todoOk = false;
                }
            }

            if (todoOk)
            {
                if (buttonAlojamientosAgregarHotel.Enabled && !buttonAlojamientosAgregarCabania.Enabled)    // INSERT HOTEL
                {
                    todoOk = agenciaManager.insertarAlojamiento(codigo, ciudad, barrio, estrella, cantPersonas, tv, precioxPersona, 0, 0, 0, "HOTEL");
                }
                else if (!buttonAlojamientosAgregarHotel.Enabled && buttonAlojamientosAgregarCabania.Enabled)   // INSERT CABAÑA
                {
                    todoOk = agenciaManager.insertarAlojamiento(codigo, ciudad, barrio, estrella, cantPersonas, tv, 0, precioxDia, cantHabitacion, cantBanios, "CABANIA");
                }
                else if (!buttonAlojamientosAgregarHotel.Enabled && !buttonAlojamientosAgregarCabania.Enabled)     
                {
                    if (esHotel)     // UPDATE HOTEL
                    {
                        todoOk = agenciaManager.modificarAlojamiento(codigo, ciudad, barrio, estrella, cantPersonas, tv, precioxPersona, 0, 0, 0, "HOTEL");
                    }
                    else    // UPDATE CABAÑA
                    {
                        todoOk = agenciaManager.modificarAlojamiento(codigo, ciudad, barrio, estrella, cantPersonas, tv, 0, precioxDia, cantHabitacion, cantBanios, "CABANIA");
                    }

                }
                populateDGVAlojamientos();
            }
            return todoOk;
        }

        private void dataGridViewAlojamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetForm();
            labelAccion.Text = "";
            DataGridView senderGrid = (DataGridView)sender;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewAlojamientos.Rows[indexRow];

            panelAgregarAlojamientos.Visible = true;
            buttonAlojamientosAgregarCabania.Enabled = false;
            buttonAlojamientosAgregarHotel.Enabled = false;

            if (row.Cells[1].Value.ToString() == "Hotel")
            {
                panelAlojamientosAgregarHotel.Visible = true;
                panelAlojamientosAgregarCabania.Visible = false;
            } 
            else
            {
                panelAlojamientosAgregarHotel.Visible = false;
                panelAlojamientosAgregarCabania.Visible = true;
            }

            textBoxCodigo.Text = row.Cells[0].Value.ToString();
            textBoxCiudad.Text = row.Cells[2].Value.ToString();
            textBoxBarrio.Text = row.Cells[3].Value.ToString();
            comboBoxEstrellas.Text = row.Cells[4].Value.ToString();
            textBoxCantPersonas.Text = row.Cells[5].Value.ToString();
            checkBoxTieneTV.Checked = row.Cells[6].Value.ToString() == "No"? false : true;
            textBoxPrecioxPersona.Text = row.Cells[7].Value.ToString();
            textBoxPrecioxDia.Text = row.Cells[8].Value.ToString();
            textBoxCantHabitaciones.Text = row.Cells[9].Value.ToString();
            textBoxCantBanios.Text = row.Cells[10].Value.ToString();

            textBoxCodigo.Enabled = false;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 12)
            {
                labelAccion.Text = "DELETE";                
                textBoxCiudad.Enabled = false;
                textBoxBarrio.Enabled = false;
                comboBoxEstrellas.Enabled = false;
                textBoxCantPersonas.Enabled = false;
                checkBoxTieneTV.Enabled = false;
                textBoxPrecioxPersona.Enabled = false;
                textBoxPrecioxDia.Enabled = false;
                textBoxCantHabitaciones.Enabled = false;
                textBoxCantBanios.Enabled = false;
            }
        }
        
        private void dataGridViewAlojamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void resetForm()
        {
            textBoxCodigo.Enabled = true;
            textBoxCiudad.Enabled = true;
            textBoxBarrio.Enabled = true;
            comboBoxEstrellas.Enabled = true;
            textBoxCantPersonas.Enabled = true;
            checkBoxTieneTV.Enabled = true;
            textBoxPrecioxPersona.Enabled = true;
            textBoxPrecioxDia.Enabled = true;
            textBoxCantHabitaciones.Enabled = true;
            textBoxCantBanios.Enabled = true;
            buttonAlojamientosAgregarHotel.Enabled = true;
            buttonAlojamientosAgregarCabania.Enabled = true;
            panelAgregarAlojamientos.Visible = false;
            resetAlojamientosAdd();            
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

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":
                    dgvCodigo.HeaderText = "Código";
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
                    dgvModificar.HeaderText = "Modificar";
                    dgvEliminar.HeaderText = "Eliminar";
                    textBoxCodigo.PlaceholderText = "Código";
                    textBoxCiudad.PlaceholderText = "Ciudad";
                    textBoxBarrio.PlaceholderText = "Barrio";
                    textBoxCantPersonas.PlaceholderText = "Cantidad Personas";
                    checkBoxTieneTV.Text = "¿TV?";
                    textBoxPrecioxDia.PlaceholderText = "Precio x Día";
                    textBoxCantHabitaciones.PlaceholderText = "Cantidad de Habitaciones";
                    textBoxCantBanios.PlaceholderText = "Cantidad de Baños";
                    textBoxPrecioxPersona.PlaceholderText = "Precio por Persona";
                    buttonAlojamientosAgregarCabania.Text = "[+] Cabaña";
                    break;


                case "English":
                    dgvCodigo.HeaderText = "Code";
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
                    dgvModificar.HeaderText = "Update";
                    dgvEliminar.HeaderText = "Delete";
                    textBoxCodigo.PlaceholderText = "Code";
                    textBoxCiudad.PlaceholderText = "City";
                    textBoxBarrio.PlaceholderText = "Neighborhood";
                    textBoxCantPersonas.PlaceholderText = "Guests Qty.";
                    checkBoxTieneTV.Text = "TV?";
                    textBoxPrecioxDia.PlaceholderText = "Amount per Day";
                    textBoxCantHabitaciones.PlaceholderText = "Bedrooms";
                    textBoxCantBanios.PlaceholderText = "Bathrooms";
                    textBoxPrecioxPersona.PlaceholderText = "Amount per Guest";
                    buttonAlojamientosAgregarCabania.Text = "[+] Cottage";
                    break;
            }
        }

    }
}
