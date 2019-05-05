/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.complemento_juan;

import java.util.Scanner;

public class Main 
{
    
   public static void main(String[] args) {

        //   -----      Primera parte        ------------------------------------------
        Scanner teclado = new Scanner(System.in);
        System.out.println("digite los numeros que desee tener");
        String numeros = teclado.nextLine();
        
        // ----- incorporamos split---------------------------------        
        String[] arregloLetras = numeros.split(",");
        int first = numeroMayor(arregloLetras);

        //--------- funcion de la impresion-----------------
        imprimirAsteriscos(first);
    }

    public static int numeroMayor(String[] data){
        int[] arregloNumeros = new int[data.length];
            for (int i = 0; i < arregloNumeros.length; i++) {
                arregloNumeros[i] = Integer.parseInt(data[i]);

            }
        int firts = arregloNumeros[0];
            for (int j = 1; j < arregloNumeros.length; j++)
            {
                if (arregloNumeros[j] > firts)
                {
                    firts = arregloNumeros[j];
                }
                
            }
            return firts;
    }

 //   -----  Segunda parte (impriecion de *)      ------------------------------------------ 
    public static void imprimirAsteriscos(int x){
        
            System.out.println("la ctdad en * del numero mayor son..  ");
            String n = "";
            for (int i = 0; i < x; i++)
            {
                n += " ";
                System.out.println(n + "*");
            }
        
    } 
}
