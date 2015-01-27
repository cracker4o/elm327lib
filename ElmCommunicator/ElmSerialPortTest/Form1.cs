using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElmCommunicator;
using ElmCommunicator.Commands;

namespace ElmSerialPortTest
{
    public delegate void SetTextCallback(IReceiveMessage response);
    public partial class Form1 : Form
    {
        private SerialCommunicator _communicator;
        private SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
            var commands = GetAllCommands();
            foreach(var command in commands)
            {
                lbCommands.Items.Add(command);
            }
            this.SetUpPort();
        }

        private void SetUpPort()
        {
            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            _communicator = new SerialCommunicator(_serialPort);
            _communicator.Receiver.OnProcessMessage += ProcessMessage;
        }

        private void ProcessMessage(IReceiveMessage response)
        {
            if (this.tbResponses.InvokeRequired)
            {
                var d = new SetTextCallback(this.ProcessMessage);
                this.Invoke(d, new object[] { response });
            }
            else
            {
                this.tbResponses.Text += response.Data + "\r\n";    
            }
        }

        private void SendMessage(ISendMessage message)
        {
            _communicator.Sender.Send(message);
        }

        private IEnumerable<string> GetAllCommands()
        {
            var type = typeof(ISendMessage);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(t => type.IsAssignableFrom(t) && (t.FullName != typeof(SendMessage).FullName))
                .OrderBy(t => t.FullName);

            return types.Select(t => t.FullName);
        }

        private void lbCommands_DoubleClick(object sender, EventArgs e)
        {
            string item = ((ListBox) sender).SelectedItem.ToString();

            var commandType = Type.GetType(string.Format("{0},{1}", item, Assembly.GetAssembly(typeof(ISendMessage)).FullName));
            
            if (commandType == null)
                return;

            var command = (SendMessage)Activator.CreateInstance(commandType);

            _communicator.Sender.Send(command);
        }
    }
}