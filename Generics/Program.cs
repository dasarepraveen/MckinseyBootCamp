using System;

namespace Generics
{
    class CFG<T>
    {
        private T data;

        public T value{
            get{
                return this.data;
                }
            set{
                this.data=value;
            }
        }

      

        
    }

    public class TestClass<T>  
    {  
        // define an Array of Generic type with length 5  
        T[] obj = new T[5];  
        int count = 0;  
  
        // adding items mechanism into generic type  
        public void  Add(T item)  
        {  
            //checking length  
            if (count + 1 < 6)  
            {  
                obj[count] = item;  
  
            }  
            count++;  
        }  
        //indexer for foreach statement iteration  
        // public T this[int index]  
        // {  
        //     get { return obj[index]; }  
        //     set { obj[index] = value; }  
        // }

        public void Dsiplayy()
        {
            foreach(T iter in obj)
            {
                Console.WriteLine("Displaying all the int values{0}",iter);
            }

        }   
    } 

  public  class GenericExample <T>
    {
        private T name;
       

         public GenericExample(T xyz)
        {
            name=xyz;
        }
        

        public void DisplayGenericValues()
        {
            Console.WriteLine("values of genric from Generic Example is {0}",name);
        }
    }
    class generic<T>
    {
        private T genericMemberVariable;

        public generic(T value)
        {
            genericMemberVariable=value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type:{0}, value{1}",typeof(T).ToString(),genericParameter);
            Console.WriteLine("genericMember type:{0}, value{1}",typeof(T).ToString(),genericMemberVariable);
            return genericMemberVariable;
        }
        public T genericProperty{get;set;} 
    }

    class GenridClasswithGenericFunction
    {
        public void Display<TypeofObject> (string parameter, TypeofObject value)
        {
            Console.WriteLine("parametr {0} , value {1}",parameter,value);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            TestClass<int> intObj = new TestClass<int>();  
  
            //adding integer values into collection  
            intObj.Add(1);  
            intObj.Add(2);  
            intObj.Add(3);     //No boxing  
            intObj.Add(4);   
            intObj.Add(5);  

  
            //displaying values  
            // for (int i = 0; i < 5; i++)  
            // {  
            //     Console.WriteLine(intObj[i]);   //No unboxing  
            // }  
            intObj.Dsiplayy();


            generic<int> genericobject = new generic<int>(10);
            genericobject.genericMethod(30);

             generic<string> genericobjectstr = new generic<string>("asd");
            genericobjectstr.genericMethod("dasdasd");

            GenericExample<double> dgenExample = new GenericExample<double>(3.55);
            dgenExample.DisplayGenericValues();

            CFG <string> name = new CFG<string>();
            name.value="Testing this";

             CFG <int> nameint = new CFG<int>();
            nameint.value=22;

            Console.WriteLine(name.value);

            Console.WriteLine(nameint.value);

            GenridClasswithGenericFunction cfgobj = new GenridClasswithGenericFunction();
            cfgobj.Display<int>("its a int",2);
            cfgobj.Display<char>("its char",'C');
            cfgobj.Display<string>("its a string","sadasdsa");
            cfgobj.Display("its a int",2);

            cfgobj.Display("guess","asdasdasdsadasdasdasdsada");




             
           
        }
    }
}
