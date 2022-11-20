//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Напишіть метод, який визначатиме: 
//    1) чи є введене число позитивним чи негативним. 
//    2) Чи є воно простим (використовуйте техніку перебору значень). 
//    (Просте число - це натуральне число, яке ділиться на 1 і саме на себе. 
//    Щоб визначити просте число чи ні, слід знайти всі цілі дільники. 
//    Якщо дільників більше 2-х, значить воно не просте.) 
//    3) Чи ділиться на 2 , 5, 3, 6, 9 без залишку. 

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your integer number -> ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чи є введене число позитивним - " + (IsPositive(number)?"Так":"Ні"));
            Console.WriteLine("Чи є воно простим - " + (IsPrime(number) ? "Так" : "Ні"));
            Console.WriteLine("Чи ділиться на 2 , 5, 3, 6, 9 без залишку - " + (IsDivise(number) ? "Так" : "Ні"));
        }
        static bool IsPositive(int number)
        {
            return (number >= 0);
        }
        static bool IsPrime(int number)
        {
            int flag = 0;
            for(int i = 1; i<=number; i++)
            {
                if(number%i==0)
                    flag++;
            }
            return (flag == 2);
        }
        static bool IsDivise(int number)
        {
            return (number % 2 == 0 && number % 5 == 0 && number % 3 == 0 && number % 6 == 0 && number % 9 == 0);
        }
    }
}