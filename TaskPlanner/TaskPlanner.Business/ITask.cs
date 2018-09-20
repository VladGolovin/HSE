namespace TaskPlanner.Business
{
    /// <summary>
    /// Работа
    /// </summary>
    public interface ITask
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Продолжительность
        /// </summary>
        double Duration { get; set; }
    }
}
