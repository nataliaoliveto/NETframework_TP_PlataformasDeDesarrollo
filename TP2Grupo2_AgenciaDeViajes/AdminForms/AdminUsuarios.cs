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
using System.Text.RegularExpressions;
using EasyEncryption;


namespace TP2Grupo2_AgenciaDeViajes
{

    public partial class AdminUsuarios : Form
    {
        
        private AgenciaManager agenciaManager;
        static Regex validate_emailaddress = email_validation();
        private int indexRow;
        private string idioma; 

        public AdminUsuarios(AgenciaManager agenciaManager, string idioma)
        {
            this.agenciaManager = agenciaManager;
            this.idioma = idioma;
            InitializeComponent();
            setIdioma();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populateDGVUsuarios();
            estilarDGBAloajmientos();
        }


        private void populateDGVUsuarios()
        {
            dataGridViewUsuarios.Rows.Clear();            
            string[][] rows = agenciaManager.generarArrayUsuarios();

            foreach (string[] rowArray in rows)
            {
                dataGridViewUsuarios.Rows.Add(rowArray);
            }           
        }


        private void buttonAgregarAlojamientosCancelar_Click(object sender, EventArgs e)
        {
            resetForm();
            labelAccion.Text = "";
        }

        private void resetForm()
        {
            textBoxDNI.Enabled = true;
            textBoxNombre.Enabled = true;
            textBoxMail.Enabled = true;
            checkBoxAdmin.Enabled = true;            
            resetAllVariables();
        }

        private void buttonAlojamientoAgregar_Click(object sender, EventArgs e)
        {
            bool todoOk;
            if (labelAccion.Text == "DELETE")
            {
                int codigo = Int32.Parse(textBoxDNI.Text);
                int cantReservas = agenciaManager.cantReservasUsuario(codigo);

                string caption = idioma == "Español" ? "Confirmar Eliminación de Usuario" : "Confirm User Delete";
                string message;

                if (idioma == "Español")
                {
                    message = cantReservas > 0 ? "El Usuario que desea eliminar tiene Reservas hechas. Si lo elimina, se eliminarán también sus Reservas ¿Desea eliminarlo de todas formas?" : "¿Confirma que desea eliminar el Usuario?";
                }
                else
                {
                    message = cantReservas > 0 ? "The User you want to delete has Reservations made. If you delete it, your Reservations will also be deleted. Do you want to delete it anyway?" : "Do you confirm that you want to delete the User?";
                }

                
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    todoOk = agenciaManager.eliminarUsuario(codigo);
                    if (todoOk)
                    {
                        populateDGVUsuarios();
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
                todoOk = insertarModificarUsuario();
                if (todoOk)
                {
                    populateDGVUsuarios();
                    if (labelAccion.Text == "UPDATE")
                    {
                        MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");                        
                    }
                    else
                    {
                        MessageBox.Show(idioma == "Español"? "Acción realizada con éxito. La contraseña del nuevo usuario es igual a su DNI." : "Action carried out successfully. The password of the new user is the same as his ID.");
                    }                   
                    resetForm();
                    labelAccion.Text = "";                    
                }
                else
                {
                    MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                }
            }
        }

        private bool insertarModificarUsuario()
        {
            errorProvider1.Clear();

            int DNI = 0;
            string password = "";
            string nombre = "";
            bool esAdmin = false;
            string mail = "";
            
            try
            {
                DNI = Int32.Parse(textBoxDNI.Text);
            }
            catch
            {
                MessageBox.Show(idioma == "Español" ? "El DNI es un dato numérico." : "The DNI is a numerical data.");
                return false;
            }

            bool todoOk = true;

            nombre = textBoxNombre.Text;
            mail = textBoxMail.Text;
            esAdmin = checkBoxAdmin.Checked;
            password = DNI.ToString();
            
            errorProvider1.SetError(textBoxNombre, "");
            if (nombre == "")
            {
                errorProvider1.SetError(textBoxNombre, idioma == "Español" ? "Ingrese Nombre" : "Enter Name");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxMail, "");
            if (validate_emailaddress.IsMatch(mail) != true)
            {
                errorProvider1.SetError(textBoxMail, idioma == "Español" ? "Ingrese un Mail válido." : "Enter a valid Mail");
                todoOk = false;
            }

            if (todoOk)
            {
                if (labelAccion.Text == "UPDATE")
                {
                    password = agenciaManager.devolverUsuario(DNI).password;
                    todoOk = agenciaManager.modificarUsuario(DNI, nombre, mail, esAdmin);
                }
                else
                {
                    todoOk = agenciaManager.insertarUsuario(DNI, nombre, mail, password, esAdmin);
                }
                
                
            }

            return todoOk;

        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void resetAllVariables()
        {
            textBoxDNI.Text = "";
            textBoxNombre.Text = "";
            textBoxMail.Text = "";            
            textBoxPassDNI.Text = "";
            textBoxPassNueva.Text = "";
            textBoxPassNuevaRep.Text = "";
            checkBoxAdmin.Checked = false;
        }

        private void estilarDGBAloajmientos()
        {
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.RowsDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewUsuarios.BackgroundColor = Color.FromArgb(33, 34, 36);
            dataGridViewUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 36);
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(166, 236, 245);
            dataGridViewUsuarios.ForeColor = Color.White;
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelAccion.Text = "";
            DataGridView senderGrid = (DataGridView)sender;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewUsuarios.Rows[indexRow];
            bool todoOk = false;
            int dniActual = Int32.Parse(row.Cells[0].Value.ToString());

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8)
            {
                todoOk = agenciaManager.bloquearDesbloquearUsuario(dniActual,false);
                if (todoOk)
                {
                    MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                }
                else
                {
                    MessageBox.Show(idioma == "Español" ? "Error en la ejecución." : "Execution failed.");
                }
                populateDGVUsuarios();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7)
            {                
                panelUsuario.Visible = false;
                panelPassword.Visible = true;
                textBoxPassDNI.Text = row.Cells[0].Value.ToString();                
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6)
            {
                textBoxDNI.Text = row.Cells[0].Value.ToString();
                textBoxNombre.Text = row.Cells[1].Value.ToString();
                textBoxMail.Text = row.Cells[2].Value.ToString();
                checkBoxAdmin.Checked = row.Cells[4].Value.ToString() == "No" ? false : true;

                textBoxDNI.Enabled = false;
                textBoxNombre.Enabled = false;
                textBoxMail.Enabled = false;
                checkBoxAdmin.Enabled = false;
                labelAccion.Text = "DELETE";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 5)
            {               
                textBoxDNI.Text = row.Cells[0].Value.ToString();
                textBoxNombre.Text = row.Cells[1].Value.ToString();
                textBoxMail.Text = row.Cells[2].Value.ToString();
                checkBoxAdmin.Checked = row.Cells[4].Value.ToString() == "No" ? false : true;
                textBoxDNI.Enabled = false;
                labelAccion.Text = "UPDATE";
            }
        }

