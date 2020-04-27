using System;
using System.Linq;

namespace MyFirstProject
{
    class AnotherClass
    {
       //private string name;
        //private string sound;
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello!"+args[2]);
        }

        /*public Animal():this("no name","no sound")
        {

        }

        public Animal(string name):this(name,"no sound")
        {

        }

        public Animal(string name,string sound)
        {
            SetName(name);
            Sound=sound;

        }
        public string Getname()
        {
            return name;
        }

        public void SetName(string name)
        {
            if(!name.Any(Char.IsDigit))
            {
                this.name=name;
            }
            else{
                this.name="no name";
                Console.WriteLine("you cannot enter {0} s it is integer",name);
            }
        }

        public string Sound{
            get{return sound;}
            set{
                sound=value;
            }

        }
        public string Owner {get;set;}

        public static int numbofanimals=0;

        public static int Numbofanimals{
            get{
                return numbofanimals;
            }
            set{
                numbofanimals+=value;
            }
        }*/
    }
}
