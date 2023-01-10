using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Assignment.Controllers
{
    public class program
    {
        public class MyTest
        {
            public event EventHandler MyEvent
            {
                add
                {
                    Console.WriteLine("add operation");
                }
                remove
                {
                    Console.WriteLine("remove operation");
                }
            }
        }
        public class Test 
        { 
             public void TestEvent()
             {
                MyTest myTest = new MyTest();
                myTest.MyEvent += myTest_MyEvent;
                myTest.MyEvent _= myTest_MyEvent;
             }
            public void myTest_MyEvent(object sender, EventArgs e)
            {
            }
        }
        static void main(String[] args)
        {
            Test test = new Test();
            test.TestEvent();
            
            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);

            Console.ReadKey();
        }
    }
}