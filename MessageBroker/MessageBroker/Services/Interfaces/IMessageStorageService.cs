using MessageBroker.Models;


namespace MessageBroker.Services.Interfaces
{
   public interface IMessageStorageService
    {
        void Add(Message message);

        Message GetNext();

        bool IsEmpty();
    }
}
