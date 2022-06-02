using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada oma eesnimi
            //programm kuvab kasutaja eesnime pikust
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem, kui 3 rida koodi

            Console.WriteLine("sisesta oma eesnime:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"sinu nimi on {userInput.Length} sumbolit pikk.");
            Console.WriteLine($"sinu eesnime esimene taht on {userInput[0]}");
            
            for(int i =userInput.Length - 1; i >= 0; i --)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
