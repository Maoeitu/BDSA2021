using System;
using Xunit;
using System.IO;

namespace Week1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Is_Leap_Year()
        {
        var isLeapYear = Program.Is_Leap_Year(2020);
        Assert.True(isLeapYear);
        }
        [Fact]
        public void Is_Not_Leap_Year(){
            var isNotLeapYear = Program.Is_Leap_Year(2021);
            Assert.False(isNotLeapYear);
        }
        [Fact]
        public void Exactly_Divisible_By_100(){
            var IsNotALeapYear = Program.Is_Leap_Year(1700);
            Assert.False(IsNotALeapYear);
        }
        [Fact]
        public void Excactly_Divisible_By_400(){
            var isLeapYear = Program.Is_Leap_Year(1600);
            Assert.True(isLeapYear);
        }
    }
}
