using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_rover
{
    public class Plateau
    {
        public static int xMax { get; private set; }
        public static int yMax { get; private set; }
   
        public Plateau(int x,int y)
        {
            xMax = x;
            yMax = y;
        }
        

    }
}
