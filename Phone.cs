using System;

namespace DevicesApp
{
    /// <summary>
    /// Телефон — заряжаемое устройство.
    /// </summary>
    public class Phone : Device, IChargeable
    {
        /// <summary>
        /// Размер экрана в дюймах.
        /// </summary>
        public double ScreenSize { get; set; }

        /// <summary>
        /// Признак «фаблета»: <c>true</c>, если размер экрана больше 5.5 дюймов.
        /// </summary>
        public bool IsPhablet => ScreenSize > 5.5;

        /// <summary>
        /// Создаёт телефон с указанными параметрами.
        /// </summary>
        /// <param name="serial">Серийный номер.</param>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность в киловаттах.</param>
        /// <param name="screenSize">Размер экрана в дюймах.</param>
        public Phone(string serial, string model, double power, double screenSize)
            : base(serial, model, power)
        {
            ScreenSize = screenSize;
        }

        /// <summary>
        /// Включает телефон.
        /// </summary>
        public override void TurnOn()
        {
            Console.WriteLine($"{Model} turns on.");
        }
    }
}