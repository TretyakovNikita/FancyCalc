using System;


namespace FancyCalc
{
    public class FancyCalcEnguine
    {
        private const char plus = '+';
        private const char minus = '-';
        private const char mult = '*';

        public double Add(int a, int b)
        {
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            if (expression is null)
            {
                throw new ArgumentNullException();
            }

            expression = expression.Replace(" ", string.Empty);
            var parameters = expression.Split(plus, minus, mult);
            char sign = expression[parameters[0].Length];

            int firstNumber = int.Parse(parameters[0]);
            int secondNumber = int.Parse(parameters[1]);
            switch (sign)
            {
                case plus:
                    return Add(firstNumber, secondNumber);
                case minus:
                    return Subtract(firstNumber, secondNumber);
                case mult:
                    return Multiply(firstNumber, secondNumber);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

        

