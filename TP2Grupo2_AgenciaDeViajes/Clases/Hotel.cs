using System;
using System.Collections.Generic;
using System.Text;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    public class Hotel : Alojamiento
    {
       public double hPrecioxPersona { get; set; }       

        public Hotel() : base() { }

        public Hotel(int aCodigo, String aCiudad, String aBarrio, int aEstrellas, int aCantPersonas, bool aTV, double hPrecioxPersona) : base(aCodigo, aCiudad, aBarrio, aEstrellas, aCantPersonas, aTV)
       {
            this.hPrecioxPersona = hPrecioxPersona;
       }

        public override String ToString()
        {
            return base.ToString() + "HOTEL" + "," + hPrecioxPersona;
        }
    }
}
