using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        //demonstarte without static
        
        public static void Arrfunc(params string[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Printing array from function "+arr[i]);
            }
            foreach(string siterator in arr )
            {
                Console.WriteLine("Printing array from for each function "+siterator);
            }

        }
        static void Main(string[] args)
        {
            List<int> list_name =new List<int>(){1,3,4,5,6,7};
            list_name.Add(1);
            list_name.Add(2);
            Console.WriteLine("list count{0}",list_name.Count);
        //single dimn array
        //new keyword because array is a refrence type in c#
       int[] arr = new int[5];
            arr[1]=2;
            arr[2]=4;
            arr[4]=5;

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Arrays {0}",arr[i]);
            }
            

            //1st way of declaring an array 
            string[] arstring = new string[3]{"magic","dancing","victory"};
            Arrfunc(arstring);

            Arrfunc("dasd","asdasd","qweqwe","asdasdas");
            Console.WriteLine("array size is " + arstring.Length);

            for(int i=0;i<arstring.Length;i++)
            {
                Console.WriteLine("1st way of declaring an array {0}",arstring[i]);
            }

            foreach(string xy in arstring)
            {
                Console.WriteLine("pronting from for each {0} ",xy);
            }

            //2nd way of declaring array ommit the size of an array
            string[] ss = new string[]{"asd","sdwqas","adsqwe","weqrsdf"};
            for(int i=0;i<ss.Length;i++)
            {
                Console.WriteLine("2nd way of declaring an array {0}",ss[i]);
            }


            //3rd way of declaring arrays we can ommit the new operator
            double[] dd ={3.3,4.4,5.5};
            foreach(var xxx in dd)
            {
                Console.WriteLine("printing from 3rd way of declaring an array {0}",xxx);

            }



        int[,] aarr=new int[3,3];//declaration of 2D array  
        aarr[0,1]=10;//initialization  
        aarr[1,2]=20;  
        aarr[2,0]=30;  
  
        //traversal  
        for(int i=0;i<3;i++){  
            for(int j=0;j<3;j++){  
                Console.Write(aarr[i,j]+" ");  
            }  
            Console.WriteLine();//new line at each row  
        }  


        //1st way of declaring
        int[,] fstway = new int[3,3]{ {1,2,3},{4,5,6},{7,8,9}};
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.WriteLine("1st way of declaring"+fstway[i,j]);
            }
        }
        //2nd way of declaring 
        string[,] scndwystr = new string[,]{ { "zero", "one" }, {"one","two"} };

       string[,] sdsds = new string[,]{{"sda","asdsad"},{"dsad","asdasd"},{"qweqw","qweweqw"} }; 

       //3rd way of declaring
       int[,] thriddd = { {1,2},{2,2}};
       

       

        Arrfunc("magic","dancing","victory");
       

    
        Array.Sort(arstring);
        foreach(string sss in arstring )
        {
            Console.WriteLine("sorted arrays" +ss);
         }
    
        }
    }
}
