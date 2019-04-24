using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Johto
    {   

        public List<Terreno> terrenos;
        public string nombreRegion;
        private int largo;
        private int ancho;
        Random random = new Random();
        public Terreno[,] mapaRegion;

        public Johto(string nombreRegion, int largo,int ancho)
        {
            this.nombreRegion = nombreRegion;
            this.ancho = ancho;
            this.largo = largo;
            terrenos = new List<Terreno>();
            terrenos.Add(new Terreno("Volcan"));
            terrenos.Add(new Terreno("Acuatico"));
            terrenos.Add(new Terreno("Vegetacion"));
            terrenos.Add(new Terreno("Desierto"));
            terrenos.Add(new Terreno("Nieve"));
            mapaRegion = new Terreno[ancho,largo];
        }


        public void crearMapa()
        {

            for (int i = 0; i < mapaRegion.GetLength(0); i++)
            {
                for (int j= 0; j < mapaRegion.GetLength(1); j++)
                {
                    int num = terrenos.Count();
                    int terrenoRandom = random.Next(0,num);
                    
                    Terreno terrenonuevo = new Terreno(terrenos[terrenoRandom].getTipo());
                    mapaRegion[i, j] = terrenonuevo;

                }
            }
        }
        

        public string getTipoTerreno(int x,int y)
        {
            Terreno tmpterreno = mapaRegion[x, y];
            return tmpterreno.getTipo();
        }

    }
}
