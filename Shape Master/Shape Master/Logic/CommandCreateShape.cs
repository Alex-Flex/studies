using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Команда на создание фигуры
    /// </summary>
    class CommandCreateShape : Command
    {
        private Context context;
        private string command;
        private string parameters;
        private string howtocreate;
        private string figure;
        private string[] words;

        public CommandCreateShape(Context context, string command)
        {
            this.context = context;
            this.command = command;
            string[] words = command.Split(' ');
        }

        /// <summary>
        /// Исполняет команду
        /// </summary>
        public override void Execute()
        {
            
        }

        /// <summary>
        /// Парсит команду
        /// </summary>
        private void Parse()
        {
            string[] args = command.Split(' ');
            figure = args[0];
            howtocreate = args[1];
            string
            if(howtocreate == "bypoint")
            {
                
            }
            else
            {

            }
        }

        /// <summary>
        /// Проверяет правильность введённых данных
        /// </summary>
        /// <returns>Всё ок или нет?</returns>
        public override bool Validate()
        {
            //неверный способ создания фигуры
            if (words[1] != "bypoint" && words[1] != "byside") return false;

            //нельзя создать многоугольник по сторонам
            if (words[0] == "polygon" && words[1] == "byside") return false;

            //неправильное название фигуры
            if (words[0] != "triangle" && words[0] != "rectangle"
                && words[0] != "circle" && words[0] != "square") return false;

            return ValidateBySide();
        }

        /// <summary>
        /// Проверка на отрицательные стороны при спопобе создания "byside"
        /// </summary>
        /// <returns></returns>
        private bool ValidateBySide()
        {
            if (words[1] == "byside")
            {
                for (int i = 2; i < words.Length; i++)
                {
                    double d;
                    if (Double.TryParse(words[i], out d))
                    {
                        if (d <= 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
