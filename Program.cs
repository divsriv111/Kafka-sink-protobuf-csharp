using Confluent.Kafka;
using Confluent.Kafka.SyncOverAsync;
using Confluent.SchemaRegistry;
using Confluent.SchemaRegistry.Serdes;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            const string bootstrapServers = "localhost:9092";   //kafka server
            const string schemaRegistryUrl = "localhost:8081";  //schema registry server url
            const string topicName = "test";                    //topic name

            var producerConfig = new ProducerConfig
            {
                BootstrapServers = bootstrapServers
            };

            var schemaRegistryConfig = new SchemaRegistryConfig
            {
                Url = schemaRegistryUrl
            };

            var consumerConfig = new ConsumerConfig
            {
                BootstrapServers = bootstrapServers,
                GroupId = "protobuf-sink-consumer-group"
            };

            CancellationTokenSource cts = new CancellationTokenSource();
            var consumeTask = Task.Run(() =>
            {
                using var consumer =
                    new ConsumerBuilder<string, User>(consumerConfig)
                        .SetValueDeserializer(new ProtobufDeserializer<User>().AsSyncOverAsync())
                        .SetErrorHandler((_, e) => Console.WriteLine($"Error: {e.Reason}"))
                        .Build();
                consumer.Subscribe(topicName);

                try
                {
                    while (true)
                    {
                        try
                        {
                            var consumeResult = consumer.Consume(cts.Token);
                            Console.WriteLine($"UserId: {consumeResult.Message.Key}, Name: {consumeResult.Message.Value.Name}");
                        }
                        catch (ConsumeException e)
                        {
                            Console.WriteLine($"Consume error: {e.Error.Reason}");
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    consumer.Close();
                }
            }, cts.Token);

            using var schemaRegistry = new CachedSchemaRegistryClient(schemaRegistryConfig);
            using var producer = new ProducerBuilder<string, User>(producerConfig)
                .SetValueSerializer(new ProtobufSerializer<User>(schemaRegistry))
                .Build();
            Console.WriteLine($"{producer.Name} producing on {topicName}.");

            var i = 0;
            string text;
            Console.WriteLine(@"Enter user names (press 'q' to stop):");
            while ((text = Console.ReadLine()) != "q")
            {
                var user = new User
                {
                    Userid = i++,
                    Name = text,
                    Contact = new Contact()
                    {
                        Phone = 999999999,
                        Email = "protobuf@example.com",
                        Fax = "NA"
                    }
                };

                await producer
                    .ProduceAsync(topicName, new Message<string, User> { Key = user.Userid.ToString(), Value = user }, cts.Token)
                    .ContinueWith(task => task.IsFaulted
                        ? $"error producing message: {task.Exception.Message}"
                        : $"produced to: {task.Result.TopicPartitionOffset}", cts.Token);
                cts.Cancel();
            }
        }
    }
}


