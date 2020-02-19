using System;

namespace TestEvenlyDivisible
{
    public class Program
    {
        public static void Main(string[] args)
        {
               bool isContinue = true;
               Input obj = new Input();
               while (isContinue)
               {
                //TODO : we need to remove below try catch block still we have try parse for each input, not doing any business logic by Exceptions and want to re-try something that may fail.
                try
                {
                invalidLow:                    
                    Console.WriteLine("Please enter the Min value : ");
                    int minNumber;
                    var low = Console.ReadLine();
                    if (!int.TryParse(low, out minNumber))
                    {
                        Console.WriteLine("Please enter the valid Min value.");
                        goto invalidLow;
                    }
                    obj.Start = Convert.ToInt32(low);
                    if (obj.Start <= 0)
                    {
                        Console.WriteLine("Please enter the valid Min value.");
                        goto invalidLow;
                    }
                invalidHigh:
                    Console.WriteLine("Please enter the Max value : ");
                    var high = Console.ReadLine();
                    if (!int.TryParse(high, out minNumber))
                    {
                        Console.WriteLine("Please Enter the valid Max value. ");
                        goto invalidHigh;
                    }
                    obj.End = Convert.ToInt32(high);
                    if (obj.End <= 0)
                    {
                        Console.WriteLine("Please Enter the valid Max value. ");
                        goto invalidHigh;
                    }
                    if (obj.Start > obj.End)
                    {
                        Console.WriteLine("Please Enter the valid values for Min and Max. ");
                        goto invalidLow;
                    }
                invalidA:
                    Console.WriteLine("Please enter the vlaue for First Divisible");
                    var firstDivisible = Console.ReadLine();
                    if (!int.TryParse(firstDivisible, out minNumber))
                    {
                        Console.WriteLine("Please Enter the valid First Divisible value.");
                        goto invalidA;
                    }
                    obj.FirstDivisible = Convert.ToInt32(firstDivisible);
                    if (obj.FirstDivisible <= 0)
                    {
                        Console.WriteLine("Please Enter the valid First Divisible value. ");
                        goto invalidA;
                    }
                invalidB:
                    Console.WriteLine("Please enter the vlaue for Second Divisible");
                    var secondDivisible = Console.ReadLine();
                    if (!int.TryParse(secondDivisible, out minNumber))
                    {
                        Console.WriteLine("Please Enter the valid Second Divisible value. ");
                        goto invalidB;
                    }
                    obj.SecondDivisible = Convert.ToInt32(secondDivisible);
                    if (obj.SecondDivisible <= 0)
                    {
                        Console.WriteLine("Please Enter the valid Second Divisible value.");
                        goto invalidB;
                    }

                    Console.WriteLine("Output : ");
                    CheckEvenlyDivisible(obj);
                invalidChoice:
                    Console.WriteLine("Please enter Y to continue else N : ");
                    var val = Console.ReadLine();
                    if (val.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                    {
                        isContinue = false;
                    }
                    else if (val.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("Welcome back!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid choice");
                        goto invalidChoice;

                    }
                }
                catch(Exception)
                {
                //TODO: Do we really need this option since the application getting crashed, or can we give the down time for the user until system is up

                invalidExceptionChoice:
                    Console.WriteLine("Internal Application Error occured, still want to continue please press Y else N : ");
                    var val = Console.ReadLine();
                    if (val.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                    {
                        isContinue = false;
                    }
                    else if (val.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("Welcome back!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid choice");
                        goto invalidExceptionChoice;

                    }

                }


                }
            
            
        }

        private static void CheckEvenlyDivisible(Input obj)
        {
            for (int i = obj.Start; i <= obj.End; i++)
            {

                if (i % obj.FirstDivisible == 0 && i % obj.SecondDivisible == 0)
                {
                    Console.WriteLine("FancyPants");
                }
                else if (i % obj.FirstDivisible == 0)
                {
                    Console.WriteLine("Fancy");
                }
                else if (i % obj.SecondDivisible == 0)
                {
                    Console.WriteLine("Pants");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
