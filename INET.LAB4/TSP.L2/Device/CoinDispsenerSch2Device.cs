using System.IO.Ports;

namespace INET.Lab4.Device
{
    class CoinDispsenerSch2Device : Device
    {
        public void setPort(ref SerialPort port)
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
        }
    }
}
