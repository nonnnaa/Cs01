using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            String input_name = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    check = true;
                    break;
                }
            }
            if(!check) Console.WriteLine("Not found" + input_name + " in the list.");
        }
    }
}
