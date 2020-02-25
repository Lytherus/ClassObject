using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{ // Variables: Area, Length, Width, Depth, Volume | Processes: CollectLength, CollectWidth, CollectDepth, CalculateArea, CalculateVolume
    class Cuboid
    {
        //Variables
        public double length = 0.0;
        public double width = 0.0;
        public double depth = 0.0;
        public double area = 0.0;
        public double volume = 0.0;

        //Methods 

        public void CollectLength()
        {
            Console.WriteLine("Please enter the length of the shape.");
            length = Convert.ToDouble(Console.ReadLine());

        }

        public void CollectWidth()
        {
            Console.WriteLine("Please enter the width of the shape.");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public void CollectDepth()
        {
            Console.WriteLine("Please enter the depth of the shape.");
            depth = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateArea()
        {
            area = 2 * (length * width) + 2 * (width * depth) + 2 * (length * depth);
            Console.WriteLine("The Surface Area is equal to " + area);
        }

        public void CalculateVolume()
        {
            volume = length * width * depth;
            Console.WriteLine("Volume is:" + volume);
        }

        //public interface
        public void Process()
        {
            CollectDepth();
            CollectLength();
            CollectWidth();
            CalculateArea();
            CalculateVolume();
            
        }
    }
}
