using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57consolaversion02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombrePersona, mayorPersona = null, menorPersona = null;
            int edadPersona, cantidadPersonas, mayorEdad = 0, menorEdad = 150;
            double promedioEdades = 0;
            int personasEntre25y40 = 0;

            Console.WriteLine("Calcule el mayor, menor y el promedio de edades");
            Console.Title = "EDADES";
            do
            {
                Console.Write("Ingrese la cantidad de personas a calcular:  ");
                if (!int.TryParse(Console.ReadLine(), out cantidadPersonas));
                {
                    Console.WriteLine("ERROR: Número mal ingresado");
                }
                if (cantidadPersonas<=0)
                {
                    Console.WriteLine("ERROR: Se debe ingresar un valor superior a 0");
                }
                else
                {
                    break;
                }
            } while (true);
            

            for (int contador = 1; contador < cantidadPersonas + 1; contador++)
            {
                do
                {
                    Console.Write($"Ingrese el nombre de la {contador}° persona: ");
                    nombrePersona = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nombrePersona) && !string.IsNullOrWhiteSpace(nombrePersona))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El nombre de la persona es requerido");
                    }
                } while (true);
                do
                {
                    Console.Write($"Ingrese la edad de {nombrePersona}:  ");
                    if (!int.TryParse(Console.ReadLine(), out edadPersona))
                    {
                        Console.WriteLine("ERROR: Número mal ingresado");
                    }
                    else if (edadPersona <= 0)
                    {
                        Console.WriteLine("ERROR: El valor debe ser superior a 0");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                if (edadPersona > mayorEdad)
                {
                    mayorPersona = nombrePersona;
                    mayorEdad = edadPersona;
                }

                if (edadPersona < menorEdad)
                {
                    menorPersona = nombrePersona;
                    menorEdad = edadPersona;
                }

                if (edadPersona > 25 && edadPersona < 40)
                {
                    personasEntre25y40 = personasEntre25y40 + 1;
                }
                promedioEdades = promedioEdades + edadPersona;
            }
            Console.Clear();
            promedioEdades = promedioEdades / cantidadPersonas;
            Console.WriteLine($"La persona de menor edad es {menorPersona} con {menorEdad}");
            Console.WriteLine($"La persona de mayor edad es {mayorPersona} con {mayorEdad}");
            Console.WriteLine($"El promedio de edades es de {promedioEdades}");
            Console.WriteLine($"La cantidad de personas entre 25 y 40 años es {personasEntre25y40}");
            Console.ReadLine();
        }
    }
}
