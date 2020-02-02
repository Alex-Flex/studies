using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Все запомненные фигуры здесь
    /// </summary>
    class Context
    {
        private List<Shape2D> shapes;
        private string filename = "remembered_shapes";
        private FileInfo info;

        public Context()
        {
            this.shapes = new List<Shape2D>();
            info = new FileInfo(filename);
            info.Create();
            File.SetAttributes(info.FullName, FileAttributes.Normal);
        }

        /// <summary>
        /// Получить фигуру
        /// </summary>
        /// <param name="index">Номер в списке</param>
        /// <returns>Фигура</returns>
        public Shape2D Get(int index)
        {
            return shapes.ElementAt(index);
        }

        /// <summary>
        /// Добавить фигуру
        /// </summary>
        /// <param name="o">Фигура</param>
        public void Add(Shape2D o)
        {
            shapes.Add(o);
            Remember();
        }

        /// <summary>
        /// Подытоживаем наши свершения
        /// </summary>
        public void Totalize()
        {
            double perimeter = 0;
            double spaces = 0;
            foreach (Shape2D s in shapes)
            {
                Console.WriteLine(s.ToString());
                spaces += s.S();
                perimeter += s.P();
            }
            Console.WriteLine(Strings.COMMON_RESULT + "P = {0}, S = {1}", perimeter, spaces);
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
                File.SetAttributes(info.FullName, FileAttributes.Normal);
            }
            Stream stream = new FileStream(info.FullName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(stream);
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
