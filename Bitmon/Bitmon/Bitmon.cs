using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    public abstract class Bitmon
    {   
        
        protected int x;
        protected int y;
        protected int permanencia;

        public Bitmon()
        {
            
        }

        public abstract void movimiento();
        public abstract string getTipo();
    }
}
