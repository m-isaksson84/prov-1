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
            bool numericalAnswer = false;
            bool correctAnswer = false;

            Console.WriteLine("Välje ett värde mellan 0-10");


            while (!numericalAnswer)
            {

                answerString = Console.ReadLine();
                numericalAnswer = int.TryParse(answerString, out answerInt);

                // testar om svaret är en siffra och om den inte är det körs koden nedan och användaren måste försöka igen
                if (!numericalAnswer)
                {
                    Console.WriteLine("Skriv endast siffror");
                }

            }


            while (!correctAnswer)
            {

                correctAnswer = int.TryParse(answerString, out answerInt);
                if (answerInt != 7)
                {
                    Console.WriteLine("Fel svar!");
                    //numericalAnswer = true;
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
