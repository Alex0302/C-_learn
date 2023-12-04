string token = File.ReadAllText("app.config");
TelegramBotClient botClient = new(token);

botClient.StartReceiving(m => Console.WriteLine(m));

Console.WriteLine("stop");