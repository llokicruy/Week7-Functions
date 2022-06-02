using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime
            //programm kusib kasutajal sisestada numbrit 1-3
            //kui kasutaja valin 1, siis kuvatakse tema eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimene taht
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust


            Console.WriteLine("sisesta oma eesnime:");
            string userName = Console.ReadLine();

            Console.WriteLine("vali number: (sisesta '1', '2' voi '3')");
            char userOperator = Convert.ToChar(Console.ReadLine());


            switch (userOperator)
            {
                case '1':
                    Number1(userName);
                    break;
                case '2':
                    Number2(userName);
                    break;
                case '3':
                    Number3(userName);
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void Number1(string userInput)
        {


            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void Number2(string userInput)
        {
            Console.WriteLine($"sinu eesnime esimene taht on {userInput[0]}");
        }

        public static void Number3(string userInput)
        {
            Console.WriteLine($"sinu nimi on {userInput.Length} sumbolit pikk.");
        }

    }
}
