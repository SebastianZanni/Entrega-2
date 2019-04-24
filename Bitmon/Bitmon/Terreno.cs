using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Terreno

    {
        public List<Bitmon> bitmonsTerreno;
        private string tipo;

        public Terreno(string tipo)
        {
            bitmonsTerreno = new List<Bitmon>();
            this.tipo = tipo;
        }
        public int numBitmons()
        {
            return bitmonsTerreno.Count;
        }

      public string getTipo()
        {
            return tipo;
        }
        }
    }

