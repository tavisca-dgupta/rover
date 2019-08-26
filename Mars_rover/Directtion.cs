using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_rover
{
    public class Directtion
    {
        public char GetDirectionWhenTurnLeft(char head)
        {
            switch(head)
            {
                case 'N': return 'W';
                case 'W': return 'S';
                case 'S': return 'E';
                case 'E': return 'N';
                default: return 'A';
            }
        }

        public char GetDirectionWhenTurnRight(char head)
        {
            switch (head)
            {
                case 'N': return 'E';
                case 'E': return 'S';
                case 'S': return 'W';
                case 'W': return 'N';
                default: return 'A';
            }
        }
    }
}
