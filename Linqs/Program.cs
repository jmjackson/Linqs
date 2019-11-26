using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqs
{
    class Program
    {
        static void Main(string[] args)
        {
            RepoDatos r = new RepoDatos();
            Console.WriteLine("Escribe un Id del usuario a buscar: ");
            var id=int.Parse(Console.ReadLine());
            var persona = r.BuscarPersona( id);

            Console.WriteLine("El usuario encontrado es : ");
            Console.WriteLine("Nombre : "+persona.Nombre);
            Console.WriteLine("Su profesion es : "+persona.Profesion);
            Console.WriteLine("SU edad es "+persona.Edad);
            Console.ReadLine();

            Console.WriteLine("Ingrese un nombre");
            var nombre = Console.ReadLine();
            var personas=r.ObtenerPersonasByNombre(nombre);
            foreach (var item in personas)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.ReadLine();

        }
    }
}
