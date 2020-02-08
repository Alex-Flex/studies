namespace Shape_Master.Logic
{
    interface ICommand
    {
        /// <summary>
        /// Имя команды
        /// </summary>
       string Name { get;  }
        /// <summary>
        /// Выполнение команды, а заодно и её парсинг
        /// </summary>
        /// <param name="context">Хранилище фигур</param>
        /// <param name="params">Текст команды</param>
        /// <returns>true, если команда выполнена успешно</returns>
        bool Execute(Context context, string @params);
    }
}
