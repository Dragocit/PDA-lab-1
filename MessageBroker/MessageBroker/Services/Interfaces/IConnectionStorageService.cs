using MessageBroker.Models;

using System.Collections.Generic;


namespace MessageBroker.Services.Interfaces
{
   public interface IConnectionStorageService
    {
        void Add(Connection connection);

        void Remove(string address);

        IList<Connection> GetConnectionsByTopic(string topic);
    }
}
