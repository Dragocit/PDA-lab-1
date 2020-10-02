using Grpc.Core;
using GrpcAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reciever.Services
{
    public class NotificationService : Notifier.NotifierBase
    {
        public override Task<NotifyReply> Notify(NotifyRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Recieved: {request.Content}");

            return Task.FromResult(new NotifyReply() { IsSuccess = true });
        }

    }
}
