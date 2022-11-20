//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Створіть метод з ім'ям Calculate, який приймає як параметри три цілих аргументи і 
//    виводить на екран середнє арифметичне значень аргументів.

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 integer number ->");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2 integer number ->");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3 integer number ->");
            int c = Convert.ToInt32(Console.ReadLine());

            Calculate(a, b, c);
        }
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Result = "+((a+b+c)/3));
        }
    }
}