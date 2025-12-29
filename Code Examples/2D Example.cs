
//------------------------Student Result Example----------------------------------------




using System;

class Program
{
    static void Main()
    {
        // Array to store student names
        string[] studentNames = { "Ali", "Ahmed", "Sara" };

        // Array to store subject names
        string[] subjects = { "Math", "Computer", "English" };

        // 2D array to store marks 
        int[,] marks =
        {
            { 85, 78, 90 },   
            { 88, 76, 92 },   
            { 80, 70, 89 }    
        };

        Console.WriteLine("STUDENT RESULT SHEET\n");

        // Loop through students
        for (int i = 0; i < studentNames.Length; i++)
        {
            int total = 0;

            Console.WriteLine("Student Name: " + studentNames[i]);
            Console.WriteLine("Marks:");

            // Loop through subjects
            for (int j = 0; j < subjects.Length; j++)
            {
                Console.WriteLine(subjects[j] + ": " + marks[i, j]);
                total += marks[i, j];
            }

            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("----------------------------");
        }
    }
}
