using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projectmain
{
    class socketconn
    {
        /*
        ClientWebSocket client = new ClientWebSocket();
        cts = new cancellationTokenSource();
        async void ConnectToServerAsync()
        {
            
            await client.ConnectAsync(new Uri("http://192.168.1.105/"), cts.Token);
            UpdateClientState();
        }


        async Task ReadMessage()
        {
            WebSocketReceiveResult result;
            var message = new ArraySegment(new byte[4096]);
            do
            {
                result = await client.ReceiveAsync(message, cts.Token);
                if (result.MessageType != WebSocketMessageType.Text)
                    break;
                var messageBytes = message.Skip(message.Offset).Take(result.Count).ToArray();
                string receivedMessage = Encoding.UTF8.GetString(messageBytes);
                Console.WriteLine("Received: {0}", receivedMessage);
            }
            while (!result.EndOfMessage);
        }
        */
    }
}