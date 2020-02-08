using System;

namespace InterviewHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            // test code goes here
        }
    }

    sealed class myClass1
    {
        public int add(int no1, int no2)
        {
            return no1 + no2;
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

}
