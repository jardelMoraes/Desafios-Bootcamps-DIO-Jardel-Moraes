﻿using System;

namespace Dividindo_X_por_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0) 
                {
                    Console.WriteLine("divisao impossivel");
                }
                else 
                {
                    var divisao = X/Y;
                    Console.WriteLine(""+divisao.ToString("0.0") );
                }
            }
        }
    }
}
