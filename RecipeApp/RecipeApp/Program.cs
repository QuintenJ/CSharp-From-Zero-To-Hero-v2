using System;

namespace RecipeApp
{

    //Here is async list of standard cooking units:
    //  Cup 0.24 1
    //  Gallon 3.79 1
    //  Fluid Ounce 29.57 ml
    //  Pint 0.47 1
    //  Quart 0.95 1
    //  Tablespoon 14.79 ml
    //  Teaspoon 4.93 ml

    // Holder of functions and data
    class Program
    {
        // Name block of code
        static void Main(string[] args)
        {
            
            double totalM1 = PrintTeaspoonsToMl() + PrintTablespoonsToMl();
            PrintHowMany100MlBottles(totalM1);
           
        }

        static double PrintTeaspoonsToMl()
        {
            double teaspoons = GetAmountFromConsole(unit: "teaspoons"); ;
            double mlOfTeaspoons = TeaspoonsToM1(teaspoons);
            Print(cookingUnitAmount: teaspoons, cookingUnit: "teaspoons", mlOfTeaspoons);

            return mlOfTeaspoons;
        }
         
        static double PrintTablespoonsToMl()
        {
            double tablespoons = GetAmountFromConsole(unit: "tablespoon");
            double mlOfTablespoon = TableSpoonsToM1(tablespoons);
            Print(cookingUnitAmount: tablespoons, cookingUnit: "tablespoon", mlOfTablespoon);

            return mlOfTablespoon;
        }

        static void PrintHowMany100MlBottles(double ml)
        {
            // 1 / 0 = error
            // 1 / 2 = 0
            // int / int = int
            // 1.0 / 2 = 0.5
            // double / int = double
            // 1.0 + 1 = 2.0
            // double + int = double
            // We have bottles of 100 ml.
            // How many bottles can we fill after the conversion?
            // int is a whole number
            int bottlesCount = (int)(ml / 100) + 1;
            Console.WriteLine($"{ml:F2} can fill {bottlesCount} bottles of 100ml");
        }
        static double GetAmountFromConsole(string unit)
        {
            Console.WriteLine($"Please enter {unit} amount:");
            string amountText = Console.ReadLine();


            // ml = teaspoons * 4.93
            // Floating point number with double precision.
            double amount = double.Parse(amountText);

            return amount;
        }

        static double TeaspoonsToM1(double teaspons)
        {
            //4.93m is decimal - use it for money
            //4.93 is double
            //4.93f is a float use it when you don't plan to use math.
            double ml = teaspons * 4.93;

            return ml;
        }

        static double TableSpoonsToM1(double teaspons)
        {
            
            double tablespoons = teaspons * 14.79;

            return tablespoons;
        }
        static void Print(double cookingUnitAmount, string cookingUnit, double ml)
        {
            //string interpolation
            // F2 2 digits after the decimal point
            string convertedDescription = $"{cookingUnitAmount} {cookingUnit} = {ml:F2} ml";
            Console.WriteLine(convertedDescription);

        }
    }
}
