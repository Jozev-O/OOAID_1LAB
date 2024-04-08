namespace OOAID_2LAB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка вставками");
            Console.Write("Введите элементы массива: ");
            string[] parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = [.. parts.Select(int.Parse)];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", InsertionSort(array)));

            Console.ReadLine();
        }
        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            (e2, e1) = (e1, e2);
        }

        //сортировка вставками
        public static int[] InsertionSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 0) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;
        }
    }
}