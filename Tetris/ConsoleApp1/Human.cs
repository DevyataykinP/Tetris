using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Human
    {
        protected int age;
        protected int height;

        public void Set(int a)
        {
            age = a;
        }

        public void Set(int a, int h)
        {
            age = a;
            height = h;
        }

        //public virtual void Write()
        //{
        //    Console.WriteLine($"age: {age}. height: {height}");
        //}
        public abstract void Write();
    }
}
