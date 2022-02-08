using System;
(prathap)
namespace ConsoleApp1
{
    class Program this is class program
    {
        static void Main(string[] args)
        {
            int a=0,b = 1,c,n,i;
            Console.WriteLine("Enter number for fibonacci:"); 
            n=int.Parse(Console.ReadLine());
            Console.Write(a+" "+b+" ");
            for(i=0;i<=n;i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a=b;
                b=c;
            }

        }
    }
}
