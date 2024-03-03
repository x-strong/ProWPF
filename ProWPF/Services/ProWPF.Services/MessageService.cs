using ProWPF.Services.Interfaces;

namespace ProWPF.Services
{
  public class MessageService : IMessageService
  {
    public string GetMessage()
    {
      return "Hello from the Message Service";
    }
  }
}
