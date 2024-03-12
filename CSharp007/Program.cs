using System.Runtime.CompilerServices;

namespace CSharp007
{

    //=============================================================
    /*
     this : 자기 자신을 참조 
      
     */

    //=============================================================

    // 확장 메서드를 쓸때는 정적 클래스(static)
    static class A
    {
        // 정적 함수여야되고 첫번쨰 매개변수에 this 붙이고 확장하고자 하는 자료형
        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }
    }




    // A.cs 파일, B.cs파일에 하나씩 파일이 분리되어 있어도 하나로 인식되어서 같이 컴파일(대규모 프로젝트에 적합) 파티션
    // 전투시스템
    //partial class Player
    //{

    //}
    //// 아이템
    //partial class Player
    //{

    //}


    class Player
    {
        private string name;
        private int hp;
        public void SetName(string name)
        {
            this.name = name;
        }
    }
    // this()
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 1;
        }
        public MyClass(int b)
        {
            this.a = 1;
            this.b = b;
        }
        public MyClass(int b, int c)
        {
            this.a = 1;
            this.b = b;
            this.c = c;
        }
       
    }
    // this()
    // 자기 자신의 생성자
    // 생성자에서만 사용가능, 생성자의 코드블록 안쪽이 아닌 앞쪽에서만 사용가능
    class MyClass01
    {
        int a, b, c;

        public MyClass01()
        {
            this.a = 1;
            Console.WriteLine("MyClass01()");
        }
        // this()는 위에 있는 MyClass01() 호출
        public MyClass01(int b) : this()    
        {
            this.b = b;
            Console.WriteLine("MyClass01({0})", b); 
        }
        // this(b)는 MyClass01(int b) 호출
        public MyClass01(int b, int c) : this(b) 
        {
            this.c = c;
            Console.WriteLine("MyClass01({0}, {1})", b, c);
        }
        public void Print()
        {
            Console.WriteLine("a : {0}, b : {1}, c : {2}", a, b, c);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass01 a = new MyClass01();
            a.Print();
            MyClass01 b = new MyClass01(1);
            b.Print();
            MyClass01 c = new MyClass01(10, 20);
            c.Print();

            string str = "Hello World";

            // Console.WriteLine(WordCount(str));

            //
            // str.WordCount;
        }
    }
}
