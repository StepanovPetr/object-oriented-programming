namespace LibExample
{
    public class ClassForUnitTesting
    {
        /// <summary> Сила тока. </summary>
        /// <param name="electricalVoltage">Электрическое Напряжение.</param>
        /// <param name="electricalResistance"> Электрическое Сопротивление.</param>
        /// <returns></returns>
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