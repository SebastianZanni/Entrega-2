using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Taplan : Bitmon
    {
        public int tiempoVida;
        public int puntosVida;
        public int puntosAtaque;

        public int maxTiempoVida = 12;
        public int minTiempoVida = 5;
        public int maxpuntosAtaque = 35;
        public int minpuntosAtaque = 15;
        public int maxpuntosVida = 60;
        public int minpuntosVida = 25;
        public int velocidad = 1;
        public List<Terreno> terrenosafin;
        public List<Terreno> terrenosdebil;

        Random random = new Random();

        public Taplan()
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
            return ("Taplan");
        }
    }
}
