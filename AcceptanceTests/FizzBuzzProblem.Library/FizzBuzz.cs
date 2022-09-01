using System.Diagnostics;

namespace FizzBuzzProblem.Library
{


    public class FizzBuzz
    {
        public  List<string> GetValue(int value)
        {
            List<string>strings=new List<string>();
            string output = string.Empty;
            for (int i = 1; i <= value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    output = "FizzBuzz";
                else if (i % 3 == 0)
                    output = "Fizz";
                else if (i % 5 == 0)
                    output = "Buzz";
                else
                    output = i.ToString();
                strings.Add(output);
            }
                return strings;
        }
    }
}
