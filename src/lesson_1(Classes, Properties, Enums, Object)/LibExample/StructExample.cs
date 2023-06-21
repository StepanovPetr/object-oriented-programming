namespace LibExample
{
    public struct StructExample
    {
        public bool Field1;
        public int Field2; // = 112233;
        public double Field3;

        public string Info => $"{Field1} {Field2} {Field3}";

        public StructExample(bool field1, int field2, double field3)
        {
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
        }
    }
}