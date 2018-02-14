using System;
using System.Globalization;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalculoAreaTrianguloSemOOP();
            CalculoAreaTrianguloComOOP();
        }



        public static void CalculoAreaTrianguloSemOOP()
        {

            double aX, bX, cX, aY, bY, cY;
            double areaX, areaY, p;
            aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p = (aX + bX + cX) / 2.0;
            areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));
            p = (aY + bY + cY) / 2.0;
            areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));
            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS");
            }

            Console.ReadLine();

        }


        public static void CalculoAreaTrianguloComOOP()
        {
            Triangulo TrianguloA, TrianguloB;
            double areaTrianguloA, areaTrianguloB;

            TrianguloA = new Triangulo();
            TrianguloB = new Triangulo();

            TrianguloA.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloA.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloA.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloB.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloB.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloB.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            areaTrianguloA = TrianguloA.CalcularArea();
            areaTrianguloB = TrianguloB.CalcularArea();

            Console.WriteLine("AREA DO TRIANGULO X: " + areaTrianguloA.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaTrianguloB.ToString("F4", CultureInfo.InvariantCulture));
            if (areaTrianguloA > areaTrianguloB)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: A");
            }
            else if (areaTrianguloB > areaTrianguloA)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: B");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS");
            }

            Console.ReadLine();
        }
    }

}
