using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PrimerForm;

namespace PrimerForm
{
    internal class Postulante
    {
        private string? nombre;
        private string? apellido;
        private string? tipo;
        private int documento;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public string? Tipo { get => tipo; set => tipo = value; }
        public int Documento { get => documento; set => documento = value; }

        public Postulante(string nombre, string apellido, string tipo, int documento) { 
            this.nombre = nombre;
            this.Apellido = apellido;
            this.Tipo = tipo;
            this.Documento = documento;
                    
        }
    }
}
