﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTourOfHeros.Client.Services
{
    public class MessagingService : IMessagingService
    {
        // Messages List
        public List<string> Messages { get; set; } = new List<string>();


        public event EventHandler<List<string>> OnMessagesChanged;


        // Get
        public List<string> Get() => Messages;
  

        // Add
        public async Task Add(string message)
        {
            await Task.Factory.StartNew(() => Messages.Add(message));
            OnMessagesChanged?.Invoke(this, Messages);
        }


        // Clear
        public async Task Clear()
        {
            await Task.Factory.StartNew(() => Messages.Clear());
            OnMessagesChanged.Invoke(this, Messages);
        }

    }
}
