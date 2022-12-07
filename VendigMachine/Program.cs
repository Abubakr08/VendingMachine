using System;

namespace VendigMachine
{
    class Program
    {
        public const double ColaAmount = 1, ChipsAmount = 0.5, CandyAmount = 0.65;
        //public const double Nickels = 20, Dimes = 10, Quarters = 25;
        static void Main(string[] args)
        {
            int itemType = 0;
            TakeInput(ref itemType);
            double EnteredAmt;
            Console.WriteLine();
            while (itemType != 1 || itemType != 2 || itemType != 3)
            {
                switch (itemType)
                {
                    case 1:
                        Console.WriteLine("\nPlease Enter/Pay $1.00 for Cola");
                        EnteredAmt = Convert.ToDouble(Console.ReadLine());
                        ValidateAmount(ColaAmount,EnteredAmt);
                        
                        break;


                    case 2:
                        Console.WriteLine("\nPlease Enter/Pay $0.50 for Chips");
                        EnteredAmt = Convert.ToDouble(Console.ReadLine());
                        ValidateAmount(ChipsAmount, EnteredAmt);
                        break;

                    case 3:
                        Console.WriteLine("\nPlease Enter/Pay $0.65 for Candy");
                        EnteredAmt = Convert.ToDouble(Console.ReadLine());
                        ValidateAmount(CandyAmount, EnteredAmt);
                        break;


                    default:
                        return;
                }
                TakeInput(ref itemType);
            }
        }

        public static void ValidateAmount(double ProdutAmount, double EnteredAmount)
        {
            double Short;
            if (EnteredAmount == ProdutAmount)
                Console.WriteLine("\nPlease Collet the Cola\nThanks You!\n\n");
            else if (EnteredAmount < ProdutAmount)
            {
                Console.WriteLine("\nEntered Amount is Less, Please Enter ${0} more\n", ProdutAmount - EnteredAmount);
                Short = Convert.ToDouble(Console.ReadLine());
                ValidateAmount((double)System.Math.Round(ProdutAmount - EnteredAmount,2), Short);
            }
            else
            {
                Console.WriteLine("\nPlease Collet the Cola and your change ${0}\nThanks You!\n\n", (EnteredAmount - ProdutAmount));
            }
        }

        public static void TakeInput(ref int itemType)
        {
            Console.WriteLine("Press/Select the Number you want buy \n1)Cola for $1.00 \n2)Chips for $0.50 \n3)Candy for $0.65. Any other key to quit: ");
            try
            {
                itemType = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}