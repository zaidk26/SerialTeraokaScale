using System;
using System.IO.Ports;


namespace SerialTeraokaScale
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort port = new SerialPort("COM"+args[0], 9600, Parity.None, 8, StopBits.One);
            port.Open();
            byte[] bytestosend = { 0x05 };

            port.Write(bytestosend, 0, bytestosend.Length);
            string text = port.ReadLine();
            System.IO.File.WriteAllText(args[1], text);
        }
    }
}
