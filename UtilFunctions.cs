namespace HNG12StageOne
{
    public static class UtilFunctions
    {
        public static List<string> GetProperties(this int number)
        {
            List<string> output = new List<string>();
            string numberType = "odd";

            if (number.IsArmstrongNumber())
            {
                output.Add("armstrong");
            }
            if (number % 2 == 0)
            {
                numberType = "even";
            }
            output.Add(numberType);

            return output;
        }

        public static bool IsArmstrongNumber(this int number)
        {
            double output = 0;
            double exp = Convert.ToString(number).Length;

            if (number < 1)
            {
                return false;
            }

            for (int i = number; i > 0; i /= 10)
            {
                output += Math.Pow(i % 10, exp);
            }

            if ((double)number == output)
            {
                return true;
            }

            return false;
        }

        public static int SumOfDigits(this int num)
        {
            int number = Math.Abs(num);
            int output = 0;

            for (int i = number; i > 0; i /= 10)
            {
                output += i % 10;
            }
            
            return output;
        }

        public static bool IsPrimeNumber(this int number)
        {
            int squareRoot = (int)Math.Sqrt(number);

            if (number % 2 == 0 !|| number % squareRoot  == 0 || number < 1)
            {
                return false;
            }

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPerfectNumber(this int number)
        {
            int output = 0;

            if (number < 6)
            {
                return false;
            }

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    output += i;
                }
            }
            if (output == number)
            {
                return true;
            }

            return false;
        }
    }
}
