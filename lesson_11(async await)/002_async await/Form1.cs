using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibExample;

namespace _002_async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsyncExample.Wait();
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            await AsyncExample.WaitAsync();
        }
    }
}
