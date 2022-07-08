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
                int afleveringer;
                string mål, hf = "High five", ju = "Jubel!!!", hu = "Huh!", sh = "Shh", ol = "Olé olé olé";
                do
                {
                    try
                    {
                        Console.Write("\nAntal aflerveringer: ");
                        afleveringer = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("input må kun være et tal");
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                } while (true);
                Console.Write("Skriv 'mål' hvis der er mål: ");
                mål = Console.ReadLine().ToLower();

                if (mål == "mål")
                {
                    Console.WriteLine(ol);
                }
                else if (afleveringer == 0)
                {
                    Console.WriteLine(sh);
                    continue;
                }
                else if (afleveringer <= 10)
                {
                    for (int i = 0; i < afleveringer; i++)
                    {
                        Console.Write("{0} ", hu);
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine($"{hf} - {ju}");
                    continue;
                }
            } while(true);
            
        }
    }
}
