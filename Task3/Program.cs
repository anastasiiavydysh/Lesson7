//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Напишіть програму, яка буде конвертувати валюти. Користувач вводить: суму грошей у певній валюті.
//    курс конвертації в іншу валюту. 
//    Організуйте виведення результату операції конвертування валюти на екран.

namespace Task3
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            decimal sum = 0, currency = 0;
            GetUserData(ref sum, ref currency);
            ReturnResult(sum, currency);
        }

        static void GetUserData(ref decimal sum, ref decimal currency)
        {            
            while (sum <= 0 || currency <= 0)
            {
                Console.Write("Enter sum in your currency (> 0) -> ");
                sum = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter currency (> 0) -> ");
                currency = Convert.ToDecimal(Console.ReadLine());
            }
        }

        static void ReturnResult(decimal sum, decimal currency)
        {
            Console.WriteLine("Result = " + (sum * currency));
        }

    }
}