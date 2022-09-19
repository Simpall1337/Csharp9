using System;
namespace Lessons
{
    internal class Program
    {
        static void foo(ref int[] myArray, int index)
        {
            int[] newArray = new int[myArray.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = index + 1; i < myArray.Length; i++)
            {
                newArray[i - 1] = myArray[i];
            }
            myArray = newArray;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[6] { 1, 2, 3, 4, 5, 6 }; // Создание массива 
            for (int i = 0; i < myArray.Length; i++) // Заполнение масива
            {
                myArray[i] = random.Next(100);
            }
            Console.Write("Наш массив : ");
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++) // вывод масива
            {
                Console.WriteLine(myArray[i]);
            }
            Console.Write("Введите елемент который хотите удалить : ");
            int index = int.Parse(Console.ReadLine());
            foo(ref myArray, index); // вызов метода 
            for (int i = 0; i < myArray.Length; i++) // вывод масива
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}