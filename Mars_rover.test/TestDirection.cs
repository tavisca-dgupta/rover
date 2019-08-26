using System;
using Xunit;

namespace Mars_rover.test
{
    public class TestDirection
    {
        [Theory]
        [InlineData('N','W')]
        [InlineData('W', 'S')]
        [InlineData('S', 'E')]
        [InlineData('E', 'N')]

        public void Test_direction_when_turn_left(char head, char expected)
        {
            Directtion directtion = new Directtion();
            Assert.Equal(expected, directtion.GetDirectionWhenTurnLeft(head));
        }

        [Theory]
        [InlineData('N', 'E')]
        [InlineData('E', 'S')]
        [InlineData('S', 'W')]
        [InlineData('W', 'N')]

        public void Test_direction_when_turn_right(char head, char expected)
        {
            Directtion directtion = new Directtion();
            Assert.Equal(expected, directtion.GetDirectionWhenTurnRight(head));
        }
    }
}
