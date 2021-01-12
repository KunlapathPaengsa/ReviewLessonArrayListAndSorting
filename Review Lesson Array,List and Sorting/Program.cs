using System;
using System.Collections.Generic;
using System.Linq;

namespace Review_Lesson_Array_List_and_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ReviewArray();
            ReviewList();
            ReviewSorting();
        }
        public static void ReviewArray()
        {
            int[] Array1 = new int[5];
            int[] Array2 = new int[] {1,3,5,7,9};
            int[] Array3 = new int[] {1,2,3,4,5,6};
            int[,] MultiDimArr = new int[2,3];
            int[,] MultiDimVector = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] JaggedArr = new int [6][];
            JaggedArr[0] = new int[4] {1,2,3,4};
            int[][,] jaggedArray3 = new int[3][,]
                                   {
                                    new int[,] { {1,3}, {5,7} },
                                    new int[,] { {0,2}, {4,6}, {8,10} },
                                    new int[,] { {11,22}, {99,88}, {0,9} }
                                   };
            
            Console.WriteLine("Array1");
            foreach (int item1 in Array1)
            {
                
                Console.Write($"{0} ",item1);
            }

            Console.WriteLine("\n\nArray2");
            for (int i = 0; i < Array2.Length; i++)
            {
                Console.Write($"{Array2[i]} ");
            }

            Console.WriteLine("\n\nArray3");
            for (int i = 0; i < Array3.Length; i++)
            {
                Console.Write($"{Array3[i]} ");
            }

            Console.WriteLine("\n\nMultiDimVector For Loop");
            for (int i = 0; i < MultiDimVector.Length; i++)
            {
                Console.Write($"{MultiDimVector} ",i);
            }
            
            Console.WriteLine("\n\nMultiDimVector Foreach");
            foreach (int i in MultiDimVector)
            {
                Console.Write($"{0} ",i);
            }
            Console.Write($"\n{MultiDimVector[0,0]} {MultiDimVector[0, 1]} {MultiDimVector[0, 2]} {MultiDimVector[1, 0]} {MultiDimVector[1, 1]} {MultiDimVector[1, 2]}\n");

            Console.WriteLine("\n\nJaggedArray3[0][1, 0]");
            Console.WriteLine("{0}", jaggedArray3[0][1, 0]);


        }
        public static void ReviewList()
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(1);
            //list1.Add("");
            //list1.Add(null);//Nullable Error
            for (int i =0; i < 10; i++)
            {
                list1.Add(i);
            }

            List<string> list2 = new List<string>();
            list2.Add("A");
            list2.Add("I");
            list2.Add("");
            list2.Add("Y");
            list2.Add("E");
            //Console.WriteLine(list1);//SystemInt32
            //Console.WriteLine($"{list1}");//SystemInt32
            Console.WriteLine("Generic List<Int>");
            foreach (int i in list1)
            {
                Console.WriteLine("{0}", i.ToString());
            }
            Console.WriteLine("\nGeneric List<String>");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine($"{list2[i]}");
            }

        }
        public static void ReviewSorting()
        {
            int[] DataSource = new int[] { 15, 58, 45, 25, 89, 75 };
            int n = DataSource.Length;
            int[] DataKeep = new int[n];

            Console.WriteLine("\nData Sorting");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{DataSource[i]}  ");
            }
            Console.WriteLine("\nSorted");

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < DataSource.Length; j++)
                    if (DataSource[i] > DataSource[j])//Min to Max
                    //if (DataSource[j] > DataSource[i])//Max to Min
                    {
                        int temp = DataSource[j];
                        DataSource[j] = DataSource[i];
                        DataSource[i] = temp;
                        i = 0;
                        j = i + 1;
                    }
                DataKeep[i] = DataSource[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{DataKeep[i]}  ");
            }

        }
    }
}
