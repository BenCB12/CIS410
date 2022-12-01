//Grading ID here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityApp
{
    public class CommodityItem
    {
        // #1 - Put needed backing fields here
        // Remember: Some properties may be
        // auto-implemented, so only create
        // backing fields for ones needed

        public string Description
        {
            // #2 - Put your code here for get/set accessors
            // May be auto-implemented

        }

        public string ProductNumber
        {
            // #3 - Put your code here for get/set accessors
            // May be auto-implemented

        }

        public int Quantity
        {
            // #4 - Put your code here for get/set accessors
            // Set must validate!

        }

        public double Price
        {
            // #5 - Put your code here for get/set accessors
            // Set must validate!

        } 

        public CommodityItem(string desc, string productNum, int quant, double price)
        {
            // #6 - Put your code here for constructor
            // Be sure your parameters get validated through properties

        }

        public double CalcValue()
        {
            // #7 - Put your code here to calculate value of
            // this item in inventory
            // Example: 2000 @ $9.99 = $19,980

        }

        public override string ToString()
        {
            // #8 - Put your code here to create formatted string
            // Use format that would produce a string like:
            // "TP1234: Toilet Papers (2500 @ $29.99)"
            // where TP1234 is the prodcut number, Toilet Paper is the
            // description, 2500 is the quantity, and $29.99 is
            // the price. No newlines are needed.

           
        }
    }
}
