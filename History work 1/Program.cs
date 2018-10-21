﻿using System;

namespace MyPrimaryCode
{
    class Program
    {

        static void Main(string[] args)
        {

            //Solicitamos valores
            Console.WriteLine("------Sistema para calcula el guacal de tu perro, para esto necesitaremos unos valores, ingresalos por favor------");

            Console.WriteLine("Ingresa el nombre de tu perro:");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el alto en cm y sin puntos de su perro:");
            int alto = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el ancho en cm y sin puntos de su perro:");
            int ancho = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el largo en cm y sin puntos de su perro:");
            int largo = Convert.ToInt32(Console.ReadLine());


            //Cumplimos politicas
            alto = alto + 5;
            ancho = ancho + 5;
            largo = largo + 5;



            //calculamos el volumen del guacal segun el perro con el espacio adecuado para el.
            double volumen = CalcularVolumen(largo, ancho, alto);
           
            if (volumen <= 100){ //Guacal pequeno
                //El perro nombre se le asigna un guacal pequeño el cual tiene un volumen volumen y su precio es 60.000.
                Console.WriteLine("El guacal para el perro " + nombre + "es un guacal pequenio de precio 60.000 debido a que su volumen es de " + volumen);
            }
            else if(volumen > 100 && volumen <= 150){ //Guacal Mediano.

                Console.WriteLine("El guacal para el perro " + nombre + "es un guacal mediano de precio 120.000 debido a que su volumen es de " + volumen);

            }
            else if(volumen > 150 && volumen <= 250 ) { //Guacal Grande.

                Console.WriteLine("El guacal para el perro " + nombre + "es un guacal grande de precio 200.000 debido a que su volumen es de " + volumen);

            }
            else if(volumen > 250){ //Guacal Personalizado.
                Console.WriteLine("El guacal para el perro " + nombre + "es un guacal personalizado de precio 350.000 debido a que su volumen es de " + volumen);
            }

        }

        public static double CalcularVolumen(double largo, double ancho, double alto)
        {
            // Do calculation for a rectangle
            return largo * ancho * alto; //Si esta mala la formula se cambia aca y se pone la formula que este buena con estas variables 
        }
    }
}

