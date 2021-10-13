using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2Grupo2_AgenciaDeViajes;
using TP2Grupo2_AgenciaDeViajes.Clases;
using System.Text.RegularExpressions;

namespace TP2Grupo2_AgenciaDeViajes
{
    public partial class Registro : Form
    {        
        private AgenciaManager agenciaManager;
        private string idioma;
        private string[] argumentos;
        static Regex validate_emailaddress = email_validation();
        public Registro(AgenciaManager agenciaManager, string idioma)
        {
            InitializeComponent();
            this.agenciaManager = agenciaManager;
            this.idioma = idioma;
            setIdioma();

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            int DNI = 0;
            string password = "";
            string passwordRepe = "";
            string nombre = "";
            string mail = "";
            bool todoOk = true;

            try
            {
                DNI = Int32.Parse(textBoxDNI.Text);
            }
            catch
            {
                MessageBox.Show(idioma == "Español" ? "El DNI es un dato numérico." : "The DNI is a numerical data.");
                todoOk = false;
            }

            nombre = textBoxNombre.Text;
            mail = textBoxMail.Text;
            password = textBoxContrasenia.Text;
            passwordRepe = textBoxContraseniaRepe.Text;

            errorProvider1.SetError(textBoxDNI, "");
            if (DNI <= 0)
            {
                errorProvider1.SetError(textBoxNombre, idioma == "Español" ? "Ingrese DNI" : "Enter DNI");
                todoOk = false;
            } 
            else if (agenciaManager.existeUsuario(DNI))
            {
                errorProvider1.SetError(textBoxDNI, idioma == "Español" ? "El DNI ingresado ya pertenece a un Usuario existente." : "The DNI entered already belongs to an existing User.");
                textBoxDNI.Text = "";
                todoOk = false;
            }

            errorProvider1.SetError(textBoxNombre, "");
            if (nombre == "")
            {
                errorProvider1.SetError(textBoxNombre, idioma == "Español" ? "Ingrese Nombre." : "Enter Name.");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxMail, "");
            if (validate_emailaddress.IsMatch(mail) != true)
            {
                errorProvider1.SetError(textBoxMail, idioma == "Español" ? "Ingrese un Mail válido." : "Enter valid Mail.");
                todoOk = false;
            }

            errorProvider1.SetError(textBoxContrasenia, "");
            if (password == "")
            {
                errorProvider1.SetError(textBoxContrasenia, idioma == "Español" ? "Ingrese Contraseña." : "Enter Password.");
                todoOk = false;
            }
            else if(password != passwordRepe)
            {
                errorProvider1.SetError(textBoxContrasenia, idioma == "Español" ? "Las Contraseñas deben coincidir." : "Passwords must match.");
                textBoxContrasenia.Text = "";
                textBoxContraseniaRepe.Text = "";
                todoOk = false;
            }

            if (todoOk)
            {
                agenciaManager.insertarUsuario(DNI, nombre, mail, password, false);
                MessageBox.Show(idioma == "Español" ? "Su Usuario se registro exitosamente." : "Your User successfully registered.");
                Dispose();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":                    
                    labelDNI.Text = "DNI";
                    labelNombre.Text = "Nombre";
                    labelMail.Text = "Mail";
                    labelPassword.Text = "Contraseña";
                    labelPasswordRepe.Text = "Repetir Contraseña";
                    buttonCancelar.Text = "Cancelar";
                    buttonConfirmar.Text = "Confirmar";
                    textBoxNombre.PlaceholderText = "Nombre";
                    textBoxContrasenia.PlaceholderText = "Contraseña";
                    textBoxContraseniaRepe.PlaceholderText = "Repetir Contraseña";
                    break;


                case "English":
                    labelDNI.Text = "DNI";
                    labelNombre.Text = "Name";
                    labelMail.Text = "Mail";
                    labelPassword.Text = "Password";
                    labelPasswordRepe.Text = "Repeat Password";
                    buttonCancelar.Text = "Cancel";
                    buttonConfirmar.Text = "Confirm";
                    textBoxNombre.PlaceholderText = "Name";
                    textBoxContrasenia.PlaceholderText = "Password";
                    textBoxContraseniaRepe.PlaceholderText = "Repeat Password";
                    break;
            }
        }
    }
}
