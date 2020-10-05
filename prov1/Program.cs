using System;

namespace prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int answerInt = 0;
            string answerString = "";
            bool correctAnswer = false;
            Console.WriteLine("");


            while (!correctAnswer)
            {

                answerString = Console.ReadLine();
                correctAnswer = int.TryParse(answerString, out answerInt);

                if (!correctAnswer)
                {
                    Console.WriteLine("Skriv endast siffror");
                }

                if (answerInt = 5 || 6 || 8 || 8)
                {
                    Console.WriteLine("Near miss!");
                }

                else if (answerInt != 5)
                {
                    Console.WriteLine("Fel! Försök igen.");
                    correctAnswer = false;
                }
                else
                {
                    points++;
                    Console.WriteLine("Hit!.");

                }
            }
            Console.ReadLine();
        }
    }
}
