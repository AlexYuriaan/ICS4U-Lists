using System.Collections.Generic;

namespace Lists
{
    class Lists
    {
        public static void Main(string[] args)
        {
            bool firstBoot = true;
            bool inputFlag = true;
            string menuSelect = "";
            string[] asciiMenu =
                {
                " __   __  _______  __    _  __   __ ",
                "|  |_|  ||       ||  |  | ||  | |  |",
                "|       ||    ___||   |_| ||  | |  |",
                "|       ||   |___ |       ||  |_|  |",
                "|       ||    ___||  _    ||       |",
                "| ||_|| ||   |___ | | |   ||       |",
                "|_|   |_||_______||_|  |__||_______|"};

            while (inputFlag)
            {
                if (!firstBoot)
                {
                    Thread.Sleep(2000);

                }
                firstBoot = false;
                for (int i = 0; i < asciiMenu.Length; i++)
                {
                    Console.WriteLine(asciiMenu[i]);
                }
                Console.WriteLine("Please select a program, or press X to quit");
                Console.WriteLine("1. List of Integers\n2. List of Strings\nX. QUIT");
                menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                {
                    ListOfIntegers();
                }
                else if (menuSelect == "2")
                {
                    ListOfStrings();
                }
                else if (menuSelect.ToUpper() == "X")
                {
                    Console.WriteLine("Thank you for using the program.");
                    Environment.Exit(0);
                }

            }

        }



        static void ListOfIntegers()
        {
            bool inputFlag = true;
            string menuSelect;
            List<int> randomList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                randomList.Add(rand.Next(10, 21));
            }
            for (int i = 0; i < randomList.Count; i++)
            {
                Console.Write(randomList[i] + " ");
            }

            while (inputFlag)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("How would you like to adjust this list");
                Console.WriteLine("1. Sort the list\n2. Make a new list of random numbers\n3. Remove a number (by value)\n4. Add a value to the list\n5. Count the occurances of a number\n6. Print the largest value\n7. Print the smallest value\n8. Print the sum and average of the list\n9. Determine the most frequently occuring value\nX. QUIT");
                menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                {
                    // Sort List
                    Console.WriteLine("\n\n\n");
                    randomList.Sort();
                    PrintList(randomList);

                }
                else if (menuSelect == "2")
                {
                    // Regenerate List
                    Console.WriteLine("\n\n\n");
                    randomList.Clear();
                    for (int i = 0; i < 25; i++)
                    {   
                        randomList.Add( rand.Next(10, 21));
                    }
                    Console.WriteLine("List Regenerated. Your New List is: ");
                    PrintList(randomList);
                }
                else if (menuSelect == "3")
                {
                    Console.WriteLine("\n\n\n");

                    RemoveNum(randomList);
                    PrintList(randomList);
                }
                else if (menuSelect == "4")
                {
                    Console.WriteLine("\n\n\n");

                    AddNum(randomList);
                    PrintList(randomList);

                }
                else if (menuSelect == "5")
                {
                    Console.WriteLine("\n\n\n");

                    Console.WriteLine($"Your Number Appeared {FindAllOccurances(randomList)} times.");
                }
                else if (menuSelect == "6")
                {
                    Console.WriteLine("\n\n\n");

                    Console.WriteLine("The highest number in the list is: " + randomList.Max());
                }
                else if (menuSelect == "7")
                {
                    Console.WriteLine("\n\n\n");

                    Console.WriteLine("The lowest number in the list is: " + randomList.Min());
                }
                else if (menuSelect == "8")
                {
                    Console.WriteLine("\n\n\n");

                    Console.WriteLine("Sum: " + randomList.Sum(x => x));
                    double average = (Convert.ToDouble(randomList.Sum(x => x)) / (randomList.Count));
                    Console.WriteLine("Average: " + Math.Round(average,2));
                }
                else if (menuSelect == "9")
                {
                    Console.WriteLine("\n\n\n");

                    FindMostOccuring(randomList);
                }




