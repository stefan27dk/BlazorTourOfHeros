using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTourOfHeros.Client.Services
{
    public interface IMessagingService
    {
        Task Add(string Message);

        Task Clear();

        List<string> Get();

        event EventHandler<List<string>> OnMessagesChanged;  // Event Handler
    }
}
