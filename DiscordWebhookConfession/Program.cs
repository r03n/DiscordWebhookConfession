using JNogueira.Discord.Webhook.Client;

namespace Confession_Discord_Webhook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var client = new DiscordWebhookClient(DiscordWebhook.defaultWebhook);

        }
    }
}