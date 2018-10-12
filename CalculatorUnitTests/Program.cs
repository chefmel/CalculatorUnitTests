using System;

namespace Calculator_CG_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {



                //Create a basic calculator app that lets the user enter a basic formula 
                //like 10 + 4. If the user enters in any invalid data, catch the error and 
                //let the user know their input was bad.This application should be able to 
                //do addition, subtraction, division and multiplication.You should also be 
                //using a calculator class instead of putting everything in the Program class. 
                //Upload your program to a new repository called CG 11-1


                int firstnumber = 0;
                int secondnumber = 0;
                int answer = 0;
                string operation = " ";

                Console.WriteLine("Welcome to a simple calculator. Please enter your equation in the following format: number, space, operator, space, number, IE 2 + 2");


                string equation = Console.ReadLine();

                var parts = equation.Split(" ");

                if (parts != null)
                {
                    firstnumber = Convert.ToInt32(parts[0]);
                    operation = parts[1];
                    secondnumber = Convert.ToInt32(parts[2]);

                }

                switch (operation)
                {
                    case "+":
                        answer = Operators.Addition(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + "+" + secondnumber + "=" + answer); break;

                    case "-":
                        answer = Operators.Subtraction(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + "-" + secondnumber + "=" + answer); break;

                    case "*":
                        answer = Operators.Multiply(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + "*" + secondnumber + "=" + answer); break;

                    case "/":
                        answer = Operators.Division(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + "/" + secondnumber + "=" + answer); break;

                    default:

                        Console.WriteLine("Invalid operator"); break;



                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect format, try again and pay attention!");
            }

            Console.ReadLine();

        }

    }
}

