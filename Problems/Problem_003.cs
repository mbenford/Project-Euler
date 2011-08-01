﻿using System;
using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem_003 : Problem
    {
        public override Solution Solve()
        {                                  
            long value = Toolbox.Factorize(600851475143)                
                .Max();

            return new Solution(value);
        }
    }
}