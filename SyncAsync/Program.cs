using System;
using System.Threading;
 using System.Threading.Tasks;
 

namespace SyncAsync
{
    
    class Program
    {
        public void  calculate()
        {
            calculate1_2();

            calculate3();

         // var task1 = Task.Run(()=>
            // {
            //      return calculate1();

            // });
            // var task2 = Task.Run(()=>
            // {
            //      return calculate2();

            // });

            // Task.WaitAll(task1,task2);

            // var awaiter1 = task1.GetAwaiter();
            // var awaiter2 = task2.GetAwaiter();
            // var result1 = awaiter1.GetResult();
            // var result2 = awaiter2.GetResult();
            // calculate3(result1,result2);
    }

    async void calculate1_2()
    {
       var result1 = await Task.Run(()=>
        {
            return calculate1();

        });
        calculate2(result1);
    }

        public int calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Inside Calculat1");
            return 100;
        }
        public int calculate2(int result1)
        {
            Console.WriteLine("Inside Calculat2");
            return 2*result1;
        }

         public int calculate3()
        {
            
            
            Console.WriteLine("Inside Calculat3");
            return 200;
        }

        // public int calculate3(int res1,int res2)
        // {
            
        //     Console.WriteLine("Inside Calculat3");
        //     return res1+res2;
        // }
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.calculate();
            Console.Read();
            
            
        }
    }
}
