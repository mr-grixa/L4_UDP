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
                    dataThread1 = new Thread(() =>
                    {
                        string ip = string.Empty;
                        int port = 0;
                        string generateFunction = string.Empty;
                        double noise = 0.1;

                        // Получение значений из элементов управления с использованием Invoke
                        Invoke((MethodInvoker)(() =>
                        {
                            ip = textBox_IP1.Text;
                            port = int.Parse(textBox_Port1.Text);
                            generateFunction = comboBox_GenerateFunction1.SelectedItem.ToString();
                            noise = (double)numericUpDown1.Value;

                        }));

                        GenerateAndSendData(client1, ip, port, generateFunction, noise);
                    });
                    dataThread2 = new Thread(() =>
                    {
                        string ip = string.Empty;
                        int port = 0;
                        string generateFunction = string.Empty;
                        double noise = 0.1;

                        // Получение значений из элементов управления с использованием Invoke
                        Invoke((MethodInvoker)(() =>
                        {
                            ip = textBox_IP2.Text;
                            port = int.Parse(textBox_Port2.Text);
                            generateFunction = comboBox_GenerateFunction2.SelectedItem.ToString();
                            noise = (double)numericUpDown1.Value;

                        }));

                        GenerateAndSendData(client2, ip, port, generateFunction, noise);
                    });

                    dataThread3 = new Thread(() =>
                    {
                        string ip = string.Empty;
                        int port = 0;
                        string generateFunction = string.Empty;
                        double noise = 0.1;

                        // Получение значений из элементов управления с использованием Invoke
                        Invoke((MethodInvoker)(() =>
                        {
                            ip = textBox_IP3.Text;
                            port = int.Parse(textBox_Port3.Text);
                            generateFunction = comboBox_GenerateFunction3.SelectedItem.ToString();
                            noise = (double)numericUpDown1.Value;

                        }));

                        GenerateAndSendData(client3, ip, port, generateFunction, noise);
                    });

                    dataThread4 = new Thread(() =>
                    {
                        string ip = string.Empty;
                        int port = 0;
                        string generateFunction = string.Empty;
                        double noise = 0.1;

                        // Получение значений из элементов управления с использованием Invoke
                        Invoke((MethodInvoker)(() =>
                        {
                            ip = textBox_IP4.Text;
                            port = int.Parse(textBox_Port4.Text);
                            generateFunction = comboBox_GenerateFunction4.SelectedItem.ToString();
                            noise = (double)numericUpDown1.Value;
                        }));

                        GenerateAndSendData(client4, ip, port, generateFunction, noise);
                    });

                    //dataThread1 = new Thread(() => GenerateAndSendData(client1, textBox_IP1.Text, int.Parse(textBox_Port1.Text), comboBox_GenerateFunction1.SelectedItem.ToString()));
                    //dataThread2 = new Thread(() => GenerateAndSendData(client2, textBox_IP2.Text, int.Parse(textBox_Port2.Text), comboBox_GenerateFunction2.SelectedItem.ToString()));
                    //dataThread3 = new Thread(() => GenerateAndSendData(client3, textBox_IP3.Text, int.Parse(textBox_Port3.Text), comboBox_GenerateFunction3.SelectedItem.ToString()));
                    //dataThread4 = new Thread(() => GenerateAndSendData(client4, textBox_IP4.Text, int.Parse(textBox_Port4.Text), comboBox_GenerateFunction4.SelectedItem.ToString()));
                    if (checkBox1.Checked) dataThread1.Start();
                    if (checkBox2.Checked) dataThread2.Start();
                    if (checkBox3.Checked) dataThread3.Start();
                    if (checkBox4.Checked) dataThread4.Start();

                    button_IP.Text = "Отключится";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                // Остановка потоков
                if (dataThread1 != null && dataThread1.IsAlive)
                {
                    dataThread1.Abort();
                }
                if (dataThread2 != null && dataThread2.IsAlive)
                {
                    dataThread2.Abort();
                }
                if (dataThread3 != null && dataThread3.IsAlive)
                {
                    dataThread3.Abort();
                }
                if (dataThread4 != null && dataThread4.IsAlive)
                {
                    dataThread4.Abort();
                }

                // Закрытие объектов UdpClient
                client1.Close();
                client2.Close();
                client3.Close();
                client4.Close();

                button_IP.Text = "Подключится";
            }
        }

        static void GenerateAndSendData(UdpClient client, string serverIP, int serverPort, string selectedFunction,double noiseLevel)
        {
            Random random = new Random();
            //noiseLevel = 0.1; // Уровень шума
            Func<double, double> generateFunction;

            switch (selectedFunction)
            {
                case "Синусоида":
                    generateFunction = Generate.SineWave;
                    break;
                case "Линейные данные":
                    generateFunction = Generate.LinearData;
                    break;
                case "Пила":
                    generateFunction = Generate.RandomData;
                    break;
                case "Треугольник":
                    generateFunction = Generate.TriangleWave;
                    break;
                case "Гауссовский шум":
                    generateFunction = Generate.GaussianNoise;
                    break;
                default:
                    generateFunction = null;
                    break;
            }
            double i = 0;
            while (true)
            {
                try
                {
                    // Генерация данных
                    i += 0.001;
                    if (i > 1) i = 0;
                    double value = generateFunction(i);
                    value += noiseLevel * (random.NextDouble() - 0.5); // Добавление шума к данным
                   // value *= 1000;
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
                    Thread.Sleep(1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при отправке данных: {ex.Message}");
                }
            }
        }
    }
}