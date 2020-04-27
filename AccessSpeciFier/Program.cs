using System;

namespace AccessSpeciFier
{

class Rectangle {
      
      //member variables
      protected double length;
      protected double width;
      
      public Rectangle(double l, double w) {
         length = l;
         width = w;
      }
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle  
   class Tabletop : Rectangle {
      private double cost;
      public Tabletop(double l, double w) : base(l, w) { }
      
      public double GetCost() {
         double cost;
         cost = GetArea() * 70;
         return cost;
      }
      public void Display() {
         base.Display();
         Console.WriteLine("Cost: {0}", GetCost());
      }
   }
   class ExecuteRectangle {
      static void Main(string[] args) {
         Tabletop t = new Tabletop(4.5, 7.5);
         t.Display();
         Console.ReadLine();
      }
   }







































class BaseClass
{
    public string name;
    public string subject;
    public void setget(string name,string subject)
    {
        this.name=name;
        this.subject=subject;
        Console.WriteLine("Name is "+name);
        Console.WriteLine("Subject is "+subject);

    }

    public BaseClass()
    {
        Console.WriteLine("Base class constructor");
    }



}
class Derived : BaseClass
{
    public Derived()
    {
        Console.WriteLine("base class constructor");
    }
    
}






class PrivateVariables
{
    private string name;
    private int age;

    public string Name{
        get{
           return name;
        }
        set{
            name=value;
        }

    }

    public int Age{
        get{
            return age;

        }
        set{
            age=value;

        }
    }

}

/*  class Rectangle
    {
        public double length;
        public double breadth;

        public double GetArea()
        {
            return length*breadth;
        }

        public void Display()
        {
            Console.WriteLine("length is {0} breadth is {1} Area is {2}",length,breadth,GetArea());
        }
        
    }*/

   /* class ExecuterRectangle
    {
        static void Main(string[] args)
        {

          /*  PrivateVariables pvt = new PrivateVariables();
            pvt.Name="shhhhhhhhh";
            pvt.Age=0;



           Rectangle rect = new Rectangle()
        {
                length =2,
                breadth=5
           //r
          
        };

        Console.WriteLine(pvt.Name);
        Console.WriteLine(pvt.Age);
         //Console.WriteLine(rect.GetArea());
        //rect.Display(); 
        
            Console.WriteLine("Hello World!");



            Derived dd = new Derived();
            
            dd.setget("Dasare","SST");
            dd.name="Danger Dasare";
            Console.WriteLine("name can be updated from object of a derived class "+dd.name);
        }
    }*/
}
