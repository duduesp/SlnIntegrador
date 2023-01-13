using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            List<Paciente> ListaPacientes = new List<Paciente>();

            ListaPacientes.Add(new Paciente("Facundo", "Romero", "San Juan 600", 66666, "facundopaciente@gmail.com", 6, 1000));
            ListaPacientes.Add(new Paciente("Matias", "Espinoza", "San Juan 700", 77777, "matiaspaciente@gmail.com", 7, 2000));
            ListaPacientes.Add(new Paciente("Leonel", "Fernández", "San Juan 800", 88888, "leonelpaciente@gmail.com", 8, 3000));
            ListaPacientes.Add(new Paciente("Julian", "Guerrero", "San Juan 900", 99999, "julianpaciente@gmail.com", 9, 4000));
            ListaPacientes.Add(new Paciente("Franco", "Díaz", "San Juan 1000", 00000, "francopaciente@gmail.com", 10, 5000));

            return ListaPacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO Inserta un paciente a la lista

            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO Elimina un paciente de la lista

            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO Trae un paciente de la lista

            return null;
        }

    }
}
