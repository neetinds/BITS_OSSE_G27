using System;
using System.Collections.Generic;
using System.Text;

namespace fileDirDemo
{
    class Rectangleinternal
    {
        //member variables
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangleinternal

    class ExecuteRectangle2
    {
        static void Main(string[] args)
        {
            Rectangleinternal r = new Rectangleinternal();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