        private void buttonCancelarPass_Click(object sender, EventArgs e)
        {            
            panelPassword.Visible = false;
            panelUsuario.Visible = true;
            resetAllVariables();
        }

        private void buttonConfirmarPass_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(textBoxPassDNI.Text);
            string oldPass = agenciaManager.devolverUsuario(dni).password;
            string newPass = textBoxPassNueva.Text;
            string newPassEncriptada = SHA.ComputeSHA256Hash(newPass);
            string newPassRep = textBoxPassNuevaRep.Text;
            bool authOK = agenciaManager.autenticarUsuario(dni, oldPass);
            if (authOK)
            {
                if (oldPass == newPassEncriptada)
                {
                    MessageBox.Show(idioma == "Español" ? "La nueva clave no puede ser igual a la anterior." : "The new password cannot be the same as the old one.");
                }
                else if (newPass == "")
                {
                    MessageBox.Show(idioma == "Español" ? "La nueva contraseña no puede estar vacía." : "The new password cannot be empty.");
                }
                else if (newPass != newPassRep)
                {
                    MessageBox.Show(idioma == "Español" ? "La nueva clave no coincide en el segundo campo." : "The new password does not match in the second field.");
                }
                else
                {
                    agenciaManager.cambiarPasswordUsuario(dni, newPass);
                    MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
                    panelPassword.Visible = false;
                    panelUsuario.Visible = true;
                    populateDGVUsuarios();
                    resetForm();
                }           
            }
            else
            {
                MessageBox.Show(idioma == "Español" ? "El usuario y la contraseña no coinciden." : "The username and password do not match.");
            }            
        }

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":
                    dgvDNI.HeaderText = "DNI";
                    dgvNombre.HeaderText = "Nombre";
                    dgvemail.HeaderText = "Mail";
                    dgvEstadoUser.HeaderText = "Bloqueado";
                    dgvEsAdmin.HeaderText = "Admin";
                    dgvModificarUsuario.HeaderText = "Modificar";
                    dgvEliminarUsuario.HeaderText = "Eliminar";
                    dgvCambiarContrasenia.HeaderText = "Cambiar Contraseña";
                    dgvDesbloquearUsuario.HeaderText = "Desbloquear";
                    textBoxDNI.PlaceholderText = "DNI";
                    textBoxNombre.PlaceholderText = "Nombre";
                    textBoxMail.PlaceholderText = "Mail";
                    checkBoxAdmin.Text = "¿Es Administrador?";
                    textBoxPassDNI.PlaceholderText = "DNI";                    
                    textBoxPassNueva.PlaceholderText = "Ingrese Nueva Contraseña";
                    textBoxPassNuevaRep.PlaceholderText = "Repita Nueva Contraseña";
                    break;


                case "English":
                    dgvDNI.HeaderText = "DNI";
                    dgvNombre.HeaderText = "Name";
                    dgvemail.HeaderText = "Mail";
                    dgvEstadoUser.HeaderText = "Locked";
                    dgvEsAdmin.HeaderText = "Admin";
                    dgvModificarUsuario.HeaderText = "Update";
                    dgvEliminarUsuario.HeaderText = "Delete";
                    dgvCambiarContrasenia.HeaderText = "Change Password";
                    dgvDesbloquearUsuario.HeaderText = "Unlock";
                    textBoxDNI.PlaceholderText = "DNI";
                    textBoxNombre.PlaceholderText = "Name";
                    textBoxMail.PlaceholderText = "Mail";
                    checkBoxAdmin.Text = "Admin?";
                    textBoxPassDNI.PlaceholderText = "DNI";                    
                    textBoxPassNueva.PlaceholderText = "Enter New Password";
                    textBoxPassNuevaRep.PlaceholderText = "Repeat New Password";
                    break;
            }
        }
    }

}
