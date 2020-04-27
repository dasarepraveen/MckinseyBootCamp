using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsGenerics
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //Collection -Lists
            //list can add duplicate entries 
            List<int> list_name= new List<int>(){1,1,2,3,4,1,5,6,7};

            

            for(int i=0;i<list_name.Count;i++)
            {
                Console.WriteLine("list names are {0}",list_name[i]);
            }
            Console.WriteLine("Count is {0}",list_name.Count);

            //remove 

            list_name.Remove(1);

            for(int i=0;i<list_name.Count;i++)
            {
                Console.WriteLine("Demonstrating remove {0}",list_name[i]);
            }
            Console.WriteLine("Count is {0}",list_name.Count);

            //removeAt

            list_name.RemoveAt(5);

            for(int i=0;i<list_name.Count;i++)
            {
                Console.WriteLine("Demonstrating RemoveAt {0}",list_name[i]);
            }
            Console.WriteLine("Count is {0}",list_name.Count);


            //Remove All


            list_name.RemoveAll(item => item ==1);

             for(int i=0;i<list_name.Count;i++)
            {
                Console.WriteLine("Demonstrating removeall  {0}",list_name[i]);
            }
            Console.WriteLine("Count is {0}",list_name.Count);

            //appends entire list again

             list_name.AddRange(list_name);

             for(int i=0;i<list_name.Count;i++)
            {
                Console.WriteLine("Demonstrating addrange  {0}",list_name[i]);
            }
            Console.WriteLine("Count is {0}",list_name.Count);

            List<int> liststs = new List<int>{1,2,3};

            List<int> liststs2 = new List<int>(liststs);

            foreach(int iterator in liststs2)
            {

                Console.WriteLine("lists2 array copied from listst {0}",iterator);

            }

            //index of
            int index = liststs.IndexOf(2);
            int index2 = liststs.IndexOf(9);
            Console.WriteLine("index {0},index2 {1}",index,index2);

           string abcd = string.Join(":",liststs2.ToArray());

           Console.WriteLine(abcd);
            
            Dictionary<int,string> dict = new Dictionary<int, string>();
            dict.Add(1,"Praveen");
            dict.Add(2,"Dasare");
            dict.Add(3,"Dasare");
            //dict.Add(1,"Dasare");
            dict.Add(4,"Prabhavathi");
            dict.Add(5,"");

            foreach(KeyValuePair<int,string> dct in dict)
            {
                Console.WriteLine("Printing it from dictionary {0}",dct);

            }

             foreach(KeyValuePair<int,string> dct in dict)
            {
                Console.WriteLine("Printing key from dictionary {0}",dct.Key);

            }
            

             foreach(KeyValuePair<int,string> dct in dict)
            {
                Console.WriteLine("Printing value from dictionary {0}",dct.Value);

            }

            

            var fibonacciNumbers = new List<int> {1, 1};

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);

          foreach (var item in fibonacciNumbers)
          Console.WriteLine(item);

          string[] arxr = new string[]
	{
	    "One",
	    "Two"
	};
	var dicxt = arxr.ToDictionary(item => item, item => true);
	foreach (var pair in dicxt)
	{
	    Console.WriteLine("{0}, {1}",
		pair.Key,
		pair.Value);
	}
          

            
            




            
        }
    }
}
