﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Ent:Bitmon
    {
        public int tiempoVida;
        public int puntosVida;
        public int puntosAtaque;

        public int maxTiempoVida = 15;
        public int minTiempoVida = 5;
        public int maxpuntosAtaque = 15;
        public int minpuntosAtaque = 5;
        public int maxpuntosVida = 80;
        public int minpuntosVida = 30;
        public int velocidad = 0;
        public List<Terreno> terrenosafin;
        public List<Terreno> terrenosdebil;

        Random random = new Random();

        public Ent()
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
            return ("Ent");
        }
    }
}

