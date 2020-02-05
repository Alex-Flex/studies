using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Класс со строками, легче написать их в одном 
    /// месте, чем собирать по всем файлам
    /// </summary>
    class Strings
    {
        public static string GREETING = "Привет, нужна помощь? Введи help";
        public static string COMMAND_PREFIX = "\n" + DateTime.Now.ToString() + " > ";
        public static string HELP = "\nСинтаксис команды созданиия фигуры выглядит так:" +
            "\nназвание_фигуры способ_создания параметры, где:" +
            "\nназвание_фигуры: одно из следующих слов:" +
            "\n\ttriangle -- треугольник" +
            "\n\trectangle -- прямоугольник" +
            "\n\tsquare -- квадрат" +
            "\n\tcircle -- круг" +
            "\n\tpolygon -- многоугольник" +
            "\n\tellipse -- эллипс" +
            "\nспособ_создания: bypoint (по точкам) или byside (по сторонам)" +
            "\nпараметры: числа, идут через пробелы (15 26 48)" +
            "\tили точки, пишутся как: x1,y1;x2,y2; и т. д." +
            "\n\n exit -- выход, clear -- удаляет все фигуры в данном сеансе";

        public static string NO_SUCH_COMMAND = "\nТакой команды нет, введите help для подробностей";
        public static string WRONG_COMMAND = "\nНеверные параметры или синтаксис команды. help в помощь";
        public static string SUCCESS = "\nКоманда выполнена!";
        public static string COMMON_RESULT = "Общие значения величин: ";
    }
}
