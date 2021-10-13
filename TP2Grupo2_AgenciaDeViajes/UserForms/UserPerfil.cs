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

    public partial class UserPerfil : Form
    {
        
        private AgenciaManager agenciaManager;
        private Usuario usuario;
        private int indexRow;
        string idioma; 

        public UserPerfil(AgenciaManager agenciaManager, Usuario usuario, string idioma)
        {
            this.agenciaManager = agenciaManager;
            this.usuario = usuario;
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
            string[][] rows = agenciaManager.generarArrayUsuarios(usuario);

            foreach (string[] rowArray in rows)
            {
                if (true)
                {
                    dataGridViewUsuarios.Rows.Add(rowArray);
                }                
            }           
        }
       
        private void resetForm()
        {           
            panelPassword.Visible = false;
            textBoxPass.Text = "";
            textBoxPassNueva.Text = "";
            textBoxPassNuevaRep.Text = "";
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
            DataGridView senderGrid = (DataGridView)sender;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewUsuarios.Rows[indexRow];
            bool todoOk = false;
            int dniActual = Int32.Parse(row.Cells[0].Value.ToString());

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 5)
            {
                panelPassword.Visible = true;
                textBoxPassDNI.Text = row.Cells[0].Value.ToString();                
            }            
        }

        private void buttonCancelarPass_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void buttonConfirmarPass_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(textBoxPassDNI.Text);
            string oldPass = textBoxPass.Text;
            string oldPassEncriptada = SHA.ComputeSHA256Hash(oldPass);
            string newPass = textBoxPassNueva.Text;
            string newPassRep = textBoxPassNuevaRep.Text;
            bool authOK = agenciaManager.autenticarUsuario(dni, oldPassEncriptada);
            if (authOK)
            {
                if (oldPass == newPass)
                {
                    MessageBox.Show(idioma == "Español" ? "La nueva clave no puede ser igual a la anterior." : "The new password cannot be the same as the old one.");
                }
                else if (newPass == "")
                {
                    MessageBox.Show(idioma == "Español" ? "La nueva clave no puede estar vacía." : "The new password cannot be empty.");
                }
                else if (newPass != newPassRep)
                {
                    MessageBox.Show(idioma == "Español" ? "La nueva clave no coincide en el segundo campo." : "The new password does not match in the second field.");
                }
                else
                {
                    agenciaManager.cambiarPasswordUsuario(dni, newPass);
                    MessageBox.Show(idioma == "Español" ? "Acción realizada con éxito." : "Action carried out successfully.");
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
                    dgvUserName.HeaderText = "Nombre";
                    dgvemail.HeaderText = "Mail";
                    dgvEstadoUser.HeaderText = "Bloqueado";
                    dgvEsAdmin.HeaderText = "Admin";
                    dgvCambiarContrasenia.HeaderText = "Cambiar Contraseña";                    
                    textBoxPassDNI.PlaceholderText = "DNI";
                    textBoxPass.PlaceholderText = "Ingrese Contraseña";
                    textBoxPassNueva.PlaceholderText = "Ingrese Nueva Contraseña";
                    textBoxPassNuevaRep.PlaceholderText = "Repita Nueva Contraseña";
                    break;


                case "English":
                    dgvDNI.HeaderText = "DNI";
                    dgvUserName.HeaderText = "Name";
                    dgvemail.HeaderText = "Mail";
                    dgvEstadoUser.HeaderText = "Locked";
                    dgvEsAdmin.HeaderText = "Admin";                   
                    dgvCambiarContrasenia.HeaderText = "Change Password";                    
                    textBoxPassDNI.PlaceholderText = "DNI";
                    textBoxPass.PlaceholderText = "Enter Password";
                    textBoxPassNueva.PlaceholderText = "Enter New Password";
                    textBoxPassNuevaRep.PlaceholderText = "Repeat New Password";
                    break;
            }
        }

    }

}
