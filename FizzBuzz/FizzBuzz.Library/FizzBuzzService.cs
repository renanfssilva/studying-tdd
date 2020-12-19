namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int n)
        {
            if (IsDivisibleByThree(n) && IsDivisibleByFive(n))
            {
                return "FizzBuzz";
            }
            
            if (IsDivisibleByFive(n))
            {
                return "Buzz";
            }

            if (IsDivisibleByThree(n))
            {
                return "Fizz";
            }

            return n.ToString();
        }

        public bool IsDivisibleByThree(int n)
        {
            return n % 3 == 0;
        }
        
        public bool IsDivisibleByFive(int n)
        {
            return n % 5 == 0;
        }
    }
}
