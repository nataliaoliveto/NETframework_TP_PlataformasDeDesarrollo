using System;
using System.Collections.Generic;
using System.Text;
using EasyEncryption;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    public class Usuario
    {
        public int id { get; set; }
        public int DNI { get; set; }
        public String nombre { get; set; }
        public String mail { get; set; }
        public String password { get; set; }
        public bool esADMIN { get; set; }
        public bool bloqueado { get; set; }

        public Usuario() { }

        public Usuario(int DNI, String nombre, String mail, String password, bool esADMIN)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.mail = mail;
            this.password = password;
            this.esADMIN = esADMIN;
            this.bloqueado = false;
        }

        public override String ToString()
        {
            return DNI + "," + nombre + "," + mail + "," + password + "," + esADMIN + "," + bloqueado;
        }
    }
}
