using System;

namespace MyAwesomeCalculator
{
    class Calculator
    {

        float value;

    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Enter a number to begin");
        calc.beginCalculations();
        Console.WriteLine("Exiting Calculator...");
    }

    Calculator()
    {
        this.value = 0;
    }

    void beginCalculations()
    {
     
        bool iSaySo = true;
        String firstExpression = Console.ReadLine();
        try
        {
            float init = float.Parse(firstExpression);
            value = init; 
        }
        catch(Exception ex){
            Console.WriteLine("@Hey quit screwing around!!! \nJust because of "
             + "that your beginning value is 0!!!\n\n");
        }
        
        while(iSaySo)
        {
            Console.WriteLine("enter following expressions to continue.\nEnter q to quit");
            String expression = Console.ReadLine();

            try
            {

            
            if (firstExpression == "quit" || firstExpression == "q")
                return;
            else
            {
                if (expression.Contains("+"))
                {
                    expression = expression.Replace("+","");
                    float secondValue = float.Parse(expression);
                    value += secondValue;
                }
                else if (expression.Contains("-"))
                {
                    expression = expression.Replace("-","");
                    float secondValue = float.Parse(expression);
                    value -= secondValue;
                }
                else if (expression.Contains("/"))
                {
                    expression = expression.Replace("/","");
                    float secondValue = float.Parse(expression);
                    value = value/secondValue;
                }
                else if (expression.Contains("**"))
                {
                    expression = expression.Replace("**","");
                    float secondValue = float.Parse(expression);
                    value = (float)Math.Pow(value,secondValue);
                }
                else if (expression.Contains("*"))
                {
                    expression = expression.Replace("*","");
                    float secondValue = float.Parse(expression);
                    value *= secondValue;
                }
                else if (expression == "q" || expression == "quit")
                {
                    return;
                }
                else{
                    Console.WriteLine("Invalid expression");
                }

                Console.WriteLine("Result = " + this.value + "\n");
            }
            }
            catch(Exception ex){
                Console.WriteLine("What the heck are you trying to do!!! This is a Calulator!!!\n\n"
                + ex.ToString());
            }
        }
    }

    }
}
