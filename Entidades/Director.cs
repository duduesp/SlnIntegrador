using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Director : Persona
    {
        public Director(string Nombre, string Apellido, string Domicilio, int Telefono, string Email, int Id, string Especialidad, int Matricula) : base(Nombre, Apellido, Domicilio, Telefono, Email, Id)
        {
            this.Especialidad = Especialidad;
            this.Matricula = Matricula;
        }
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
    }
}
