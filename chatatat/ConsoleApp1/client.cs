using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

try
{
    // Подключение к серверу
    await tcpClient.ConnectAsync("192.168.220.226", 12345);
    while (true)
    {

        // Создание сообщения 
        System.Console.WriteLine("Введите ip");
        // string ip = Console.ReadLine() + '\n';
        string ip = "192.168.220.181";
        System.Console.WriteLine("Введите soo");
        string text = Console.ReadLine() + '\n';
        string msg = ip + '.' + text;

        // Первод запроса из строкового типа данных в массив байт
        byte[] requestData = Encoding.UTF8.GetBytes(msg);
        await tcpClient.SendAsync(requestData, new SocketFlags());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}