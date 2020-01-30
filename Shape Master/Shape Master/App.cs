using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    public class App
    {
        public static void Run()
        {
            int figure;
            List<Shape> shapes = new List<Shape>();
            Shape s = null;
            while(true){
                Console.WriteLine("1--Круг\n" +
                              "2--Квадрат\n" +
                              "3--Прямоугольник\n" +
                              "4--Треугольник\n" +
                              "5 -- многоугольник\n" +
                              "Введите номер фигуры: ");
                figure = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nВведите стороны: ");
                switch(figure){
                    case 1:
                        s = new Circle(GetInput());
                        break;
                    case 2:
                        s = new Square(GetInput());
                        break;
                    case 3:
                        s = new Rectangle(GetInput(), GetInput());
                        break;
                    case 4:
                        s = new Triangle(GetInput(), GetInput(), GetInput());
                        break;
                    case 5:
                        Console.WriteLine("Введите координаты точек, точек должно быть не меньше 5.\n" +
                                "Когда закончите, просто нажмите Enter, ничего не вводя");
                        List<Point> points = new List<Point>();
                        while (true)
                        {
                            try
                            {
                                Point p = new Point(GetInput(), GetInput());
                                points.Add(p);
                            }
                            catch (System.FormatException)
                            {
                                break;
                            }
                        }
                        s = new Polygon(points);
                        break;
                    default:
                        continue;
                }
                Console.WriteLine("P={0} S={1}", s.P(), s.S());
                shapes.Add(s);
                Console.Write("Желаете повторить? y -- да, n -- нет");
                if(Console.ReadLine()=="n")
                {
                    //сумма периметров всех фигур
                    double psum = shapes.Sum(P => s.P());
                    //сумма площадей всех фигур
                    double ssum = shapes.Sum(S => s.S());
                    Console.WriteLine("Периметр = {0}, Площадь = {1}", psum, ssum);
                    break;
                }
                Console.Clear();
            }
        }

        //просто получаем дробное число с клавиатуры
        private static double GetInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}