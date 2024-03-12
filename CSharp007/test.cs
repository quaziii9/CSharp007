using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp007
{
    class Queue<T>
    {
        private const int MAX_VALUES = 8;
        private int head;
        private int tail;
        private T[] values;
          
        public Queue()
        {
            tail = 0;
            head = 0; 
            values = new T[MAX_VALUES]; // 초기화
            Array.Clear(values, 0, MAX_VALUES);
        }
        public void Enqueue(T val)
        { 
            if (!IsFull())
            {
                tail = tail % MAX_VALUES;
                values[tail++] = val;
            }
            else
            {
                Console.WriteLine("Full! Enqueue 불가능!");
            }
        }

        public void Dequeue()
        { 
            if (!IsEmpty())
            {
                head = head % MAX_VALUES;
                values[head++] = default(T);
            }
            else
            {
                Console.WriteLine("초기화 Deque 불가능");
            }
        }
        public bool IsFull() { return (tail + 1) % MAX_VALUES == head; }

        public bool IsEmpty() { return head == tail; }
      
        public void Print()
        {
            foreach (T i in values)
                Console.Write($"   {i}   |");
            Console.WriteLine();
        }
    }

    internal class test
    {     
        static void Main()
        {
            //eq dq , 비어있나, 꽉차있나
            // 과제 : 배열을 이용해서 큐를 구현
            // 메서드 4개
            // ㄴ Enqueue, Dequeue, IsFull, IsEmpty

            Queue <int> arrQ = new Queue<int>();

            arrQ.Enqueue(1);
            arrQ.Enqueue(2);
            arrQ.Enqueue(3);
            arrQ.Enqueue(4);
            arrQ.Enqueue(5);
            arrQ.Enqueue(6);
            arrQ.Enqueue(7);

            arrQ.Dequeue();
            arrQ.Dequeue();
            arrQ.Dequeue();
            arrQ.Dequeue();
            arrQ.Dequeue();
            arrQ.Dequeue();

            arrQ.Enqueue(8);
            arrQ.Print();
        }
    }
}
