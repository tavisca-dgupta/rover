using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_rover
{
    public class Rovers
    {
        private Robot _robot;
        private Plateau _plateau;
       

        public List<string> InstructRobot(string[] instructions)
        {
            int xMax = 0;
            int yMax = 0;
            int xPoint = 0;
            int yPoint = 0;
            char head='N';
            List<string> position=new List<string>();
            int.TryParse(instructions[0][0].ToString(), out xMax);
            int.TryParse(instructions[0][1].ToString(), out yMax);

            _plateau = new Plateau(xMax,yMax);
            _robot = new Robot(_plateau);
            for(int i=1;i<instructions.Length;i=i+2)
            {
                int.TryParse(instructions[i][0].ToString(), out xPoint);
                int.TryParse(instructions[i][1].ToString(), out yPoint);
                _robot.SetCurrentPositin(xPoint, yPoint);
                head = instructions[i][2];
                for(int j=0;j<instructions[i+1].Length;j++)
                {
                    if(instructions[i+1][j]=='M')
                    {
                        _robot.Move(head);
                    }
                    else if(instructions[i+1][j]=='L')
                    {
                        head = _robot.TurnLeft(head);
                    }
                    else if (instructions[i + 1][j] == 'R')
                    {
                        head = _robot.TurnRight(head);
                    }
                }
                position.Add(_robot.GetCurrentPosition());
            }
            return position;
        }


    }
}
