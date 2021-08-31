//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
           /* for (int i = 0; i<10000000; i++)
            {
                Train test = new Train($"Tren n°: {i}");
            }
            Console.WriteLine($"{Train.CantidadTrenes}");
            
        /// <summary>
        /// Se generan las 100 instancias de trenes exitosamente, pero al intentar inicializarse 10 millones, esto supera la capacidad de la memoria heap para almacenar objetos
        /// por lo que se destruyen  para hacer lugar para los nuevos, la cantidad maxima que sobrevivieron en mi caso fueron 9972287 
        /// <summary>
        */

        Train t1 = new Train ("Last Train to London");
        Train t2 = new Train ("Last Train to London");
        Train t3 = new Train ("Runaway Train");

        Console.WriteLine($"Caso 1: t1==t2: {t1==t2}");
        Console.WriteLine($"Caso 1: t3==t2: {t3==t2}");
        
        /// <summary>
        /// Ambas devuelven false: El primer caso es debido a que se crean dos objetos distintos en direcciones diferentes, por lo que a pesar de que su estado es tecnicamente el mismo,
        /// son objetos diferentes con lugares diferentes en la memoria.
        /// El segundo caso ocurre lo mismo, aunque tambien añadido que el estado de ambas instancias es diferente, pero la diferencia que provoca esta respuesta es el mismo del caso
        /// anterior.
         /// <summary>
        }

    }
}