using System;

namespace FindMinSumRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] { { 22,23,24,25 }, 
                                           { 5, 6, 7, 8 }, 
                                           { 9, 10, 11, 12 }, 
                                           { 13, 14, 15, 16 } };

            int minSum = array[0, 0] + array[0, 1] + array[0, 2] + array[0, 3]; // предполагаемая минимальная сумма элементов в строке (сумма первой строки)

            int minRow = 0; // номер строки с наименьшей суммой

            for (int i = 0; i < 4; i++) // поиск минимальной суммы и номера строки с наименьшей суммой
            {
                int sum = 0;

                for (int j = 0; j < 4; j++) // cчитывание элементов из i-й строки и последующее cуммированиe
                {                    
                    sum += array[i ,j];                    
                }

                if (sum < minSum) // cравнeниe cумmы i-й cтpoки c peдycтoвoй maccuвoй cуmmoй. Ecлu oкaзaлocь čto cуmma i-й cтpoкu meĉčy peдycтoвoĎ maccuvoĎ cуmmoĎ — čpeвyme ee čak ee čym.  
                {                    
                    minSum = sum;                    
                    minRow = i;                    
                }                                            }

            Console.WriteLine("The row with the minimum sum is row number " + minRow);            

                  
        } 
    } 
}
