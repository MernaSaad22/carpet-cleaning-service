using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String key;
            String key2;
            List<int> testlist = new List<int>();
            
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find the index of a number");
                Console.WriteLine("C - Clear all elements");          
                Console.WriteLine("O - Display elements in ascending order ");
                Console.WriteLine("D - Display elements in descending order");
                Console.WriteLine("Q - Quit");

                Console.WriteLine("Enter your choice : ");
                key = Console.ReadLine();

                key2 = key.ToUpper();




                if (testlist.Count == 0 && key2 == "P")
                {
                    Console.WriteLine("The list is empity");
                }
                else if (testlist.Count > 0 && key2 == "P")
                {
                    Console.Write("[ ");
                    for (int i = 0; i < testlist.Count; i++)
                    {
                        Console.Write(testlist[i] + " ");
                    }
                    Console.WriteLine("]");
                }
                // Adding number without duplication
                else if (key2 == "A")
                {
                    Console.WriteLine("Please enter a number");
                    int num = Convert.ToInt32(Console.ReadLine());

                    bool duplicate = false;
                    for (int i = 0;i < testlist.Count; i++)
                    {
                        if (num == testlist[i])
                        {
                            duplicate = true;
                        }
                    }
                    if (duplicate == false)
                    {
                        testlist.Add(num);
                        Console.WriteLine(num + " is added");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you add "+ num+" before");
                    }



                   
                }
                else if (key2 == "M")
                {
                    if (testlist.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean ");
                    }
                    else
                    {
                        int sum = 0;
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            sum += testlist[i];

                        }
                        Console.WriteLine("The mean of the elements in the list is " + (sum / testlist.Count));
                    }

                }
                else if (key2 == "S")
                {
                    if (testlist.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number");
                    }
                    else if (testlist.Count == 1)
                    {
                        Console.WriteLine("The samllest element in the list is " + testlist[0]);
                    }
                    else
                    {
                        int miny = 10000000;
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            if (testlist[i] < miny)
                            {
                                miny = testlist[i];
                            }
                        }
                        Console.WriteLine("The samllest element in the list is " + miny);
                    }
                }
                else if (key2 == "L")
                {
                    if (testlist.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number");
                    }
                    else if (testlist.Count == 1)
                    {
                        Console.WriteLine("The largest element in the list is " + testlist[0]);
                    }
                    else
                    {
                        int maxy = -10000000;
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            if (testlist[i] > maxy)
                            {
                                maxy = testlist[i];
                            }
                        }
                        Console.WriteLine("The samllest element in the list is " + maxy);
                    }

                }
                else if (key2 == "F")
                {
                    if(testlist.Count == 0)
                    {
                        Console.WriteLine("Unabel to find because list is empty");
                    }
                    else
                    {
                        bool test = false;
                        Console.WriteLine("please enter  a number which you want to find");
                        int num2=Convert.ToInt32(Console.ReadLine());
                        for (int i = 0;i < testlist.Count; i++)
                        {
                            if(testlist[i] == num2)
                            {
                                test = true;
                                Console.WriteLine("the order of number is " + i);
                               
                            }
                           
                            
                        }
                        if (test == false)
                        {
                            Console.WriteLine("Sorry this number is not found");
                        }
                    }
                }


                else if (key2 == "C")
                {
                    if (testlist.Count == 0)
                    {
                        Console.WriteLine("The list already cleared(empty)");
                    }
                    else
                    {
                        for (int i = 0; i<testlist.Count; i++)
                        {
                            testlist.Clear();
                        }
                        Console.WriteLine("All elements are cleared: ");
                        Console.Write("[ ");
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            Console.Write(testlist[i] + " ");
                        }
                        Console.WriteLine("]");

                    }
                }
                else if (key2 == "O")
                {   if (testlist.Count == 0)
                    {
                        Console.WriteLine("The list is empty");
                    }
                    else
                    {

                        for (int i = 0; i < testlist.Count; i++)
                        {
                            for (int j = 0; j < testlist.Count - i - 1; j++)
                            {
                                if (testlist[j] > testlist[j + 1])
                                {
                                    int temp = testlist[j];
                                    testlist[j] = testlist[j + 1];
                                    testlist[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("the elements in ascendind order is : ");
                        Console.Write("[ ");
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            Console.Write(testlist[i] + " ");
                        }
                        Console.WriteLine("]");
                    }
                }

                else if (key2 == "D")
                {
                    if (testlist.Count == 0)
                    {
                        Console.WriteLine("The list is empty");
                    }
                    else
                    {
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            for (int j = 0; j < testlist.Count - i - 1; j++)
                            {
                                if (testlist[j] < testlist[j + 1])
                                {
                                    int temp = testlist[j];
                                    testlist[j] = testlist[j + 1];
                                    testlist[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("the elements in descendind order is : ");
                        Console.Write("[ ");
                        for (int i = 0; i < testlist.Count; i++)
                        {
                            Console.Write(testlist[i] + " ");
                        }
                        Console.WriteLine("]");
                    }
                }


                else if(key2=="Q")
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Unknown eslection please try again ");
                }




              



            }
            while (key2 != "Q");
           






        }
    }
}
