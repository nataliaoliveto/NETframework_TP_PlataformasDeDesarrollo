using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using EasyEncryption;
using Microsoft.EntityFrameworkCore;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    public class AgenciaManager
    {
        public Agencia miAgencia { get; set; }
        private DbSet<Reserva> misReservas;
        private DbSet<Usuario> misUsuarios;
        private MyContext contexto;

        public AgenciaManager()
        {
            Agencia agencia = new Agencia();
            this.miAgencia = agencia;
            inicializarAtributos();
        }

        // Calculo el precio de una Reserva.
        public float calcularPrecioReserva(int codAloj, DateTime fDesde, DateTime fHasta, int cantPersonas)
        {
            float precio = 0;
            var span = fHasta.Date.Subtract(fDesde.Date);
            int dias = span.Days;
            dias = dias + 1;
            Alojamiento propiedad = devolverAlojamiento(codAloj);

            if (propiedad is Hotel)
            {
                Hotel hotel = (Hotel)propiedad;
                precio = Convert.ToSingle(hotel.hPrecioxPersona * cantPersonas * dias);
            }
            else if (propiedad is Cabania)
            {
                Cabania cabania = (Cabania)propiedad;
                precio = Convert.ToSingle(cabania.cPrecioxDia * dias);
            }
            return precio;
        }                              

        // Devuelve el Alojamiento correspondiente al Código recibido.
        public Alojamiento devolverAlojamiento(int aCodigo)
        {
            if (miAgencia.hayAlojamientos())
            {
                foreach (Alojamiento alojamiento in miAgencia.getMisAlojamientos())
                {
                    if (alojamiento.aCodigo == aCodigo)
                    {
                        return alojamiento;
                    }
                }
            }
            return null;
        }

        // Devuelve el Usuario correspondiente al DNI recibido.
        public Usuario devolverUsuario(int dni)
        {
            if (misUsuarios.Count() > 0)
            {
                foreach (Usuario usuario in misUsuarios)
                {
                    if (usuario.DNI == dni)
                    {
                        return usuario;
                    }
                }
            }
            return null;
        }       

        // Autentica al Usuario.
        public bool autenticarUsuario(int dni, string password)
        {
            foreach (Usuario usuario in misUsuarios)
            {
                if (usuario.DNI == dni && usuario.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        // Determina si el DNI recibido pertenece a algún Usuario.
        public bool existeUsuario(int dni)
        {
            foreach (Usuario usuario in misUsuarios)
            {
                if (usuario.DNI == dni)
                {
                    return true;
                }
            }
            return false;
        }

        // Devuelve la Reserva correspondiente al ID recibido.
        public Reserva devolverReserva(int id)
        {
            if (misReservas.Count() > 0)
            {
                foreach (Reserva reserva in misReservas)
                {
                    if (reserva.id == id)
                    {
                        return reserva;
                    }
                }
            }
            return null;
        }

        // Devuelve la cantidad de Reservas que tiene el Usuario correspondiente al DNI recibido por parámetro.
        public int cantReservasUsuario(int dni)
        {
            int cantReservas = 0;

            foreach (Reserva reserva in misReservas)
            {
                if (reserva.persona.DNI == dni)
                {
                    cantReservas++;
                }
            }

            return cantReservas;
        }

        // Devuelve la cantidad de Reservas que tiene el Alojamiento correspondiente al Código recibido por parámetro.
        public int cantReservasAlojamiento(int codigo)
        {
            int cantReservas = 0;

            foreach (Reserva reserva in misReservas)
            {
                if (reserva.propiedad.aCodigo == codigo)
                {
                    cantReservas++;
                }
            }

            return cantReservas;
        }

        // Devuelve el ID del Usuario correspondiente al DNI recibido por parámetro.
        public int obtenerUsuarioId(int dni)
        {
            foreach (Usuario u in misUsuarios)
            {
                if (u.DNI == dni)
                {
                    return u.id;
                }
            }
            return 0;
        }

        // Devuelve el ID del Alojamiento correspondiente al Código recibido por parámetro.
        public int obtenerAlojamientoId(int aCodigo)
        {
            foreach (Alojamiento a in miAgencia.misAlojamientos)
            {
                if (a.aCodigo == aCodigo)
                {
                    return a.id;
                }
            }
            return 0;
        }        

        // Genera un CSV para debugear.
        public void generarDebugCSV(string msgDebug)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 999);
            string path = @".\Archivos\";
            string fileDebug = @"debug" + random + ".txt";
            string destFileDebug = System.IO.Path.Combine(path, fileDebug);

            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            StreamWriter sw = new StreamWriter(destFileDebug);

            sw.WriteLine(msgDebug);

            sw.Close();
        }

        // Genera el Array de Alojamientos para cargar el DGV de los Alojamientos que puede ver un Usuario administrador.
        public string[][] generarArrayAlojamientos()
        {
            List<string[]> listRows = new List<string[]>();

            foreach (Alojamiento alojamiento in miAgencia.getMisAlojamientos())
            {
                string[] row = new string[11];

                row[0] = alojamiento.aCodigo.ToString();
                row[1] = alojamiento is Hotel ? "Hotel" : "Cabaña";
                row[2] = alojamiento.aCiudad;
                row[3] = alojamiento.aBarrio;
                row[4] = alojamiento.aEstrellas.ToString();
                row[5] = alojamiento.aCantPersonas.ToString();
                row[6] = alojamiento.aTV ? "Sí" : "No";
                if (alojamiento is Hotel)
                {
                    Hotel hotel = (Hotel)alojamiento;

                    row[7] = hotel.hPrecioxPersona.ToString();
                    row[8] = "N/A";
                    row[9] = "N/A";
                    row[10] = "N/A";
                }
                else
                {
                    Cabania cabania = (Cabania)alojamiento;

                    row[7] = "N/A";
                    row[8] = cabania.cPrecioxDia.ToString();
                    row[9] = cabania.cHabitaciones.ToString();
                    row[10] = cabania.cbanios.ToString();

                }
                listRows.Add(row);
            }
            return listRows.ToArray();
        }

        // Genera el Array de Alojamientos para cargar el DGV de los Alojamientos que puede ver un Usuario que NO es administrador.
        public string[][] generarArrayAlojamientosUsuario(String aCiudad, DateTime fDesde, DateTime fHasta, int aCantPersonas, String tipo)
        {
            List<string[]> listRows = new List<string[]>();
            List<Alojamiento> alojamientosFiltrados = devolverAlojamientosReservables(aCiudad, fDesde, fHasta, aCantPersonas, tipo);

            foreach (Alojamiento alojamiento in alojamientosFiltrados)
            {
                string[] row = new string[11];

                row[0] = alojamiento.aCodigo.ToString();
                row[1] = alojamiento is Hotel ? "Hotel" : "Cabaña";
                row[2] = alojamiento.aCiudad;
                row[3] = alojamiento.aBarrio;
                row[4] = alojamiento.aEstrellas.ToString();
                row[5] = alojamiento.aCantPersonas.ToString();
                row[6] = alojamiento.aTV ? "Sí" : "No";
                if (alojamiento is Hotel)
                {
                    Hotel hotel = (Hotel)alojamiento;

                    row[7] = hotel.hPrecioxPersona.ToString();
                    row[8] = "N/A";
                    row[9] = "N/A";
                    row[10] = "N/A";
                }
                else
                {
                    Cabania cabania = (Cabania)alojamiento;

                    row[7] = "N/A";
                    row[8] = cabania.cPrecioxDia.ToString();
                    row[9] = cabania.cHabitaciones.ToString();
                    row[10] = cabania.cbanios.ToString();

                }
                listRows.Add(row);
            }
            return listRows.ToArray();
        }

        // Genera el Array de Usuarios para cargar el DGV de los Usuarios que puede ver un Usuario administrador.
        public string[][] generarArrayUsuarios()
        {
            List<string[]> listRows = new List<string[]>();

            foreach (Usuario usuario in misUsuarios)
            {                
                string[] row = new string[5];

                row[0] = usuario.DNI.ToString();
                row[1] = usuario.nombre;
                row[2] = usuario.mail;
                row[3] = usuario.bloqueado ? "Si" : "No";
                row[4] = usuario.esADMIN ? "Sí" : "No";
                listRows.Add(row);
            }
            return listRows.ToArray();
        }

        // Genera el Array de Usuarios para cargar el DGV del Perfil del Usuario que NO es administrador recibido.
        public string[][] generarArrayUsuarios(Usuario usuarioParametro)
        {
            List<string[]> listRows = new List<string[]>();

            foreach (Usuario usuario in misUsuarios)
            {                
                if (usuario.DNI == usuarioParametro.DNI)
                {
                    string[] row = new string[5];

                    row[0] = usuario.DNI.ToString();
                    row[1] = usuario.nombre;
                    row[2] = usuario.mail;
                    row[3] = usuario.bloqueado ? "Si" : "No";
                    row[4] = usuario.esADMIN ? "Sí" : "No";
                    listRows.Add(row);
                }
            }
            return listRows.ToArray();
        }

        // Genera el Array de Reservas para cargar el DGV de las Reservas que puede ver un Usuario administrador.
        public string[][] generarArrayReservas()
        {
            List<string[]> listRows = new List<string[]>();

            foreach (Reserva reserva in misReservas)
            {                
                string tipoPropiedad = reserva.propiedad.aCodigo.ToString();      
                    
                if (reserva.propiedad is Hotel)
                {
                    tipoPropiedad += " | Hotel";
                }
                else
                {
                    tipoPropiedad += " | Cabaña";
                }

                string[] row = new string[7];

                row[0] = reserva.id.ToString();
                row[1] = tipoPropiedad;
                row[2] = reserva.persona.DNI.ToString();
                row[3] = reserva.fDesde.ToString("yyyy/MM/dd");
                row[4] = reserva.fHasta.ToString("yyyy/MM/dd");
                row[5] = reserva.cantPersonas.ToString();
                row[6] = reserva.precio.ToString();
                listRows.Add(row);

            }        
            return listRows.ToArray();
        }

        // Genera el Array de Reservas para cargar el DGV de las Reservas del Usuario que NO es administrador recibido.
        public string[][] generarArrayReservas(int dni)
        {
            List<string[]> listRows = new List<string[]>();

            foreach (Reserva reserva in misReservas)
            {
                int reservaDNI = reserva.persona.DNI;
                string tipoPropiedad = reserva.propiedad.aCodigo.ToString();
                if (reservaDNI == dni)
                {
                    if (reserva.propiedad is Hotel)
                    {
                        tipoPropiedad += " | Hotel";
                    }
                    else
                    {
                        tipoPropiedad += " | Cabaña";
                    }

                    string[] row = new string[6];

                    row[0] = reserva.id.ToString();
                    row[1] = tipoPropiedad;
                    row[2] = reserva.fDesde.ToString("yyyy/MM/dd");
                    row[3] = reserva.fHasta.ToString("yyyy/MM/dd");
                    row[4] = reserva.cantPersonas.ToString();
                    row[5] = reserva.precio.ToString();
                    listRows.Add(row);
                }

            }
            return listRows.ToArray();
        }                

        // Inicializa Usuarios, Alojamientos y Reservas.
        private void inicializarAtributos()
        {
            try
            {
                // Creo un contexto
                contexto = new MyContext();

                // Cargo los usuarios
                contexto.usuarios.Load();
                misUsuarios = contexto.usuarios;

                // Cargo los Alojamientos
                contexto.alojamientos.Load();
                miAgencia.misAlojamientos = contexto.alojamientos;
                miAgencia.cantAlojamientos = miAgencia.misAlojamientos.Count();

                //// Cargo los Reservas
                contexto.reservas.Load();
                misReservas = contexto.reservas;
            }
            catch (Exception ex)
            {
                generarDebugCSV(ex.Message);
            }
        }

        // Cierra el Contexto.
        public void cerrarContexto()
        {
            contexto.Dispose();
        }

        // Inserta un Usuario.
        public bool insertarUsuario(int dni, string nombre, string mail, string password, bool esAdmin)
        {
            if (!existeUsuario(dni))
            {
                try
                {
                    string passwordHash = SHA.ComputeSHA256Hash(password);
                    Usuario usuario = new Usuario(dni, nombre, mail, passwordHash, esAdmin);
                    misUsuarios.Add(usuario);
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;            
        }

        // Modifica un Usuario
        public bool modificarUsuario(int dni, string nombre, string mail, bool esAdmin)
        {
            bool todoOk = false;

            foreach (Usuario u in misUsuarios)
            {
                if (u.DNI == dni)
                {
                    u.nombre = nombre;
                    u.mail = mail;
                    u.esADMIN = esAdmin;
                    misUsuarios.Update(u);
                    todoOk = true;
                }
            }

            if (todoOk)
            {
                contexto.SaveChanges();
            }

            return todoOk;
        }

        // Elimina un Usuario
        public bool eliminarUsuario(int dni)
        {
            try
            {
                bool todoOk = false;
                foreach (Usuario u in misUsuarios)
                {
                    if (u.DNI == dni)
                    {
                        misUsuarios.Remove(u);
                        todoOk = true;
                    }
                }

                if (todoOk)
                {
                    contexto.SaveChanges();
                }
                return todoOk;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cambia la Contraseña del Usuario que se corresponde con el DNI recibido.
        public bool cambiarPasswordUsuario(int dni, string password)
        {
            string passwordHash = SHA.ComputeSHA256Hash(password);
            bool todoOk = false;
            foreach (Usuario u in misUsuarios)
            {
                if (u.DNI == dni)
                {
                    u.password = passwordHash;
                    misUsuarios.Update(u);
                    todoOk = true;
                }
            }

            if (todoOk)
            {
                contexto.SaveChanges();
            }
            return todoOk;
        }

        // Bloquea/Desbloquea el Usuario que se corresponde con el DNI recibido.
        public bool bloquearDesbloquearUsuario(int dni, bool bloqueado)
        {
            bool todoOk = false;
            foreach (Usuario u in misUsuarios)
            {
                if (u.DNI == dni)
                {
                    u.bloqueado = bloqueado;
                    misUsuarios.Update(u);
                    todoOk = true;
                }
            }

            if (todoOk)
            {
                contexto.SaveChanges();
            }
            return todoOk;
        }

        // Inserta un Alojamiento.
        public bool insertarAlojamiento(int aCodigo, String aCiudad, String aBarrio, int aEstrellas, int aCantPersonas, bool aTV, double hPrecioxPersona, double cPrecioxDia, int cHabitaciones, int cbanios, string aTipo)
        {
            if (!miAgencia.estaLlena() && !miAgencia.estaAlojamiento(aCodigo))
            {
                try
                {
                    if (aTipo == "HOTEL")
                    {
                        Hotel hotel = new Hotel(aCodigo, aCiudad, aBarrio, aEstrellas, aCantPersonas, aTV, hPrecioxPersona);
                        miAgencia.misAlojamientos.Add(hotel);
                        miAgencia.cantAlojamientos++;
                    }
                    else
                    {
                        Cabania cabania = new Cabania(aCodigo, aCiudad, aBarrio, aEstrellas, aCantPersonas, aTV, cPrecioxDia, cHabitaciones, cbanios);
                        miAgencia.misAlojamientos.Add(cabania);
                        miAgencia.cantAlojamientos++;
                    }                    
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        // Modifica un Alojamiento.
        public bool modificarAlojamiento(int aCodigo, String aCiudad, String aBarrio, int aEstrellas, int aCantPersonas, bool aTV, double hPrecioxPersona, double cPrecioxDia, int cHabitaciones, int cbanios, string aTipo)
        {

            bool todoOk = false;

            foreach (Alojamiento a in miAgencia.misAlojamientos)
            {
                if (a is Hotel && a.aCodigo == aCodigo)
                {
                    Hotel h = (Hotel)a;

                    h.aCiudad = aCiudad;
                    h.aBarrio = aBarrio;
                    h.aEstrellas = aEstrellas;
                    h.aCantPersonas = aCantPersonas;
                    h.aTV = aTV;
                    h.hPrecioxPersona = hPrecioxPersona;

                    miAgencia.misAlojamientos.Update(h);
                    todoOk = true;
                }
                else
                {
                    if (a is Cabania && a.aCodigo == aCodigo)
                    {
                        Cabania c = (Cabania)a;

                        c.aCiudad = aCiudad;
                        c.aBarrio = aBarrio;
                        c.aEstrellas = aEstrellas;
                        c.aCantPersonas = aCantPersonas;
                        c.aTV = aTV;
                        c.cPrecioxDia = cPrecioxDia;
                        c.cHabitaciones = cHabitaciones;
                        c.cbanios = cbanios;

                        miAgencia.misAlojamientos.Update(c);
                        todoOk = true;
                    }
                }
            }            

            if (todoOk)
            {
                contexto.SaveChanges();
            }

            return todoOk;
        }

        // Elimina un Alojamiento.
        public bool eliminarAlojamiento(int aCodigo)
        {
            try
            {
                bool todoOk = false;
                foreach (Alojamiento a in miAgencia.misAlojamientos)
                {
                    if (a.aCodigo == aCodigo)
                    {
                        miAgencia.misAlojamientos.Remove(a);
                        miAgencia.cantAlojamientos--;
                        todoOk = true;
                    }
                }

                if (todoOk)
                {
                    contexto.SaveChanges();
                }
                return todoOk;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Devuelve los Alojamientos reservables para la Ciudad, Fecha Desde, Fecha Hasta, Cantidad de Personas y Tipo recibidos.
        public List<Alojamiento> devolverAlojamientosReservables(String aCiudad, DateTime fDesde, DateTime fHasta, int aCantPersonas, string aTipo)
        {
            var queryAlojamientos = from aloj in miAgencia.misAlojamientos.AsEnumerable()
                                    where (aTipo == "Ambos" || (aTipo == "Hotel" && aloj is Hotel) || (aTipo == "Cabania" && aloj is Cabania)) &&
                                            (aCiudad == "" || aloj.aCiudad.StartsWith(aCiudad)) &&
                                            (aCantPersonas == 0 || aloj.aCantPersonas >= aCantPersonas)
                                    select aloj;

            var queryReservas = from r in misReservas.AsEnumerable()
                                where (fDesde.Date >= r.fDesde && fHasta.Date <= r.fHasta) ||
                                        (fHasta.Date >= r.fDesde && fHasta.Date <= r.fHasta) ||
                                        (fDesde.Date >= r.fDesde && fDesde.Date <= r.fHasta) ||
                                        (fDesde.Date <= r.fDesde && fHasta.Date >= r.fHasta)
                                select r;

            List<Alojamiento> alojamientosUsuario = new List<Alojamiento>();
            List<Alojamiento> alojamientosFiltrados = queryAlojamientos.ToList();
            List<Reserva> reservasFiltradas = queryReservas.ToList();

            foreach (Alojamiento alojamiento in alojamientosFiltrados)
            {
                bool agregarAlojamiento = true;

                foreach (Reserva reserva in reservasFiltradas)
                {
                    if (alojamiento.id == reserva.propiedadId)
                    {
                        agregarAlojamiento = false;
                    }
                }

                if (agregarAlojamiento)
                {
                    alojamientosUsuario.Add(alojamiento);
                }
            }
            return alojamientosUsuario;
        }

        // Inserta una Reserva.
        public bool insertarReserva(DateTime fDesde, DateTime fHasta, int propiedad, int persona, float precio, int cantPersonas)
        {
            int propiedadId = obtenerAlojamientoId(propiedad);
            int count = 0;

            foreach (Reserva r in misReservas)
            {
                if (r.propiedadId == propiedadId)
                {
                    if ((fDesde.Date >= r.fDesde && fHasta.Date <= r.fHasta) ||
                        (fHasta.Date >= r.fDesde && fHasta.Date <= r.fHasta) ||
                        (fDesde.Date >= r.fDesde && fDesde.Date <= r.fHasta) ||
                        (fDesde.Date <= r.fDesde && fHasta.Date >= r.fHasta))
                    {
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                try
                {
                    Alojamiento alojamiento = devolverAlojamiento(propiedad);
                    Usuario usuario = devolverUsuario(persona);

                    Reserva reserva = new Reserva(fDesde.Date, fHasta.Date, alojamiento, usuario, precio, cantPersonas);

                    misReservas.Add(reserva);
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;                    
        }

        // Modifica una Reserva.
        public bool modificarReserva(int id, DateTime fDesde, DateTime fHasta, int propiedad, int persona, float precio, int cantPersonas)
        {
            bool todoOk = false;

            int propiedadId = obtenerAlojamientoId(propiedad);
            int usuarioId = obtenerUsuarioId(persona);
            int count = 0;

            foreach (Reserva r in misReservas)
            {
                if (r.id != id && r.propiedadId == propiedadId)
                {
                    if ((fDesde.Date >= r.fDesde && fHasta.Date <= r.fHasta) ||
                        (fHasta.Date >= r.fDesde && fHasta.Date <= r.fHasta) ||
                        (fDesde.Date >= r.fDesde && fDesde.Date <= r.fHasta) ||
                        (fDesde.Date <= r.fDesde && fHasta.Date >= r.fHasta))
                    {
                        count++;
                    }                    
                }
            }

            if (count == 0)
            {
                foreach (Reserva r in misReservas)
                {
                    if (r.id == id)
                    {
                        r.fDesde = fDesde.Date;
                        r.fHasta = fHasta.Date;
                        r.propiedadId = propiedadId;
                        r.personaId = usuarioId;
                        r.precio = precio;
                        r.cantPersonas = cantPersonas;

                        misReservas.Update(r);
                        todoOk = true;
                    }
                }
            }

            if (todoOk)
            {
                contexto.SaveChanges();
            }
            
            return todoOk;
        }

        // Elimina una Reserva.
        public bool eliminarReserva(int id)
        {
            try
            {
                bool todoOk = false;

                foreach (Reserva r in misReservas)
                {
                    if (r.id == id)
                    {
                        misReservas.Remove(r);
                        todoOk = true;
                    }
                }

                if (todoOk)
                {
                    contexto.SaveChanges();
                }
                return todoOk;
            }
            catch (Exception)
            {
                return false;
            }
        }        

    }
}


