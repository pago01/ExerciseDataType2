using System;


namespace ExerciseDatatype2
{
    //Data structure declaration

    class Program
    {
        

        public static void Main(string[] args)
        {
            char letter1 = ' ';
            char letter2 = ' ';
            char letter3 = ' ';

            //Letter1
            Console.WriteLine("Podaj pierwszą literę");
            Char.TryParse(Console.ReadLine(), out letter1);
            //Letter2
            Console.WriteLine("Podaj drugą literę");
            Char.TryParse(Console.ReadLine(), out letter2);
            //Letter3
            Console.WriteLine("Podaj trzecią literę");
            Char.TryParse(Console.ReadLine(), out letter3);
            
            //Display data
            Console.WriteLine($"Litera 3: {letter3}");
            Console.WriteLine($"Litera 2: {letter2}");
            Console.WriteLine($"Litera 1: {letter1}"); 
            
        }
    }
}
