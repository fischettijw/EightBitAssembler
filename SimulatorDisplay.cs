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
            InitializeRam(0);
            CreateRamDisplay();
        }
        private void InitializeRam(int initializeValue)
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

            for (int n = 0; n < ramValue.Length; n++)
            {
                LblAddress[n] = new Label();
                LblAddress[n].Location = new Point(addressWidth * n % 16, addressHeight * n % 16);
                LblAddress[n].AutoSize = false;
                LblAddress[n].Size = new Size(addressWidth, addressHeight);
                LblAddress[n].Margin = new Padding(0);
                LblAddress[n].Text = Convert.ToString(Convert.ToByte(ramValue[n]), 16).ToUpper();
                LblAddress[n].Text = Convert.ToString(Convert.ToByte(ramValue[n]), 16).ToUpper().ToString();
                LblAddress[n].TextAlign = ContentAlignment.MiddleCenter;
                RamPanel.Controls.Add(LblAddress[n]);
            }
        }

    }
}
