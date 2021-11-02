using System;

namespace ConsoleApp2
{
    class Program
    {
        
       
        //uc4 equal and compareTo method by oops concept 
       static double Distance(int X1,int Y1,int X2,int Y2)
        {
            //length. - A Length as 2 Points (x1, y1) and (x2, y2)
            //- Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2-y1) ^2)

            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
        static void Main(string[] args)
        {
            // equality method
            double line1 = Distance(1, 3, 4, 5);
            double line2 = Distance(1, 3, 4, 5);
            if (line1 == line2)
            {
                Console.WriteLine("length is prefferable ");
            }
            else
            {
                Console.WriteLine("length is not prefferable");
            }
            //compareTo method
            int compTo = line1.CompareTo(line2);
            Console.WriteLine("compareto:" + compTo);
            if (compTo > 0)
            {
                Console.WriteLine("length is greater");
            }
            else if (compTo < 0)
            {
                Console.WriteLine("length is lesser");
            }
            else 
            {
                Console.WriteLine("length is equal");
            }
            Console.WriteLine("length of first  line is :"+line1);
            Console.WriteLine("length of second line:" + line2);


        }
    }
}
