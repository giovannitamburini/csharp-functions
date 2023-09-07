﻿using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] originalArray = { 2, 6, 7, 5, 3, 9 };

            // stampo a video l'array che gli passo, in questo caso "originalArray"
            Console.Write("Array originale di numeri interi: ");
            PrintArray(originalArray);

            // salvo in una variabile l'array originale con gli elementi elevati al quadrato
            int[] squaredArray = SquareOfTheArrayElements(originalArray);

            // stampo a video il nuovo array, cioè l' originalArray ma con gli elementi al suo interno elevati al quadrato
            Console.Write("Array originale con gli elementi elevati al quadrato: ");
            PrintArray(squaredArray);

            // controllo che l'array originale non sia stato modificato
            Console.Write("Controllo se l'array originale è stato modificato: ");
            PrintArray(originalArray);

            // salvo in una variabile integer la somma dei numeri dell'array originale
            int sumOriginalArrayElements = SumArrayElements(originalArray);
            // stampo a video la somma di tutti i numeri facenti parte dell'array originale
            Console.WriteLine($"Somma dei numeri dell'array originale: {sumOriginalArrayElements}");

            // salvo in una variabile integer la somma dei numeri dell'array al quadrato
            int sumSquaredArrayElements = SumArrayElements(squaredArray);
            // stampo a video la somma di tutti i numeri facenti parte dell'array con gli elementi elevati al quadrato
            Console.WriteLine($"Somma dei numeri dell'array quadrato: {sumSquaredArrayElements}");


            // BONUS -------------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("BONUS -------------------------");

            Console.Write("Da quanti elementi vorresti che il tuo array di numeri interi fosse composto? ");
            int numberOfArrayElements = int.Parse(Console.ReadLine());

            int[] userArray = new int[numberOfArrayElements];

            for (int i = 0; i < numberOfArrayElements; i++)
            {
                Console.Write($"Inserisci il {i + 1}° elemento del tuo array: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Il tuo array: ");
            PrintArray(userArray);

            // salvo in una variabile l'array originale con gli elementi elevati al quadrato
            int[] squaredUserArray = SquareOfTheArrayElements(userArray);

            // stampo a video il nuovo array, cioè l' originalArray ma con gli elementi al suo interno elevati al quadrato
            Console.Write("Array originale con gli elementi elevati al quadrato: ");
            PrintArray(squaredUserArray);

            // controllo che l'array originale non sia stato modificato
            Console.Write("Controllo se l'array originale è stato modificato: ");
            PrintArray(userArray);

            // salvo in una variabile integer la somma dei numeri dell'array originale
            int sumUserArrayElements = SumArrayElements(userArray);
            // stampo a video la somma di tutti i numeri facenti parte dell'array originale
            Console.WriteLine($"Somma dei numeri dell'array originale: {sumUserArrayElements}");

            // salvo in una variabile integer la somma dei numeri dell'array al quadrato
            int sumSquaredUserArrayElements = SumArrayElements(squaredUserArray);
            // stampo a video la somma di tutti i numeri facenti parte dell'array con gli elementi elevati al quadrato
            Console.WriteLine($"Somma dei numeri dell'array quadrato: {sumSquaredUserArrayElements}");
            */

            Console.Write("Inserisci un numero di cui vorresti calcolare il fattoriale: ");
            int userNumber = int.Parse(Console.ReadLine());

            int fattoriale = FactorialCalculator(userNumber);

            Console.WriteLine($"Il fattoriale del numero {userNumber} è {fattoriale}");
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



        // FUNZIONI BONUS: FUNZIONI RICORSIVE

        // funzione per calcolare il fattoriale di un numero
        public static int FactorialCalculator(int factor)
        {
            if (factor == 0)
                return 1;

            else
            {
                // 1° modo
                /*
                int prod = 1;

                for (int i = 2; i <= factor; i++)
                {
                    prod *= i;
                }

                return prod;
                */

                return factor * FactorialCalculator(factor - 1);
            }
        }
    }
}