using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace L4_UDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_GenerateFunction1.SelectedIndex = 0;
            comboBox_GenerateFunction2.SelectedIndex = 1;
            comboBox_GenerateFunction3.SelectedIndex = 2;
            comboBox_GenerateFunction4.SelectedIndex = 3;

        }
        UdpClient client1;
        UdpClient client2;
        UdpClient client3;
        UdpClient client4;

        Thread dataThread1;
        Thread dataThread2;
        Thread dataThread3;
        Thread dataThread4;
        private void button_IP_lidar_Click(object sender, EventArgs e)
        {

            if (button_IP.Text == "Подключится")
            {
                // Создание экземпляров класса UdpClient для каждого порта
                client1 = new UdpClient();
                client2 = new UdpClient();
                client3 = new UdpClient();
                client4 = new UdpClient();
                try
                {
                    // Запуск генерации и отправки данных в отдельных потоках
                    dataThread1 = new Thread(() => GenerateAndSendData(client1, textBox_IP1.Text, int.Parse(textBox_Port1.Text), comboBox_GenerateFunction1.SelectedItem.ToString()));
                    dataThread2 = new Thread(() => GenerateAndSendData(client2, textBox_IP2.Text, int.Parse(textBox_Port2.Text), comboBox_GenerateFunction2.SelectedItem.ToString()));
                    dataThread3 = new Thread(() => GenerateAndSendData(client3, textBox_IP3.Text, int.Parse(textBox_Port3.Text), comboBox_GenerateFunction3.SelectedItem.ToString()));
                    dataThread4 = new Thread(() => GenerateAndSendData(client4, textBox_IP4.Text, int.Parse(textBox_Port4.Text), comboBox_GenerateFunction4.SelectedItem.ToString()));

                    dataThread1.Start();
                    dataThread2.Start();
                    dataThread3.Start();

                    button_IP.Text = "Отключится";
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                // Остановка потоков
                if (dataThread3 != null && !dataThread3.IsAlive)
                {
                    dataThread3.Abort();
                }
                dataThread1.Abort();
                dataThread2.Abort();
                // dataThread3.Abort();

                client1.Close();
                client2.Close();
                client3.Close();
                button_IP.Text = "Подключится";
            }

        }
        static void GenerateAndSendData(UdpClient client, string serverIP, int serverPort, string selectedFunction)
        {
            Random random = new Random();
            double noiseLevel = 0.1; // Уровень шума
            Func<double, double> generateFunction;
            switch (selectedFunction)
            {
                case "Синусоида":
                    generateFunction = Generate.SineWave;
                    return;
                case "Линейные данные":
                    generateFunction = Generate.LinearData;
                    return;
                case "Случайные данные":
                    generateFunction = Generate.RandomData;
                    return;
                default:
                    generateFunction = null;
                    return;
            }

            while (true)
            {
                try
                {
                    // Генерация данных
                    double value = generateFunction(random.NextDouble());
                    value += noiseLevel * (random.NextDouble() - 0.5); // Добавление шума к данным

                    // Преобразование данных в массив байтов
                    byte[] data = Encoding.UTF8.GetBytes(value.ToString());

                    // Преобразование IP-адреса сервера в объект IPAddress
                    IPAddress serverAddress = IPAddress.Parse(serverIP);
                    // Формирование endPoint для отправки данных
                    IPEndPoint endPoint = new IPEndPoint(serverAddress, serverPort);

                    // Отправка данных
                    client.Send(data, data.Length, endPoint);

                    Console.WriteLine($"Отправлено на порт {serverPort}: {Encoding.UTF8.GetString(data)}");

                    // Задержка между отправками данных
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при отправке данных: {ex.Message}");
                }
            }
        }
    }
}
