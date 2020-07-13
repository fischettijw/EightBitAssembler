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
        private int ramAddress;

        private byte[] ramValue = new byte[256];
        private Label[] LblAddress = new Label[256];

        public FlowLayoutPanel RamPanel
        {
            get { return ramPanel; }
            set { ramPanel = value; }
        }

        public int RamAddress
        {
            get { return ramAddress; }
            set { ramAddress = value; }
        }

        public SimulatorDisplay(FlowLayoutPanel _ramPanel)
        {
            RamPanel = _ramPanel;
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
            int addressWidth = RamPanel.ClientSize.Width / 16;
            int addressHeight = RamPanel.ClientSize.Height / 16;

            for (int nAddress = 0; nAddress < ramValue.Length; nAddress++)
            {
                LblAddress[nAddress] = new Label();
                LblAddress[nAddress].Location = new Point(addressWidth * nAddress % 16, addressHeight * nAddress % 16);
                LblAddress[nAddress].AutoSize = false;
                LblAddress[nAddress].Size = new Size(addressWidth, addressHeight);
                LblAddress[nAddress].Margin = new Padding(0);
                LblAddress[nAddress].Font = new Font("Courier New", 14);
                LblAddress[nAddress].Text = (ramValue[nAddress] < 16 ? "0" : "") + Convert.ToString(Convert.ToByte(ramValue[nAddress]), 16).ToUpper();
                LblAddress[nAddress].Text = "00";
                LblAddress[nAddress].TextAlign = ContentAlignment.MiddleCenter;
                LblAddress[nAddress].Tag = nAddress;
                RamPanel.Controls.Add(LblAddress[nAddress]);
                LblAddress[nAddress].MouseHover += new EventHandler(hoover);
            }
        }

        private void hoover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Red;
            lbl.Text = lbl.Tag.ToString();
            lbl.Text = (Convert.ToInt32(lbl.Tag) < 16 ? "0" : "") + Convert.ToString(Convert.ToByte(Convert.ToInt32(lbl.Tag)), 16).ToUpper();
        }


    }
}
