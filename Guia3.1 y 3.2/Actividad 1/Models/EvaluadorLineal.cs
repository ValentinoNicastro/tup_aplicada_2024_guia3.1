using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Models
{
    internal class EvaluadorLineal : Evaluador
    {
        public int VidaUtil;

        public EvaluadorLineal(Moto vehiculo, int añoACalcular, int vidaUtil) :base(vehiculo, añoACalcular)
        {
            VidaUtil = vidaUtil;
        }
        public override double CalcularDepreciacion()
        {
            int añosUso = AñoACalcular - Vehiculo.Modelo;

            double datos = 0;

            if (VidaUtil > 0 && añosUso > 0) 
            {
                datos = Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * añosUso / VidaUtil);
                return datos;
            }
            return datos;
        }

        public override string VerDescripcion()
        {
            return 
$@"{base.VerDescripcion()} 
Evaluacion Lineal, Monto: {CalcularDepreciacion()}.
            ";
        }
    }
}
