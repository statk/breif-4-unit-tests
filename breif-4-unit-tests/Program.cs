using System;

namespace breif_4_unit_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessLogic = new BusinessLogic(2, 2);
            var sumResult = businessLogic.CalculateSum();
            var multipleResult = businessLogic.CalculateMultiplication();

            Console.WriteLine("Какую операцию вывести?: \n" +
                "1: Сложение; \n" +
                "2: Умножение;\n");
            var operationId = int.Parse(Console.ReadLine());
            switch (operationId)
            {
                case 1: Console.WriteLine($"\n Сумма чисел равна {sumResult}"); break;
                case 2: Console.WriteLine($"\n Произведение чисел равно {sumResult}"); break;
                default:
                    Console.WriteLine($"\n Нет такой операции"); break;
            }
            Console.ReadKey();
        }
    }
}
