namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //array[basIndex...sonIndex]
            int[] array = { 4, 1, 0, 7, 7, 2, 9 };

            //fonksiyonları çağırma
            Merge merge = new Merge();
            merge.divide(array, 0, array.Length - 1);

            //diziyi sıralayıp ekrana yazdırma
            Console.Write("sıralı dizi: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

