using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Cat
    {
        private int mood;
        private int hungry;
        private int energy;

        private void meow()
        {
            Console.WriteLine("let meow");
        }
        public void sleep()
        {
            energy++;
            hungry++;
        }
        public void play()
        {
            mood++;
            energy--;
            Console.WriteLine("let meow !!!!!");
        }
        public void food()
        {
            hungry--;
            mood++;

            Console.WriteLine("let meow !!!!!");
        }

    }
}
