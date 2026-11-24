using System.IO.Ports;

namespace BUSSINES
{
    public class ESP
    {
        private SerialPort sp {get; set;}
        public ESP (string PortaName)
        {
            sp = new SerialPort(PortaName)
        }
    }
}
