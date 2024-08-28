using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Models
{
    internal class EvaluadorAnual : Evaluador
    {
        public double TasaDepreciacion;

        public EvaluadorAnual(Moto vehiculo, int añoACalcular, double tasaDepreciacion):base(vehiculo, añoACalcular)
        {
            TasaDepreciacion = tasaDepreciacion;
        }
        public override double CalcularDepreciacion()
        {
            int añosUso = AñoACalcular - Vehiculo.Modelo;

            double datos = 0;
            datos = Vehiculo.ValorFabricacion * Math.Pow(1 - TasaDepreciacion, añosUso);
            return datos;
        }

        public override string VerDescripcion()
        {
            return 
$@"Vehiculo: {base.VerDescripcion()}
Evaluacion Anual, Monto: {CalcularDepreciacion()}";
        }
    }
}
