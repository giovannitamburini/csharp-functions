using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }









        // FUNZIONI -------------------------------------------

        // funzione generica per stampare un array
        static void PrintArray(int[] array)
        {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
            Console.WriteLine("]");
        }

        // funzione che restituisce il quadrato del numero che gli passiamo
        public static int NumberSquared(int number)
        {
            int numberMultipliedByItself = number * number;
            return numberMultipliedByItself;
        }

        // funzione per elevare al quadrato gli elementi di un array che passiamo alla funzione
        public static int[] SquareOfTheArrayElements(int[] array)
        {
            int[] arraySquered = (int[])array.Clone();

            for (int i = 0; i < arraySquered.Length; i++)
            {
                arraySquered[i] = NumberSquared(arraySquered[i]);
            }

            return arraySquered;
        }

        // funzione per sommare il valore di tutti gli elementi dell'array che gli passo
        public static int SumArrayElements(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}