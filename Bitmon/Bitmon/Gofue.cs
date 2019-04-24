using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Gofue : Bitmon
    {
        public int tiempoVida;
        public int puntosVida;
        public int puntosAtaque;

        public int maxTiempoVida = 10;
        public int minTiempoVida = 2;
        public int maxpuntosAtaque = 45;
        public int minpuntosAtaque = 15;
        public int maxpuntosVida = 50;
        public int minpuntosVida = 10;
        public int velocidad = 1;
        public List<Terreno> terrenosafin;
        public List<Terreno> terrenosdebil;

        Random random = new Random();


        public Gofue()
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
            return ("Gofue");
        }
    }
}

