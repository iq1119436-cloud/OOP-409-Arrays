
//------------------------------Displaying Marks------------------------------------




using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];

        marks[0] = 80;
        marks[1] = 75;
        marks[2] = 90;
        marks[3] = 65;
        marks[4] = 85;

        Console.WriteLine("Student Marks:");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Mark " + (i + 1) + ": " + marks[i]);
        }
    }
}
