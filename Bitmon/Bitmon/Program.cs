using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Program
    {
        static void Main(string[] args)

        {

            // Definicion de terrenos,region y mundoBitmons

            Bitmonlandia mundoBitmon = new Bitmonlandia();
            //Johto Region1 = new Johto("Config1",5,5);
            Johto Region2 = new Johto("Config2", 3, 3);
            //Johto Region3 = new Johto("Config3", 10, 10);

            //Se agregan los terrenos existentes al mapa y se crea el mapa

            ////Region1.crearMapa();

            Region2.crearMapa();

            ////Region3.crearMapa();


            //crearBitmons(Region1);
            crearBitmons(Region2);
            //crearBitmons(Region3);



            //Crear y seleccionar configuraciones



            foreach (Terreno terreno in Region2.mapaRegion)
            {
                Console.WriteLine(terreno.getTipo());
                Console.WriteLine("*****************");
                foreach (Bitmon bitmon in terreno.bitmonsTerreno)
                {

                    Console.WriteLine(bitmon.getTipo());
                 }

                Console.WriteLine("*****************");
                Console.WriteLine("*****************");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }



        //Simulador simulador = new Simulador(Region,mundoBitmon);


        public static void crearBitmons(Johto region)
        {

            Random random = new Random();
            TiposBitmons tipos = new TiposBitmons();
            foreach (Terreno terrenoRegion in region.mapaRegion)
            {
                int numBitmons = random.Next(0, 2);

                for (int i = 0; i <= numBitmons; i++)
                {
                    int randomBitmon = random.Next(0, 6);
                    string tipoBitmon = tipos.tipo[randomBitmon];

                    switch (tipoBitmon)
                    {
                        case "Dorvalo":
                            terrenoRegion.bitmonsTerreno.Add(new Dorvalo());
                            break;
                        case "Doti":
                            terrenoRegion.bitmonsTerreno.Add(new Doti());
                            break;
                        case "Ent":
                            terrenoRegion.bitmonsTerreno.Add(new Ent());
                            break;
                        case "Gofue":
                            terrenoRegion.bitmonsTerreno.Add(new Gofue());
                            break;
                        case "Taplan":
                            terrenoRegion.bitmonsTerreno.Add(new Taplan());
                            break;
                        case "Wetar":
                            terrenoRegion.bitmonsTerreno.Add(new Wetar());
                            break;
                    }
                }
            }
        }
    }
}


        

