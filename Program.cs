using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores_y_tiempo_de_ejecucion
{
    
        class Program
        {
            static void Main(string[] args)
            {
                int size;

                Console.Write("Ingrese el tamaño del vector: ");
                size = int.Parse(Console.ReadLine());

                // Creación de un vector en tiempo de ejecución
                int[] vector = new int[size];

                // Inicialización del vector
                for (int i = 0; i < size; i++)
                {
                    vector[i] = i * 2;
                }

                // Imprimir el contenido del vector
                Console.WriteLine("Contenido del vector:");
                foreach (int num in vector)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }

