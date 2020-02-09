using System;

namespace InterviewHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass1 myc1 = new myClass1();

            myc1.add(2,4);
            Test1 T1 = new myClass1();
            T1.add();

            Test2 T2 = new myClass1();

            T2.add();
        }
    }

    sealed class myClass1 : Test1, Test2
    {
        public int add(int no1, int no2)
        {
            return no1 + no2;
        }

        void Test1.add()
        {
            Console.WriteLine("Interface method T1");
        }

        void Test2.add()
        {
            Console.WriteLine("Interface method T2");
        }
    }

    class myclass2 : IDisposable
    {
        public int add(int no1, int no2)
        { return no1 + no2; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    interface Test1
    {

        void add();
    }

    interface Test2
    { void add(); }
}
