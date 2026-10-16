using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrikKalandpark
{
    internal class Program
    {
        static void MenuKiir()
        {
            Console.WriteLine("======PETRIK KALANDPARK======");
            Console.WriteLine("1.) Napijegy vásárlása");
            Console.WriteLine("2.) Pálya választása");
            Console.WriteLine("3.) Kupon kalkulátor");
            Console.WriteLine("4.) Napi bevétel");
            Console.WriteLine("5.) Kilépés");
            Console.WriteLine(" ");
            Console.WriteLine("Választás: ");
            
        }

        static string JegyTipus(int eletkor)
        {

            
            if (eletkor == 0 && eletkor <= 7)
            {
                return "Mini jegy";
            }
            else if (eletkor <= 15)
            {
                return "Junior jegy";
            }
            else if (eletkor <= 24)
            {
                return "Ifjúsági jegy";
            }
            else if (eletkor <= 59)
            {
                return "Felnőttjegy";
            }
            else if (eletkor <=60)
            {
                return "Senior jegy";
            }
            else
            {
                return "Nincs ilyen tipusú jegy";
            }

        }

        static int JegyAr(int eletkor)
        {

            if (eletkor < 0 || eletkor > 120) 
            {
                return 0;
            }
            else if (eletkor <= 14 && eletkor >= 0)
            {
                return 1000;
            }
            else if (eletkor <= 15)
            {
                return 2200;

            }
            else if (eletkor <= 24)
            {
                return 3000;
            }
            else if (eletkor <= 59)
            {
                return 4500;
            }
            else if (eletkor >= 60)
            {
                return 2800;
            }
            else
                    {  return 0; }
        }

        static void Palyavalaszto()
        {
            Console.WriteLine("=====KALANDPÁLYÁK======");
            Console.WriteLine("1.) Gyerekpálya");
            Console.WriteLine("2.) Erdei pálya");
            Console.WriteLine("3.) Extrém pálya");
            Console.WriteLine(" ");
            Console.WriteLine("Választás");
            int valasztas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Magasság:");
            int magassag = Convert.ToInt32(Console.ReadLine());
                switch (magassag)
                    {
                    case 1:
                        {
                            if (magassag < 90)
                            {
                                Console.WriteLine("Nem használhatod ezt a pályát!");
                            break;
                            }
                            else
                                    {
                                Console.WriteLine("Használhatod ezt  a pályát! ");
                                break;
                            }
                        }
                    case 2:
                        {
                            if (magassag < 130)
                            {
                                Console.WriteLine("Nem használhatod ezt a pályát!");
                            break;
                            }
                            else
                            {
                                Console.WriteLine("Használhatod ezt  a pályát! ");
                            break ;
                            }



                        }
                    case 3:
                        {
                            if (magassag < 160)
                            {
                                Console.WriteLine("Nem használhatod ezt a pályát!");
                            break;
                            }
                            else
                            {
                                Console.WriteLine("Használhatod ezt  a pályát! ");
                            break;
                            }

                        }
                    default:
                        {
                            Console.WriteLine("Nincs ilyen pálya");
                        break;
                        }


            }
        }

        
        static int KuponosAr(int ar, int kupon)
        {
            switch(kupon)
            {
                case 1:
                    return ar;

                case 2:
                    return ar - ar * 10 / 100;

                case 3:
                    return ar - ar * 25 / 100;

                default:
                    return ar;
            }
        }
        static void KuponKalk()
        {
            Console.WriteLine("A jegy eredeti ára");
            int ar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.) Nincs kupon");
            Console.WriteLine("2.) SILVER kupon - 10%");
            Console.WriteLine("3.) GOLD kupon - 25%");
            Console.WriteLine(" ");
            Console.WriteLine("Kupon:");
            int kupon = Convert.ToInt32(Console.ReadLine());

            if (kupon > 0 && kupon <= 3)
            {
                int fizetendo =
                    KuponosAr(ar, kupon);

                Console.WriteLine();

                Console.WriteLine(
                    $"Fizetendő: {fizetendo} Ft"
                );
            }
            else
            {
                Console.WriteLine(
                    "Nincs ilyen kedvezménytípus!"
                );

            }

        }
        static void Main(string[] args)
        {
                int bevetel= 0;
                int valasztas= 0;
            do
            {
                Console.Clear();
                MenuKiir();
                try
                {
                    valasztas = Convert.ToInt32(Console.ReadLine());

                    switch (valasztas)
                    {
                        case 1:

                            Console.Clear();

                            Console.WriteLine(
                                "=== JEGYVÁSÁRLÁS ==="
                            );

                            Console.WriteLine();


                            Console.Write("Név: ");

                            string nev =
                                Console.ReadLine();


                            Console.Write("Életkor: ");

                            int eletkor =
                                Convert.ToInt32(
                                    Console.ReadLine()
                                );


                            if (eletkor < 0 && eletkor > 120)
                            {
                                Console.WriteLine(
                                    "Hibás életkor!"
                                );
                            }
                            else
                            {
                                string jegyTipus =
                                    JegyTipus(eletkor);


                                int ar =
                                    JegyAr(eletkor);


                                Console.WriteLine();

                                Console.WriteLine(
                                    $"Jegytípus: {jegyTipus}"
                                );


                                Console.WriteLine(
                                    $"Fizetendő: {ar} Ft"
                                );


                                bevetel += ar;
                            }

                            Console.ReadLine();

                            break;


                        case 2:

                            Palyavalaszto();

                            Console.ReadLine();

                            break;


                        case 3:

                            KuponKalk();

                            Console.ReadLine();

                            break;


                        case 4:

                            Console.Clear();

                            Console.WriteLine(
                                "=== NAPI BEVÉTEL ==="
                            );

                            Console.WriteLine();

                            Console.WriteLine(
                                $"A kalandpark mai bevétele:: {bevetel} Ft"
                            );

                            Console.ReadLine();

                            break;


                        case 5:

                            Console.WriteLine("Viszlát!");

                            Console.ReadLine();

                            break;


                        default:

                            Console.WriteLine(
                                "Válassz az 1-5 lehetőség közül!"
                            );

                            Console.ReadLine();

                            break;
                    }
                }
                catch
                {
                    Console.WriteLine();

                    Console.WriteLine(
                        "Hiba! Számot kell megadni!"
                    );

                    Console.ReadLine();
                }



            } while (valasztas != 5);    
                

        }
       
    }
}
