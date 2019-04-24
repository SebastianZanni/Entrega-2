using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Dorvalo:Bitmon
    {
        public int tiempoVida;
        public int puntosVida;
        public int puntosAtaque;

        public int maxTiempoVida = 12;
        public int minTiempoVida = 3;
        public int maxpuntosAtaque = 50;
        public int minpuntosAtaque = 20;
        public int maxpuntosVida = 30;
        public int minpuntosVida = 15;
        public int velocidad = 2;
        public List<Terreno> terrenosafin;
        public List<Terreno> terrenosdebil;

        Random random = new Random();

        public Dorvalo() 
        {
            terrenosafin = new List<Terreno>();
            terrenosdebil = new List<Terreno>();

            terrenosafin.Add(new Terreno("Vegetacion"));
            terrenosdebil.Add(new Terreno("Volcan"));
            terrenosdebil.Add(new Terreno("Nieve"));
            puntosVida = random.Next(minpuntosVida, maxpuntosVida);
            tiempoVida = random.Next(minTiempoVida, maxTiempoVida);
            puntosAtaque = random.Next(minpuntosAtaque, maxpuntosAtaque);
        }
        public override void movimiento()
        {

        }
        public override string getTipo()
        {
            return ("Dorvalo");
        }
    }

}
