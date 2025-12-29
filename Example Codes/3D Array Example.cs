

//----------------------------Showing Students Result--------------------




using System;

class Program
{
    static void Main()
    {
//-------------- Students and Subjects--------------------------------


        string[] name = { "Ali", "Usman", "Sarah" };
        string[] subjects = { "English", "Science", "Sociology" };


//--------------- 3D marks array: [exam, student, subject]-------------------


        int[,,] marks = new int[2, 3, 3];


//---------------------Layer 0 for Mid Exam-----------------------------------
        marks[0, 0, 0] = 16; marks[0, 0, 1] = 27; marks[0, 0, 2] = 15;
        marks[0, 1, 0] = 20; marks[0, 1, 1] = 22; marks[0, 1, 2] = 12;
        marks[0, 2, 0] = 26; marks[0, 2, 1] = 19; marks[0, 2, 2] = 25;

//---------------------Layer 1 for Final Exam---------------------------------
        marks[1, 0, 0] = 89; marks[1, 0, 1] = 85; marks[1, 0, 2] = 91;
        marks[1, 1, 0] = 78; marks[1, 1, 1] = 81; marks[1, 1, 2] = 64;
        marks[1, 2, 0] = 74; marks[1, 2, 1] = 70; marks[1, 2, 2] = 67;

// ----------------------Loop through exams------------------------------------


        for (int exam = 0; exam < marks.GetLength(0); exam++)
        {
            Console.WriteLine("====== Exam " + (exam + 1) + " =====\n");

//---------------------------Loop through students----------------------------------


            for (int student = 0; student < name.Length; student++)
            {
                Console.WriteLine(  "\n" + "Student: " + name[student]);
                int total = 0;

//-------------------------Loop through subjects------------------------------------------


                for (int sub = 0; sub < subjects.Length; sub++)
                {
                    Console.WriteLine(subjects[sub] + ": " + marks[exam, student, sub]);
                    total += marks[exam, student, sub];
                }

                Console.WriteLine("Total Marks: " + total);
                Console.Write("===============");
            }

            Console.WriteLine();
        }
    }
}
