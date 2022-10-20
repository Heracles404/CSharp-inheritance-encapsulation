using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment{

    // use encapsulation to get sum and product
    class Calculate
    {
        public double n1, n2, n3, n4, n5;

        // return sum
        public double getSum()
        {
            double sum = n1 + n2 + n3 + n4 + n5;
            return sum;
        }

        public double getProd()
        {
            double prod = n1 * n2 * n3 * n4 * n5;
            return prod;
        }

        public void showResult()
        {
            Console.WriteLine("Product: {0}", getProd());
            Console.WriteLine("Sum: {0} \n", getSum());
        }
    }

    // use inheritance to check if numbers are positive or negative
    class Numbers
    {

        // return sum
        public void num1(double x)
        {
            n1 = x;
        }
        public void num2(double x)
        {
            n2 = x;
        }
        public void num3(double x)
        {
            n3 = x;
        }
        public void num4(double x)
        {
            n4 = x;
        }
        public void num5(double x)
        {
            n5 = x;
        }

        protected double n1, n2, n3, n4, n5;
    }

    class Check : Numbers
    {
        public string checkNum()
        {
            int pos = 0;
            int neg = 0;

            if(n1 > 0)
            {
                pos++;
            }else
            {
                neg++;
            }

            if (n2 > 0)
            {
                pos++;
            }
            else
            {
                neg++;
            }

            if (n3 > 0)
            {
                pos++;
            }
            else
            {
                neg++;
            }

            if (n4 > 0)
            {
                pos++;
            }
            else
            {
                neg++;
            }

            if (n5 > 0)
            {
                pos++;
            }
            else
            {
                neg++;
            }

            string positive = Convert.ToString(pos);
            string negative = Convert.ToString(neg);

            string output = "\nNumber of Positive Input: " + positive +
                            "\nNumber of Negative Input: " + negative;
            return output;
        }
    }

    // Validate input(s)
    class Val
    {
        public static double validation(string num1, string num2, string num3, string num4, string num5)
        {
            double n1, n2, n3, n4, n5;

            try
            {
                n1 = Double.Parse(num1);
                n2 = Double.Parse(num2);
                n3 = Double.Parse(num3);
                n4 = Double.Parse(num4);
                n5 = Double.Parse(num5);

                Check x = new Check();
                x.num1(n1);
                x.num2(n2);
                x.num3(n3);
                x.num4(n4);
                x.num5(n5);
                Console.WriteLine(x.checkNum());


                Calculate n = new Calculate();
                n.n1 = n1;
                n.n2 = n2;
                n.n3 = n3;
                n.n4 = n4;
                n.n5 = n5;
                n.showResult();
            }
            catch
            {
                Console.WriteLine("One or more inputs are invalid");
            }

            return 0;
        }
    }

    // Main Class
    class Input
    {
        static void Main(string[] args)
        {
            String choice;

            do
            {
                Console.WriteLine("A) Calculate");
                Console.WriteLine("E) EXIT");
                choice = Console.ReadLine();
                if (choice.ToUpper() == "A")
                {
                    string num1, num2, num3, num4, num5;

                    Console.WriteLine("Enter a Number: ");
                    num1 = Console.ReadLine();

                    Console.WriteLine("Enter Another Number: ");
                    num2 = Console.ReadLine();

                    Console.WriteLine("Enter Another Number: ");
                    num3 = Console.ReadLine();

                    Console.WriteLine("Enter Another Number: ");
                    num4 = Console.ReadLine();

                    Console.WriteLine("Enter Another Number: ");
                    num5 = Console.ReadLine();



                    Val.validation(num1, num2, num3, num4, num5);
                }
                else if (choice.ToUpper() == "E")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (choice != "E");

        }
    }
}