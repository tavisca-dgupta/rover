using System;
using System.Linq;
using Xunit;

namespace Mars_rover.test
{
    public class TestRobot
    {
        [Theory]
        [InlineData('N', "34N")]
        [InlineData('E', "43E")]
        [InlineData('S', "32S")]
        [InlineData('W', "23W")]
        public void Test_robot_when_move(char head, string expected)
        {
            Plateau plateau = new Plateau(5, 5);
            Robot robot = new Robot(plateau);
            robot.SetCurrentPositin(3, 3);
            robot.Move(head);
            Assert.Equal(expected, robot.GetCurrentPosition());
        }
        [Fact]
        public void Test_Getting_Current_Position_Of_Robot()
        {
            Plateau plateau = new Plateau(5, 5);
            Robot robot = new Robot(plateau);
            robot.SetCurrentPositin(3, 3);
            Assert.Equal("33N", robot.GetCurrentPosition());
        }

        [Fact]
        public void Test_Setting_Current_Position_Of_Robot()
        {
            Plateau plateau = new Plateau(5, 5);
            Robot robot = new Robot(plateau);
            robot.SetCurrentPositin(4, 3);
            Assert.Equal("43N", robot.GetCurrentPosition());
        }
    }
}
