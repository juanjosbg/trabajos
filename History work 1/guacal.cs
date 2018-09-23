// medidas de los perros y los precios de guacales 

 // perro 1 = Cosmo
//Alto = 14 + 7 = 21; Largo 26+4= 30; Ancho 26+4= 30;   ----> Se le pone mas para la movilidada del per

 //perro 2 = Ruffo
//Alto = 13 + 5 = 18; Largo 19,5+14= 33.5; Ancho 6+4= 10; ----> Todas las medics van en Cm

//(Precio Guacal Para Perro(guacal 0 ) "en el Avion 45largo, 60alt, 60alto"= 129.900)
//(Precio Guacal Para Perro(guacal 1 ) "en el Avion 60largo, 40alt, 40alto"= 189.900)
//(Precio Guacal Para Perro(guacal 2 ) "en el Avion 80largo, 55alt, 57alto"= 335.000)

//-----------------------------------------------------------------------------------------------------
using System;
 

// Queremos calcular mediante las medias el tipo de guacal que le sirve al perro (cosmo, ruffo)
public namesdog;
{
    double cosmo;
    double ruffo; 
}

int lenght = 0;
int widt = 0;
int height = 0;

public static double namesdog (void) (string lenght, string width, string height)
{
    return length* width * height;
}

if (namesdog.Equals(""))
        {
        if (namesdog.Equals("las medidas del perro"))
        lenght = 30;
        width = 30;
        height = 21;

    console.writeline(height* width* lenght);
            {






// inicio del codigo para calcular el volumen

public static double Get.Volume(double length, double width, double height)
{
   // para calcular el rectangulo
    return length * width * height;
}


static void Main()
{
    Console.WriteLine("Volume Calculator\n-----------------");

    string[] input;    
    double dimension;  
    double volume;     
    // Get input from user
    do
    {
        Console.Write("Enter a comma-separated list of 1 to 3 numeric dimensions: ");
        input = Console.ReadLine().Split(new[] { ',' },
            StringSplitOptions.RemoveEmptyEntries);
    }
    while (input.Length < 1 || input.Length > 3 ||
           input.Any(i => !double.TryParse(i, out dimension)));


    // Call appropriate method based on number of dimensions and output results to user
    switch (input.Length)
    {  
            volume = GetVolume(double.Parse(input[0]), double.Parse(input[1]),
                double.Parse(input[2]));
            Console.WriteLine($"The volume of the Rectangle is: {volume}");
            break;
    }

    Console.Write("\nDone!\nPress any key to exit...");
    Console.ReadKey();
}