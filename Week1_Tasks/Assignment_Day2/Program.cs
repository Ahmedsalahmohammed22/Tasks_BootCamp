namespace Assignment_Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numStudents = 6;
            const int numSubjects = 4;

            int[] studentIDs = new int[numStudents];
            double[,] grades = new double[numStudents, numSubjects];

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter ID for student {i + 1}: ");
                studentIDs[i] = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"Enter grade for subject {j + 1} for student {studentIDs[i]}: ");
                    grades[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("\nGrade Evaluation:");
            for (int i = 0; i < numStudents; i++)
            {
                int failedSubjects = 0;
                Console.WriteLine($"\nStudent ID: {studentIDs[i]}");

                for (int j = 0; j < numSubjects; j++)
                {
                    string gradeEval = GetGradeEvaluation(grades[i, j]);
                    Console.WriteLine($"Subject {j + 1} grade: {grades[i, j]} -> {gradeEval}");

                    // Count the number of failed subjects
                    if (gradeEval == "F")
                    {
                        failedSubjects++;
                    }
                }
                double totalGrade = 0;
                for (int j = 0; j < numSubjects; j++)
                {
                    totalGrade += grades[i, j];
                }
                totalGrade /= numSubjects;
                Console.WriteLine($"Total Grade Evaluation for Student {studentIDs[i]}: {GetGradeEvaluation(totalGrade)}");

                // Print ID if the student failed more than two subjects
                if (failedSubjects > 2)
                {
                    Console.WriteLine($"Student {studentIDs[i]} failed in more than two subjects.");
                }
            }
        }
        static string GetGradeEvaluation(double grade)
        {
            if (grade >= 85)
                return "A";
            else if (grade >= 70)
                return "B";
            else if (grade >= 65)
                return "C";
            else if (grade >= 50)
                return "D";
            else
                return "F";
        }
    }
}
