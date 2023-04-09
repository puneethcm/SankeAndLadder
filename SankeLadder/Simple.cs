using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace SankeLadder
{
	public class Simple
	{
		public void SimpleDemo()
		{
			List<int> list = new List<int>();
			list.Add(10);
            list.Add(20);
            list.Add(30);

            //string[] array = list.ToArray();
            //foreach(string i in array)
            //{
            //	Console.WriteLine(i);
            //}
            //list.Reverse();
            //foreach (string i in list)
            //{
            //	Console.WriteLine(i);
            //}
            //int n = list.Count;

            for (int i = list.Count - 1;i>=0;i--)
            {
                Console.WriteLine(list[i]);
            }
            
        }

		public static void ReverseArray()
		{
			int[] array = { 10, 20, 30 };

			for (int i = array.Length - 1; i >= 0; i--)
			{
				Console.Write(array[i] + " ");
			}
		}

        public static void DecSortedList()
        {
            SortedList<int, int> sort = new SortedList<int, int>();
            sort.Add(1,10);
            sort.Add(3, 30);
            sort.Add(2, 20);
            sort.Add(4, 40);

            foreach (KeyValuePair<int, int> element in sort)
            {
                Console.WriteLine("key: " + element.Key + " and Value: " + element.Value);
            }

            //for (int i = sort.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("key: " + sort.Keys[i] + " and Value: " + sort.Values[i]);
            //}
        }

        public static void Duplicate()
        {
            int[] array = { 10, 2, 3, 2, 4, 5, 6, 6, 5, 7 };
            var square = array.Select(x => x);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            Console.WriteLine(array[j]);
            //        }
            //    }
            //}
            foreach(int value in square)
            {
                Console.WriteLine(value);
            }

        }
    }
}

