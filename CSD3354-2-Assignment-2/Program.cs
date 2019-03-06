using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : Rajandeep Singh (C0730233)
//Name : Shiv Pratap (C0723724)
//CSD3354 Section 2
//Assignment 2
//March 6,2019

namespace CSD3354_2_Assignment_2
{
    class Program
    {
       
          class proram
        {
            static void Main(string[] args)
            {
                DelegateExercises a = new DelegateExercises();
                a.Method2();
            }
        }
        public class DelegateExercises
        {
            public delegate void MyDelegate();

            void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();

            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }



    }
}

    