using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._23_class
{
    internal class Program
    {
        /*Создайте интерфейс IOutput.В нём должно быть два
метода:
■ void Show() — отображает информацию;
■ void Show(string info) — отображает информацию и
информационное сообщение, которое было указано
в параметре info.
Создайте класс Array (массив целого типа) с необходимыми методами.Этот класс должен имплементировать
интерфейс IOutput.
Метод Show() — отображает на экран элементы массива.
Метод Show(string info) — отображает на экран элементы массива и информационное сообщение, указанное
в параметре info.
Напишите код для тестирования полученной функциональности.
       
        Создайте интерфейс IMath. В нём должно быть четыре метода:
■ int Max() — возвращает максимум;
■ int Min() — возвращает минимум;
Практическое задание
1
■ float Avg() — возвращает среднеарифметическое;
■ bool Search(int valueToSearch) — ищет valueSearch
внутри контейнера данных. Возвращает true, если 
значение найдено. Возвращает false, если значение 
не найдено.
Класс, созданный в первом задании Array, должен 
имплементировать интерфейс IMath. 
Метод Max — возвращает максимум среди элементов 
массива.
Метод Min — возвращает минимум среди элементов 
массива.
Метод Avg — возвращает среднеарифметическое 
среди элементов массива.
Метод Search — ищет значение внутри массива. Возвращает true, если значение найдено. Возвращает false, 
если значение не найдено.
Напишите код для тестирования полученной функциональности

        Создайте интерфейс ISort. В нём должно быть два 
метода
■ void SortAsc() — сортировка по возрастанию;
■ void SortDesc() — сортировка по убыванию;
■ void SortByParam(bool isAsc) — сортировка в зависимости от переданного параметра. Если isAsc равен 
true, сортируем по возрастанию. Если isAsc равен false, 
сортируем по убыванию.
Практическое задание
2
Класс, созданный в первом задании Array, должен 
имплементировать интерфейс ISort. 
Метод SortAsc — сортирует массив по возрастанию.
Метод SortDesc — сортирует массив по убыванию.
Метод SortByParam — сортирует массив в зависимости 
от переданного параметра. Если isAsc равен true, сортируем по возрастанию. Если isAsc равен false, сортируем 
по убыванию.
Напишите код для тестирования полученной функциональности.
*/
        interface ISort
        {
            void SortAsc();
            void SortDesc();
            void SortByParam(bool isAsc);
        }
        interface IMath
        {
            int Max();
            int Min();
            float Avg();
            bool Search(int valueToSearch);

        }
        interface IOutput
        {
            void Show();
            void Show(string info);

        }
        class MyArray : IOutput, IMath, ISort
        {
            int[] array = new int[10];
            public MyArray() { }
            public MyArray(int[] array)
            {
                this.array = array;
            }
            public void SortAsc()
            {
                Array.Sort(array);
            }
            public void SortDesc()
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
            public void SortByParam(bool isAsc)
            {
                if (isAsc)
                {
                    SortAsc();
                }
                else
                {
                    SortDesc();
                }
            }
            public int Min()
            {
                int min = array[0];
                foreach(int i in array)
                {
                    if(i < min)
                    {
                        min = i;
                    }
                }
                return min;
            }
            public int Max()
            {
                int max = array[0];
                foreach (int i in array)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return max;
            }
            public float Avg()
            {
                int sum = 0;
                foreach (int i in array)
                { 
                    sum+= i;
                }
                return sum/array.Length;
            }
            public bool Search(int valueTosearch)
            {
                return array.Contains(valueTosearch);
            }
            public void Show()
            {
                foreach (int i in array)
                {
                    Console.Write(i);
                }
            }
            public void Show(string info)
            {
                foreach(int i in array)
                {
                    Console.Write(i);
                    Console.Write($" {info}");
                }
            }

        }
        static void Main(string[] args)
        {
            int[] ints = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyArray array= new MyArray(ints);
            array.Show();
            Console.WriteLine();
            array.Show("вот так ");
            Console.WriteLine();
            Console.WriteLine(array.Search(1));
            Console.WriteLine(array.Avg());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            array.SortAsc();
            array.Show();
            Console.WriteLine();
            array.SortDesc();
            array.Show();
            Console.WriteLine();
        }
    }
}
