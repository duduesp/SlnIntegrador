using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director : Persona
    {
        public Director(string Nombre, string Apellido, string Domicilio, int Telefono, string Email, int Id, int Matricula, string Especialidad) : base(Nombre, Apellido, Domicilio, Telefono, Email, Id)
        {
            this.Matricula = Matricula;
            this.Especialidad = Especialidad;
        }
        public int Matricula { get; set; }
        public string Especialidad { get; set; }
        
    }
}
