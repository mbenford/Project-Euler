﻿using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Get_Least_Common_Multiple
    {
        [Fact]
        public void Returns_2_When_Passing_2_2()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 2);
            Assert.Equal(2, lcm);
        }
        
        [Fact]
        public void Returns_6_When_Passing_2_3()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 3);
            Assert.Equal(6, lcm);
        }

        [Fact]
        public void Returns_10_When_Passing_2_5()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 5);
            Assert.Equal(10, lcm);
        }

        [Fact]
        public void Returns_14_When_Passing_2_7()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 7);
            Assert.Equal(14, lcm);
        }

        [Fact]
        public void Returns_15_When_Passing_3_5()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(3, 5);
            Assert.Equal(15, lcm);
        }

        [Fact]
        public void Returns_30_When_Passing_2_3_5()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 3, 5);
            Assert.Equal(30, lcm);
        }

        [Fact]
        public void Returns_210_When_Passing_2_3_5_7()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 3, 5, 7);
            Assert.Equal(210, lcm);
        }

        [Fact]
        public void Returns_4_When_Passing_2_4()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 4);
            Assert.Equal(4, lcm);
        }

    }
}
