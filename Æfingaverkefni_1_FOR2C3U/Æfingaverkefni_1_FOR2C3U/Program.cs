using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Anton Freyr Magnússon, FOR2C3U

namespace Æfingaverkefni_1_FOR2C3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Soccer Teams");
                Console.WriteLine("2. Addition and Subtraction");
                Console.WriteLine("3. Line of numbers");
                Console.WriteLine("4. String play");
                Console.WriteLine("5. BMI");
                Console.WriteLine("6. Array play");
                Console.WriteLine("7. Craps");
                Console.WriteLine("8. Exit");
                Console.Write("Which function do you want? ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                        //Case 1, for soccer teams, use of modulus
                    case 1:
                        int participants = 0;
                        int teams = 0;
                        int outcome1 = 0;
                        int outcome2 = 0;

                        Console.Write("How many participants are there? ");
                        participants = Convert.ToInt32(Console.ReadLine());
                        Console.Write("How many members on a team? ");
                        teams = Convert.ToInt32(Console.ReadLine());
                        if (teams > participants)
                        {
                            MessageBox.Show("There cannot be more members on a team then there are participants.");
                        }
                        else
                        {
                            outcome1 = participants / teams;
                            outcome2 = participants % teams;
                            Console.Write("Results:");
                            Console.Write("\nNumber of teams = " + outcome1);
                            Console.Write("\nExtras = " + outcome2);
                            Console.ReadLine();
                        }
                        break;

                        //Case 2, Addition and Subrtaction, do while and for loop
                    case 2:

                        int addition = 0;
                        
                        
                        do
                        {
                            int result = 0;
                            Console.Write("What number do you want to check up on? ");
                            addition = Convert.ToInt32(Console.ReadLine());

                            if (addition > 0)
                            {
                                for (int i = 1; i <= addition; i++)
                                {
                                    result = result + i;
                                    if (i != addition)
                                    {
                                        Console.Write(i + " + ");
                                    }
                                    
                                    else
                                    {
                                        Console.Write(addition + " = " + result);
                                    }
                                }
                                
                                
                                
                                Console.ReadLine();
                            }
                            else if (addition < 0)
                            {
                                for (int i = -1; i >= addition; i--)
                                {
                                    result = result + i;

                                    if (i != addition)
                                    {
                                        Console.Write("(" + i + ")" + " + ");
                                    }

                                    else
                                    {
                                        Console.Write("(" + addition + ")" + " = " + result);
                                    }
                                }

                                
                                Console.ReadLine();
                            }
                            
                        } while (addition != 0);
                        MessageBox.Show("Thank you for using my program.");
                        break;
                        
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
            } while (choice != 8);
        }
    }
}
