﻿namespace LibExample
{
    public class ClassForUnitTesting
    {
        // Сила тока.
        public static double Amperage(double electricalVoltage, double electricalResistance)
        {
            return electricalVoltage / electricalResistance;
        }

        public static double ElectricalVoltage(double amperage, double electricalResistance)
        {
            return amperage * electricalResistance;
        }

        public static double ElectricalResistance(double amperage, double electricalVoltage)
        {
            return electricalVoltage / amperage;
        }
    }
}