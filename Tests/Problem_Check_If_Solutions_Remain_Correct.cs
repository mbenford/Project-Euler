﻿using System;
using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_Check_If_Solutions_Remain_Correct
    {
        [Test]
        public void Check_If_Solution_For_Problem_1_Remains_Correct()
        {
            Check(1, 233168);
        }

        [Test]
        public void Check_If_Solution_For_Problem_2_Remains_Correct()
        {
            Check(2, 4613732);
        }

        [Test]
        public void Check_If_Solution_For_Problem_3_Remains_Correct()
        {
            Check(3, 6857);
        }

        [Test]
        public void Check_If_Solution_For_Problem_4_Remains_Correct()
        {
            Check(4, 906609);
        }

        [Test]
        public void Check_If_Solution_For_Problem_5_Remains_Correct()
        {
            Check(5, 232792560);
        }

        [Test]
        public void Check_If_Solution_For_Problem_6_Remains_Correct()
        {
            Check(6, 25164150);
        }

        [Test]
        public void Check_If_Solution_For_Problem_7_Remains_Correct()
        {
            Check(7, 104743);
        }

        [Test]
        public void Check_If_Solution_For_Problem_8_Remains_Correct()
        {
            Check(8, 40824);
        }

        [Test]
        public void Check_If_Solution_For_Problem_9_Remains_Correct()
        {
            Check(9, 31875000);
        }

        [Test]
        public void Check_If_Solution_For_Problem_10_Remains_Correct()
        {
            Check(10, 142913828922);
        }

        [Test]
        public void Check_If_Solution_For_Problem_11_Remains_Correct()
        {
            Check(11, 70600674);
        }

        private void Check(int problemId, long expectedValue)
        {
            Solution solution = GetSolution(problemId);
            Assert.IsTrue(expectedValue == solution.Value);
        }

        private Solution GetSolution(int problemId)
        {
            Problem problem = ProblemFactory.GetProblem(problemId);
            return problem.Solve();
        }
    }
}
