using System;
using System.Collections.Generic;
namespace parImpar
{
    class Program
    {      
        static void Main(string[] args)
        {
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) { pares.Add(i); Console.WriteLine($"Número Par: " + i); }
                else impares.Add(i); Console.WriteLine("Número Ímpar: " + i);
            }                            
            Console.WriteLine($"\nO SÉTIMO NÚMERO PAR ENTRE 0 E 100 É: {pares[6]}");
            Console.WriteLine($"\nO VIGÉSIMO NÚMERO ÍMPAR ENTRE 0 E 100 É: {impares[19]}");
            for (int i = 0; i <= pares.Count-1; i++)
            {
                if (pares[i] % 2 == 0) pares[i] += 1;
                else impares[i] -= 1;
            }
            impares.Add(100); pares.Remove(101); 
        }
    }
}

