using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             Console.WriteLine("Hola Unai ");
             Console.WriteLine("Hola Unai " + (4 + 4));
             double num1 = 6.0 / 5;
             Console.WriteLine(num1);
             Console.WriteLine(6.0 / 5);

             decimal num2 = -5 + (8 * 6),  num3 = (55 + 9) % 9,  num4 = 20 + ((-3 * 5) / 8),  num5 = 5 + (15 / 3) * 2 - 8 % 3;

             Console.WriteLine(num2 + " " + num3 + " " + num4 + " " + num5);

             //EJERCICIO 5

             Console.WriteLine("Escribe un número");
             int num6, num7;

             num6 = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Escribe otro número");

             num7 = Int32.Parse(Console.ReadLine());

             Console.WriteLine("La multiplicacion entre " + num6 + " y " + num7 + " es: " + (num6 * num7));

             // EJERCICIO 6
             Console.WriteLine("Escribe un número");
             decimal num8, num9;

             num8 = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Escribe otro número");

             num9 = Int32.Parse(Console.ReadLine());

             Console.WriteLine("La suma es " +  (num8 + num9));
             Console.WriteLine("La resta es " + (num8 - num9));
             Console.WriteLine("La multiplicación es " + (num8 * num9));
             Console.WriteLine("La division es " + (num8 / num9));
             Console.WriteLine("El resto de la división es " + (num8 % num9));


             //EJERCICIO 7

             Console.WriteLine("Escribe un número");
             int num10;
             num10 = Int32.Parse(Console.ReadLine());
             Console.WriteLine( num10 + " *  1 = " + num10 * 1);
             Console.WriteLine( num10 + " *  2 = " + num10 * 2);
             Console.WriteLine( num10 + " *  3 = " + num10 * 3);
             Console.WriteLine( num10 + " *  4 = " + num10 * 4);
             Console.WriteLine( num10 + " *  5 = " + num10 * 5);
             Console.WriteLine( + num10 + " *  6 = " + num10 * 6);
             Console.WriteLine( + num10 + " *  7 = " + num10 * 7);
             Console.WriteLine( + num10 + " *  8 = " + num10 * 8);
             Console.WriteLine( + num10 + " *  9 = " + num10 * 9);

             //EJERCICIO 8
             Console.WriteLine(" El resultado de (25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)= " + (25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));

             //EJERCICIO 9
             Console.WriteLine("El resultado de 4.0 * (1 - (1.0/3) + (1.0/5) - (1.0/7) + (1.0/9) - (1.0/11)) = " + 4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11)));

             //EJERCICIO 10
             Console.WriteLine("Escribe el radio del círculo: ");
             double num11;
             num11 = Int32.Parse(Console.ReadLine());
             Console.WriteLine("El area del circulo es: " + (num11 * num11) * 3.14);
             Console.WriteLine("El perimetro del circulo es: " + 2 * num11 + 3.14);
             Console.ReadLine();
             
             
             //EJERCICIO 11
             Console.WriteLine("Escribe un número:");
             decimal num12, num13, num14;
             num12 = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Escribe otro número:");
             num13 = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Escribe el último número:");
             num14 = Int32.Parse(Console.ReadLine());
             Console.WriteLine("La media es " + (num12 + num13 + num14) / 3);
             Console.ReadLine();
         

            //EJERCICIO 12

            Console.WriteLine("Escriba la anchura del rectangulo:");
            decimal anchuraRectangulo, alturarectangulo;
            anchuraRectangulo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del rectangulo:");
            alturarectangulo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("EL area del rectangulo es " + alturarectangulo * anchuraRectangulo + " y su perimetro es " + (alturarectangulo + anchuraRectangulo) * 2);
            Console.ReadLine();
        

            //EJERCICIO 13

            Console.WriteLine("escribe un valor:");
            int valor1, valor2, valor3;
            valor1 = Int32.Parse(Console.ReadLine());
            valor3 = valor1;
           Console.WriteLine("escribe otro valor:");
            valor2 = Int32.Parse(Console.ReadLine());
            valor1 = valor2;
            valor2 = valor3;
            Console.WriteLine("ahora el primer valor es:" + valor1);
          
            Console.WriteLine("ahora el segundo valor es:" + valor2);

            Console.ReadLine();

        
            //EJERCICIO 14
            Console.WriteLine("Escribe tres numeros:");
            int num13;
            num13 = Int32.Parse(Console.ReadLine());
        
            Console.WriteLine(num13 % 10 + num13%100 + num13%1000);

            Console.ReadLine();
        

            //EJERCICIO 15
            Console.WriteLine("Escribe un numero");
            int num14, num15, num16;
            num14 = Int32.Parse(Console.ReadLine());
            num15 = (num14 * 10) + num14;
            num16 = (num14 * 100) + num15;
            Console.WriteLine(num14 + num15 + num16);
            Console.ReadLine();
        
           

            //EJERCICIO 16

            Console.WriteLine("Escribe un numero");
            int num16;
            num16 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num16);
            Console.ReadLine();

            //EJERCICIO 17

            Console.WriteLine("Escribe un número");
            int num17, num18;
            num17 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro número");
            num18 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num17-num18);
            

            Console.ReadLine();

        
            //EJERCICIO 18

            Console.WriteLine("Escribe un número en pulgadas");
            int num19;
            num19 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("son " + num19 * 0.0254 + " metros");
            Console.ReadLine();

        

            //EJERCICIO 19
            Console.WriteLine("Escribe los minutos");
            int minutos;
            minutos = Int32.Parse(Console.ReadLine());
            Console.WriteLine(minutos + " minutos son " + minutos/1440 + " días o " + minutos/525600.0 + " años");
            Console.ReadLine();

        

            //EJERCICIO 20
            Console.WriteLine("Escribe los metros");
            int metros, horas, minutos, segundos;
            metros = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe las horas");
            horas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe los minutos");
            minutos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe los segundos");
            segundos = Int32.Parse(Console.ReadLine());

            Console.WriteLine(metros / (horas * 3600.0 + minutos * 60 + segundos) + " m/s " + (metros / 1000) / (horas + minutos / 60 + segundos / 3600.0) + "km/h");

            Console.ReadLine();

        
            //EJERCICIO 21

            Console.WriteLine("Escribe dos números");
            int num20, num21;
            num20 = Int32.Parse(Console.ReadLine());
            num21 = num20 % 10;
            Console.WriteLine((num20+num21) + " " + (num20-num21) + " " + (num20*num21) + " "+ (num21+num20)/2);
            Console.ReadLine();

        */

            //EJERCICIO 22

            Random r = new Random();

            //Genera un numero entre 0 y 100 
            Console.WriteLine(r.Next(0, 101));

            Console.ReadLine();









        }
    }
}
