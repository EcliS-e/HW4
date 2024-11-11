using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream aFile = new FileStream("username.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);

            int playerScore = 0;

            Console.WriteLine("What's your name?");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();



            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {


                playerScore++;
                Console.WriteLine("/n Your score is " + playerScore);
                sw.WriteLine(playerScore);
            }


            Environment.Exit(0);

            /*
            When(keyPressed) {
                playerScore++;

                Console.WriteLine(playerScore);

            }
            If
'*/




        }
    }
}