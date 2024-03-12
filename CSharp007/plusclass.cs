using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp007
{
    class Stack<T>
    {
         
    }


    internal class plusclass
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);  
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
