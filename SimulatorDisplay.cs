using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EightBitAssembler
{
    class SimulatorDisplay
    {
        private FlowLayoutPanel ramPanel;
        //private int ramAddress;
        private string tempText;
        private byte[] ramValue = new byte[256];
        private Label[] LblAddress = new Label[256];

        //public int RamAddress
        //{
        //    get { return ramAddress; }
        //    set { ramAddress = value; }
        //}

        public SimulatorDisplay(FlowLayoutPanel userRamPanel)
        {
            ramPanel = userRamPanel;
            InitializeRam();
            CreateRamDisplay();
        }

        private void InitializeRam()
        {
            for (int n = 0; n < ramValue.Length; n++)
            {
                ramValue[n] = Convert.ToByte(n);
            }
        }

        private void CreateRamDisplay()
        {
            int addressWidth = ramPanel.ClientSize.Width / 16;
            int addressHeight = ramPanel.ClientSize.Height / 16;

            for (int nAddress = 0; nAddress < ramValue.Length; nAddress++)
            {
                LblAddress[nAddress] = new Label();
                LblAddress[nAddress].Location = new Point(addressWidth * nAddress % 16, addressHeight * nAddress % 16);
                LblAddress[nAddress].AutoSize = false;
                LblAddress[nAddress].Size = new Size(addressWidth, addressHeight);
                LblAddress[nAddress].Margin = new Padding(0);
                LblAddress[nAddress].Font = new Font("Courier New", 14);
                LblAddress[nAddress].ForeColor = Color.Black;

                //LblAddress[nAddress].Text = (ramValue[nAddress] < 16 ? "0" : "") +
                //                            Convert.ToString(Convert.ToByte(ramValue[nAddress]), 16).ToUpper();
                LblAddress[nAddress].Text = "00";

                LblAddress[nAddress].TextAlign = ContentAlignment.MiddleCenter;
                LblAddress[nAddress].Tag = nAddress;
                ramPanel.Controls.Add(LblAddress[nAddress]);
                LblAddress[nAddress].MouseDown += new MouseEventHandler(MouseDown);
                LblAddress[nAddress].MouseUp += new MouseEventHandler(MouseUp);
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Black;
            lbl.Text = tempText;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            tempText = lbl.Text;
            if (e.Button == MouseButtons.Left)
            {
                lbl.ForeColor = Color.Green;
                lbl.Text = Convert.ToChar(Convert.ToUInt64(lbl.Text, 16)).ToString();
                //lbl.Text = Convert.ToChar(lbl.Tag).ToString();
            }
            else
            {
                lbl.ForeColor = Color.Red;
                lbl.Text = (Convert.ToInt32(lbl.Tag) < 16 ? "0" : "") + Convert.ToString(Convert.ToByte(Convert.ToInt32(lbl.Tag)), 16).ToUpper();

            }
        }

        public string GetRamValue(int add)
        {
            return LblAddress[add].Text;
            //return ramValue[add].ToString();
        }

        public void SetRamValue(int add, string value)
        {
            LblAddress[add].Text = value;
            //ramValue[add] = Convert.ToByte(value);
        }

    }
}