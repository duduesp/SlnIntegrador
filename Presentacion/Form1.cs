using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridMostrarMedicos.DataSource = AdmMedico.Listar();
            gridMostrarPacientes.DataSource = AdmPaciente.Listar();

            listBoxMedicosClinicos.DataSource = ListarNombresDeMedicosClinicos();

            listBoxHabitaciones.DataSource = ListadoHabitacionesConNumeroYEstado();

        }

        private List<string> ListarNombresDeMedicosClinicos()
        {
            List<Medico> ListaMedicos = AdmMedico.Listar();

            List<string> ListaDeNombresDeMedicosClinicos = new List<string>();

            ListaDeNombresDeMedicosClinicos.Add("La lista de los nombres de los médicos clínicos es: ");

            foreach (Medico medico in ListaMedicos)
            {
                if (medico.Especialidad == "Clinico")
                {
                    ListaDeNombresDeMedicosClinicos.Add(medico.Nombre);
                } 
            }

            return ListaDeNombresDeMedicosClinicos;
        }

        private List<string> ListadoHabitacionesConNumeroYEstado()
        {
            List<Habitacion> ListaHabitaciones = AdmHabitacion.Listar();

            List<string> ListaDeHabitacionesConNumeroYEstado = new List<string>();

            ListaDeHabitacionesConNumeroYEstado.Add("La lista de las habitaciones por número y estado de habitaciones es: ");

            foreach (Habitacion habitacion in ListaHabitaciones)
            {
                ListaDeHabitacionesConNumeroYEstado.Add("Número: " + Convert.ToString(habitacion.Numero) + ", estado: " + habitacion.Estado + ".");

            }

            return ListaDeHabitacionesConNumeroYEstado;
        }
    }
}
