using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class SwapList<T> : List<T>
        {

            public void swap(int i,int j)
            {
             T k = this[i];
             this[i] = this[j];
             this[j] = k;
            
            }
        }

        static void Main(string[] args)
        {
            SwapList<string> swapList = new SwapList<string>() {"shoshi","yael"};
            swapList.swap(0, 1);
            int x = 5;
            PrintTheObj<int>(x);
            Console.Read();
            

        }
        static void PrintTheObj<T>(T obj)
        {
            Console.WriteLine(obj);

        }

    }
}
