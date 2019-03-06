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
    using System;

    namespace DelegatesAndEvents
    {
        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                try
                {
                    delegateExercises.Method3();
                    Console.ReadLine();
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine("Exception Occurred.");
                    Console.ReadLine();

                }
            }
        }

        public delegate void MyDelegate();

        public class DelegateExercises
        {
            void Method1()
            {
                throw new System.Exception();
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }

    }
}



