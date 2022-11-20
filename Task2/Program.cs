//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Створіть чотири методи до виконання арифметичних операцій, з іменами: 
//    Add – додавання, Sub – віднімання, Mul – множення, Div – поділ.
//    Кожен метод повинен приймати два цілих аргументи і виводити на екран результат виконання 
//    арифметичної операції відповідної імені методу.
//    Метод поділу Div повинен виконувати перевірку спроби поділу на нуль. 
//    Потрібно надати користувачеві можливість вводити з клавіатури значення операндів та знак 
//    арифметичної операції для виконання обчислень.

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            char sign;

            GetUserData();

            switch (sign)
            {
                case '+':
                    Add(a, b);
                    break;
                case '-':
                    Sub(a, b);
                    break;
                case '*':
                    Mul(a, b);
                    break;
                case '/':
                    Sub(a, b);
                    break;
                default:
                    Console.WriteLine("Unknown sign!");
                    return;
            }

            void GetUserData()
            {
                Console.Write("Enter number first operand -> ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number second operand -> ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter sign -> ");
                sign = Convert.ToChar(Console.ReadLine());
            }

            void Add(double a, double b)
            {
                Console.WriteLine(a + b);
            }
            void Sub(double a, double b)
            {
                Console.WriteLine(a - b);
            }
            void Mul(double a, double b)
            {
                Console.WriteLine(a * b);
            }
            void Div(double a, double b)
            {
                if (b <= 0)
                {
                    Console.WriteLine("Division by 0");
                    return;
                }
                Console.WriteLine(a / b);
            }
        }
    }
}