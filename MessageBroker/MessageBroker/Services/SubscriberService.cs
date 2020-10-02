using Grpc.Core;
using GrpcAgent;
using MessageBroker.Models;
using MessageBroker.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBroker.Services
{
    public class SubscriberService : Subscriber.SubscriberBase
    {
        private readonly IConnectionStorageService _connectionStorage;

        public SubscriberService(IConnectionStorageService connectionStorage)
        {
            _connectionStorage = connectionStorage;
        }



        public override Task<SubscribeReply> Subscribe(SubscribeRequest request, ServerCallContext context)
        {
            Console.WriteLine($"New client trying to  subscribed: { request.Address} { request.Topic}");

            try
            {
                var connection = new Connection(request.Address, request.Topic);
                _connectionStorage.Add(connection);

            }
            catch(Exception e)
            {
                Console.WriteLine($"Could not add the new connection {request.Address} {request.Topic}. {e.Message}");
            }

          
           // Console.WriteLine($"New client subscribed: { request.Address} { request.Topic}");

            return Task.FromResult(new SubscribeReply()
            {
                IsSuccess = true

            });
        }
    }
}
