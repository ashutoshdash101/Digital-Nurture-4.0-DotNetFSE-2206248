using Confluent.Kafka;
using System;
using System.Threading;
using System.Windows.Forms;

namespace KafkaChatWinFormApp
{
    public partial class Form1 : Form
    {
        private readonly string bootstrapServers = "localhost:9092";
        private readonly string topic = "chat-topic";
        private Thread consumerThread;
        private bool keepConsuming = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartKafkaConsumer();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var config = new ProducerConfig { BootstrapServers = bootstrapServers };
            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                string message = txtMessageBox.Text;
                if (!string.IsNullOrEmpty(message))
                {
                    producer.ProduceAsync(topic, new Message<Null, string> { Value = message }).Wait();
                    lstChat.Items.Add("You: " + message);
                    txtMessageBox.Clear();
                }
            }
        }

        private void StartKafkaConsumer()
        {
            consumerThread = new Thread(() =>
            {
                var config = new ConsumerConfig
                {
                    GroupId = "chat-group",
                    BootstrapServers = bootstrapServers,
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };

                using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
                {
                    consumer.Subscribe(topic);

                    while (keepConsuming)
                    {
                        try
                        {
                            var result = consumer.Consume(TimeSpan.FromMilliseconds(500));
                            if (result != null)
                            {
                                Invoke(new Action(() =>
                                {
                                    lstChat.Items.Add("Friend: " + result.Message.Value);
                                }));
                            }
                        }
                        catch
                        {
                            // optional: log errors
                        }
                    }

                    consumer.Close();
                }
            });

            consumerThread.IsBackground = true;
            consumerThread.Start();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            keepConsuming = false;
            this.Close();
        }
    }
}
