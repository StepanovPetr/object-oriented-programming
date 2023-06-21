namespace LeetCode.Common.Factories
{
    public static class ListNodeFactory
    {
        public static ListNode FactoryMethod(int[] mas)
        {
            ListNode result = null;
            ListNode previous = null;
            foreach (var item in mas)
            {
                ListNode node = new ListNode(item, null);
                if (result == null)
                {
                    result = node;
                    previous = node;
                }
                else
                {
                    previous.next = node;
                    previous = node;
                }
            }

            return result;
        }
    }
}