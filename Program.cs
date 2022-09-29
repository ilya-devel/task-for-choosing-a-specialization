using System;

namespace Program
{
    class MainProgram
    {
        static void Main()
        {

        }
        static string[] GrowArr(string[] oldArr)
        {
            int size = oldArr.Length + 10;
            string[] newArr = new string[size];
            for (int i = 0; i < oldArr.Length; i++) newArr[i]=oldArr[i];
            return newArr;
        }
        static string[] GetNewArr()
        {
            string[] arr = new string[10];
            int ind = 0;
            while (true)
            {
                Console.WriteLine("Введите значение для добавления в список, для прекращения нажмите Enter: ");
                string tmpText = Convert.ToString(Console.ReadLine())!;
                if (tmpText == string.Empty) break;
                else
                {
                    if (ind == arr.Length) arr = GrowArr(arr);
                    else
                    {
                        arr[ind] = tmpText;
                        ind++;
                    }
                }
            }
            return arr;
        }
        static void ShowArr(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length-1) Console.Write($"{arr[i]} -> ");
                else Console.Write($"{arr[i]}\n");
            }
        }
    }
}