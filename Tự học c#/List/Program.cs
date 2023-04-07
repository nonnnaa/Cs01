using System;
using System.Collections.Generic;


namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            List<int> l = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0 ; i<n ; i++)
            {
                l[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int x in l)
            {
                Console.Write(x + " ");
            }
        }
    }
}