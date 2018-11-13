using System;
namespace Application 
{

//correccion del ejercicio 

    public class Segundo_trabajo
    {
        public Segundo_trabajo()
        {
            Console.WriteLine("escriba la cantidad de (*) que desee en numeros enteros");

            int numero = Convert.ToInt32(Console.ReadLine());
            String n = "";
            for (int i = 0; i < numero; i++)
            {
                n += " ";
                Console.WriteLine(n + "*");
            }
    }
}
