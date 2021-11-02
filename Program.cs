﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        //uc1 calculating line length
       static double Distance(int X1,int Y1,int X2,int Y2)
        {
            //length. - A Length as 2 Points (x1, y1) and (x2, y2)
            //- Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2-y1) ^2)

            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
        static void Main(string[] args)
        {
            double line = Distance(1, 3, 4, 5);
            Console.WriteLine("length of line is :"+line);
            
            
        

        }
    }
}