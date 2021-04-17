using System;
using System.Collections.Generic;
using System.Text;

namespace fileDirDemo
{
    class rectanglepublic
    {
        //member variables
        public double length;
        public double width;

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
    }//end class rectanglepublic

    class ExecuteRectangle
    {
        static void Maind(string[] args)
        {
            rectanglepublic r = new rectanglepublic();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    
}
}
