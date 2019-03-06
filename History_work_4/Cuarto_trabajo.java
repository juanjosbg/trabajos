import java.util.*;
import javax.swing.JOptionPane;

public class Main {


    public int numeroMayor(int longitud)
        {
            int[] arregloNumeros = new int[longitud];
            for (int i = 0; i < arregloNumeros.length; i++)
                {
                  arregloNumeros[i] = Integer.parseInt(JOptionPane.showInputDialog(null, "Ingresar los datos"));
                }

            int firts = arregloNumeros[0];
            for (int i = 1; i < arregloNumeros.length; i++)
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
            System.out.print("la ctdad en * del numero mayor son..  ");
            String n = "";
            for (int i = 0; i < x; i++)
            {
                n += " ";
                System.out.print(n + "*");
            }
        }


    public static void main(String[] args) throws Exception {
                System.out.print("digite los numeros que desee tener");

//   ------     Luego declaramos las variables      ---------------------------
                Main cuarto_Trabajo = new Main();

//   ------     Luego incorporamos el .split         ---------------------------
                // String[] arregloLetras = System.out.print().Split(',');
                int longitud = Integer.parseInt(JOptionPane.showInputDialog(null, "Ingresar los datos"));
                int first = cuarto_Trabajo.numeroMayor(longitud);

 //   ------     Funcion de la impresion         ---------------------------
                cuarto_Trabajo.imprimirAsteriscos(first);
    }
