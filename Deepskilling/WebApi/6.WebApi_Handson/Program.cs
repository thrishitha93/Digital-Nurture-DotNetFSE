using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Chat Producer");
Console.WriteLine("Type your message. Type 'exit' to stop.");

while (true)
{
    Console.Write("You: ");
    string? message = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(message))
        continue;

    if (message.ToLower() == "exit")
        break;

    await producer.ProduceAsync(
        "chat-topic",
        new Message<Null, string>
        {
            Value = message
        });

    Console.WriteLine("Message sent to Kafka!");
}