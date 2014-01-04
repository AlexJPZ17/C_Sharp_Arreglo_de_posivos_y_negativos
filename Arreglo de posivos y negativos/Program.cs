using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_de_posivos_y_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las variables de tipo entero
            //Arreglo de 10 posiciones
            //Array unidimensional
            int[] Arreglo = new int[10];
            int Suma_positivos = 0, Suma_negativos = 0;
            Console.WriteLine("Ingrese los numeros");
            //Ciclo for que recorre el arreglo
            //length vara calcular el número de elementos del array
            for (int i = 0; i <Arreglo.Length; i++)
            {
                //Mensage que muestra la posición del arreglo
                                               //Para que inicioe en la posicion 1 no en la posicion 0
                Console.WriteLine("Numero" + (i + 1 ) + " : ");
                //Método que obtiene los datos ingresados 
                //y lo almacena en el arreglo
                Arreglo[i] = Convert.ToInt32(Console.ReadLine());
                //Condición que evalúa el arreglo
                if (Arreglo[i] > 0)
                {
                    //Operador de asignación += el significado 
                    //Suma_Positivos = Suma_Positivos + Arreglo
                    Suma_positivos += Arreglo[i];
                }
                else
                {
                    Suma_negativos += Arreglo[i];
                }
            }
            Console.WriteLine("La suma de los positivos es : " + Suma_positivos);
            Console.WriteLine("La suma de los negativos es : " + Suma_negativos);
            Console.ReadLine();
        }
    }
}
