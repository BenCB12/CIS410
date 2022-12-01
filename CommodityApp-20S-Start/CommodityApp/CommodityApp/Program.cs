// S2097

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CommodityApp
{
    class Program
    {
        private int _quantity;
        private double _price;
        public string Description { get; set; }
        public string ProductNumber { get; set; }
        public int Quantity { get { return _quantity; } set { if (Quantity < 0) Quantity = 0; } }
        public double Price { get { return _price; } set { if (Price < 0) Price = 0; } }
        static void Main(string[] args)
        {
            double currentValue;   // Current commodity's value
            double totalValue = 0; // Running total of commodity's value
            CommodityItem[] items; // Commodity Items

            // #1 - Put code here to construct 3  commodity items: Toilet Paper, Hand Sanitizer, Disinfection Wipes as directed
            CommodityItem item1 = new CommodityItem  //Toilet Paper
            CommodityItem item2 = new CommodityItem; //Hand Sanitizer
            CommodityItem item3 = new CommodityItem; //Disinfection Wipes
           

            items = new CommodityItem[] { item1, item2, item3 };

            WriteLine($"Commodity Revenue Report:");

            // #2 - Complete loop to step through array of items
            for (int index = 0; index <= 2; ++index)
            {
                
                currentValue = CalcValue// #3 - Complete statement to calculate value of current item
                               //      from array by calling CalcValue

                totalValue = currentValue + totalValue; // #4 - Add currentValue into running total

                WriteLine($"{currentValue:c}");
                WriteLine($"{CommodityItem[index]}");

                // #5 - Output currentValue, with currency formatting, followed by string representation
                //      of current item from array
            }

            WriteLine($"\nTotal Gross Revenue: {totalValue:c}");
            // #6 - Output totalValue of Gross Revenue, with currency formatting

            double CalcValue()
            {
                double value;

                value = Price * Quantity;
                return value;
            }
           

           
        }
    }
}
