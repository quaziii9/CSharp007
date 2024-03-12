
namespace CSharp007
{
    // IEnumerable : 컬렉션을 나타내는 인터페이스, 반복자를 제공해서 순회하는걸 가능하게끔 해줌



    // =============================================================
    // <yield>  
    // - 반복기를 통해서 데이터 집합을 하나씩 리턴할때 사용
    // - 반환할 데이터 양이 커서 한꺼번에 리턴하는 것보다 분할해서 반환하는게 효율적인 경우

    // yield return : 컬렉션 데이터를 하나씩 리턴하는데 사용
    // yield break : 리턴을 중지하고 반복 루프를 빠져나올때 사용
    // =============================================================



    internal class Program01
    {
        public IEnumerable<int> GetNumber()
        {
            // 한번 루프를 돌때마다 
            yield return 10; // 첫번째 루프에서 리턴되는 값
            yield return 20; // 두번째 루프에서 리턴되는 값
            yield return 30; // 세번째 루프에서 리턴되는 값
            yield return 40; // 네번째 루프에서 리턴되는 값
            yield return 50;
        }

        public IEnumerable<int> Repeater(int count)
        {
            for(int i = 0; i < count; i++)
            {
                yield return i;
            }
        }

        public IEnumerable<int>UntilPlus(IEnumerable<int> numbers)
        {
            foreach(var item in numbers)
            {
                if(item > 0)
                    yield return item;
                else
                {
                    yield break; // 음수가 나오면 하지마
                }
            }
        }

        public IEnumerable<int> GetRandomNumber()
        {
            Random random = new Random();

            while(true)
            {
                yield return random.Next();
            }
        }
        void Test02()
        {
            foreach( var item in GetRandomNumber())
            {
                Console.WriteLine(item);
                Console.WriteLine("다음 난수를 원한다면 ..");
                if (Console.ReadLine().ToLower() != "y") break;
            }
        }

        public void Test()
        {
            foreach (var item in GetNumber())
            {
                Console.WriteLine(item);
                
            }
        }
        public void Test01()
        {
            foreach(var item in UntilPlus(new int[5] { 1,3,5,-1,4}))
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            Program01 program01 = new Program01();
            program01.Test();
            program01.Test01();
            program01.Test02();

        }
    }
}
