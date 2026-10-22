using System;

namespace DevicesApp
{
    /// <summary>
    /// Настольный компьютер. Не поддерживает зарядку.
    /// </summary>
    public class Desktop : Device
    {
        /// <summary>
        /// Размер корпуса (например, <c>"Large"</c>, <c>"Mid"</c>, <c>"Mini"</c>).
        /// </summary>
        public string TowerSize { get; set; }

        /// <summary>
        /// Признак игрового компьютера: <c>true</c>, если размер корпуса равен <c>"Large"</c>.
        /// </summary>
        public bool IsGaming => TowerSize == "Large";

        /// <summary>
        /// Создаёт настольный компьютер с указанными параметрами.
        /// </summary>
        /// <param name="serial">Серийный номер.</param>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность в киловаттах.</param>
        /// <param name="towerSize">Размер корпуса.</param>
        public Desktop(string serial, string model, double power, string towerSize)
            : base(serial, model, power)
        {
            TowerSize = towerSize;
        }

        /// <summary>
        /// Включает компьютер.
        /// </summary>
        public override void TurnOn()
        {
            Console.WriteLine($"{Model} turns on.");
        }
    }
}