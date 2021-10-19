using System.IO.Ports;

namespace INET.Lab4.Device
{
    public interface Device
    {
        public void setPort(ref SerialPort port);
    }
}
