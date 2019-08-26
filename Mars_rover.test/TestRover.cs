using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Mars_rover.test
{
    public class TestRover
    {
        [Fact]
        public void Test_Robot()
        {
            Rovers rover = new Rovers();
            string[] instructions = { "55" ,"12N", "LMLMLMLMM" ,"33E", "MMRMMRMRRM" };
            List<string> positions = new List<string>();
            positions.Add("13N");
            positions.Add("51E");
            Assert.Equal(positions, rover.InstructRobot(instructions));
        }
    }
}
