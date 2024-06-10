using System;

StartProgram();
static void StartProgram()
{
    Console.WriteLine("Welcome to IELTS Calculator Program");
    
    double listening = GetValidScore("Listening Score");
    double writing = GetValidScore("Writing Score");
    double reading = GetValidScore("Reading Score");
    double speaking = GetValidScore("Speaking Score");

    double overall = (listening + writing + reading + speaking) / 4;
    overall = Math.Round(overall * 2, MidpointRounding.AwayFromZero) / 2;

    if (overall >= 8.5 && overall <= 9) Console.WriteLine($"Your IELTS level is Expert with an overall score of {overall}");
    else if (overall >= 7.5 && overall < 8.5) Console.WriteLine($"Your IELTS level is Very Good with an overall score of {overall}");
    else if (overall >= 6.5 && overall < 7.5) Console.WriteLine($"Your IELTS level is Good with an overall score of {overall}");
    else if (overall >= 5.5 && overall < 6.5) Console.WriteLine($"Your IELTS level is Competent with an overall score of {overall}");
    else if (overall >= 5 && overall < 5.5) Console.WriteLine($"Your IELTS level is Modest with an overall score of {overall}");
    else Console.WriteLine("Below or above the valid range, please check the scores entered.");
}

static double GetValidScore(string prompt)
{
    double score;
    while (true)
    {
        try
        {
            Console.Write(prompt + ": ");
            score = Convert.ToDouble(Console.ReadLine());
            if (score >= 0 && score <= 9)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid score between 0 and 9.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
      
    }
    return score;
}
