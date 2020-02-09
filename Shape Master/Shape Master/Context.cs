using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Все запомненные фигуры здесь
    /// </summary>
    class Context
    {
        private List<IShape> shapes;
        private string filename = "remembered_shapes";
        private FileInfo info;

        public Context()
        {
            this.shapes = new List<IShape>();
            if(info==null)
                info = new FileInfo(filename);
            if (!info.Exists)
                info.Create();
            File.SetAttributes(info.FullName, FileAttributes.Normal);
        }

        /// <summary>
        /// Получить фигуру
        /// </summary>
        /// <param name="index">Номер в списке</param>
        /// <returns>Фигура</returns>
        public IShape Get(int index)
        {
            return shapes.ElementAt(index);
        }

        /// <summary>
        /// Добавить фигуру
        /// </summary>
        /// <param name="o">Фигура</param>
        public void Add(IShape o, string command)
        {
            shapes.Add(o);
            Remember(command);
        }

        /// <summary>
        /// Подытоживаем наши свершения
        /// </summary>
        public void Totalize()
        {
            double perimeter = 0;
            double spaces = 0;
            double sp, per;
            foreach (IShape s in shapes)
            {
                per = s.P();
                sp = s.S();
                Console.WriteLine(s.GetType() + ", P = {0}, S = {1}", per, sp);
                spaces += sp;
                perimeter += per;
            }
            Console.WriteLine(Strings.COMMON_RESULT + "P = {0}, S = {1}", perimeter, spaces);
        }

        /// <summary>
        /// Добавляем параметры фигуры в файл
        /// </summary>
        public void Remember(string s)
        {
            if (info == null)
            {
                info = new FileInfo(filename);
                if(!info.Exists)
                    info.Create();
                File.SetAttributes(info.FullName, FileAttributes.Normal);
            }

            Stream stream = new FileStream(info.FullName, FileMode.Open, FileAccess.Write, FileShare.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(s);
            writer.Close();
            stream.Close();
        }

        /// <summary>
        /// Удаляем файл с фигурами
        /// </summary>
        public void ForgetAll()
        {
            info.Delete();
            info = null;
        }

        /// <summary>
        /// Получаем список команд
        /// </summary>
        /// <returns></returns>
        public List<ICommand> GetCommandList()
        {
            List<ICommand> commands = new List<ICommand>();
            Type[] types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetType().IsInstanceOfType(typeof(ICommand)))
                .ToArray();
            foreach (Type t in types)
            {
                ICommand command = (ICommand) Activator.CreateInstance(t);
                commands.Add(command);
            }
            return commands;
        }
    }
}
