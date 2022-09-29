using System;

namespace Program
{
    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("--Данная программа запрашивает массив строковых элементов--\n");
            Console.WriteLine("Заполните массив\n");
            string[] arr = GetNewArr();
            Console.WriteLine("Создан массив:");
            ShowArr(arr);
            Console.WriteLine();
            int choiceLen = GetLengthElements();
            Console.WriteLine();
            Console.WriteLine("Ниже указан результат выборки");
            string[] newArr = ChoiceValuesInArr(arr, choiceLen);
            ShowArr(newArr);
        }
        static string[] GrowArr(string[] oldArr)
        {
            string[] newArr = new string[oldArr.Length + 1];
            for (int i = 0; i < oldArr.Length; i++) newArr[i]=oldArr[i];
            return newArr;
        }
        static string[] GetNewArr()
        {
            string[] arr = new string[0];
            int ind = 0;
            while (true)
            {
                Console.WriteLine("Введите значение для добавления в список, для прекращения нажмите Enter: ");
                string tmpText = Console.ReadLine()!;
                if (tmpText == string.Empty) break;
                else
                {
                    if (ind == arr.Length) arr = GrowArr(arr);
                    arr[ind] = tmpText;
                    ind++;
                }
            }
            return arr;
        }
        static void ShowArr(string[] arr)
        {
            if (arr.Length == 0) Console.WriteLine("Массив пуст");
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length-1) Console.Write($"{arr[i]} -> ");
                    else Console.Write($"{arr[i]}\n");
                }
            }
        }
        static string[] ChoiceValuesInArr(string[] arr, int choiceLength)
        {
            string[] newArr = new string[0];
            int ind = 0;
            for (int i = 0 ; i < arr.Length; i++)
            {
                if (arr[i].Length <= choiceLength)
                {
                    if (ind == newArr.Length) newArr = GrowArr(newArr); 
                    newArr[ind] = arr[i];
                    ind++;
                }
            }
            return newArr;
        }
        static int GetLengthElements()
        {
            Console.WriteLine("Введите длину элементов для выборки (по умолчанию: 3): ");
            bool checking = int.TryParse(Console.ReadLine(), out int size);
            if (!checking) size = 3;
            return size;
        }
    }
}