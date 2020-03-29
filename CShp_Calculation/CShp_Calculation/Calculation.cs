namespace CShp_Calculation
{
    public static class Calculation
    {
        public static double Sum(double number1, double number2)
        {
            return (number1 + number2);
        }

        public static double Subtract(double number1, double number2)
        {
            return (number1 - number2);
        }

        public static double Multiply(double number1, double number2)
        {
            return (number1 * number2);
        }

        public static double Divide(double number1, double number2)
        {
            return (number1 / number2);
        }

        public static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
    }
}
