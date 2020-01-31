using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Все заомненные фигуры здесь
    /// </summary>
    class Context
    {
        private List<Shape> shapes;
        private string filename = "remembered_shapes";
        private FileInfo info;

        public Context()
        {
            this.shapes = new List<Shape>();
            new FileInfo(filename);
            info.Create();
        }

        /// <summary>
        /// Получить фигуру
        /// </summary>
        /// <param name="index">Номер в списке</param>
        /// <returns>Фигура</returns>
        public Shape Get(int index)
        {
            return shapes.ElementAt(index);
        }

        /// <summary>
        /// Добавить фигуру
        /// </summary>
        /// <param name="o">Фигура</param>
        public void Add(Shape o)
        {
            shapes.Add(o);
            Remember();
        }

        /// <summary>
        /// Сумма всех периметров фигур 
        /// </summary>
        /// <returns></returns>
        public double TotalizeP()
        {
            double perimeter = 0;
            foreach(Shape s in shapes)
            {
                perimeter += s.P();
            }
            return perimeter;
        }

        /// <summary>
        /// Сумма всех площадей фигур
        /// </summary>
        /// <returns></returns>
        public double TotalizeS()
        {
            double spaces = 0;
            foreach (Shape s in shapes)
            {
                spaces += s.S();
            }
            return spaces;
        }

        /// <summary>
        /// Добавляем параметры фигуры в файл
        /// </summary>
        public void Remember()
        {
            if (info == null)
            {
                info = new FileInfo(filename);
                info.Create();
            }
            StreamWriter writer = new StreamWriter(info.FullName, true);
            writer.WriteLine(shapes.ElementAt(shapes.Count() - 1));
            writer.Close();
        }

        /// <summary>
        /// Удаляем файл с фигурами
        /// </summary>
        public void ForgetAll()
        {
            info.Delete();
            info = null;
        }
    }
}
