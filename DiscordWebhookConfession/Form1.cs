namespace Confession_Discord_Webhook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiscordWebhook.Send("Yes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiscordWebhook.Send("No");
        }
    }
}