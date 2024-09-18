using static System.Runtime.InteropServices.JavaScript.JSType;

namespace introduction
{

    /*
    8.	Accept a number n and prints the sum of the numbers 1 to n
    9.	Check Even or Odd: Determine if a number is even or odd
    10.	Accept an integer as input and calculate the factorial of that number. If the number is 4, then the output should be 24 (i.e. 4x3x2x1).
    11.	Write a program that displays the sum of the even numbers and the product of the odd numbers between 1 and 10.  Use two loops. Can you solve the problem with one loop?
    12.	Write a program that displays the average of the integers between 5 and 17. Edit your program so that the user can enter the start and end numbers.
    13.	€1000 is deposited in a savings account and €1000 is deposited at the end of each year. If the interest rate is 5% calculate and display the amount in the account after 6 years.
    14.	The population of Ireland is 4.8 million and growing at a rate of 20% per year. Write a program to determine and display the population in 10 years time. Your program should also display the number of years that the population exceeds 5 million.
    15.	A number can also be a palindrome. For example, each of the following five-digit integers is a palindrome: 12321, 55555, 45554 and 11611. Write a program that reads in a five-digit integer and determines whether it is a palindrome. (Hint: Use the division and modulus operators to separate the number into its individual numbers).
    16.	Write a program that reads 5 sets of three nonzero integers and determines and prints if they could be the sides of a right triangle.
    17.	Write a program that calculates and prints the average of several integers. Assume the last value read is the sentinel 9999. A typical input sequence might be 10 8 11 7 9 9999 indicating that the average of all the values preceding 9999 is to be calculated.
    18.	One interesting application of computers is drawing graphs and bar charts (sometimes called “histograms”). Write a program that reads five numbers (each between 1 and 30). For each number read, your program should print a line containing that number of adjacent asterisks. For example, if your program reads the number seven, it should print *******.
    19.	Write a program that allows a user to enter 10 numbers between 1 and 100 and displays, the total of the numbers, the smallest and largest numbers entered and the average of the numbers entered.
    20.	Write a C# program that utilizes looping and the tab escape sequence \t to print the following table of values:

    N 	10*N 	100*N 	1000*N
    1 	10 	100	 1000
    2	 20 	200 	2000
    3	30	300 	3000
    4 	40 	400 	4000
    5 	50 	500 	5000

    21.	Develop a C# program that will determine the gross pay for each of several employees. The company pays “straight-time” for the first 40 hours worked by each employee and pays “time-and-a-half” for all hours worked in excess of 40 hours. You are given a list of the employees of the company, the number of hours each employee worked last week and the hourly rate of each employee. Your program should input this information for each employee and should determine and display the employee's gross pay.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
            /*
            Console.WriteLine("Please enter a number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < usersNumber + 1; i++)
            {
                Console.WriteLine(i);
            }

            //2.	Check Even or Odd: Determine if a number is even or odd. 
            if (usersNumber % 2 == 0)
            {
                Console.WriteLine(usersNumber + " is even");
            }
            else
            {
                Console.WriteLine(usersNumber + " is odd");
            }
            //3.	Write a guessing game where the user must guess a secret number. After every guess the program tells the user whether their number was too large or too small.
            //      At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.
            Console.WriteLine("Now we will play a guess a number game.");
            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            int before = -1;
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Guess the number from 1-10:");
                int guess = Convert.ToInt32(Console.ReadLine());
                
                if (guess != before)
                {
                    counter++;
                }
                before = guess;
                if (guess == number)
                {
                    Console.WriteLine($"Yo you guess it well done, it just took you {counter}");
                    break;
                }
                else
                {
                    if (guess > number)
                    {
                        Console.WriteLine("It's too big");
                    }
                    else
                    {
                        Console.WriteLine("It's too small");
                    }
                }
            }
            
            //4.	Check if a number is prime.
            if (IsPrime(usersNumber))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }

            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                        return false;

                return true;
            }
            

            //5.	Check if a word is plural. 
            Console.WriteLine("Write a word please: ");
            string word = Console.ReadLine();

            if (word.EndsWith("s") || word.EndsWith("men") || word.EndsWith("ves") || word.EndsWith("ses") || word.EndsWith("ies") || word.EndsWith("es"))
            {
                Console.WriteLine($"This word {word} is plural.");
            }
            else
            {
                Console.WriteLine($"This word {word} is singular.");
            }
            

            //6.	Reverse a String: Reverse the characters in a given string. Check if the string is a palindrome. (same backwards as forwards)
            Console.WriteLine("Write a word please: ");
            string word = Console.ReadLine().Trim();

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            if (word.Equals(reversed))
            {
                Console.WriteLine($"Word {word} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Word {word} is not a palindrome.");
            }
            */

            //7.	Check if a work is an isogram (contains no duplicated letters)
            Console.WriteLine("Write a word please: ");
            string word = Console.ReadLine().Trim();

            HashSet<char> words = new HashSet<char>();

            foreach (char c in word)
            {
                if (!words.Add(c))
                {
                    Console.WriteLine($"Word {word} is a isogram.");
                    break;
                }
            }
        }
    }
}