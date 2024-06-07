using System;

StartProgram();
static void StartProgram()
{
    Console.WriteLine("Welcome to Ielts Calculator Program");
    Console.WriteLine("Welcome IELTS Band Score Calculator\nPlease enter your score");
    Console.Write("Listening Score: ");
    double listening = Convert.ToDouble(Console.ReadLine());
    Console.Write("Writing Score: ");
    double writing = Convert.ToDouble(Console.ReadLine());
    Console.Write("Reading Score: ");
    double reading = Convert.ToDouble(Console.ReadLine());
    Console.Write("Speaking Score: ");
    double speaking = Convert.ToDouble(Console.ReadLine());

    double overall = (listening + writing + reading + speaking) / 4;
    if (overall > 8 && overall <= 9) Console.WriteLine("Your Ielts level is Expert");
    if (overall > 7 && overall <= 8) Console.WriteLine("Your Ielts level is Very Good");
    if (overall > 6 && overall <= 7) Console.WriteLine("Your Ielts level is Good");
    if (overall > 5 && overall <= 6) Console.WriteLine("Your Ielts level is Competent");
    if (overall == 5) Console.WriteLine("Your Ielts level is Modest ");
    if (overall > 9 && overall < 5) Console.WriteLine("Below or above that range is Invalid");
}


