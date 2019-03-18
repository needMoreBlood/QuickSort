using System;

namespace ClassLibrary5
{
    public class Class1
    {
        public static void HoareSort(int[] array, int start, int end)
        {
            if (end == start) return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }

        public static void QuickSort(int[] array)
        {
            if (array.Length != 0)
                HoareSort(array, 0, array.Length - 1);
        }

        static Random random = new Random();

        public static int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            return array;
        }

        public static void Main()
        {
            var array = GenerateArray(10);
            QuickSort(array);
            foreach (var e in array)
                Console.WriteLine(e);
        }
    }
}
