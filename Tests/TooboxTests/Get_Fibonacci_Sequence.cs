﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests.ToolboxTests
{
    [TestFixture]
    public class Get_Fibonacci_Sequence
    {
        [Test]
        public void Returns_1_When_Taking_1()
        {
            var result = Toolbox.FibonacciSequence().Take(1);
            CollectionAssert.AreEqual(new int[] { 1 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_When_Taking_2()
        {
            var result = Toolbox.FibonacciSequence().Take(2);
            CollectionAssert.AreEqual(new int[] { 1, 2 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_When_Taking_3()
        {
            var result = Toolbox.FibonacciSequence().Take(3);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_When_Taking_4()
        {
            var result = Toolbox.FibonacciSequence().Take(4);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_8_When_Taking_5()
        {
            var result = Toolbox.FibonacciSequence().Take(5);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_8_13_When_Taking_6()
        {
            var result = Toolbox.FibonacciSequence().Take(6);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8, 13 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_8_13_21_When_Taking_7()
        {
            var result = Toolbox.FibonacciSequence().Take(7);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8, 13, 21 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_8_13_21_34_When_Taking_8()
        {
            var result = Toolbox.FibonacciSequence().Take(8);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8, 13, 21, 34 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_8_13_21_34_55_When_Taking_9()
        {
            var result = Toolbox.FibonacciSequence().Take(9);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55 }, result.ToList());
        }

        [Test]
        public void Returns_1_2_3_5_8_13_21_34_55_89_When_Taking_10()
        {
            var result = Toolbox.FibonacciSequence().Take(10);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }, result.ToList());
        }
    }
}