using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatExplode___Falcari___Manuzzato
{
    internal class Cella
    {
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        public bool scoperta { get; set; }
        public bool flag { get; set; }

        public Cella(int x, int y, int value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
            scoperta = false;
            flag = false;
        }
    }
}
