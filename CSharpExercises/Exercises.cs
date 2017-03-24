using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")+
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            return age >= 18;
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string name)
        {
            return name.Substring(0, name.IndexOf(" "));
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string quote)
        {
            char[] chars = quote.ToCharArray();
            string result = "";
            for(int i=0; i<chars.Length; i++)
            {
                result += chars[chars.Length-1-i].ToString();
            }
            return result;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string quote)
        {
            char[] c = quote.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
         public static string PrintTimesTable(int mult)
        {
            string table = "";
            for(int i=1; i<11; i++)
            {
                table += mult.ToString() + " * " + i.ToString() + " = " + (i * mult).ToString();
                if (i != 10) table +=Environment.NewLine;


            }
            return table;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            return Math.Round(1.8*(kelvin - 273.15) + 32.0, 2);
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] ints)
        {
            double Sum = 0;
            foreach(int i in ints)
            {
                Sum += (double)i;
            }
            return Sum / ints.Length;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] i)
        {
            return i.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        public static string DrawTriangle(int num, int width)
        {
            string res = "";
            while(width>0)
            {
                res+= String.Concat(Enumerable.Repeat(num.ToString(), width));
                if(width!=1)res+= Environment.NewLine;
                width--;
            }
            return res;
        }
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double dist, int h, int m, int s)
        {
            return (Math.Round(dist / ((double)h + (double)m / 60 + (double)s / 3600))).ToString() + "MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letter)
        {
            return (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' );
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char letter)
        {
            return !Exercises.IsVowel(letter);
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int n)
        {
            
            return  (n==1? 0 :(n % 2 == 0 ? 1+Exercises.CollatzConjecture(n / 2) : 1+Exercises.CollatzConjecture(3*n+1)));
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime date)
        {
            DateTime[] dates = new DateTime[7];
            for(int i =0; i<dates.Length; i++)
            {
                dates[i] = date.AddDays((double)i);
            }
            return dates;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(DateTime date)
        {
            return date.Year % 4 == 0;
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double balance, double rate, int term, int paymentPeriod)
        {
            rate = rate / 100;
            double monthlyInterest = rate / (paymentPeriod);
            double payments = term * (paymentPeriod);
            double top = monthlyInterest * Math.Pow((1 + monthlyInterest), payments);
            double bot = Math.Pow((1 + monthlyInterest), payments) - 1;
            return Math.Round(balance * (top/bot),2); 

        }
        
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        public static string DuckGoose( int rounds)
        {
            string str = "";
            for(int i=1; i<=rounds;i++)
            {
                if (i % 3 == 0) str += "Duck";
                if (i % 5 == 0) str += "Goose";
                if (!(i % 3 == 0) && !(i % 5 == 0)) str += i.ToString();

                if (i != rounds)
                {
                    str += Environment.NewLine;
                }
            }
            return str;
        }
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}