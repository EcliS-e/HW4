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

            //Initialize variables 
            string userName;
            int playerScore;

            //Check if a previous file exists, if not, prompt the user to enter a username
            //and start out with the score of zero.
            if (File.Exists("username.txt"))
            {
                
                using (StreamReader sr = new StreamReader("username.txt"))
                {
                   // load previous data into user name and player score variables 
                    userName = sr.ReadLine();
                    playerScore = Int32.Parse(sr.ReadLine());

                    Console.WriteLine("Welcome " + userName);


                }
            }
            else
            {
                //prompt username and set playerscore to 0
                Console.WriteLine("What's your name?");

                userName = Console.ReadLine();
                playerScore = 0;
            }

            //increase score while keys except enter are pressed
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {


                playerScore++;
                Console.WriteLine("\n Your score is " + playerScore);

            }
            //Save data : username and player score  
            using (StreamWriter sw = new StreamWriter("username.txt"))
            {
                sw.WriteLine(userName);
                sw.WriteLine(playerScore);
            }

            

        }
    }
}