using FortNiteStatus.TelegramBot;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace FortNiteStatus.TelegramBotManual
{
    class Program
    {
        static Task Main(string[] args)
        {
            if (!System.IO.File.Exists("appSettings.json"))
            {
                Console.WriteLine("appSettings.json file was not found, please add one with TRN-Api-Key and TelegramToken values");
                return Task.CompletedTask;
            }

            var configs = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();

            var trnApiKey = configs.GetSection("TRN-Api-Key").Value;
            var telegramToken = configs.GetSection("TelegramToken").Value;


            var manualBot = new TelegramBotManualEngine(telegramToken, trnApiKey);

            Console.WriteLine("Reading updates");
            return manualBot.ReadUpdates();
        }
    }
}
