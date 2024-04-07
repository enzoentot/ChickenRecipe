using System;
using System.ComponentModel.Design;
using Recipe;

namespace ChickenRecipe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HAPPY HOLODAYS! ");
            Console.WriteLine("1.JANUARY");
            Console.WriteLine("2.FEBUARY");
            Console.WriteLine("3.MARCH");
            Console.WriteLine("4.APRIL");
            Console.WriteLine("5.MAY");
            Console.WriteLine("6.JUNE");
            Console.WriteLine("7.JULY");
            Console.WriteLine("8.AUGUST");
            Console.WriteLine("9.SEPTEMBER");
            Console.WriteLine("10.OCTOBER");
            Console.WriteLine("11.NOVEMBER");
            Console.WriteLine("12.DECEMBER");


            string instructions = Console.ReadLine();

            if (instructions == "1")
            {
                Months.January();
            }
            else if (instructions == "2")
            {
                Months.Febuary();
            }
            else if (instructions == "3")
            {
                Months.March();
            }

            else if (instructions == "4")
            {
                Months.April();
            }

            else if (instructions == "5")
            {
                Months.May();
            }

            else if (instructions == "6")
            {
                Months.June();
            }

            else if (instructions == "7")
            {
                Months.July();
            }

            else if (instructions == "8")
            {
                Months.August();
            }

            else if (instructions == "9")
            {
                Months.September();
            }

            else if (instructions == "10")
            {
                Months.October();
            }

            else if (instructions == "11")
            {
                Months.November();
            }

            else if (instructions == "12")
            {
                Months.December();
            }

            else
            {

                Console.WriteLine("Ivalid.Please RE-enter a valid MONTH");
            }
        }
            
        }
    }




        
    

