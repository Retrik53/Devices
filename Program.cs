using System;

namespace DevicesApp
{
    class Program
    {

        static void Main()
        {
            Laptop laptop = new Laptop("SN-001", "ThinkPad", 65, 60);
            Desktop desktop = new Desktop("SN-002", "Gaming PC", 500, "Large");
            Phone phone = new Phone("SN-003", "Galaxy S", 25, 6.1);

            laptop.PrintInfo();
            desktop.PrintInfo();
            phone.PrintInfo();
        }
    }
}