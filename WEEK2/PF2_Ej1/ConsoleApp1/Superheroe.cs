using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Superheroe
    {

        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        public Superheroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Resistencia = resistencia;
            this.Superpoderes = superpoderes;
        }

        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public int Fuerza
        {
            get { return fuerza; }
            private set { fuerza = validarNumero(value); }
        }

        public int Resistencia
        {
            get { return resistencia; }
            private set { resistencia = validarNumero(value); }
        }

        public int Superpoderes
        {
            get { return superpoderes; }
            private set { superpoderes = validarNumero(value); }
        }

        private int validarNumero(int value)
        {
            if (value < 0)
            {
                return 0;
            }
                
            else if (value > 100)
            {
                return 100;
            }           
            return value;
        }

        public string competir(Superheroe otroSuperheroe)
        {
            string resultado = "EMPATE";
            int misPuntos = 0;
            int susPuntos = 0;

            if (this.Fuerza > otroSuperheroe.Fuerza)
                misPuntos++;
            else if (this.Fuerza < otroSuperheroe.Fuerza)
                susPuntos++;

            if (this.Resistencia > otroSuperheroe.Resistencia)
                misPuntos++;
            else if (this.Resistencia < otroSuperheroe.Resistencia)
                susPuntos++;

            if (this.Superpoderes > otroSuperheroe.Superpoderes)
                misPuntos++;
            else if (this.Superpoderes < otroSuperheroe.Superpoderes)
                susPuntos++;

            if (susPuntos >= 2)
                resultado = "DERROTA";
            else if (misPuntos >= 2)
                resultado = "VICTORIA";
            return resultado;
        }

    }
}
