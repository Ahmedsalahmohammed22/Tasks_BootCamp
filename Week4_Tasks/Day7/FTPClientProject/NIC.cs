using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPClientProject
{
    public enum NICType
    {
        Ethernet,
        TokenRing
    }

    internal class NIC
    {
        public string Manufacture {  get; set; }
        public string MACAddress { get; set; }
        public NICType Type { get; set; }

        static NIC NICMachine = null;
        NIC(string manufacture , string macAddress , NICType type)
        {
            Manufacture = manufacture;
            MACAddress = macAddress;
            Type = type;
        }
        public static NIC getNIC(string manufacture, string macAddress, NICType type)
        {
            if (NICMachine == null)
            {
                NICMachine = new NIC(manufacture, macAddress, type);
            }
            return NICMachine;
        }

        public override string ToString()
        {
            return $"NIC Manufacture: {Manufacture} - MAC Address: {MACAddress} - NIC Type: {Type}";
        }
    }
} 
