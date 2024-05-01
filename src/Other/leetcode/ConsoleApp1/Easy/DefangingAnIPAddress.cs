namespace LeetCode.Easy
{
    public class DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}