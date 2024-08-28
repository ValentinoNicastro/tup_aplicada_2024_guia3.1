using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Models
{
    internal class Moto
    {
        public string Marca { get;private set; }
        public int Modelo { get;private set; }
        public double ValorFabricacion { get;private set; }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public string VerDescripcion()
        {
            string data;
            data = $"Marca: {Marca} Modelo: {Modelo.ToString()} Precio De Fabricación: {ValorFabricacion.ToString()}";
            return data;
        }
    }
}
