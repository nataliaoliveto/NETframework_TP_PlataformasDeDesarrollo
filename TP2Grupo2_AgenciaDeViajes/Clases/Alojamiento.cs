using System;
using System.Collections.Generic;
using System.Text;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    public class Alojamiento
    {
        public int id { get; set; }
        public int aCodigo { get; set; }
        public String aCiudad { get; set; }
        public String aBarrio { get; set; }
        public int aEstrellas { get; set; }
        public int aCantPersonas { get; set; }
        public bool aTV { get; set; }

        public Alojamiento() { }

        public Alojamiento(int aCodigo, String aCiudad, String aBarrio, int aEstrellas, int aCantPersonas, bool aTV)
        {
            this.aCodigo = aCodigo;
            this.aCiudad = aCiudad;
            this.aBarrio = aBarrio;
            this.aEstrellas = aEstrellas;
            this.aCantPersonas = aCantPersonas;
            this.aTV = aTV;
        }

        public override String ToString()
        {
            return aCodigo + "," + aCiudad + "," + aBarrio + "," + aEstrellas + "," + aCantPersonas + "," + aTV + ",";
        }

    }
}
