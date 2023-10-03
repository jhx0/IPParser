using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPParser
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnIPConvert_Click(object sender, EventArgs e)
        {
            IP ip = new IP(txtBoxIP.Text);
            Boolean Result = true;

            Result = ip.ConvertOctets(
                new List<TextBox>() { txtBoxOctet1, txtBoxOctet2, txtBoxOctet3, txtBoxOctet4 },
                new List<TextBox>() { txtBoxBinOctet1, txtBoxBinOctet2, txtBoxBinOctet3, txtBoxBinOctet4 },
                new List<TextBox>() { txtBoxHexOctet1, txtBoxHexOctet2, txtBoxHexOctet3, txtBoxHexOctet4 }
            );

            if(!Result)
            {
                txtBoxIP.Text = "";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
