using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cant created object of SingletonClass
            //SingletonClass sc = new SingletonClass();
            Program p = new Program();

            p.GetInstance();
            Console.ReadLine();
        }

        private void GetInstance()
        {
            Parallel.Invoke(() => SingletonClass.GetInstance(),
                () => SingletonClass.GetInstance(),
                () => SingletonClass.GetInstance(),
                () => SingletonClass.GetInstance(),
                () => SingletonClass.GetInstance()
                );
        }
    }
}
