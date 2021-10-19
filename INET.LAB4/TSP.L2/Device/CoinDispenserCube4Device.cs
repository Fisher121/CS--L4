using System.IO.Ports;

namespace INET.Lab4.Device
{
    class CoinDispenserCube4Device : Device
    {
        public void setPort(ref SerialPort port)
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
        }
    }
}
