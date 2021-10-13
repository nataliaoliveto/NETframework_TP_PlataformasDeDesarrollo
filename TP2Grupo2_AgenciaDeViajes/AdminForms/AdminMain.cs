using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2Grupo2_AgenciaDeViajes.Clases;

namespace TP2Grupo2_AgenciaDeViajes
{
    public partial class AdminMain : Form
    {
        private AgenciaManager agenciaManager;
        private Usuario usuario;
        private string idioma;
        public AdminMain(AgenciaManager agenciaManager, Usuario usuario, string idioma)
        {            
            InitializeComponent();
            this.agenciaManager = agenciaManager;
            this.usuario = usuario;
            this.idioma = idioma;
            setIdioma();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAdminAlojamientos.Controls.Add(childForm);
            panelAdminAlojamientos.Tag = childForm;
            childForm.BringToFront(); 
            childForm.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            this.Hide();            
        }

        private void buttonAlojamientos_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminAlojamientos(this.agenciaManager, idioma));
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminUsuarios(this.agenciaManager, idioma));
        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminReservas(this.agenciaManager, idioma));
        }

        private void setIdioma()
        {
            switch (idioma)
            {
                case "Español":
                    buttonAlojamientos.Text = "ALOJAMIENTOS";
                    buttonReservas.Text = "RESERVAS";
                    buttonUsuarios.Text = "USUARIOS";
                    buttonDesconectarse.Text = "DESCONECTARSE";
                    break;


                case "English":
                    buttonAlojamientos.Text = "LODGINGS";
                    buttonReservas.Text = "BOOKINGS";
                    buttonUsuarios.Text = "USERS";
                    buttonDesconectarse.Text = "LOG OUT";
                    break;
            }
        }
    }
}
