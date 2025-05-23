using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Student : Iinformation, IPrinter
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Roll { get; set; }

        public string GetBasicInformation()
        {
            return $"{RegNo} {Name} {Email} {Roll}";
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void SetIpAddress(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
