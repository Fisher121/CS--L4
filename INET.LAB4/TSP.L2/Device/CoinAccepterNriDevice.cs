using System.IO.Ports;

namespace INET.Lab4.Device
{
    class CoinAccepterNriDevice : Device
    {
        public void setPort(ref SerialPort port)
        {
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
        }
    }
}
