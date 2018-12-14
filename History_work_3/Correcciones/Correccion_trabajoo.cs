using System;
                    
namespace Application 
{

    //correccion del ejercicio 

    public class Tercer_trabajo
    {
        // -----------------------------Principio, (ctdad de numeros que desee optener)------------------------------------------------------//
        public static void Main()
        {
            Console.WriteLine("digite los numeros que desee tener en numeros enteros y uno a uno");
            // Declaraacion de variables 
            Tercer_trabajo Tercer_trabajo = new Tercer_trabajo();
            Tercer_trabajo.numeroMayor();

        }

        
        // ----------------------------Tercera parte, (Escoge el numero mayor)------------------------------------------------------//
        public void numeroMayor()
        {
            
            int[] arregloNumeros = new int[4];
            string n = "";
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                arregloNumeros[i] = Convert.ToInt32(Console.ReadLine());
                n+=arregloNumeros[i].ToString() + ",";
            }
            
            string[] stringArray = new string[]{ n };
            for(int i = 0; i < stringArray.Length; i++) {
                Console.WriteLine(stringArray[i]);
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
        
        // ----------------------------Segunda parte (impriecion de *)------------------------------------------------------//
        public void imprimirAsteriscos(int x)
        {
            Console.WriteLine("la ctdad en * del numero mayor son..  ");
            String n = "";
            for (int i = 0; i < x; i++)
            {
                n += " ";
                Console.WriteLine(n + "*");
                // Console.WriteLine("\n"); - con esto los (*) van a estar separados
            }
        }


    }
}
