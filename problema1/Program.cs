using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("Ingrese el número de pesos a analizar (máximo 300): ");
            Console.WriteLine("====================================================");
            int numPersonas = int.Parse(Console.ReadLine());

            if (numPersonas <= 0 || numPersonas > 300)
            {
                Console.WriteLine("Número de personas no válido. Debe estar entre 1 y 300.");
                return;
            }

            float[] pesos = new float[numPersonas];
            int menor60Kg = 0;
            int mayor100Kg = 0;
            float sumaPesos = 0.0f;
            float sumaPromedio = 0.0f;

            for (int i = 0; i < numPersonas; i++)
            {
                Console.WriteLine($"Ingrese el peso de la persona {i + 1} en kilogramos: ");
                pesos[i] = float.Parse(Console.ReadLine());
                sumaPesos += pesos[i];

                if (pesos[i] < 60)
                {
                    menor60Kg++;
                }
                else if (pesos[i] > 100)
                {
                    mayor100Kg++;
                }
            }

            sumaPromedio = sumaPesos / (float)numPersonas;
            Console.WriteLine("====================================================");
            Console.WriteLine($"La suma de los pesos es: {sumaPesos} Kg");
            Console.WriteLine($"El promedio de todos los pesos es de: {sumaPromedio.ToString("0.00")} Kg");
            Console.WriteLine($"Personas con menos de 60 Kg: {menor60Kg}");
            Console.WriteLine($"Personas con más de 100 Kg: {mayor100Kg}");
            Console.ReadKey();
        }
    }
}
