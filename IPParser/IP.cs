using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPParser
{
    public class IP
    {
        public string IPv4Address { get; private set; }

        public IP(string IPAddress) {
            IPv4Address = IPAddress; 
        }

        private string ToBinary(string number)
        {
            return Convert.ToString(int.Parse(number), 2).ToString();
        }

        private string ToHex(string number)
        {
            return Convert.ToString(int.Parse(number), 16).ToString();
        }

        private Boolean CheckIPAddress(string IP)
        {
            if (IPAddress.TryParse(IP, out _))
            {
                return true;
            }

            return false;
        }

        public Boolean ConvertOctets(List<TextBox> tbo, List<TextBox> tbb, List<TextBox> tbh)
        {
            String[] IPOctets;
            int counter = 0;

            IPOctets = IPv4Address.Split('.');

            if(!CheckIPAddress(string.Join(".", IPOctets)))
            {
                MessageBox.Show("The IP address entered is not valid!", "IPParser Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            foreach (TextBox t in tbo)
            {
                t.Text = IPOctets[counter++];
            }

            counter = 0;
            foreach(TextBox t in tbb)
            {
                t.Text = ToBinary(IPOctets[counter++]);
            }

            counter = 0;
            foreach(TextBox t in tbh)
            {
                t.Text = ToHex(IPOctets[counter++]);
            }

            return true;
        }

    }
}
