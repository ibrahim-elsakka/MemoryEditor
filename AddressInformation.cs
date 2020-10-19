namespace MemoryEditor
{
    internal class AddressInformation
    {
        public int Address;
        public int Value;
        public int FormerValue;

        public AddressInformation(int address, int value, int formerValue)
        {
            Address = address;
            Value = value;
            FormerValue = formerValue;
        }
    }
}