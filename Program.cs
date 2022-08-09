// Задача: Написать программу, которая из имеющегося массива строк формирует массив из сторок,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользвоваться колекциями,
// лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

namespace VerificationTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите строки через пробел");
            string? str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                PrintLessThanThreeCharactersStrings(str);
            }
            else
            {
                Main(new string[] { "" });
            }
        }
        public static void PrintLessThanThreeCharactersStrings(string str)
        {
            string[] arrayStrings = str.Split(' ');
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                string element = Convert.ToString(arrayStrings[i]).Replace(" ", "");
                if (element.Length <= 3 && element.Length > 0)
                {
                    Console.Write($"[{element}] ");
                }
            }
        }
    }
}
