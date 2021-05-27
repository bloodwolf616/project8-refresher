using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8_refresher_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 10;
            number1 += 10;
            Console.WriteLine(number1);
            Console.WriteLine(add(10, 15));
            askMathQuestion(256, 567);

            Bird robin = new Bird("red", "robin");
            Console.WriteLine(robin.Species);
            
            
            Console.ReadLine();
        }


        static void askMathQuestion(int firstNumber, int secondnumber)
        {
            int correctAnswer = firstNumber + secondnumber;
            int answerAsInt = 0;
            Console.WriteLine($"what is {firstNumber} + {secondnumber}");

            while (correctAnswer != answerAsInt)
            {
             
                    string guess = Console.ReadLine();
                    answerAsInt = int.Parse(guess);
                    if (correctAnswer == answerAsInt)
                    {
                        Console.WriteLine("Correct answer. good job. Press any key to exit");
                        break;
                    }
                    else { Console.WriteLine("Sorry please try again."); }
            }
      
            
        }

        static double add(int firstNumber, int secondNumber)
        {
            double firstN = firstNumber;
            double secondN = secondNumber;

            return firstN + secondN;
        }
    }
}
