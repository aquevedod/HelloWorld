using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class FrogJump2
    {
        public int Solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int res = X;

            if ((X < 1 && X > 1000000000) || (Y < 1 && Y > 1000000000) || (D < 1 && D > 1000000000) || X > Y)
                return res;

            return Jugadita(X, Y, D, 0);
        }


        public int Jugadita(int X, int Y, int D, int c)
        {
            if (X >= Y)
            {
                return c;
            }
            else
            {
                c += 1;
                return Jugadita(X + D, Y, D, c);
            }
        }
    }
}
