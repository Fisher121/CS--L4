using System.IO.Ports;

namespace INET.Lab4.Device
{
    class BillDispenserEcdmDevice : Device
    {
        public void setPort(ref SerialPort port)
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
        }
    }
}
