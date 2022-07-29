using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void ArraySort(string arraychoice)
        { // reads each text file dependent on which file the user wants to analyse t hen executes the appropriate methods i.e bubblesort
            if (arraychoice == "1")
            {
                Console.WriteLine("You chose to analyse the Net_1_256 array.\n");
                string stringarray = "Net_1_256.txt";
                string[] strNet_1_256 = System.IO.File.ReadAllLines(stringarray);

                Console.WriteLine("Array Before Sorting:\n ");

                foreach (var line in strNet_1_256) // for each line in the string array (str (string) Net_1_256)
                    Console.Write(line.ToString() + " "); // takes each defined 'line' and turn them into a string with a space separating them. 
                int[] Net_1_256 = Array.ConvertAll(strNet_1_256, int.Parse); // converts string array into an integer array     
                BubbleSort(Net_1_256);
            }
            //above steps are repeated for all other files.
            if (arraychoice == "2")
            {
                Console.WriteLine("You chose to analyse the Net_2_256 array.\n");
                string stringarray2 = "Net_2_256.txt";
                string[] strNet_2_256 = System.IO.File.ReadAllLines(stringarray2);

                Console.WriteLine("Array Before Sorting:\n ");

                foreach (var line in strNet_2_256)
                    Console.Write(line.ToString() + " ");
                int[] Net_2_256 = Array.ConvertAll(strNet_2_256, int.Parse);
                BubbleSort(Net_2_256);
            }

            if (arraychoice == "3")
            {
                Console.WriteLine("You chose to analyse the Net_3_256 array.\n");
                string stringarray3 = "Net_3_256.txt";
                string[] strNet_3_256 = System.IO.File.ReadAllLines(stringarray3);

                Console.WriteLine("Array Before Sorting:\n ");

                foreach (var line in strNet_3_256)
                    Console.Write(line.ToString() + " ");
                int[] Net_3_256 = Array.ConvertAll(strNet_3_256, int.Parse);
                BubbleSort(Net_3_256);
            }

            if (arraychoice == "4")
            {
                Console.WriteLine("You chose to analyse the Net_1_2048 array.\n");
                string stringarray4 = "Net_1_2048.txt";
                string[] strNet_1_2048 = System.IO.File.ReadAllLines(stringarray4);

                Console.WriteLine("Array Before Sorting:\n ");

                foreach (var line in strNet_1_2048)
                    Console.Write(line.ToString() + " ");
                int[] Net_1_2048 = Array.ConvertAll(strNet_1_2048, int.Parse);
                BubbleSort2(Net_1_2048);
            }

            if (arraychoice == "5")
            {
                Console.WriteLine("You chose to analyse the Net_2_2048 array.\n");
                string stringarray5 = "Net_2_2048.txt";
                string[] strNet_2_2048 = System.IO.File.ReadAllLines(stringarray5);

                Console.WriteLine("Array Before Sorting:\n ");

                foreach (var line in strNet_2_2048)
                    Console.Write(line.ToString() + " ");
                int[] Net_2_2048 = Array.ConvertAll(strNet_2_2048, int.Parse);
                BubbleSort2(Net_2_2048);
            }

            if (arraychoice == "6")
            {
                Console.WriteLine("You chose to analyse the Net_3_2048 array.\n");
                string stringarray6 = "Net_3_2048.txt";
                string[] strNet_3_2048 = System.IO.File.ReadAllLines(stringarray6);

                Console.WriteLine("Array Before Sorting:\n ");

                foreach (var line in strNet_3_2048)
                    Console.Write(line.ToString() + " ");
                int[] Net_3_2048 = Array.ConvertAll(strNet_3_2048, int.Parse);
                BubbleSort2(Net_3_2048);
            }
        }
        static int[] BubbleSort(int[] array)
        {/* sorts array into desired order (ascending or descending)
            compares pair of adjacent elements and are swapped if they are not in order*/
            int counter = 0; // counter implemented to count number of steps the algorithm takes
            int length = array.Length;
            int temp = array[0];
            // code to put array into ascending order
            for (int i = 0; i < length; i++)
            {
                counter++;
                for (int j = i + 1; j < length; j++)
                {
                    //counter++;
                    if (array[i] > array[j])
                    {
                        // swaps temp and array[i] 
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        //counter++;
                    }
                }
            }
            Console.WriteLine("\n\nThis bubble sort ascending algorithm took {0} steps", counter); // hows the user how many steps were taken (this occurs with every algorithm)
            Console.WriteLine("\nEvery 10th Value in Ascending Order\n");
            var result = ArraySort_10th_Value(array, 10); // assigns the variable 'result' with the return value from the method ArraySort_10th_value
                                                          // parameters for the method are array and 10, array being the array to be passed and 10 being the value index to be printed
            Console.WriteLine(string.Join(" ", result));

            //code to put array into descending order           

            int counter1 = 0;
            int length2 = array.Length;
            int temp2 = array[0];
            for (int i = 0; i < length2; i++)
            {
                counter1++;
                for (int j = i + 1; j < length2; j++)
                {
                    if (array[i] < array[j]) // only difference between this and the above code is array[i] is now set to less than rather than greater than
                    {
                        temp2 = array[i];
                        array[i] = array[j];
                        array[j] = temp2;

                    }
                }
            }
            Console.WriteLine("\n\nThis bubble sort descending algorithm took {0} steps", counter1);
            Console.WriteLine("\nEvery 10th Value in Descending Order\n");
            var result2 = ArraySort_10th_Value(array, 10);
            Console.WriteLine(string.Join(" ", result2));
            return array; // returns the sorted array to 'BubbleSort()' in case it needs to be displayed or altered else where.
        }
        public static int[] BubbleSort2(int[] array) // exact same algorithm as above. But this executes with displaying every 50th element rather than every 10th element.
        {
            int counter = 0;
            int length = array.Length;
            int temp = array[0];
            for (int i = 0; i < length; i++)
            {
                counter++;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
            Console.WriteLine("\n\nThis bubble sort ascending algorithm took {0} steps to finish", counter);
            Console.WriteLine("\n\nEvery 50th Value in Ascending Order\n");
            var result = ArraySort_50th_Value(array, 50); // (array) is the array to be sorted by every 50th value (50) is telling the method is display every 50th value.
            Console.WriteLine(string.Join(" ", result));

            //code to put array into descending order           

            int counter1 = 0;
            int length2 = array.Length;
            int temp2 = array[0];
            for (int i = 0; i < length2; i++)
            {
                counter1++;
                for (int j = i + 1; j < length2; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp2 = array[i];
                        array[i] = array[j];
                        array[j] = temp2;

                    }
                }
            }
            Console.WriteLine("\n\nThis bubble sort descending algorithm took {0} steps to finish", counter1);
            Console.WriteLine("\n\nEvery 50th Value in Descending Order\n");
            var result2 = ArraySort_50th_Value(array, 50);
            Console.WriteLine(string.Join(" ", result2));
            return array;
        }
        static int[] BubbleSort3(int[] array) // this bubblesort algorithm is created so neither 10th or 50th value method is called.
        {
            int counter = 0;
            int length = array.Length;
            int temp = array[0];
            for (int i = 0; i < length; i++)
            {
                counter++;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j]) // this algorithm will display the array into ascending order.
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
            Console.WriteLine("\n\nThis bubble sort algorithm took {0} steps to finish", counter);
            return array; // returns the sorted array back to 'BubbleSort'

        }
        static int[] InsertionSort(int[] array) // takes an element at a time and inserts it in its correct position in the array. Continued until the array is sorted
        {
            int counter = 0;
            int j, temp;
            for (int i = 1; i <= array.Length - 1; i++)
            {
                counter++;
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > temp) // moves elements of array[0.i-1] that are graeter then the key to one position ahead of their current position
                {
                    //counter++;
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            Console.WriteLine("\nThis Insertion Sort algorithm took {0} steps\n", counter);
            return array;
        }
        static int[] InsertionSort_Descending(int[] array) // this algorithm sorts the passed array into descending order rather than ascending order 
        {
            int counter = 0;
            int j, temp;
            for (int i = 1; i <= array.Length - 1; i++)
            {
                counter++;
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j] < temp) // only difference is that array[j] is less than temp
                {
                    //counter++;
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            Console.WriteLine("\nThis Insertion Sort Descending algorithm took {0} steps\n", counter);
            return array;
        }
        static List<int> ArraySort_10th_Value(int[] array, int n)
        {
            int counter = 0;
            List<int> array_list = array.OfType<int>().ToList(); // creates an integer array list that stores each 10th value which is then later displayed to the user
            List<int> result = new List<int>();
            for (int i = 0; i < array_list.Count; i++)
            {
                counter++;
                if ((i % n) == 0) // if i divided by n (which is the 10 or 50) is equal to 0 then that value is added to the array list
                {
                    counter++;
                    result.Add(array_list[i]); // adds the current element into the array list 'result'
                }
            }
            Console.WriteLine("\nThis 10th value algorithm took {0} steps\n", counter);
            return result; // returns the result list back to the method so it can then be called by the user.
        }
        static List<int> ArraySort_50th_Value(int[] array, int n) // the same code as above. Only difference is that the passed number is 50 rather than 10
        {
            int counter = 0;
            List<int> array_list = array.OfType<int>().ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < array_list.Count; i++)
            {
                counter++;
                if ((i % n) == 0)
                {
                    counter++;
                    result.Add(array_list[i]);
                }
            }
            Console.WriteLine("\nThis 50th value algorithm took {0} steps\n", counter);
            return result;
        }
        static int[] ArrayMerge() // method that reads two text files then merges them together. Along with putting the merged array into order and displaying the 10th and 50th value
        {
            string merge = "Net_1_256.txt";
            string[] strNet_1_256 = System.IO.File.ReadAllLines(merge); // reads all lines of the text file into a string array
            int[] Net_1_256 = Array.ConvertAll(strNet_1_256, int.Parse); // string array is then converted into an integer array

            string merge2 = "Net_3_256.txt";
            string[] strNet_3_256 = System.IO.File.ReadAllLines(merge2); // repeated for the second text file
            int[] Net_3_256 = Array.ConvertAll(strNet_3_256, int.Parse);
            int n1 = Net_1_256.Length; // variable n1 is equal to the length of the first array
            int n2 = Net_3_256.Length;
            int[] arrayresult = new int[n1 + n2]; // arrayresult is equal to length of n1 plus n2
            int[] MergedArray = MergeSort(Net_1_256, Net_3_256, arrayresult); // calls the MergeSort algorithm with each array plus the combined array into the algorithm.                      
            Console.WriteLine("\nArray after merging\n");
            Console.WriteLine(string.Join(" ", MergedArray));
            int[] array_ascended = InsertionSort(MergedArray.ToArray());     // what is returned from InsertionSort is assigned to the new array 'array_ascended'                  
            Console.WriteLine("\nArray in Ascending order\n");
            var result1 = ArraySort_10th_Value(array_ascended, 10);
            Console.WriteLine(string.Join(" ", result1));
            int[] array_descending = InsertionSort_Descending(MergedArray.ToArray()); // what is returned from InsertionSort_Descending is assigned to the new array 'array_descending'
            Console.WriteLine("\nArray in Descending order\n");
            var result2 = ArraySort_10th_Value(array_descending, 10);
            Console.WriteLine(string.Join(" ", result2));
            return MergedArray;
        }

        static int[] ArrayMerge_2048()
        {
            string merge = "Net_1_2048.txt";
            string[] strNet_1_2048 = System.IO.File.ReadAllLines(merge);
            int[] Net_1_2048 = Array.ConvertAll(strNet_1_2048, int.Parse);

            string merge2 = "Net_2_2048.txt";
            string[] strNet_2_2048 = System.IO.File.ReadAllLines(merge2);
            int[] Net_2_2048 = Array.ConvertAll(strNet_2_2048, int.Parse);

            string merge3 = "Net_3_2048.txt";
            string[] strNet_3_2048 = System.IO.File.ReadAllLines(merge3);
            int[] Net_3_2048 = Array.ConvertAll(strNet_3_2048, int.Parse);

            var arraymerge = Net_1_2048.Concat(Net_2_2048).Concat(Net_3_2048).ToArray();
            int[] array2048_ascending = InsertionSort(arraymerge.ToArray());
            Console.WriteLine("\nArray in ascending order");
            var result1 = ArraySort_10th_Value(array2048_ascending, 10);
            Console.WriteLine(string.Join(" ", result1));

            int[] array_descending = InsertionSort_Descending(arraymerge.ToArray()); // what is returned from InsertionSort_Descending is assigned to the new array 'array_descending'
            Console.WriteLine("\nArray in Descending order\n");
            var result2 = ArraySort_10th_Value(array_descending, 10);
            Console.WriteLine(string.Join(" ", result2));
            return arraymerge;
        }


        public static int[] MergeSort(int[] array1, int[] array2, int[] array3) // based on divide and conquer paradigm
        {
            int counter = 0;
            //index for result
            int n = 0;
            //index for array 1
            int i = 0;
            //index for array 2
            int j = 0;
            // while either array still has an element
            while (i < array1.Length && j < array2.Length)
            {
                //counter++;
                if (array1[i] < array2[j]) // if item in left array is less than item in right array
                                           // compares the first two elements to see which is smaller
                {
                    counter++;
                    array3[n] = array1[i];
                    i++;
                }
                else
                {
                    counter++;
                    array3[n] = array2[j];
                    j++;
                }
                counter++;
                n++;

            }
            while (i < array1.Length) // if left array still has elements 
            {
                counter++;
                array3[n] = array1[i];
                i++;
                n++;
            }
            while (j < array2.Length) // if right array still has elements
            {
                counter++;
                array3[n] = array2[j];
                j++;
                n++;
            }
            Console.WriteLine("\nThis merge sort algorithm took {0} steps\n", counter);
            return array3;  // returns the merged array as array3 back to the method.         
        }
        static void ArraySearch(string valuechoice)
        {
            if (valuechoice == "1")
            {
                Console.WriteLine("\nWhat value do you want to search for?\n "); // searches for a value in the users specified array
                string input = Console.ReadLine();
                //input = " " + input;
                //input += " ";
                int SearchedValue = int.Parse(input);
                Array_1_ValueSearch(input, SearchedValue);
            }

            if (valuechoice == "2")
            {
                Console.WriteLine("\nWhat value do you want to search for?\n ");
                string input = Console.ReadLine();
                //input = " " + input;
                //input += " ";
                int SearchedValue = int.Parse(input); // converts string variable into an integer variable
                Array_2_ValueSearch(input, SearchedValue);

            }

            if (valuechoice == "3")
            {
                Console.WriteLine("\nWhat value do you want to search for?\n ");
                string input = Console.ReadLine();
                //input = " " + input;
                //input += " ";
                int SearchedValue = int.Parse(input);
                Array_3_ValueSearch(input, SearchedValue);

            }

            if (valuechoice == "4")
            {
                Console.WriteLine("\nWhat value do you want to search for?\n ");
                string input = Console.ReadLine();
                //input = " " + input;
                //input += " ";
                int SearchedValue = int.Parse(input);
                Array_4_ValueSearch(input, SearchedValue);

            }

            if (valuechoice == "5")
            {
                Console.WriteLine("\nWhat value do you want to search for?\n ");
                string input = Console.ReadLine();
                //input = " " + input;
                //input += " ";
                int SearchedValue = int.Parse(input);
                Array_5_ValueSearch(input, SearchedValue);

            }

            if (valuechoice == "6")
            {
                Console.WriteLine("\nWhat value do you want to search for?\n ");
                string input = Console.ReadLine();
                // input = " " + input;
                //input += " ";
                int SearchedValue = int.Parse(input);
                Array_6_ValueSearch(input, SearchedValue);

            } // calls each individual array value search to which array the user wants to search          
        }
        static void Array_1_ValueSearch(string value, int SearchedValue) // executes search algorithms to find the users desired value plus duplicates if any are present. If not then find the closest value and check for duplicates
        {
            string stringarray = "Net_1_256.txt";
            string[] strNet_1_256 = System.IO.File.ReadAllLines(stringarray);
            int[] Net_1_256 = Array.ConvertAll(strNet_1_256, int.Parse);

            int nameIndex = LinearSearch(strNet_1_256, value); // executes the linear search algorithm with string array and desired value

            if (nameIndex == -1) // if value isnt present in the array then the returned result is -1.
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue); // {0} is a placeholder for a variable to be added to it                        
                int[] sorted_array = BubbleSort3(Net_1_256); // bubble sort is executed again to then use a binary search to find the closest value           
                int closest = FindClosest(Net_1_256, SearchedValue); //  executes method to find the closest value to the searched value from the user
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(strNet_1_256, closestvalue); // search for the new value is repeated and returned back into the variable name index

                var DuplicateIndex = DuplicateSearch(Net_1_256, closest, Net_1_256.Length); // duplicate search is executed to find if any duplicates are present in the code
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else // value is present so only a duplicate search is needed
            {
                var DuplicateIndex = DuplicateSearch(Net_1_256, SearchedValue, Net_1_256.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }
        }
        static void Array_2_ValueSearch(string value, int SearchedValue) // code is repeated as above for all 6 files plus the merged file
        {
            string stringarray = "Net_2_256.txt";
            string[] strNet_2_256 = System.IO.File.ReadAllLines(stringarray);
            int[] Net_2_256 = Array.ConvertAll(strNet_2_256, int.Parse);

            int nameIndex = LinearSearch(strNet_2_256, value);

            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(Net_2_256);
                int closest = FindClosest(Net_2_256, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(strNet_2_256, closestvalue);

                var DuplicateIndex = DuplicateSearch(Net_2_256, closest, Net_2_256.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else
            {
                var DuplicateIndex = DuplicateSearch(Net_2_256, SearchedValue, Net_2_256.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }

        }
        static void Array_3_ValueSearch(string value, int SearchedValue)
        {
            string stringarray = "Net_3_256.txt";
            string[] strNet_3_256 = System.IO.File.ReadAllLines(stringarray);
            int[] Net_3_256 = Array.ConvertAll(strNet_3_256, int.Parse);
            int nameIndex = LinearSearch(strNet_3_256, value);
            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(Net_3_256);
                int closest = FindClosest(Net_3_256, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(strNet_3_256, closestvalue);

                var DuplicateIndex = DuplicateSearch(Net_3_256, closest, Net_3_256.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else
            {
                var DuplicateIndex = DuplicateSearch(Net_3_256, SearchedValue, Net_3_256.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }
        }
        static void Array_4_ValueSearch(string value, int SearchedValue)
        {
            string stringarray = "Net_1_2048.txt";
            string[] strNet_1_2048 = System.IO.File.ReadAllLines(stringarray);
            int[] Net_1_2048 = Array.ConvertAll(strNet_1_2048, int.Parse);
            int nameIndex = LinearSearch(strNet_1_2048, value);
            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(Net_1_2048);
                int closest = FindClosest(Net_1_2048, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(strNet_1_2048, closestvalue);

                var DuplicateIndex = DuplicateSearch(Net_1_2048, closest, Net_1_2048.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));

            }
            else
            {
                var DuplicateIndex = DuplicateSearch(Net_1_2048, SearchedValue, Net_1_2048.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }
        }
        static void Array_5_ValueSearch(string value, int SearchedValue)
        {
            string stringarray = "Net_2_2048.txt";
            string[] strNet_2_2048 = System.IO.File.ReadAllLines(stringarray);
            int[] Net_2_2048 = Array.ConvertAll(strNet_2_2048, int.Parse);
            int nameIndex = LinearSearch(strNet_2_2048, value);
            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(Net_2_2048);
                int closest = FindClosest(Net_2_2048, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(strNet_2_2048, closestvalue);

                var DuplicateIndex = DuplicateSearch(Net_2_2048, closest, Net_2_2048.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else
            {
                var DuplicateIndex = DuplicateSearch(Net_2_2048, SearchedValue, Net_2_2048.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }
        }
        static void Array_6_ValueSearch(string value, int SearchedValue)
        {
            string stringarray = "Net_3_2048.txt";
            string[] strNet_3_2048 = System.IO.File.ReadAllLines(stringarray);
            int[] Net_3_2048 = Array.ConvertAll(strNet_3_2048, int.Parse);
            int nameIndex = LinearSearch(strNet_3_2048, value);
            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(Net_3_2048);
                int closest = FindClosest(Net_3_2048, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(strNet_3_2048, closestvalue);

                var DuplicateIndex = DuplicateSearch(Net_3_2048, closest, Net_3_2048.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else
            {
                var DuplicateIndex = DuplicateSearch(Net_3_2048, SearchedValue, Net_3_2048.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }
        }
        static void Array_7_ValueSearch(int[] array, string value) // all code for each array search is the same so each value is searched in which ever desired array
        {
            int SearchedValue = Convert.ToInt32(value);
            string[] merged_array = Array.ConvertAll(array, x => x.ToString());
            int nameIndex = LinearSearch(merged_array, value);
            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(array);
                int closest = FindClosest(sorted_array, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(merged_array, value);

                var DuplicateIndex = DuplicateSearch(array, closest, array.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else
            {
                var DuplicateIndex = DuplicateSearch(array, SearchedValue, array.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }
        }
        static void Array_8_ValueSearch(int[] array, string value)
        {
            int SearchedValue = Convert.ToInt32(value);
            string[] merged_array = Array.ConvertAll(array, x => x.ToString());
            int nameIndex = LinearSearch(merged_array, value);
            if (nameIndex == -1)
            {
                Console.WriteLine("\n{0} is not in the array.", SearchedValue);
                int[] sorted_array = BubbleSort3(array);
                int closest = FindClosest(sorted_array, SearchedValue);
                string closestvalue = closest.ToString();
                int nameIndex2 = LinearSearch(merged_array, value);

                var DuplicateIndex = DuplicateSearch(array, closest, array.Length);
                Console.WriteLine("Closest value to {0} is {1} and is present at index(s) {2}, {3}", SearchedValue, closest, nameIndex2, string.Join(" ", DuplicateIndex));
            }
            else
            {
                var DuplicateIndex = DuplicateSearch(array, SearchedValue, array.Length);
                Console.WriteLine("{0} is present at index(s) {1}, {2}", SearchedValue, nameIndex, string.Join(" ", DuplicateIndex));
            }

        }

        public static int FindClosest(int[] array, int target) // algorithm to find the closest value to what the user specified // including a Binary Search Algorithm
        {
            int counter = 0;
            int n = array.Length;
            if (target <= array[0])
            {
                counter++;
                return array[0];
            }
            if (target >= array[n - 1]) // if the target value is greater than or equal to the array length - 1
            {
                counter++;
                return array[n - 1];
            }
            int i = 0, j = n, mid = 0;

            //Binary Search algorithm
            while (i < j)
            {
                counter++;
                mid = (i + j) / 2;
                if (array[mid] == target) // if middle of array is equal to the target value
                {
                    counter++;
                    Console.WriteLine("\nThis Binary Search algorithm took {0} steps\n", counter);
                    return array[mid];
                }
                if (target < array[mid]) // if target is less than the middle of the array
                {
                    counter++;
                    if (mid > 0 && target > array[mid - 1])
                    {
                        counter++;
                        Console.WriteLine("\nThis Binary Search algorithm took {0} steps\n", counter);
                        return GetClosest(array[mid - 1], array[mid], target);
                    }
                    j = mid;
                }
                else
                {
                    counter++;
                    if (mid < n - 1 && target < array[mid + 1])
                    {
                        counter++;
                        Console.WriteLine("\nThis Binary Search algorithm took {0} steps\n", counter);
                        return GetClosest(array[mid], array[mid + 1], target); // returns the values to the GetClosest method              
                    }
                    counter++;
                    i = mid + 1;
                }
            }
            Console.WriteLine("\nThis Find Closest/Binary Search algorithm took {0} steps\n", counter);
            return array[mid];
        }
        public static int GetClosest(int value1, int value2, int target) // this method gets the closest value whereas the other method finds the closest value
        {
            int counter = 0;
            if (target - value1 >= value2 - target) // if target - the first value is greater than or equal to value 2 - target then the second value is returned
            {
                counter++;
                Console.WriteLine("\nThis Get Closest algorithm took {0} steps\n", counter);
                return value2;
            }
            else
            {
                counter++;
                Console.WriteLine("\nThis Get Closest algorithm took {0} steps\n", counter);
                return value1;
            }
        }
        static List<int> DuplicateSearch(int[] array, int value, int mid) // algorithm to find duplicates or closest or the value the user desired
        {
            int counter = 0;
            List<int> result = new List<int>(); // makes a new int list called result which stores the duplicates along with the indexes and displays these to the user
            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])// if array element is equal to another array element
                    {
                        if ((array[j] % value) == 0) // if array element divided by the value is equal to 0 then a duplicate is present
                        {
                            counter++;
                            result.Add(j); // adds duplicate index to the results list                                                                   
                        }
                    }
                }
            }
            Console.WriteLine("\nThis Duplicate Search algorithm took {0} steps\n", counter);
            return result;
        }
        static int LinearSearch(string[] array, string SearchedValue) // linear search to search for a value in an unsorted list
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                if (array[i] == SearchedValue) // if array element is equal to the searched value then the value is present
                {
                    counter++;
                    Console.WriteLine("\nThis Linear Search algorithm took {0} steps\n", counter);
                    return i; // value is returned and is then used to later find duplicates
                }
            }
            Console.WriteLine("\nThis Linear Search algorithm took {0} steps\n", counter);
            return -1; // returns -1 if value is not found. Then search for the closest value is then executed
        }
        static void Main(string[] args) // Main method that initialises other methods that correspond to the user's input
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Which array do you want to analyse?\nNet_1_256 = 1\nNet_2_256 = 2\nNet_3_256 = 3\nNet_1_2048 = 4\nNet_2_2048 = 5\nNet_3_2048 = 6");
            string choice = Console.ReadLine();
            ArraySort(choice);
            Console.WriteLine("\n\nChoose an array to choose a value in.\n\nNet_1_256 = 1\nNet_2_256 = 2\nNet_3_256 = 3\nNet_1_2048 = 4\nNet_2_2048 = 5\nNet_3_2048 = 6");
            string valuechoice = Console.ReadLine();
            ArraySearch(valuechoice);
            Console.WriteLine("\nArray Net_1_256 and Net_3_256 are being merged together\n");
            int[] array = ArrayMerge();
            Console.WriteLine("\nWhat value do you want to search for in the unsorted array?\n");
            string value = Console.ReadLine();
            Array_7_ValueSearch(array, value);
            Console.WriteLine("\nArrays Net_1_2048, Net_2_2048, Net_3_2048 are being merged together\n");
            int[] array2 = ArrayMerge_2048();
            Console.WriteLine("\nWhat value do you want to search for in the unsorted array?\n");
            string value2 = Console.ReadLine();
            //value2 = " " + value2;
            //value2 += " ";
            Array_8_ValueSearch(array2, value2);
            stopwatch.Stop();
            Console.WriteLine($"\nExecution time of the program: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}