using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TP2Grupo2_AgenciaDeViajes;
using TP2Grupo2_AgenciaDeViajes.Clases;
using EasyEncryption;
using System.Globalization;

namespace TP2Grupo2_AgenciaDeViajes
{
    public partial class LogIn : Form
    {
        private const int cantMaxIntentos = 3;
        private AgenciaManager agenciaManager;
        private Usuario usuario;
        public int usuarioIngresado;
        public String contraseniaIngresada;
        public bool loginOk;
        public IDictionary<int, int> loginHistory = new Dictionary<int, int>();

        private string[] argumentos;
        public LogIn(string[] args)
        {
            this.agenciaManager = new AgenciaManager();
            InitializeComponent();
            comboBoxLanguage.Text = "Español";
            argumentos = args;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            labelFormatoInvalido.Text = "";
            labelIntentos.Text = "";

            try
            {
                usuarioIngresado = Int32.Parse(textUsuario.Text);  
            }
            catch(FormatException)
            {
                labelFormatoInvalido.Text = comboBoxLanguage.Text == "Español" ? "El DNI tiene que ser numérico." : "The DNI must be numeric.";
            }
            
            contraseniaIngresada = textContrasenia.Text;
            usuario = agenciaManager.devolverUsuario(usuarioIngresado);

            if (usuario != null)
            {
                string contraseniaIngresadaHash = SHA.ComputeSHA256Hash(contraseniaIngresada);
                loginOk = agenciaManager.autenticarUsuario(usuarioIngresado, contraseniaIngresadaHash);
                if (loginOk)
                {
                    if (!usuario.bloqueado)
                    {
                        if (usuario.esADMIN)
                        {
                            argumentos[0] = "admin";
                            Form formAdmin = new AdminMain(this.agenciaManager, this.usuario, comboBoxLanguage.Text);
                            textUsuario.Text = "";
                            textContrasenia.Text = "";
                            loginHistory.Clear();                            
                            this.Hide();
                            formAdmin.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            argumentos[0] = "user";
                            Form formUser = new UserMain(this.agenciaManager, this.usuario, comboBoxLanguage.Text);
                            textUsuario.Text = "";
                            textContrasenia.Text = "";
                            loginHistory.Clear();
                            this.Hide();
                            formUser.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        labelIntentos.Text = comboBoxLanguage.Text == "Español" ? "Su usuario está bloqueado." : "Your user is blocked.";
                    }
                }
                else
                {
                    if (loginHistory.TryGetValue(usuarioIngresado, out int value))
                    {                        
                        loginHistory[usuarioIngresado] = loginHistory[usuarioIngresado] + 1;
                        labelIntentos.Text = comboBoxLanguage.Text == "Español" ? "Datos incorrectos, intento " + loginHistory[usuarioIngresado] + "/3" : "Wrong Data, attemp " + loginHistory[usuarioIngresado] + "/3";
                        if (loginHistory[usuarioIngresado] == cantMaxIntentos)
                        {
                            agenciaManager.bloquearDesbloquearUsuario(usuario.DNI, true);
                            labelIntentos.Text = comboBoxLanguage.Text == "Español" ? "Intento 3/3, usuario bloqueado." : "Attempt 3/3, user blocked.";
                        }
                    }
                    else
                    {
                        labelIntentos.Text = comboBoxLanguage.Text == "Español" ? "Datos incorrectos, intento 1/3" : "Wrong data, attemp 1/3";
                        loginHistory.Add(usuarioIngresado, 1);
                    }             
                }
            }
            else
            {
                labelIntentos.Text = comboBoxLanguage.Text == "Español" ? "Usuario inexistente." : "Non-existent user.";
            }
        }

        private void Pass_Load(object sender, EventArgs e)
        {           
        }

        private void buttonCambiarContrasenia_Click(object sender, EventArgs e)
        {

        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            agenciaManager.cerrarContexto();
            this.Dispose();
        }

        private void buttonDesconectarse_Click(object sender, EventArgs e)
        {
            Form registro = new Registro(this.agenciaManager, comboBoxLanguage.Text);
            textUsuario.Text = "";
            textContrasenia.Text = "";
            loginHistory.Clear();
            this.Hide();
            registro.ShowDialog();
            this.Show();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
        } 

        private void comboBoxLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBoxLanguage.Text)
            {
                case "Español":                   
                    labelDNI.Text = "DNI";
                    labelPassword.Text = "Contraseña";
                    buttonCancelar.Text = "Cancelar";
                    buttonLogin.Text = "Ingresar";
                    buttonRegistrarse.Text = "REGISTRARSE";
                    labelLanguage.Text = "Idioma";
                    break;
               

                case "English":
                    labelDNI.Text = "DNI";
                    labelPassword.Text = "Password";
                    buttonCancelar.Text = "Cancel";
                    buttonLogin.Text = "Login";
                    buttonRegistrarse.Text = "SIGN IN";
                    labelLanguage.Text = "Language";
                    break;
            }

        }
    }
}
