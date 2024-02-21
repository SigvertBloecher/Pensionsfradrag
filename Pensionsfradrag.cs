using System;

namespace My_Awesome_Project
{
    class Pensionsfradrag
    {
       //float for decimals -> only 7
       //double can hold 16 digits
       //Bool -> true/false
       // var if you don't now what type the answer will be
        static void Main(string[] args)
        {
            Console.Title = "Pensionsfradrag";
            Console.ForegroundColor = ConsoleColor.Green;

            double num1;
            double num2;
            int num3;
            int born;
            double num4;

            for(int num5 = 0; num5 <1000000; num5++)
            {
            Console.WriteLine("\nVelkommen til Pensionsfradragsprogrammet. Vær opmærksom på, at der skelnes mellem store og små bogstaver.\n\nIndtast fødselsår på borger: ");
            born = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast indskudt beløb: ");

            num1 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Indbetales der som Privat eller gennem Arbejdsgiver?");
            string indbetaler = Console.ReadLine();
            if(indbetaler == "Privat")
            {
            Console.WriteLine("Indtast valg af pension: Livrente, Ratepension, Aldersopsparing eller Kapitalpension");
            string pension = Console.ReadLine();
            if(pension == "Livrente")
            {
            Console.WriteLine("Indtast Opfyldningskrav for Livrentepension (i 2021 er den 53.800 kr.): ");
            num2 = Convert.ToDouble( Console.ReadLine() );

            if(num1<num2)
            {
                Console.WriteLine("Fradraget er " + num1 + " kr.");
            }
            else
            {
                if(num1/10<num2)
                {
                    num3 = Convert.ToInt32(num1/num2);
                    num4 = num1-num2*num3;
                    Console.WriteLine("Antal år, fradraget på " + num2 + " kan trækkes fra: " + num3);
                    Console.WriteLine("Fradrag det sidste år, forudsat der ikke bliver indbetalt mere: " + num4);
                }
                else
                {
                    Console.WriteLine("Fradrag pr. år de næste 10 år: " + num1/10);
                }
            }
            }

            if(pension == "Ratepension")
            {
                Console.WriteLine("Ratepension ikke kodet endnu");
            }

            if(pension == "Aldersopsparing")
            {
                Console.WriteLine("Aldersopsparing ikke kodet endnu");
            }

            if(pension == "Kapitalpension")
            {
                Console.WriteLine("Kapitalpension ikke kodet endnu");
            
            }
            }

            if(indbetaler == "Arbejdsgiver")
            {
                Console.WriteLine("Arbejdsgiver ikke kodet endnu");
            }
            
            Console.WriteLine("Ønsker du at afslutte? y/n");
             string exit = Console.ReadLine();
            if(exit == "y")

            {
               break;
            }

            //Console.ReadKey(); //wait before closing
            }
        }
    }
}

