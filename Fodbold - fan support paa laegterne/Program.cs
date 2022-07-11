using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold___fan_support_paa_laegterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int afleveringer; //opret int variable
                string mål, hf = "High five", ju = "Jubel!!!", hu = "Huh!", sh = "Shh", ol = "Olé olé olé"; //opret 6 string variabler
                do
                {
                    try //prøv at konvertere input til 32 bit integer
                    {
                        Console.Write("\nAntal aflerveringer: ");
                        afleveringer = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException) //catch hvis input ikke er tal
                    {
                        Console.WriteLine("input må kun være et tal");
                        continue;
                    }
                    catch (Exception ex) //catch generel fejl
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                } while (true);
                Console.Write("Skriv 'mål' hvis der er mål: ");
                mål = Console.ReadLine().ToLower();

                if (mål == "mål")
                {
                    Console.WriteLine("\n{0}",ol); //skriv Olé olé olé hvis brugeren har skrevet mål
                }
                else if (afleveringer == 0)
                {
                    Console.WriteLine("\n{0}",sh); //skriv Shh hvis brugeren har angivet 0 afleveringer
                    continue;
                }
                else if (afleveringer <= 10)
                {
                    Console.WriteLine("\n");
                    for (int i = 0; i < afleveringer; i++) //loop de antal gange brugeren har skrevet i afleveringer
                    {
                        Console.Write("{0} ", hu); //skriv Huh!
                    }
                    Console.WriteLine("\n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"\n{hf} - {ju}"); //skriv High five og Jubel!!! hvis brugeren har angivet over 10 afleveringer
                    continue;
                }
            } while(true);
            
        }
    }
}
