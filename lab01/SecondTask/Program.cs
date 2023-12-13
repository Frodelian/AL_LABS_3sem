using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEx
{
    public class Rectangle // Класс Rectangle
    {
        public Rectangle() // Два поля описывающие длины сторон 
        {
            side1 = 0;
            side2 = 0;
        }

        public Rectangle(double sideA, double sideB) // Конструктор инициализирующий поля side1 и side2
        {
            side1 = sideA;
            side2 = sideB;
        }

        private double AreaCalculator() // Площадь прямоугольника 
        {
            return side1 * side2;
        }

        private double PerimeterCalculator() // Периметр прямоугольника
        {
            return 2 * side1 + 2 * side2;
        }

        // Свойства вызывающие созданные ранее методы
        public double Area
        {
            // get выполняет действия по получению значения свойства
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        public double side1;
        public double side2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide;
            double secondSide;

            Console.WriteLine("Введите размер первой стороны: ");
            double.TryParse(Console.ReadLine(), out firstSide);

            Console.WriteLine("Введите размер второй стороны: ");
            double.TryParse(Console.ReadLine(), out secondSide);

            Rectangle r1 = new Rectangle(firstSide, secondSide);

            Console.WriteLine("Площадь прямоугольник равна {0}", r1.Area);
            Console.WriteLine("Периметр прямоугольник равен {0}", r1.Perimeter);

        }
    }
}