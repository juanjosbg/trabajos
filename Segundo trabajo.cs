using System;
namespace Application
{
    public class Segundo_trabajo
    {
        public Segundo_trabajo()
        {
            Console.WriteLine("escriba la cantidad que desee en numeros enteros");

            int numero = (Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    for (int j = 1; j <= i - 1; j++)
                    {
                        Console.WriteLine(".");
                    }
                    Console.WriteLine("*");
                }
            }
        }
    }
}
