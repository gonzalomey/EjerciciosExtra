using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos ad = new AccesoDatos();
            List<Persona> personas = new List<Persona>();

            personas = ad.TraerTodos();

            Persona pe = new Persona(0, "Rigoberto", "Gonzales", 31);
            if (ad.AgregarPersona(pe))
                Console.WriteLine("Se Agrego Correctamente\n\n");

            foreach ( Persona p in personas)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();


        }
    }
}
