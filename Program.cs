using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPractica
{
    class Program
    {
        static void Main(string[] args)
        {


            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "Roja";
            c2.Color = "Negra";
            c3.Color = "Blanca";

            c1.Marca = "Ford";
            c2.Marca = "Chevrolet";
            c3.Marca = "Volkswagen";

            List<Camioneta> ListaCamioneta = new List<Camioneta>();

            ListaCamioneta.Add(c1);
            ListaCamioneta.Add(c2);
            ListaCamioneta.Add(c3);
            Console.WriteLine("CONCESIONARIA LA PERLITA");
            Console.WriteLine("Que tal, pasen y vean. Tenemos algunas camionetas a la venta.");

            Console.WriteLine("La camioneta " + c1.Marca + " es la " + c1.Color + ". La camioneta " + c2.Marca + " es la " + c2.Color + 
            " y la camioneta " + c3.Marca + " es la " + c3.Color + ". Las " + ListaCamioneta.Count +  " se entregan con minimos requisitos ");

            Console.WriteLine("La " + c2.Marca + " de color " + ListaCamioneta[1].Color + " esta semana se la llevan para una exposición en Mar del Plata y la " + c3.Marca + " ya la señaron por internet " );

            ListaCamioneta.Remove(c2);
            ListaCamioneta.Remove(c3);

            foreach (Camioneta item in ListaCamioneta)
            {
                Console.WriteLine("EL stock para entrega inmediata es la " + item.Color + " de " + c1.Marca);
            }

            Console.WriteLine("Qué le parace? Permitame traerle las llaves para que usted mismo vea el interior de esa hermosuuuura ");
            Console.ReadKey();








        }
    }
}
