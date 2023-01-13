using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> ListaHabitaciones = new List<Habitacion>();

            ListaHabitaciones.Add(new Habitacion(1, 10, "ocupada"));
            ListaHabitaciones.Add(new Habitacion(2, 20, "libre"));
            ListaHabitaciones.Add(new Habitacion(3, 30, "ocupada"));
            ListaHabitaciones.Add(new Habitacion(4, 40, "libre"));
            ListaHabitaciones.Add(new Habitacion(5, 50, "ocupada"));

            return ListaHabitaciones;
        }
        public static List<Habitacion> Listar(Habitacion Estado)
        {
            return null;
        }
        public static int Insertar(Habitacion habitacion)
        {
            //TODO
            return 0;
        }
        public static int Eliminar(Habitacion id)
        {
            //TODO
            return 0;
        }
        public static Habitacion TraerUno(Habitacion numero)
        {
            //TODO
            return null;
        }
    }
}
