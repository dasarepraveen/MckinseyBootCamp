using System;

namespace NameSpaces
{

namespace Hello
{
    class Hel{
        public void Hellooo()
        {
            Console.WriteLine("This is under Hello namespaces");
        }
    }
}

namespace Hi
{
    class Hi{
        public void Hiiiii()
        {
            Console.WriteLine("This is under HI");
        

    }
}
}

    class Program
    {
        static void Main(string[] args)
        {
            Hello.Hel hh = new Hello.Hel();
            hh.Hellooo();
            Console.WriteLine("Hello World!");
        }
    }
}



