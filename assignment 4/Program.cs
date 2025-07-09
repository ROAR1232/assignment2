using System;
class Assignment
{
    static void Main()
    {

        #region Q1 
        Console.Write("enter a num:");
        bool isParsed = int.TryParse(Console.ReadLine(), out int num);
        if (isParsed && num >= 1)
        {
            for (int i = 1; i < num; i++)
            {
                Console.Write(i);
                Console.Write(' ');
            }
        }
        else if (isParsed && num <= 1)
        {
            Console.WriteLine("you can only insert numbers more that 1");
        }
        else
        {
            Console.WriteLine("please enter a valid number");
        }
        Console.WriteLine();



        #endregion
        #region Q2
        Console.Write("enter a num:");
        bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);
        if (isParsed1)
        {
            for (int i = 1; i < 13; i++)
            {
                Console.Write(i * num1);
                Console.Write(' ');
            }
        }
        else
        {
            Console.WriteLine("please enter a valid number");
        }
        Console.WriteLine();

        #endregion
        #region Q3

        Console.Write("enter a num:");
        bool isParsed2 = int.TryParse(Console.ReadLine(), out int num2);
        if (isParsed2 && num2 >= 1)
        {
            for (int i = 1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    Console.Write(' ');
                }

            }
        }
        else if (isParsed2 && num2 <= 1)
        {
            Console.WriteLine("you can only insert numbers more that 1");
        }
        else
        {
            Console.WriteLine("please enter a valid number");
        }
        Console.WriteLine();





        #endregion
        #region Q4

        Console.Write("enter first num:");
        bool isParsed3 = int.TryParse(Console.ReadLine(), out int num3);
        Console.Write("enter second num:");
        bool isParsed4 = int.TryParse(Console.ReadLine(), out int num4);
        if (isParsed3 && isParsed4)
        {
            double resault = Math.Pow(num3, num4);
            Console.Write("resault = ");
            Console.Write(resault);
        }
        else
        {
            Console.WriteLine("please enter a valid numbers");
        }
        Console.WriteLine();


        #endregion
        #region Q5

        Console.Write("enter a num:");
        bool isParsed5 = int.TryParse(Console.ReadLine(), out int num5);
        Console.Write("enter a num:");
        bool isParsed6 = int.TryParse(Console.ReadLine(), out int num6);
        Console.Write("enter a num:");
        bool isParsed7 = int.TryParse(Console.ReadLine(), out int num7);
        Console.Write("enter a num:");
        bool isParsed8 = int.TryParse(Console.ReadLine(), out int num8);
        Console.Write("enter a num:");
        bool isParsed9 = int.TryParse(Console.ReadLine(), out int num9);


        bool allParsd = isParsed5 && isParsed6 && isParsed7 && isParsed8 && isParsed9;
        bool anyOver100 = num5 > 100 || num6 > 100 || num7 > 100 || num8 > 100 || num9 > 100;

        switch ((allParsd, anyOver100))
        {
            case (true, false):
                float result = (num5 + num6 + num7 + num8 + num9) / 5f;
                Console.Write("result = ");
                Console.Write(result);
                break;

            case (_, true):
                Console.WriteLine("you can only insert grades less than 100");
                break;

            default:
                Console.WriteLine("please enter valid numbers");
                break;
        }

        Console.WriteLine();

        #endregion
        #region Q6

        Console.Write("eneter a string: ");
        string input3 = Console.ReadLine();
        string reversed = default;

        for (int i = input3.Length - 1; i >= 0; i--)
        {
            reversed += input3[i];
        }
        Console.WriteLine("reversed string: " + reversed);


        #endregion
        #region Q7


        int num11, reverse = 0;
        Console.WriteLine("Enter a Number : ");
        bool isParsed11 = int.TryParse(Console.ReadLine(), out num11);
        if (isParsed11)
        {
            while (num11 != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num11 % 10;
                num11 = num11 / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
        }
        else
        {
            Console.WriteLine("please enter a valid number");
        }


        #endregion
        #region Q8

        int start, end;

        Console.Write("Input starting number of range: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input ending number of range: ");
        end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThe prime numbers between {0} and {1} are:", start, end);

        for (int num12 = start; num12 <= end; num12++)
        {
            bool isPrime = true;

            if (num12 <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= num12 / 2; i++)
                {
                    if (num12 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.Write(num12 + " ");
            }
        }

        Console.WriteLine();

        #endregion
        #region Q9

        int number;
        Console.Write("Enter a number to convert: ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out number);

        if (isValid && number >= 0)
        {
            int n1 = number;
            string binary = "";

            if (n1 == 0)
            {
                binary = "0";
            }
            else
            {
                while (n1 > 0)
                {
                    int remainder = n1 % 2;
                    binary = remainder + binary;
                    n1 = n1 / 2;
                }
            }

            Console.WriteLine("The Binary of {0} is {1}.", number, binary);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }


        #endregion
        #region Q10

        double x1, y1, x2, y2, x3, y3;

        Console.Write("Enter x1: ");
        bool isX1 = double.TryParse(Console.ReadLine(), out x1);
        Console.Write("Enter y1: ");
        bool isY1 = double.TryParse(Console.ReadLine(), out y1);

        Console.Write("Enter x2: ");
        bool isX2 = double.TryParse(Console.ReadLine(), out x2);
        Console.Write("Enter y2: ");
        bool isY2 = double.TryParse(Console.ReadLine(), out y2);

        Console.Write("Enter x3: ");
        bool isX3 = double.TryParse(Console.ReadLine(), out x3);
        Console.Write("Enter y3: ");
        bool isY3 = double.TryParse(Console.ReadLine(), out y3);

        if (isX1 && isY1 && isX2 && isY2 && isX3 && isY3)
        {
            double lhs = (y2 - y1) * (x3 - x2);
            double rhs = (y3 - y2) * (x2 - x1);

            if (lhs == rhs)
            {
                Console.WriteLine("The points lie on the same straight line");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on the same straight line");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values only");
        }

        #endregion
        #region Q11
        // I'm not sure about this one but it was what i'm able to find about idenity matrix
        Console.Write("Enter the size of the identity matrix: ");
        string input1 = Console.ReadLine();
        int n;

        bool isValid1 = int.TryParse(input1, out n);

        if (isValid1 && n > 0)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");

        }
        #endregion
    }
}



