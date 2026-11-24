using System.IO.Ports;

namespace BUSSINES
{
    public class ESP
    {
        private SerialPort sp {get; set;}
        public ESP (string PortaName)
        {
            sp = new SerialPort(PortaName, 115200);
            sp.Open();
        }
        ~ESP()
        {
            sp.Close();
        }
        public byte Pines
        {
            set
            {
                byte[] DatOut = new byte[] {0x2, 0x20, value, 0x3 };
                sp.Write(DatOut, 0, DatOut.Length);
                Thread.Sleep(10);
                byte[] DatIn = new byte[3];
                sp.Read(DatIn, 0, DatIn.Length);
            }
        }
        
    }
}
