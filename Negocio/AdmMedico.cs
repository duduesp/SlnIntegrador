using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> Listar()
        {
            List<Medico> ListaMedicos = new List<Medico>();

            ListaMedicos.Add(new Medico("Juan", "Perez", "San Juan 500", 11111, "juanmedico@gmail.com", 1, 100, "Clinico"));
            ListaMedicos.Add(new Medico("Pablo", "Gonzalez", "San Juan 600", 22222, "pablomedico@gmail.com", 2, 200, "Clinico"));
            ListaMedicos.Add(new Medico("Pedro", "Gutierrez", "San Juan 700", 33333, "pedromedico@gmail.com", 3, 300, "Pediatra"));
            ListaMedicos.Add(new Medico("Marco", "Martinez", "San Juan 800", 44444, "marcomedico@gmail.com", 4, 400, "Pediatra"));
            ListaMedicos.Add(new Medico("Javier", "Alvarez", "San Juan 900", 55555, "javiermedico@gmail.com", 5, 500, "Traumatologo"));

            return ListaMedicos;
        }
        public static List<Medico> Listar(Medico Especialidad)
        {
            //TODO
            return null;
        }
        public static int Insertar(Medico medico)
        {
            //TODO
            return 0;
        }
        public static int Eliminar(Medico id)
        {
            //TODO
            return 0;
        }
        public static Medico TraerUno(Medico id)
        {
            //TODO
            return null;
        }
    }
}
