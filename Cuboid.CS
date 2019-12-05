using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Cuboid 
    {
        private double length = 0.0;
        private double width = 0.0;
        private double depth = 0.0;
        private double result = 0.0;

        private void GetLength()
        {
            Console.WriteLine("Please input the length of a side on the cuboid: ");
            string input_check = Console.ReadLine();
            if (double.TryParse(input_check, out length)) //length input
            {
            }
            else
            {
                Console.WriteLine("Incorrect input please enter a number ");
                GetLength();
            }
        }

        private void GetWidth()
        {
            Console.WriteLine("Please input the width of a side on the cuboid: ");
            string input_check = Console.ReadLine();
            if (double.TryParse(input_check, out width)) //length width
            {
            }
            else
            {
                Console.WriteLine("Incorrect input please enter a number ");
                GetWidth();
            }
        }

        private void GetDepth()
        {
            Console.WriteLine("Please input the height/depth of a side on the cuboid: ");
            string input_check = Console.ReadLine();
            if (double.TryParse(input_check, out depth)) //length depth
            {
            }
            else
            {
                Console.WriteLine("Incorrect input please enter a number ");
                GetDepth();
            }
        }


        private void CalculateCuboidSurfArea()
        {

            result = 2 * (length * width) + (length * depth) + (width * depth);
        }

        private void OutputCuboidSurfArea()
        {
            Console.WriteLine("The surface area of your cuboid is: " + result);
        }

        private void CalculateCuboidVolume()
        {
            result = length * width * depth;
        }

        private void OutputCuboidVolume()
        {
            Console.WriteLine("The volume of your cuboid is: " + result + "\n");
        }

        //alows the private methods to be run by menu running the public method
        public void runCuboid()
        {
            GetLength();
            GetWidth();
            GetDepth();
            CalculateCuboidSurfArea();
            OutputCuboidSurfArea();
            OutputCuboidVolume();
            CalculateCuboidVolume();
        }
    }
}
