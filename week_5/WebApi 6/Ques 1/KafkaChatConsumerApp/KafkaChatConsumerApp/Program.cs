using System;
using System.Threading;
using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            GroupId = "chat-group",
            BootstrapServers = "localhost:9092",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("=== Kafka Chat Consumer Started ===");
        Console.WriteLine("Waiting for messages...\n");

        while (true)
        {
            var cr = consumer.Consume(CancellationToken.None);
            Console.WriteLine("Friend: " + cr.Message.Value);
        }
    }
}
