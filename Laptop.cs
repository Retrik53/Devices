using System;

namespace DevicesApp
{
    /// <summary>
    /// Ноутбук — заряжаемое устройство.
    /// </summary>
    public class Laptop : Device, IChargeable
    {
        /// <summary>
        /// Ёмкость аккумулятора в ватт-часах.
        /// </summary>
        public double BatteryCapacity { get; set; }

        /// <summary>
        /// Признак долгоиграющего ноутбука: <c>true</c>, если ёмкость аккумулятора больше 50.
        /// </summary>
        public bool IsLongLasting => BatteryCapacity > 50;

        /// <summary>
        /// Создаёт ноутбук с указанными параметрами.
        /// </summary>
        /// <param name="serial">Серийный номер.</param>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность в киловаттах.</param>
        /// <param name="batteryCapacity">Ёмкость аккумулятора в ватт-часах.</param>
        public Laptop(string serial, string model, double power, double batteryCapacity)
            : base(serial, model, power)
        {
            BatteryCapacity = batteryCapacity;
        }

        /// <summary>
        /// Включает ноутбук.
        /// </summary>
        public override void TurnOn()
        {
            Console.WriteLine($"{Model} turns on.");
        }
    }
}