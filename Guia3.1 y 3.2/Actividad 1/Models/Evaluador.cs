using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Models
{
    abstract class Evaluador
    {
        private int añoACalcular = 0; //atributo
        public int AñoACalcular
        {
            get
            {
                return añoACalcular;
            }

        }
        public Moto Vehiculo;

        public Evaluador(Moto vehiculo, int añoACalcular)
        {
            Vehiculo = vehiculo;
            this.añoACalcular = añoACalcular;
        }

        abstract public double CalcularDepreciacion();
        virtual public string VerDescripcion()
        {
            return $"Vehiculo: {Vehiculo.VerDescripcion()} Años de uso: {AñoACalcular - Vehiculo.Modelo}";
        }

    }
}
