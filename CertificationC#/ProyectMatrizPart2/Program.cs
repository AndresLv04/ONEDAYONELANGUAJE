using System;

public class ProyectMatrizPart2
{
    // Main method should start with an uppercase "M"
    static void Main(string[] args)
    {
        // initialize variables - graded assignments
        int currentAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        //There is other:
        /*
            int sophia1 = 27;
            int sophia2 = 45;
            it's not better
        */

        int sophiaSum = 0;
        decimal sophiaScore;

        int andrewSum = 0;
        decimal andrewScore;

        int emmaSum = 0;
        decimal emmaScore;

        int loganSum = 0;
        decimal loganScore;

        

        foreach (int score in andrewScores)
        {
            // add the exam score to the sum
            andrewSum += score;
        }
        foreach (int score in emmaScores)
        {
            // add the exam score to the sum
            emmaSum += score;
        }
        foreach (int score in loganScores)
        {
            // add the exam score to the sum
            loganSum += score;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;
        andrewScore = (decimal)andrewSum / currentAssignments;
        emmaScore = (decimal)emmaSum / currentAssignments;
        loganScore = (decimal)loganSum / currentAssignments;



        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
        Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
        Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
        Console.WriteLine("Longan:\t\t" + loganScore + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

        /*------------------------------------*/
        string[] studentNames = new string{"Shophia", "Andrew", "Emma", "Longan",}
        foreach(string studentName in studentNames)
        {
            Console.WriteLine($"{studentName}");
            foreach (int score in sophiaScores)
        {
            // add the exam score to the sum
            sophiaSum += score;
        }
        }
    }
}
