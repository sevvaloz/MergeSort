namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //array[basIndex...sonIndex]
            int[] array = { 6, 5, 12, 10, 9, 1 };

            //fonksiyonları çağırma
            Merge merge = new Merge();
            merge.divide(array, 0, array.Length - 1);

            //diziyi sıralayıp ekrana yazdırma
            Console.WriteLine("sıralı dizi:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}

