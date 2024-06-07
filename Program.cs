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

double overall = (listening+writing+reading+speaking)/4;
}


