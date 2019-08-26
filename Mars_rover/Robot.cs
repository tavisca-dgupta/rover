using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_rover
{
    public class Robot
    {
        private Directtion _directtion;
        private Plateau _plateau;
        private int _xPoint;
        private int _yPoint;
        private char _head='N';

        public Robot(Plateau plateau)
        {
            _directtion = new Directtion();
            _plateau = plateau;
        }

        public char TurnLeft(char head)
        {
            _head = head;
            return _directtion.GetDirectionWhenTurnLeft(head);
        }
        public void Move(char head)
        {
            _head = head;
            switch (_head)
            {
                case 'E':if(_xPoint < Plateau.xMax)
                         _xPoint++;
                    break;
                case 'N':if (_yPoint < Plateau.yMax)
                        _yPoint++;
                    break;
                case 'S':if (_yPoint > 0)
                        _yPoint--;
                    break;
                case 'W':if (_xPoint > 0)
                        _xPoint--;
                    break;
                default: break;
            }
        }
        public char TurnRight(char head)
        {
            _head = head;
            return _directtion.GetDirectionWhenTurnRight(head);
        }

        public string GetCurrentPosition()
        {
            string position = _xPoint.ToString();
            position = string.Concat(position, _yPoint.ToString());
            position = string.Concat(position, _head.ToString());
            return position;
        }
        public void SetCurrentPositin(int xPoint,int yPoint)
        {
            _xPoint = xPoint;
            _yPoint = yPoint;
            //_plateau.SetCurrentPosition(xPoint, yPoint);
        }


    }
}
