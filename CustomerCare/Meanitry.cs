using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare
{
    class Meanitry : IMeanitry
    {
        private static IMeanitry _instance = null;
        public static IMeanitry GetInstance()
        {
            if (_instance == null)
                _instance = new Meanitry();

            return (Meanitry)_instance;
        }

        public void SetInstance(IMeanitry instance)
        {
            _instance = instance;
        }

        public void print()
        {
            
        }
    }

    class MyClass
    {
        public void print()
        {
            Console.WriteLine("My Class is here!");
        }
    }

    class SubMyClass : MyClass
    {
        public void print()
        {
            Console.WriteLine("Sub My Class is here!");
        }
    }

    class Pro {

        public void getData()
        {
            SubMyClass sub = new SubMyClass();
            sub.print();
        }

    }

    class Pro2
    {
    }
}
