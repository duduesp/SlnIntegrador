using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using Entidades;

namespace Datos
{
    public static class DacPaciente
    {
        private static DBVentasContext context = new DBVentasContext();

        public static List<Paciente> Select()
        {
            return context.Pacientes.ToList();
        }

        public static Paciente SelectById(int id)
        {
            return context.Pacientes.Find(id);
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();
        }
        public static int Eliminar(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.Id);
            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
        public static int Update(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.Id);
            pacienteOrigen.Nombre = paciente.Nombre;

            return context.SaveChanges();
        }
    }
}
