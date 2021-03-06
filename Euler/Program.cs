﻿using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int problemId;
                if (int.TryParse(args[0], out problemId))
                    Runner.SolveProblem(problemId);
                else
                    Console.WriteLine("Problem Id must be an integer value");
            }
            else
            {
                Console.WriteLine("Try euler.exe <Problem Id>");
            }     
        }
    }
}
