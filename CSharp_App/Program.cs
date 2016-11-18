using System; // For console, string classes
using System.Collections.Generic; // For List class
using System.Linq; // For Distinct method 
using System.Text;
using System.Threading.Tasks;

namespace CSharp_App
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public string AgeOfMajority(int age)
        {
            if (age >= 18)
                return "You are of legal age!";
            else
                return "You are not of legal age!";
        }
    }

    class Program
    {
        //method is static because I am calling it from the static method Main
        public static void SumTwoNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstName = "Alex";
            p.lastName = "Wilson";
            Console.Write("How old are you? ");
            p.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.AgeOfMajority(p.age));
            Console.WriteLine($"Hi, my name is {p.firstName} {p.lastName} {p.age}");
            Console.WriteLine("Hi, my name is {0} {1} {2} years old.", p.firstName, p.lastName, p.age);
            Console.WriteLine("Hi, my name is " + p.firstName + " " + p.lastName + ". I am " + p.age + "years old");

            
                        Console.WriteLine("Hello World");
            int a = 10, b = 5;
            SumTwoNumbers(a, b);
           // Console.WriteLine("sum is:" + (a + b));
            Console.WriteLine("Concatenated:" + a + b);
            Console.WriteLine("Increment a:" + ++a);
            string str1 = "    Learning C# with Ferrari.!";
            string str2 = "& me";
            Console.WriteLine(string.Concat(str1,str2));
            Console.WriteLine(str1.Replace("Learning", "Learn"));
            Console.WriteLine(str1.Contains("Learn")); // Case sensitive
            Console.WriteLine("The length of str1 is:" + str1.Length);
            Console.WriteLine(str1.Trim());// Removes leading and trailing whitespaces
            Console.WriteLine();


            if (string.Compare(str1, str2) == 0) // 0 means true
            {
                Console.WriteLine("The two strings are equal!");
            }
            else
            {
                Console.WriteLine("The two strings are different");
            }

            int n1 = 5, n2 = 1;
            string result = n1 > n2 ? "N1 is greater" : "N2 is greater";

            if (!str1.Contains("bought"))
            {
                Console.WriteLine("The str1 does not contain the word bought.");
            }
            else if (str1.Contains("Ferrari.")) //if the condition is TRUE
            {
                Console.WriteLine("What word do you want instead of Ferrari? ");
                string str3 = Console.ReadLine(); //gets the string from the user
                string str4 = str1.Replace("Ferrari", str3); //declaring str3 to receive the str1 content replaced
                Console.WriteLine(str4); //showing the new sentence.
            }

            Console.WriteLine("Type a number 1 - 7 to see the day of the week corresponding to this number:"); //Converting string to Int32.
            try // Exception handling
            {
                int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
                switch (numberDayOfWeek) //Checking the number the user typed.
                {
                    case 1:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Sunday!");
                        break;
                    case 2:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Monday!");
                        break;
                    case 3:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Tuesday!");
                        break;
                    case 4:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Wednesday!");
                        break;
                    case 5:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Thursday!");
                        break;
                    case 6:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Friday!");
                        break;
                    case 7:
                        Console.WriteLine("The day number " + numberDayOfWeek + " is Saturday!");
                        break;
                    default:
                        Console.WriteLine("This number is invalid.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a number!");
            }
            string[] names = new string[3];// t[] numbers = new int[5] {10, 20, 30, 40, 50} for array initialization
            names[0] = "Davis";
            names[1] = "Matt";
            names[2] = "Bob";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Position number " + i + ": " + names[i]);
            }

            //Declaring a list "int".
            List<int> list = new List<int>();
            //Populating the list with 10 elements
            for (int i = 0; i <= 10; i++)
            {
                list.Add(i * 9);
            }
            int x = 0;
            //foreach element in the list do:
            foreach (int element in list)
            {
                Console.WriteLine("9 * " + x + " = " + element);
                x++;
            }

            List<double> orders = new List<double>(new double[] { 19.99, 6.48, 25.0, 25.0 });
            //orders.Clear(); // clears the list
            orders.Reverse(); // reverses the list
            List<double> newList = orders.Distinct().ToList();
            for (int i = 0; i < newList.Count; i++) // Count is used to count number of list elements
            {
                Console.WriteLine("Order number " + i + " : $ " + newList[i]);
            }

            Console.Read();
            /*Int16 — (-32,768 to +32,767)
            Int32 — (-2,147,483,648 to +2,147,483,647)
            Int64 — (-9,223,372,036,854,775,808 to +9,223,372,036,854,775,807 */

        }
    }
}
