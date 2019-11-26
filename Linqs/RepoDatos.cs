using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Linqs
{
    public class RepoDatos
    {

        public Persona BuscarPersona(int id)
        {
            var datos = ObtenerPersonas();
            //este es un linq
            
            var p = (from a in datos
                    where a.Id == id
                    select a).First();
            return p;
        }

        public List<Persona> TodasPersonas()
        {
            var datos = ObtenerPersonas();
            return (from persona in datos
                   select persona).ToList();
        }

        public List<Persona> ObtenerPersonasByNombre(string nombre)
        {
            var datos = ObtenerPersonas();

            //este es un lambda
            var ps = datos.Where(p => p.Nombre.Contains(nombre)).OrderByDescending(p=>p.Nombre).ToList();
            return ps;
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();

            var datos = ObtenerLineas();

            foreach (var item in datos)
            {
                var dato = item.Split(',');

                Persona p = new Persona
                {
                    Id = int.Parse(dato[0]),
                    Nombre=dato[1],
                    Profesion=dato[2],
                    Edad=int.Parse(dato[3])
                };

                personas.Add(p);
            }

            return personas;

        }


        public List<string> ObtenerLineas()
        {
            List<string> lineas = new List<string>() ;
            string[] list=null;
            if (File.Exists("Datos.txt"))
            {
                list= File.ReadAllLines("Datos.txt");
            }

            foreach (var item in list)
            {
                lineas.Add(item);
            }

            return lineas;
        }
    }
}
