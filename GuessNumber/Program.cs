using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var RandNUmber = rand.Next(101);
            RulesInformationToPlayer();

            var counter = 0;
            while (true)
            {
                counter++;
                var YourNumber = InputNumber();
                if (RandNUmber == YourNumber)
                {
                    Console.WriteLine($"Odgadłeś liczbę w {counter} próbach.");
                    break;
                }
               
                if (RandNUmber < YourNumber && YourNumber<=100)
                {
                    Console.WriteLine("Twoja liczba jest większa niż wylosowana.");
                }
               else if(RandNUmber > YourNumber && YourNumber>=0) 
                    {
                    Console.WriteLine("Twoja liczba jest mniejsza niż wylosowana.");
                }   
            }
           
            Console.ReadLine();
        }
        private static int InputNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int number) || number >= 100 ||number<0)
            {
                RulesInformationToPlayer();
            }
            return number;
        }
        private static void RulesInformationToPlayer()
        {
             Console.WriteLine("Podaj liczbę od 1 do 100.");
        }
    }

}
