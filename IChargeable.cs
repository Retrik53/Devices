namespace DevicesApp
{
    /// <summary>
    /// Интерфейс для устройств, которые можно заряжать.
    /// </summary>
    public interface IChargeable
    {
        /// <summary>
        /// Модель устройства (используется для вывода сообщения о зарядке).
        /// </summary>
        string Model { get; }

        /// <summary>
        /// Заряжает устройство.
        /// </summary>
        void Charge()
        {
            Console.WriteLine($"{Model} charging...");
        }
    }
}