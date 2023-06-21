using System.Threading.Tasks;

namespace LibExample
{
    public static class AsyncExample
    {
        public static void Wait()
        {
            Task.Delay(10000);
        }

        public static async void WaitAsync()
        {
            await Task.Delay(10000);
        }
    }
}
