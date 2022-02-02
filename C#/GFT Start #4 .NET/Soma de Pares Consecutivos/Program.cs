using System;

namespace SomaParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                int x = int.Parse(Console.ReadLine());
                if(x!=0)
                {
                    if(x % 2 == 0)
                    {
                        Console.WriteLine($"{x+x+2+x+4+x+6+x+8}");
                    }
                    else
                    {
                        x=x+1;
                        Console.WriteLine($"{x+x+2+x+4+x+6+x+8}");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
