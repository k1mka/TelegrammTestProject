using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;

namespace TelegramBotExperiments
{

    class Program
    {
        private static ITelegramBotClient bot = new TelegramBotClient("5539229150:AAEKqeMyt1oAPfdN471CDGGiEEXtaETu8Wc");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            string[] stringArray = { "Ты красивая!", "Самая лучшая!", "Офигенная!", "Люблю!" };

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {

                var message = update.Message;

                if (message.Text.ToLower() == "/start")
                {


                    for (int i = 0; i < stringArray.Length; i++)
                    {


                        await botClient.SendTextMessageAsync(message.Chat, stringArray[i]);
                        return;

                    }



                }



                //await botClient.SendTextMessageAsync(message.Chat, "Автор данного бота очень любит тебя, и он считает, что такая девушка как ты должна получать комплименты чаще");
                //await Task.Delay(1000);
                //await botClient.SendTextMessageAsync(message.Chat, "Так что с этого момента, каждые пару часов ты будешь получать комелиментик!");
                //await Task.Delay(1000);
                //await botClient.SendTextMessageAsync(message.Chat, "Если тебе вдруг станет грустно, помни всегда, что я рядом и я всегда тебя поддержу.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Улыбнись!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Когда я вижу твою улыбку, мне хочеться взлететь до неба!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Твоей фигуре могут позавидовать даже супер модели!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Твоей фигуре и внешности могут позавидовать даже  модели!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Твоя улыбка может сделать мир лучше, я постараюсь сделать чтобы ты чаще улыбалась");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Ты всегда выглядишь, словно сказочная принцесса.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Сегодня я задумался о том, что пора бы начать тебя ревновать.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Быть такой красивой – страшное преступление!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "У всех девушки как девушки, а у меня БОГИНЯ!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Ты ангел во плоти, простой человек не может быть так прекрасен.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "От тебя исходит столько света, что не нужно даже электричества.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Твой образ я видел во сне, с тех пор я не хочу просыпаться.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "С тобою тепло и хорошо в любую погоду.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Ум и красота несовместимы – но ты исключение из правил.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Всегда помни, ты особенная!");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Если тебе вдруг станет грустно, помни всегда, что я рядом и я всегда тебя поддержу.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Ты маленькая ведьма, ты околдовала меня своей красотой.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Мне тебя очень не хватает, я хочу быть с тобой рядом каждую минуту.");
                //await Task.Delay(1000000);
                //await botClient.SendTextMessageAsync(message.Chat, "Моя малышка, ты лучшее, что было в моей жизни.");
                //return;




            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
            });

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}