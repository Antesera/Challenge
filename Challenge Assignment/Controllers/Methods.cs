using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Assignment.Controllers
{
    public class Methods
    {
        public void SimpleText()
        {
            Console.WriteLine("Methods");
        }
        public void sum(int a, int b)
        {
            Console.WriteLine("multi = " + (a * b));
        }
    };
    class prog
    {
        static void main(string[] args)
        {
            Methods ex = new Methods();
            ex.sum(50, 20);
        }
    }
}