using System;

using System.Text;

namespace Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean choice =true;//To check if the user would like to continue running the program another time

            while (choice)
            {
                Console.WriteLine("Learn your squares and cubes!");
                //prompts the user to enter an integer
                Console.WriteLine("Please enter an integer: ");
                //read the user input
                string input = Console.ReadLine();
                //convert the input to an integer
                int userInput = int.Parse(input);
                //declear an empty array with size = the value that the user entered
                double[] array = new double[userInput];
                //loop to intialize the array with value started from 1 to user input
                for (int i = 0; i < userInput; i++)
                {
                    array[i] = i + 1;
                }

                //declare and intialize an array with squared values
                double[] arraySq = new double[userInput];
                for (int i = 0; i < arraySq.Length; i++)
                {
                    arraySq[i] = Math.Pow(array[i], 2);
                }

                //declare and intialize an array with cubed values
                double[] arrayCub = new double[userInput];
                for (int i = 0; i < arrayCub.Length; i++)
                {
                    arrayCub[i] = Math.Pow(array[i], 3);
                }
                //calling FormatingOutput to formate the output 
                FormatingOutput(array, arraySq, arrayCub);

                //asking the user if he/she wants to continue
                Console.WriteLine("Continue ? (y/n)");
                string userChoice = (Console.ReadLine()).ToLower();
                if (userChoice == "n")
                {
                    choice = false;
                }
            }
          }

            public static void FormatingOutput(double[] array,double[] arraySq,double[] arrayCub)
            {
                //Table head formate
                string s = string.Format("{0,-11} {1,-11} {2,-11}", "Number", "Squared", "Cubed");
                Console.WriteLine(s);
                string t = string.Format("{0,-11} {1,-11} {2,-11}", "=======", "=======", "=======");
                Console.WriteLine(t);
                //print the arrays 
                string d = "";
                for (int index = 0; index < array.Length; index++)
                    d += String.Format("{0,-11}  {1,-11} {2,-11}\n", array[index], arraySq[index], arrayCub[index]);
                Console.WriteLine(d);

            }
    }
}
