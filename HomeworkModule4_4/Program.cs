using System;

namespace HomeworkModule4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //PopulateArray();
            //CountDuplicates();

            #region Task1_PopulateArray

            static void PopulateArray()
            {
                int[] Array1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
                int[] Array2 = new int[10];

                Console.Write("Populated Array2: ");
                for (int i = 0; i < Array1.Length; i++)
                {
                    Array2[i] = Array1[i];
                    Console.Write($"{Array2[i]}; ");
                }
                Console.WriteLine();

                Console.ReadLine();
            }

            #endregion

            #region Task2_CountDuplicates
            static void CountDuplicates()
            {
                Console.WriteLine("Input array type:\n1.String \n2.Integer");
                string arrayType = Console.ReadLine();
                int[] checkArray = { 0, 0, 0, 0, 0 }; //array to check, so there isnt duplicats(to print out message one time)
                bool hasDuplicates = false; //indicator if there was at least one duplicate

                if (arrayType == "1")
                {
                    Console.WriteLine("Input 5 values for string array:");
                    string[] arrayString = new string[5];

                    for (int i = 0; i < arrayString.Length; i++)
                    {
                        arrayString[i] = Console.ReadLine();
                    }

                    Console.Write($"Entered strings in array:");

                    foreach (var item in arrayString)
                    {
                        Console.Write($" {item}; ");
                    }

                    Console.WriteLine();

                    for (int i = 0; i < arrayString.Length; i++)
                    {
                        if (checkArray[i] == 1) //to skip already checked numbers
                        {
                            continue; //continue again with loop to the next number
                        }
                        int count = 0;
                        for (int j = 0; j < arrayString.Length; j++) //loop through all i
                        {
                            if (arrayString[i] == arrayString[j]) //check if values are equal
                            {
                                count = count + 1; //duplicate count
                                checkArray[j] = 1; //fill Checkarray with 1
                            }
                        }
                        if (count > 1)
                        {
                            hasDuplicates = true;
                            Console.WriteLine($"Value:{arrayString[i]}; Duplicates count:{count - 1}"); //-1 because 3 same numbers, but 2 duplicates
                        }
                    }

                    if (hasDuplicates == false) //if we didnt have before hasDuplicates == true, then it comes here
                    {
                        Console.WriteLine("No duplicates");
                    }

                }
                else if (arrayType == "2")
                {
                    Console.WriteLine("Input 5 values for int array:");
                    int[] arrayInteger = new int[5];

                    for (int i = 0; i < 5; i++)
                    {
                        int result;
                        string intInput = Console.ReadLine();

                        bool successfullyParsed = int.TryParse(intInput, out result);
                        if (successfullyParsed)
                        {
                            arrayInteger[i] = result;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                    }
                    Console.Write($"Entered numbers in array:");

                    foreach (var item in arrayInteger)
                    {
                        Console.Write($" {item}; ");
                    }

                    Console.WriteLine();

                    for (int i = 0; i < arrayInteger.Length; i++)
                    {
                        if (checkArray[i] == 1)
                        {
                            continue;
                        }
                        int count = 0;
                        for (int j = 0; j < arrayInteger.Length; j++)
                        {
                            if (arrayInteger[i] == arrayInteger[j])
                            {
                                count = count + 1;
                                checkArray[j] = 1;
                            }
                        }
                        if (count > 1)
                        {
                            hasDuplicates = true;
                            Console.WriteLine($"Value:{arrayInteger[i]}; Duplicates count:{count - 1}");
                        }
                    }
                    if (hasDuplicates == false)
                    {
                        Console.WriteLine("No duplicates");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
                Console.ReadLine();
            }            
            #endregion
        }
    }
}
