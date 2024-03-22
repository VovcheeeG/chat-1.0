using System.Drawing.Text;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace chatatat
{
    public partial class Form1 : Form
    {
        private TcpClient client; 
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();

            client = new TcpClient("192.168.220.226", 12345);
            stream = client.GetStream();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox2.Text;

            byte[] data = Encoding.UTF8.GetBytes(message);
            StreamWriter(data, 0, data.Length);

            string historyFileName = $"{textBox2}_{remoteIp}_chat_history.txt";


            textBox2.Text += $"{textBox2}:" + message + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
