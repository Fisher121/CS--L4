using System.IO.Ports;

namespace INET.Lab4.Device
{
    class BillAccepterCashCodeDevice : Device
    {
        public void setPort(ref SerialPort port)
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
        }
    }
}
