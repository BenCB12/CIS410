// S2097
// Program 1
// 2/11/20
// CIS 199-75
// Create a program that will give an estimation on carpet installation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width; // width entered by user
            double length; // length entered by user
            double carpetPrice; // price of carpet entered by user
            int paddingLayers; // # of padding layers entered by user
            int firstRoom; // if this is first room done
            double yardConversion; // number to convert sq. feet to sq. yards
            double totalSqYards; // total sq. yards needed
            double carpetCost; // total cost for carpet
            double paddingCost; // total cost for padding
            double laborCost; // total cost for labor
            double totalCost; // total cost of project
            double wastePercent; // extra calculated for waste
            double paddingPrice; // price per sq. yard of padding
            double firstRoomPrice; // price if first room done
            double laborPrice; // price of labor per sq. yard

            yardConversion = 9;
            wastePercent = 1.1;
            paddingPrice = 2.5;
            firstRoomPrice = 75.0;
            laborPrice = 4.25;

            WriteLine("Enter the max width of room (in feet): ");
            width = double.Parse(ReadLine());

            WriteLine("Enter the max length of room (in feet): ");
            length = double.Parse(ReadLine());

            WriteLine("Enter the carpet price (per sq. yard): ");
            carpetPrice = double.Parse(ReadLine());

            WriteLine("Enter layers of padding to use (1 or 2): ");
            paddingLayers = int.Parse(ReadLine());

            WriteLine("Is this the first room? (1 = YES, 0 = NO): ");
            firstRoom = int.Parse(ReadLine());

            
            

            totalSqYards = width * length / yardConversion;
            carpetCost = carpetPrice * totalSqYards * wastePercent;
            paddingCost = paddingPrice * paddingLayers * totalSqYards * wastePercent;
            laborCost = laborPrice * totalSqYards + (firstRoom * firstRoomPrice);
            totalCost = carpetCost + paddingCost + laborCost;

            WriteLine($"Sq. Yards Needed: {totalSqYards:f1}");
            WriteLine($"Carpet Cost:      {carpetCost:c}");
            WriteLine($"Padding Cost:     {paddingCost:c}");
            WriteLine($"Labor Cost:       {laborCost:c}");
            WriteLine($"Total Cost:       {totalCost:c}");
        }
    }
}
