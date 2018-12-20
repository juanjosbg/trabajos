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
                int first = tercerTrabajo.numeroMayor(arregloLetras);

 //   ------     Funcion de la impresion         ---------------------------        
                tercerTrabajo.imprimirAsteriscos(first);
            }
        
        
//   -----      Iniciacion del codigo   ------------------------------------------
        
        public int numeroMayor(string[] data)
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
            return firts;
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