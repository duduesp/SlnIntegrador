using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero : Persona
    {
        public Enfermero(string Nombre, string Apellido, string Domicilio, int Telefono, string Email, int Id, int Cuil) : base(Nombre, Apellido, Domicilio, Telefono, Email, Id)
        {
            this.Cuil = Cuil;
        }
        public int Cuil { get; set; }
    }
}
