using System;
using System.Collections.Generic;
using System.Text;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    public class Cabania : Alojamiento
    {
        public double cPrecioxDia { get; set; }
        public int cHabitaciones { get; set; }
        public int cbanios { get; set; }

        public Cabania() : base() { }
        public Cabania(int aCodigo, String aCiudad, String aBarrio, int aEstrellas, int aCantPersonas, bool aTV, double cPrecioxDia, int cHabitaciones, int cbanios) : base(aCodigo, aCiudad, aBarrio, aEstrellas, aCantPersonas, aTV)
        {
            this.cPrecioxDia = cPrecioxDia;
            this.cHabitaciones = cHabitaciones;
            this.cbanios = cbanios;
        }

        public override String ToString()
        {
            return base.ToString() + "CABANIA" + "," + cPrecioxDia + "," + cHabitaciones + "," + cbanios;
        }        
    }
}
