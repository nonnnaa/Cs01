using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            int ans = 0;
            foreach(var x in numbers)
            {
                ans += x;
            }
            Console.WriteLine(ans);
        }
    }
}
