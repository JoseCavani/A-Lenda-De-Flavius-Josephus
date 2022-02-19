using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("soldados");
            int soldados = int.Parse(Console.ReadLine());

            Console.WriteLine("saltos");
            int saltos = int.Parse(Console.ReadLine());



            List<int> soldadosList = new List<int>();
            for (int i = 1; i <= soldados; i++)
            {
                soldadosList.Add(i);
            }
            int inical = 0;
            while (soldadosList.Count > 1)
            {
                inical = (inical + saltos - 1) % soldadosList.Count;
                soldadosList.RemoveAt(inical);


            }
            Console.WriteLine(soldadosList[0]);
            Console.ReadKey();



        }
    }
}