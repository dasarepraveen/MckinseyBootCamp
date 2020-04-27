using System;


namespace ObjectsAndClasses
{
    public static class MyMath
    {
        public static string name="world";

        public static int square(int numberParameter)
        {
            Console.WriteLine("We are in int paramter");
            return numberParameter*numberParameter;

        } 

        public static double square(double n)
        {
            Console.WriteLine("We are in duble paramter");
            return n*n;
        }    

    }
  public class Student
    {
        public int id;
        public string name;

        public void Setnasme(int id1,string name1)
        {
            id=id1;
            name=name1;
           // Console.WriteLine("name is "+name+"id is "+id);
        }

        public void displaynames()
        {
            Console.WriteLine("Name is "+name +" id is "+id);

        }
        //default constructor
       public Student()
        {
            Console.WriteLine("this is under default constructor");
        }

        public Student(int id)
        {
            this.id=id;
            name="no name";
            Console.WriteLine("this is under single parameterized constructor");
        }

        public Student(int id,string name)
        {
            this.id=id;
            this.name=name;
            Console.WriteLine("this is under parameterized constructor");
        }

    
    }

   
    public class Teacher
    {
        public static void Main(string[] args)
        {
           Student st = new Student();
           Student st2 = new Student();
            st.id=23;
            st.name=" asdasdasd";
            st2.id=44;
            st2.name="awerts";
            Console.WriteLine("The naem is "+st.id);
            Console.WriteLine("The naem is"+st.name);
            Console.WriteLine("The naem is "+st2.id);
            Console.WriteLine("The naem is"+st2.name);
           st.Setnasme(22,"Dasare");
            st.displaynames();
           
           Student ss = new Student(22,"Dasare");
            Student s3 = new Student(28);
           ss.displaynames();
           
           Console.WriteLine(MyMath.square(5));
           Console.WriteLine(MyMath.square(5.5));

           Console.WriteLine("Hello"+MyMath.name);
            
        }

    }
    
}

   
   

