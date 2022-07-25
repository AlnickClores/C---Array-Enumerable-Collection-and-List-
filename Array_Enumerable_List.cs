using System;
using System.Collections.Generic;

namespace Practice_Alnick
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- Array in C# --

            /************************************************
            *           Array Declaration                   *
            *                                               *
            *    int[] numbers = new int[10];               *
            *    int[] numbersz = new int [3] {1,2,3};      *
            *    int [][] multidimensional = new int[3][]   *
            *    {                                          *
            *        new int[3] {1,2,3},                    *
            *        new int[2] {5,6},                      *
            *        new int[5] {10,9,8,7,6}                *
            *    };                                         *          
            ************************************************/

            //single dimensional
            Console.WriteLine("-1 Dimentional Array-\n");
            var numbers = new[] {1,2,3,4,5};

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            numbers[2] = input;

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            //multidimentionl
            Console.WriteLine("\n-Multidimentional Array-\n");
            var multidimentionalArray = new int [3][] //1st [number of arrays], 2nd[number of contents in array]
                {
                new int[3] {1,2,3},
                new int[3] {4,5,6},
                new int[2] {69, 90}
                };

            for(int row = 0; row<multidimentionalArray.Length; row++) //row here indicates the number of arrays
            {
                Console.WriteLine($"Row: {row}");
                foreach(var numberInsideArray in multidimentionalArray[row]) // numbers here indicates the numbers or contents inside the arrays
                {
                    Console.WriteLine($"Content: {numberInsideArray}");
                }
            }
            #endregion

            #region -- Enumerable, Collection and List --

            /************************************************************************
             *  IEnumerable (items are readonly (cannot be modefied))               *
             *  ICollection (Count, Add(), Remove(), Clear())                       *
             *  IList (this[], InsertAt[], RemoveAt[], and function in ICollection) *
             ************************************************************************/

            Console.WriteLine("\n-Enumerable-\n");   

            var mlHeroes = new[] {"Natalia", "Kagura", "Freya", "Kimmy", "Karina"};
            IEnumerable<string> enumHeroes = mlHeroes; //data inside the array cannot be changed

            foreach (var loop in enumHeroes)
            {
                Console.WriteLine(loop);
            }

            Console.WriteLine("\n-Collection-\n");

            ICollection<string> colHeroes = new List<string>(mlHeroes);
            colHeroes.Add("Pharsa");
            colHeroes.Remove("Natalia");

            foreach(var loop in colHeroes)
            {
                Console.WriteLine(loop);
            }

            Console.WriteLine("\n-List-\n");

            var listHeroesArray = new List<string>(mlHeroes); //gets value from array

            var listHeroesGrouped = new List<string>() //gets value from initializing
            {
                "Beatrix", "Hanabi", "Kadita"
            };

            listHeroesGrouped.AddRange(new[] {"Roger", "Alucard"}); // to add multiple data
            listHeroesGrouped.Add("Angela"); // to add single data
            listHeroesGrouped.Remove("Roger"); // to remove data
            listHeroesGrouped[3] = "Selena"; // to replace data on its index 

            for(int i=0; i<listHeroesGrouped.Count; i++)
            {
                Console.WriteLine($"Index[{i}]: {listHeroesGrouped[i]}");
            }
            #endregion
        }
    }
}
