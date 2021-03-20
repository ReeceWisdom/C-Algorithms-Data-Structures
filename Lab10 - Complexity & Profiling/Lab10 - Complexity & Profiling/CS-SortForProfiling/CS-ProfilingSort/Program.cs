using System;
using System.Collections.Generic;
using System.Text;

namespace CS_ProfilingSort
{
    class Program
    {
        public static void SortMethodA(int[] a)
        {
            SortMethodA(a, 0, a.Length - 1);
        }

        static void SortMethodA(int[] a, int left, int right)
        {
            int i, j;
            int x, y;
            i = left; j = right;
            x = a[(left + right) / 2];
            do
            {
                while ((a[i] < x) && (i < right)) i++;
                while ((x < a[j]) && (j > left)) j--;
                if (i <= j)
                {
                    y = a[i];
                    a[i] = a[j];
                    a[j] = y;
                    i++; j--;
                }
            } while (i <= j);
            if (left < j) SortMethodA(a, left, j);
            if (i < right) SortMethodA(a, i, right);
        }

        static public bool IsSorted(int[] a)
        {
            int prev = a[0];
            for(int i = 0; i < a.Length -1; i++)
                if (a[i] > a[i+1])
                    return false;
            return true;
        }
 
        static public void SortMethodB(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int j, tmp = a[i];
                for (j = i - 1; j >= 0 && a[j] > tmp; j--)
                {
                    a[j + 1] = a[j];
                }
                a[j + 1] = tmp;
            }
        }

        static int[] RandomArray(int arraysize)
        {
            Random randgen = new Random();
            int[] array = new int[arraysize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randgen.Next(10000);
            }
            return array;
        }
        static void ArrayCopy(int[] from, int[] to)
        {
            from.CopyTo(to, 0);
        }

        static void Main(string[] args)
        {
            int arraysize;
            if (args.Length > 0)
                arraysize = Convert.ToInt32(args[0]);
            else
                arraysize = 20000;
     
            int[] array1 = RandomArray(arraysize);
            int[] array2 = new int[arraysize];
            ArrayCopy(array1, array2);

            Console.WriteLine("Array has {0} elements", array1.Length); 
            Console.WriteLine("Array 1 is Sorted: {0}", IsSorted(array1));
            Console.WriteLine("Array 2 is Sorted: {0}", IsSorted(array2));
            
            Console.WriteLine("Sorting Using Method A");
            SortMethodA(array1);
            Console.WriteLine("Sort Using Method A Finished");
            
            Console.WriteLine("Sorting Using Method B");
            SortMethodB(array2);
            Console.WriteLine("Sort Using Method B Finished");

            Console.WriteLine("Array 1 is Sorted: {0}", IsSorted(array1));
            Console.WriteLine("Array 2 is Sorted: {0}", IsSorted(array2));

            Console.ReadKey();
        }


    }
}