                else if (menuSelect.ToUpper() == "X")
                {
                    Console.WriteLine("Returning to menu");
                    inputFlag = false;
                }

            }
        }

        static void ListOfStrings()
        {
            bool firstBoot = true;
            bool inputFlag = true;
            string menuSelect = "";
            string[] asciiMenu =
                {
            " __   __  _______  __    _  __   __ ",
            "|  |_|  ||       ||  |  | ||  | |  |",
            "|       ||    ___||   |_| ||  | |  |",
            "|       ||   |___ |       ||  |_|  |",
            "|       ||    ___||  _    ||       |",
            "| ||_|| ||   |___ | | |   ||       |",
            "|_|   |_||_______||_|  |__||_______|"};

            List<String> vegetables = new List<String> {"CARROT", "BEET", "CELERY", "RADISH", "CABBAGE"};



            while (inputFlag)
            {
                if (!firstBoot)
                {
                    Thread.Sleep(2000);

                }
                firstBoot = false;
                for (int i = 0; i < asciiMenu.Length; i++)
                {
                    Console.WriteLine(asciiMenu[i]);
                }
                Console.WriteLine("-------------------------------");
                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i} - {vegetables[i]}");
                }
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Please select an action, or press x to quit");
                Console.WriteLine("1. Remove by index\n2. Remove all by value\n3. Search for vegetable \n4. Add vegetables to list\n5. Sort List\n6. Clear List\nQ. MORE INFO\nX. QUIT");
                menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                {
                    RemoveVegetableByIndex(vegetables);
                }
                else if (menuSelect == "2")
                {
                    RemoveVegetableByValue(vegetables);
                }
                else if (menuSelect == "3")
                {
                    SearchForVegetableByValue(vegetables);
                }
                else if (menuSelect == "4")
                {
                    AddVegetableToList(vegetables);
                }
                else if (menuSelect == "5")
                {
                    Console.WriteLine("Sorting List");
                    vegetables.Sort();
                }
                else if (menuSelect == "6")
                {
                    Console.WriteLine("Clearing List");
                    vegetables.Clear();
                }
                else if (menuSelect.ToUpper() == "X")
                {
                    Console.WriteLine("Returning to menu.");
                    inputFlag = false;
                }

                

            }



        }


        // INTEGER LISTS
        static void PrintList<T>(List<T> ts)
        {
            for(int i = 0; i < ts.Count; i++)
            {
                Console.Write(ts[i] + " ");
            }
        }

        static void RemoveNum<T>(List<T> ts)
        {
            bool inputFlag = true;
            string removeString = "";
            int removeNum = 15;

            while(inputFlag)
            {
                Console.Write("Enter the number you wish to remove: ");
                removeString = Console.ReadLine();
                if (!int.TryParse(removeString,out removeNum) || removeNum > 20 || removeNum < 10) {
                    Console.WriteLine("Invalid Input. Please enter a number between 10 and 20.");
                }
                else
                {
                    for (int i = 0; i < ts.Count; i++)
                    {
                        if (ts[i].ToString() == removeNum.ToString())
                        {
                            ts.RemoveAt(i);
                            i -= 1;
                        }
                    }
                    inputFlag = false;
                }


            }
        }

        static void AddNum(List<int> ts)
        {
            bool inputFlag = true;
            string addString = "";
            int addNum = 15;

            while (inputFlag)
            {
                Console.Write("Enter the number you wish to add: ");
                addString = Console.ReadLine();
                if (!int.TryParse(addString, out addNum) || addNum > 20 || addNum < 10)
                {
                    Console.WriteLine("Invalid Input. Please enter a number between 10 and 20.");
                }
                else
                {
                    ts.Add(addNum);
                    inputFlag = false;
                }
            }
        }

        static int FindAllOccurances(List<int> ts)
        {

            bool inputFlag = true;
            string countString;
            int countNum;
            int counter = 0;
            while (inputFlag)
            {
                Console.Write("Enter the number you wish to count: ");
                countString = Console.ReadLine();
                if (!int.TryParse(countString, out countNum))
                {
                    Console.WriteLine("Invalid Input. Please enter a number.");
                }
                else
                {
                    for(int i = 0; i < ts.Count; i++)
                    {
                        if (ts[i] == countNum) { counter++; } 
                    }
                    return counter;
                }

                
            }
            return counter;
        }

        static void FindMostOccuring(List<int> ts)
        {
            List<int> counters = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            List<int> max = new List<int>();
            for(int i = 10; i < 21; i++)
            {
                for (int t = 0; t < ts.Count; t++)
                {
                    if (ts[t] == i) { counters[i - 10]++; }
                }

            }
            PrintList(counters);
            for (int i = 0; i < counters.Count; i++)
            {
                if (counters[i] == counters.Max())
                {
                    max.Add(i + 10);
                }
            }

            if (max.Count() > 1)
            {
                Console.Write($"The Numbers that occur the most are: {String.Join(",",max)} ");

            }
            else
            {
                Console.WriteLine("The number that occurs the most is " + max[0]);
                
            }



        }

        // STRING LISTS

        static void RemoveVegetableByValue(List<string> ts)
        {
            string value = "";
            Console.WriteLine("Please enter an index to remove");
            value = Console.ReadLine().ToUpper();

            for (int i = 0; i < ts.Count;i++)
            {
                if (value == ts[i])
                {
                    ts.RemoveAt(i);
                    i--;
                }
            }

        }

        static void RemoveVegetableByIndex(List<string> ts)
        {
            bool inputFlag = true;
            int index;
            Console.WriteLine("Please enter an value to remove: ");
            while (inputFlag)
            {
                if (!Int32.TryParse(Console.ReadLine(), out index) || index >= ts.Count || index < 0)
                {
                    Console.WriteLine($"Invalid Input! Please enter an index between 0 and {ts.Count}.");
                    inputFlag = false;
                }
                else
                {
                    Console.WriteLine($"Removing at index {index}.");
                    ts.RemoveAt(index);
                    inputFlag = false;
                }
            }
        }

        static void SearchForVegetableByValue(List<string> ts)
        {
            bool flag = true;
            string input;
            int index = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Enter a vegetable to search for: ");
            input = Console.ReadLine().ToUpper();

            for (int i = 0; i < ts.Count; i++)
            {
                if (ts[i] == input)
                {
                    list.Add(i);
                }
            }
            if (list.Count > 0)
            {
                Console.WriteLine($"{input} can be found at the following locations {String.Join(",", list)}");
            }
            else
            {
                Console.WriteLine($"{input} can not be found in the list.");
            }


        }

        static void AddVegetableToList(List<string> ts)
        {
            Console.WriteLine("Enter a vegetable to add to the list: ");


            string input = Console.ReadLine().ToUpper();
            bool flag = false;

            for (int i = 0; i < ts.Count; i++)
            {
                if (ts[i] == input)
                {
                    Console.WriteLine("This Vegetable is already in the list. You can't add it.");
                    flag = true;
                }
            }
            if (!flag) {
                Console.WriteLine($"Adding {input} to the list.");
                ts.Add(input);
            }

        }
    }
}