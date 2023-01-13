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

            ListaPacientes.Add(new Paciente("Juan", "Perez", "San Juan 500", 11111, "juanmedico@gmail.com", 1, 1000));
            ListaPacientes.Add(new Paciente("Pablo", "Gonzalez", "San Juan 600", 22222, "pablomedico@gmail.com", 2, 2000));
            ListaPacientes.Add(new Paciente("Pedro", "Gutierrez", "San Juan 700", 33333, "pedromedico@gmail.com", 3, 3000));
            ListaPacientes.Add(new Paciente("Marco", "Martinez", "San Juan 800", 44444, "marcomedico@gmail.com", 4, 4000));
            ListaPacientes.Add(new Paciente("Javier", "Alvarez", "San Juan 900", 55555, "javiermedico@gmail.com", 5, 5000));

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
