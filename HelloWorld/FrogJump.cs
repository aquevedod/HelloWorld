using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class FrogJump
    {
        public int Solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int res = X;
            int jumps = 0;

            if ((X < 1 && X > 1000000000) || (Y < 1 && Y > 1000000000) || (D < 1 && D > 1000000000) || X > Y)
                return res;

            for (int i = 0; i < Y; i++)
            {
                if (res >= Y)
                {
                    break;
                }
                else
                {
                    res = res + D;
                    jumps++;
                }
            }

            return jumps;
        }
    }
}
