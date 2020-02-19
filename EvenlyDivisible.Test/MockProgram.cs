using System;
using System.Collections.Generic;
using System.Text;

namespace EvenlyDivisible.Test
{
    public class MockProgram
    {
        public void Main(string low, string high, string firstDivisible, string secondDivisible, MockInput obj)
        {
            bool isContinue = true;
            //Using While for check application while is working or not when break it            
            while (isContinue)
            { 
                int minNumber;                
                if (!int.TryParse(low, out minNumber))
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid Min value";
                    break;
                }
                obj.Start = Convert.ToInt32(low);
                if (obj.Start <= 0)
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid Min value";
                    break;
                }
            
                if (!int.TryParse(high, out minNumber))
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid Max value";
                    break;
                }
                obj.End = Convert.ToInt32(high);
                if (obj.End <= 0)
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid Max value";
                    break;
                }
                if (obj.Start > obj.End)
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid Min and Max value";
                    break;
                }
         
                
                if (!int.TryParse(firstDivisible, out minNumber))
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid first Divisible value";
                    break;
                }
                obj.FirstDivisible = Convert.ToInt32(firstDivisible);
                if (obj.FirstDivisible <= 0)
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid first Divisible value";
                    break;
                }         
              
                if (!int.TryParse(secondDivisible, out minNumber))
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid second Divisible value";
                    break;
                }
                obj.SecondDivisible = Convert.ToInt32(secondDivisible);
                if (obj.SecondDivisible <= 0)
                {
                    obj.IsValid = false;
                    obj.ErrorMessage = "Not a valid second Divisible value";
                    break;
                }
               
                CheckEvenlyDivisible(obj);
                obj.IsValid = true;
                isContinue = false;
            }


        }

        private static void CheckEvenlyDivisible(MockInput obj)
        {
            for (int i = obj.Start; i <= obj.End; i++)
            {

                if (i % obj.FirstDivisible == 0 && i % obj.SecondDivisible == 0)
                {
                    obj.FancyPantsCount = obj.FancyPantsCount + 1;
                }
                else if (i % obj.FirstDivisible == 0)
                {
                    obj.FancyCount = obj.FancyCount + 1;
                }
                else if (i % obj.SecondDivisible == 0)
                {
                    obj.PantsCount = obj.PantsCount + 1;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
