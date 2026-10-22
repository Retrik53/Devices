using Devices;
using System;

namespace DevicesApp
{
    /// <summary>
    /// Базовый класс устройства.
    /// </summary>
    public abstract class Device
    {
        /// <summary>
        /// Серийный номер устройства.
        /// </summary>
        private string _serial;

        /// <summary>
        /// Модель устройства.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Мощность устройства в киловаттах.
        /// </summary>
        public double Power { get; set; }

        /// <summary>
        /// Источник питания устройства. По умолчанию — <see cref="PowerSource.Mains"/>.
        /// </summary>
        public PowerSource Source { get; set; } = PowerSource.Mains;

        /// <summary>
        /// Мощность устройства в ваттах (пересчёт из <see cref="Power"/>).
        /// </summary>
        public double PowerInWatts => Power * 1000;

        /// <summary>
        /// Создаёт устройство с указанным серийным номером, моделью и мощностью.
        /// </summary>
        /// <param name="serial">Серийный номер устройства.</param>
        /// <param name="model">Модель устройства.</param>
        /// <param name="power">Мощность устройства в киловаттах.</param>
        public Device(string serial, string model, double power)
        {
            _serial = serial;
            Model = model;
            Power = power;
        }

        /// <summary>
        /// Создаёт устройство с указанной моделью. Серийный номер — <c>"N/A"</c>, мощность — <c>0</c>.
        /// </summary>
        /// <param name="model">Модель устройства.</param>
        public Device(string model) : this("N/A", model, 0) { }

        /// <summary>
        /// Включает устройство.
        /// </summary>
        public abstract void TurnOn();

        /// <summary>
        /// Выводит в консоль информацию об устройстве, включает его
        /// и, если устройство заряжаемое, запускает зарядку.
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine(new string('-', 40));
            
            string type = GetType().Name;

            Console.WriteLine($"[{type}] {Model}, {Power}W, source: {Source}");
            Console.WriteLine($"  watts: {PowerInWatts}");
            TurnOn();

            if (this is IChargeable chargeable)
            {
                chargeable.Charge();
            }
            else
            {
                Console.WriteLine($"{Model} cannot be charged.");
            }

        }
    }
}