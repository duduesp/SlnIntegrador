using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clinica
    {
        public Clinica(int Id, string Nombre, string Domicilio, int Telefono, string Email)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Email = Email;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

    }
}
