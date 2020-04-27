using System;

namespace Encapsulation
{

class Example{
    public int x;

    public int getx()
    {
        return x;

    }

    public void setx(int x)
    {
        if(x>0)
        {
            this.x=x;
        }
        else{
            Console.WriteLine("entrt positive values");
        }

    }

}

    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.setx(3);
            ex.getx();
             ex.setx(-3);
             ex.getx();
            //Console.WriteLine("Hello World!");
        }
    }
}
