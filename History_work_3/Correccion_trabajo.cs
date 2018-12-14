using System;
                    
namespace Application 
{
    public class Tercer_trabajo
    {   
        public static void Main()
            {   
//   -----      Primera parte        ------------------------------------------
                Console.WriteLine("digite los numeros que desee tener");
            
//   ------     Luego declaramos las variables      --------------------------- 
                Tercer_trabajo tercerTrabajo = new Tercer_trabajo();
            
//   ------     Luego incorporamos el .split         --------------------------- 
                string[] arregloLetras =Console.ReadLine().Split(',');
                tercerTrabajo.numeroMayor(arregloLetras);
            }
        
        
//   -----      Iniciacion del codigo   ------------------------------------------
        
        public void numeroMayor(string[] data)
        {
            int[] arregloNumeros = new int[data.Length];    
            for (int i = 0; i < arregloNumeros.Length; i++)
                {
                  arregloNumeros[i] = Convert.ToInt32(data [i]);
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
//   -----  Segunda parte (impriecion de *)      ------------------------------------------ 
        
         public void imprimirAsteriscos(int x)
        {
            Console.WriteLine("la ctdad en * del numero mayor son..  ");
            String n = "";
            for (int i = 0; i < x; i++)
            {
                n += " ";
                Console.WriteLine(n + "*");
            }
        }   
    }
}