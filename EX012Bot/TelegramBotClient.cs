using System.Text;
using Newtonsoft.Json.Linq;

public class TelegramBotClient
{
  private HttpClient httpClient;
  private string baseUri;
  public TelegramBotClient(string token)
  {
    this.httpClient = new HttpClient();
    baseUri = $"https://api.telegram.org/bot{token}";
  }

  public HttpResponseMessage SendMessage(string chatId, string text, int replyToMessageId = 0)
  {
    string rawBody = $$"""
    {
      "chat_id": {{chatId}},
      "text": "{{text}}",
      "reply_to_message_id": {{replyToMessageId}}
    }
    """;
    StringContent content = new StringContent(
      rawBody,
      Encoding.UTF8,
      "application/json"
    );

    return this
    .httpClient
    .PostAsync(this.baseUri + "/sendmessage", content).Result;
  }

  public string GetUpdates(Action<string> action)
  {
    string json = this.httpClient.GetStringAsync(this.baseUri + "/getUpdates").Result;

    JObject response = JObject.Parse(json);
    JArray arrayMessage = (JArray)response["result"];
    int offset = 0;
    foreach (dynamic msg in arrayMessage)
    {
      string text = $"Получено. {msg.message.text}"; //"Я шпион! Я наблюдаю за тобой";
      string chatId = msg.message.chat.id;
      int msgId = msg.message.message_id;
      offset = msg.update_id;
      var res = this.SendMessage(chatId, text, msgId);

      action(res.ToString());
    }
    string str = this.baseUri + $"/getUpdates?offset={offset + 1}";
    System.Console.WriteLine(str);

    string r = this.httpClient.GetStringAsync(str).Result;
    return r;
  }

  public void StartReceiving(Action<string> action)
  {
    action("start");
    while (true)
    {
      this.GetUpdates(action);
      Thread.Sleep(2000);
    }
  }
}