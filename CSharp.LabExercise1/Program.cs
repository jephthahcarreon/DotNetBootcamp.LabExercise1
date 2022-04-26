// Submitted by: Jephthah Carreon

using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {

        //Area and Perimeter Calculator
        static void ActivityNumber1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator \n");

            while (true)
            {
                float lengthInput;
                float widthInput;

                //gets input from user
                while (true)
                {
                    Console.Write("Enter length: ");
                    string lengthInputString = Console.ReadLine();
                    
                    try
                    {
                        lengthInput = Convert.ToSingle(lengthInputString);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Invalid input: {e.Message}");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Enter width: ");
                    string widthInputString = Console.ReadLine();

                    try
                    {
                        widthInput = Convert.ToSingle(widthInputString);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Invalid input: {e.Message}");
                        continue;
                    }
                }

                //calculates area and perimeter
                float area = (float) Math.Round(widthInput * lengthInput, 2);
                Console.WriteLine("Area: {0}", area);

                float perimeter = (float) Math.Round((2 * widthInput) + (2 * lengthInput), 2);
                Console.WriteLine("Perimeter: {0} \n", perimeter);

                //prompts user to exit or continue
                while (true)
                {
                    Console.Write("Continue? (y/n): ");
                    string userChoiceInput = Console.ReadLine();
                    Console.WriteLine("");

                    //catch errors from invalid input
                    try
                    {
                        char userChoiceInputChar = char.ToLower(Convert.ToChar(userChoiceInput));

                        switch (userChoiceInputChar)
                        {
                            case 'y':
                                break;
                            case 'n':
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("Invalid input.");
                                continue;
                        }
                        break;
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine($"Invalid input: {e.Message}");
                        continue;
                    }
                }
            }
        }


        //Letter Grade Calculator
        static void ActivityNumber2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator \n");

            while (true)
            {
                //gets input from user
                Console.Write("Enter numerical grade: ");
                string numberGradeString = Console.ReadLine();

                //catch errors from invalid input
                try
                {
                    int numberGrade = Convert.ToInt32(numberGradeString);
                    if (numberGrade <= 100 && numberGrade >= 1)
                    {
                        switch (numberGrade)
                        {
                            case int number when number <= 100 && number >= 88:
                                Console.WriteLine("Letter grade: A");
                                break;
                            case int number when number <= 87 && number >= 80:
                                Console.WriteLine("Letter grade: B");
                                break;
                            case int number when number <= 79 && number >= 67:
                                Console.WriteLine("Letter grade: C");
                                break;
                            case int number when number <= 66 && number >= 60:
                                Console.WriteLine("Letter grade: D");
                                break;
                            case int number when number < 60:
                                Console.WriteLine("Letter grade: F");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid input: {e.Message}");
                    continue;
                }

                //prompts user to exit or continue
                while (true)
                {
                    Console.Write("Continue? (y/n): ");
                    string userChoiceInput = Console.ReadLine();
                    Console.WriteLine("");

                    //catch errors from invalid input
                    try
                    {
                        char userChoiceInputChar = char.ToLower(Convert.ToChar(userChoiceInput));

                        switch (userChoiceInputChar)
                        {
                            case 'y':
                                break;
                            case 'n':
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("Invalid input.");
                                continue;
                        }
                        break;
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine($"Invalid input: {e.Message}");
                        continue;
                    }
                }
            }
        }


        //Download Time Estimator
        static void ActivityNumber3()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator \n");
            Console.WriteLine("This program calculates how long it will take to download a file with a 56k analog modem \n");

            //gets input from user
            while (true)
            {
                Console.Write("Enter a file size (MB): ");
                string fileSizeInputString = Console.ReadLine();

                try
                {
                    uint fileSizeInput = (uint) Math.Truncate((Convert.ToDecimal(fileSizeInputString)));
                    //converts file size from MB to KB (binary)
                    uint fileSizeKB = fileSizeInput * 1024;
                    float downloadRate = 5.2f; // 5.2 KB/s

                    //calculates download time
                    uint totalTimeInSeconds = (uint) Math.Truncate(fileSizeKB / downloadRate);
                    uint hours = totalTimeInSeconds / (60 * 60);
                    uint minutes = totalTimeInSeconds % (60 * 60) / 60;
                    uint seconds = totalTimeInSeconds % 60;

                    Console.WriteLine("A '56k' modem will take {0} hours {1} minutes {2} seconds \n", hours, minutes, seconds);

                    //prompts user to exit or continue
                    while (true)
                    {
                        Console.Write("Continue? (y/n): ");
                        string userChoiceInput = Console.ReadLine();
                        Console.WriteLine("");

                        //catch errors from invalid input
                        try
                        {
                            char userChoiceInputChar = char.ToLower(Convert.ToChar(userChoiceInput));

                            switch (userChoiceInputChar)
                            {
                                case 'y':
                                    break;
                                case 'n':
                                    Environment.Exit(-1);
                                    break;
                                default:
                                    Console.WriteLine("Invalid input.");
                                    continue;
                            }
                            break;
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine($"Invalid input: {e.Message}");
                            continue;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid input: {e.Message}");
                    continue;
                }

            }
        }


        //Square Display Application
        static void ActivityNumber4()
        {
            Console.Write("Enter square size: ");
            try
            {
                int squareSizeInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < squareSizeInput; i++)
                {

                    for (int n = 0; n < squareSizeInput; n++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input: {e.Message}");
            }
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            ActivityNumber1(); //Area and Perimeter Calculator
            ActivityNumber2(); //Letter Grade Calculator
            ActivityNumber3(); //Download Time Estimator
            ActivityNumber4(); //Square Display Application
        }
    }
}
