using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CSharp007
{


    internal class stackClass
    {
        //class Stack<T>
        //{
        //    private const int MAX_VALUES = 3;
        //    private int top;
        //    private T[] values;

        //    public Stack()
        //    {
        //        top = -1; // top을 -1로 설정
        //        values = new T[MAX_VALUES]; // 초기화
        //        Array.Clear(values, 0, MAX_VALUES);
        //    }
        //    public void Push(T val)
        //    {
        //        // Debug.Assert(top +1 <MAX_VALUES);
        //        if (top + 1 < MAX_VALUES)
        //        {
        //            values[++top] = val; // 값을 스택에 추가하고 Top 증가
        //        }
        //        else
        //        {
        //            Console.WriteLine("오버플로우! ");
        //        }
        //    }
        //    public T Pop()
        //    {
        //        // Debug.Assert(!Empty());
        //        if (!Empty())
        //        {
        //            T val = values[top];
        //            values[top--] = default(T);
        //            return val;
        //        }
        //        else
        //        {
        //            Console.Write("언더플로우");
        //            return default(T);
        //        }


        //        // 10 20 30 40
        //        // 
        //    }
        //    public T Top()
        //    {
        //        return values[top]; // 스택의 최상위 값 반환
        //    }
        //    public bool Empty()
        //    {
        //        return top < 0;
        //    }
        //}


        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            // stack.Push(40);

            Stack<string> stack1 = new Stack<string>();
            stack1.Push("a");
            stack1.Push("b");
            stack1.Push("c");

            Console.Write(stack1.Pop() + " ");
            Console.Write(stack1.Pop() + " ");
            Console.Write(stack1.Pop() + " ");
            Console.WriteLine();
            //try
            //{
            //    Console.Write(stack1.Pop() + " ");
            //    Console.Write(stack1.Pop() + " ");
            //    Console.Write(stack1.Pop() + " ");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}



            

            //try
            //{
            //    Console.Write(stack.Pop() + " ");
            //    Console.Write(stack.Pop() + " ");
            //    Console.Write(stack.Pop() + " ");
            //    Console.Write(stack.Pop() + " ");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            // Peek : 스택의 최상단의 값만을 확인
            int topValue = stack.Peek();
            Console.WriteLine(topValue);

            // 스택갯수
            int Count = stack.Count;
            Console.WriteLine(Count);

            // 10이 있냐없냐
            bool isValue = stack.Contains(10);
            Console.WriteLine(isValue);

            stack.Clear();

            //1. 스택을 활용해서 문자열을 역순으로 뽑아보자

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
         
            Console.WriteLine(queue.Dequeue());


            // 1. 큐를 이용해서 로비 시스템을 만든다.
            // 2. 플레이어는 3명이 있다.
            // 3. 플레이어는 로비에 입장을 하고
            // 4. 입장한 순서대로 전투를 진행한다


            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("플레이어 1");
            //queue.Enqueue("플레이어 2");
            //queue.Enqueue("플레이어 3");

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());


        }
    }
    
}
