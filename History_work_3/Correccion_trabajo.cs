using System;
namespace Application 
{

    //correccion del ejercicio 

    public class Tercer_trabajo
    {
        // -----------------------------Principio, (ctdad de numeros que desee optener)------------------------------------------------------//
        public static void Main()
        {
            Console.WriteLine("escriba la cantidad de numeros que desee tener, en numeros enteros por favor");

            // Declaraacion de variables 
            Tercer_trabajo Tercer_trabajo = new Tercer_trabajo();
            int x = Convert.ToInt32(Console.ReadLine());
            Tercer_trabajo.numeroMayor(x);

        }

        // ----------------------------Segunda parte (impriecion de *)------------------------------------------------------//
        public void imprimirAsteriscos(int x)
        {
            String n = "";
            for (int i = 0; i < x; i++)
            {
                n += " ";
                Console.WriteLine(n + "*");
                // Console.WriteLine("\n"); - con esto los (*) van a estar separados
            }
        }

        // ----------------------------Tercera parte, (Escoge el numero mayor)------------------------------------------------------//
        public void numeroMayor(int x)
        {
            int[] arregloNumeros = new int[x];
            Console.WriteLine("dentro de esa cantidad escriba los numeros que desee");
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                arregloNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // ----------------------------(muestra los * en la ctdad del numero mayor)------------------------------------------------------//
            Console.WriteLine("la ctdad en * del numero mayor son..  ");
            for (int i = 0; i < arregloNumeros.Length; i++) {
            //Console.WriteLine(rregloNumeros.Length[i]);
            }

            int firts = arregloNumeros[0];
            for (int i = 1; i < arregloNumeros.Length; i++)
            {
                if (arregloNumeros[i] > firts)
                {
                    firts = arregloNumeros[i];
                }
            }

            this.imprimirAsteriscos(firts);

        }

    }
}
