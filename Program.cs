using System;

StartProgram();
static void StartProgram()
{
   
    Console.WriteLine("Welcome to Ielts Calculator Program");
    
    Console.Write("Listening Score: ");
    double listening = Convert.ToDouble(Console.ReadLine());
    Console.Write("Writing Score: ");
    double writing = Convert.ToDouble(Console.ReadLine());
    Console.Write("Reading Score: ");
    double reading = Convert.ToDouble(Console.ReadLine());
    Console.Write("Speaking Score: ");
    double speaking = Convert.ToDouble(Console.ReadLine());

    double overall = (listening + writing + reading + speaking) / 4;
    if (overall >= 8.5 && overall <= 9) Console.WriteLine("Your Ielts level is Expert");
    else if (overall >=7.5 && overall < 8.5) Console.WriteLine("Your Ielts level is Very Good");
    else if (overall >= 6.5 && overall < 7.5) Console.WriteLine("Your Ielts level is Good");
    else if (overall >= 5.5 && overall < 6.5) Console.WriteLine("Your Ielts level is Competent");
    else if (overall >=5 && overall < 5.5) Console.WriteLine("Your Ielts level is Modest ");
    else if (overall > 9 && overall < 5) Console.WriteLine("Below or above that range is Invalid");
}


