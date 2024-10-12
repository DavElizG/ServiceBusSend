using Azure.Messaging.ServiceBus;
using DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceBusSenderService
    {
        private const string ConnectionString = "Cadena-de-Conexion";
        private const string QueueName = "dev-event-source-1";

        private readonly ServiceBusClient _client;
        private readonly ServiceBusSender _sender;

        public ServiceBusSenderService()
        {
            _client = new ServiceBusClient(ConnectionString);
            _sender = _client.CreateSender(QueueName);
        }

        public async Task SendMessageAsync(MessageEntity messageEntity)
        {
            ServiceBusMessage message = new ServiceBusMessage(messageEntity.Content);

            try
            {
                await _sender.SendMessageAsync(message);
                Console.WriteLine($"Mensaje enviado: {messageEntity.Content}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al enviar mensaje: {ex.Message}");
            }
        }
    }
}