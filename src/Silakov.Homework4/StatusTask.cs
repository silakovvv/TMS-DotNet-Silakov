namespace Silakov.Homework4
{
    /// <summary>
    /// Статусы задач.
    /// </summary>
    internal enum StatusTask
    {
        /// <summary>
        /// Запланирована.
        /// </summary>
        planned = 1,
        /// <summary>
        /// Выполняется.
        /// </summary>
        inProgress,
        /// <summary>
        /// Выполнена.
        /// </summary>
        completed,
        /// <summary>
        /// Отменена.
        /// </summary>
        canceled,
    }
}
