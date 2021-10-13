using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    public class Agencia
    {
        private const int maxAlojamientos = 10 ;
        public DbSet<Alojamiento> misAlojamientos;
        public int cantAlojamientos { get; set; }

        public Agencia(){ }

        public List<Alojamiento> getMisAlojamientos()
        {
            return misAlojamientos.ToList().OrderBy(a => a.aEstrellas).ThenBy(a => a.aCantPersonas).ThenBy(a => a.aCodigo).ToList();
        }

        // Determina si existe algún Alojamiento con el Código recibido por parámetro.
        public bool estaAlojamiento(int aCodigo)
        {
            if (hayAlojamientos())
            {
                foreach (Alojamiento alojamiento in misAlojamientos)
                {
                    if (alojamiento.aCodigo == aCodigo)
                    {
                        return true;
                    }                   
                }
            }
            return false;
        }

        // Determina si la Agencia está llena, es decir, si hay tantos Alojamientos como maxAlojamientos tiene la Agencia.
        public bool estaLlena() 
        {
            return (cantAlojamientos == maxAlojamientos) ? true : false;
        }

        // Determina si la Agencia tiene algún Alojamiento.
        public bool hayAlojamientos()
        {
            return (cantAlojamientos > 0) ? true : false;
        }

        // Devuelve la máxima cantidad de Alojamientos que puede tener la Agencia.
        public int getMaxAlojamientos()
        {
            return maxAlojamientos;
        }

        public override String ToString()  
        {
            String resStr = "";
            String alojamientosStr = "";

            if (hayAlojamientos())
            {

                foreach (Alojamiento alojamiento in misAlojamientos)
                {
                    alojamientosStr += alojamiento.ToString();
                }

                resStr += "\nAlojamientos: " + alojamientosStr + "\n";

            }
            else
            {
                resStr += "\nNo hay alojamientos en la Agencia. \n";
            }
            return resStr;
        }
    }
}
