using System;

class CalcMain
{

    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Which operatiion? (a or s, x to exit):");
        string choice = Console.ReadLine();
        while (choice != "x")
        {

        
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calc.Subtract(12, 34));
            if(choice == "a")
            {
                Console.WriteLine(calc.Add(firstNumber, secondNumber));
            }  else if (choice == "s")
            {
                Console.WriteLine(calc.Subtract(firstNumber, secondNumber));
            } else
            {
                Console.WriteLine("Invalid Choice!");
            }
            Console.WriteLine("Which operatiion? (a or s, x to exit):");
            choice = Console.ReadLine();
        }    
    }
}