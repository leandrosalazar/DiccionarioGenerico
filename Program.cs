using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios222
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese Un Número del 1 al 23: ");
            numero = int.Parse(Console.ReadLine());

            Provincia provincia = new Provincia();

            var provinciaMostrar = provincia.BuscarProvincia(numero);

            Console.WriteLine(provinciaMostrar.Item1 + " - " + provinciaMostrar.Item2);

            Console.ReadLine();
        }
    }

    public class Provincia
    {
        public Provincia()
        {
            ProCapi = new Dictionary<int, Tuple<string, string>>();

            ProCapi.Add(1, new Tuple<string, string>("Buenos Aires", "La Plata"));
            ProCapi.Add(2, new Tuple<string, string>("Catamarca", "San Fernando Del Valle de Catamarca"));
            ProCapi.Add(3, new Tuple<string, string>("Chaco", "Resistencia"));
            ProCapi.Add(4, new Tuple<string, string>("Chubut", "Rawson"));
            ProCapi.Add(5, new Tuple<string, string>("Córdoba", "Córdoba"));
            ProCapi.Add(6, new Tuple<string, string>("Corrientes", "Corrientes"));
            ProCapi.Add(7, new Tuple<string, string>("Entre Ríos", "Paraná"));
            ProCapi.Add(8, new Tuple<string, string>("Formosa", "Formosa"));
            ProCapi.Add(9, new Tuple<string, string>("Jujuy", "San Salvador de Jujuy"));
            ProCapi.Add(10, new Tuple<string, string>("La Pampa", "Santa Rosa"));
            ProCapi.Add(11, new Tuple<string, string>("La Rioja", "La Rioja"));
            ProCapi.Add(12, new Tuple<string, string>("Mendoza", "Mendoza"));
            ProCapi.Add(13, new Tuple<string, string>("Misiones", "Posadas"));
            ProCapi.Add(14, new Tuple<string, string>("Neuquén", "Neuquén"));
            ProCapi.Add(15, new Tuple<string, string>("Río Negro", "Viedma"));
            ProCapi.Add(16, new Tuple<string, string>("Salta", "Salta"));
            ProCapi.Add(17, new Tuple<string, string>("San Juan", "San Juan"));
            ProCapi.Add(18, new Tuple<string, string>("San Luis", "San Luis"));
            ProCapi.Add(19, new Tuple<string, string>("Santa Cruz", "Río Gallegos"));
            ProCapi.Add(20, new Tuple<string, string>("Santa Fe", "Santa Fe"));
            ProCapi.Add(21, new Tuple<string, string>("Santiago Del Estero", "Santiago Del Estero"));
            ProCapi.Add(22, new Tuple<string, string>("Tierra Del Fuego, Antártida e Islas del Atlántico Sur", "Ushuaia"));
            ProCapi.Add(23, new Tuple<string, string>("Tucumán", "San Miguel de Tucumán"));

        }

        public Dictionary<int, Tuple<string, string>> ProCapi { get; set; }

        public Tuple<string, string> BuscarProvincia(int numero)
        {
            return ProCapi[numero];
        }
    }
}
