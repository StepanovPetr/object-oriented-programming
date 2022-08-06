using QuickSort.Interface;

namespace QuickSort
{
    /// <summary> Сортиовка Вставками </summary>
    public class InsertionSort : ISort
    {
        public  int[] Sort(int[] array)
        {
            var newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = FindMax(array, i);
            }

            return newArray;
        }

        private static int FindMax(int[] array, int startIndex)
        {
            int max = array[startIndex];
            int maxIndex;

            for (int i = startIndex; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    var tmp = max;
                    max = array[i];
                    array[i] = tmp;
                }
            }

            return max;
        }
    }
}