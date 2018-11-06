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


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


    public class Rectangle
    {

        private double _width;
        private double _length;

        public Rectangle()
        {
            _width = 1;
            _length = 1;
            Console.WriteLine("It's a Square!");
        }

        public Rectangle(double width, double length)
        {
            this._width = width;
            this._length = length;
            Console.WriteLine("It's a Rectangle!");

        }

        public string Width { get; set; }

        public string Length { get; set; }

       public double Area () {

            return _width * _length;
                       
       }

        public double Perimeter() {

            return (_width + _length) * 2;

        }


    }



}


/*
 * 
 * Console.WriteLine("The combined ages of {0} and {1} is {2}", persons[0].Name, persons[1].Name, persons[0] + persons[1]);
            Console.WriteLine();
            Person[] p3 = new Person[1];
            p3[0] = new Person();

            p3[0].Name = "Masha";
            p3[0].Age = -4;
p3[0].GreetFriend();
 * 
 * /
 */
