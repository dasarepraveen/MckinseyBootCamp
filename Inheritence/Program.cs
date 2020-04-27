using System;

namespace Inheritence
{
//example to acces private members from b ase class
 public class baap
 {
     private int value = 5;
     public int getValue()
     {
         return value;
     }
 }
 public class beta : baap{
     public void Dsiplay()
     {
         Console.WriteLine(getValue());
     }
 }



  public  class father
    {
        public int roll_no;
        public string name;
       /* public father(int roll_no,string name)
        {
            this.roll_no=roll_no;
            this.name=name;

        }*/
        public void Editnames(string appendnames)
        {
            this.name=name+appendnames;
            Console.WriteLine("this.name is {0}",this.name);

        }

    }
  public  class son: father
    {
        public void DisplayNames()
        {
            Console.WriteLine("Roll number {0}",roll_no);
            Console.WriteLine("Name {0}",name);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            son ss = new son();
            ss.name="this should be appended";
            ss.roll_no=23;
            ss.DisplayNames();
            ss.Editnames("bBES");
            beta bb = new beta();
            bb.Dsiplay();
           
        }
    }
}
