using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {
        //Step-1
        //Make the constructor private
        private SingletonClass()
        {
        }

        //Step-2
        //Static field of SingleTonClass type,that will be returned
        private static SingletonClass SingletonClassInstance { get; set; }

        //Step-3
        //Make the Lock object .
        private static readonly Object lockObj = new object();

        //Step-4
        //GetInstance of the SingleTonClass.
        public static SingletonClass GetInstance()
        {
            if (SingletonClassInstance == null)
            {
                lock(lockObj)
                {
                    if (SingletonClassInstance == null)
                    {
                        Console.WriteLine("SingleTon instance is created!");
                        SingletonClassInstance = new SingletonClass();
                    }
                }
            }
            return SingletonClassInstance;
        }
    }
}
