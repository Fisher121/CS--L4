using INET.Lab4.Device;
using System.Collections.Generic;
using System.IO.Ports;

/*
 *  Pentru clasa DeviceFinder am folosit strategy pattern:
 *  - am creeat o interfata Device care contine o metoda setPort;
 *  - am creat cate o clasa pentru fiecare device din DeviceModel, clase care implementeaza interfata Device si calculeaza portul ;
 *  - am creat un HashMap in clasa DeviceFinder care contine cate o instanta a fiecarei clase care implementeaza Device la fiecare cheie din DeviceModel;
 *  - am apelat setPort in metoda FindDevice pentru modelul oferit de utilizator;
 */
namespace SOLID.OCP.Violation
{
    public class DeviceFinder
    {
        private Dictionary<DeviceModel, Device> strategies = new Dictionary<DeviceModel, Device>();

        DeviceFinder()
        {
            strategies.Add(DeviceModel.CoinDispenserCube4, new CoinDispenserCube4Device());
            strategies.Add(DeviceModel.CoinDispsenerSch2, new CoinDispsenerSch2Device());
            strategies.Add(DeviceModel.CoinAccepterNri, new CoinAccepterNriDevice());
            strategies.Add(DeviceModel.BillAccepterCashCode, new BillAccepterCashCodeDevice());
            strategies.Add(DeviceModel.BillDispenserEcdm, new BillDispenserEcdmDevice());
        }

        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            strategies[model].setPort(ref port);
            return Find(port);
                        
        }

        private string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach(string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0 )
                    return name;
            }
            return null;
        }
    }
}
