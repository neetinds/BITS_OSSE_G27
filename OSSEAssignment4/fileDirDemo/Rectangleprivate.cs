using System;
using System.Collections.Generic;
using System.Text;

namespace fileDirDemo
{
    class Rectangleprivate
    {
        //member variables
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
       //     length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangleprivate

    class ExecuteRectangle1
    {
        static void Main11(string[] args)
        {
            Rectangleprivate r = new Rectangleprivate();
            //r.length;
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
