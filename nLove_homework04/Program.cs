using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";
            //parameters
            //width
            double w;
            //length
            double l;
            //area
            double a;
            //perimeter
            double p;

            //create new default object
            Rectangle square = new Rectangle();
            Console.WriteLine("Area of the square is {0}.", square.Area());
            Console.WriteLine("Perimeter of the square is {0}.", square.Perimeter());

            //loop for recalculating
            while (answer == "yes")
            {
                Console.WriteLine("");
                Console.WriteLine("What is the width of the Rectangle?");
                string wid = Console.ReadLine();
                w = Int32.Parse(wid);
                if (w<=0)
                {
                    Console.WriteLine("Invalid value!");
                    continue;
                }
                Console.WriteLine("");
                Console.WriteLine("What is the length of the Rectangle?");
                string len = Console.ReadLine();
                l = Int32.Parse(len);
                if (l <= 0)
                {
                    Console.WriteLine("Invalid value!");
                    continue;
                }

                //create new custom object

                Rectangle rectangle = new Rectangle(w, l);

                //calculate area
                Console.WriteLine("Area of the rectagle is {0}.", rectangle.Area());
                //calculate perimeter
                Console.WriteLine("Perimeter of the rectangle is {0}.", rectangle.Perimeter());



                Console.WriteLine("Do you want to change the values and recalculate? (yes/no)");
                answer = Console.ReadLine();
            }
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    // create class
    public class Rectangle
    {

        private double _width;
        private double _length;

        //default constructor
        public Rectangle()
        {
            _width = 1;
            _length = 1;
            Console.WriteLine("It's a Square!");
        }

        //custom constructor
        public Rectangle(double width, double length)
        {
            this._width = width;
            this._length = length;
            Console.WriteLine("It's a Rectangle!");

        }

        //to see the erase message in the end - start the program without debugging - or hotkeys:ctrl+fn+F5
        ~Rectangle()
        {
            Console.WriteLine("You erased rectangle");
        }

        //getters and setters for width and length
        public string Width { get; set; }

        public string Length { get; set; }

        //Area method
        public double Area () {

            return _width * _length;
                       
        }

        //Perimeter method
        public double Perimeter() {

            return (_width + _length) * 2;

        }


    }



}

