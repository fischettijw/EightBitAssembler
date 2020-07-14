using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightBitAssembler
{
    public partial class FrmAssembler : Form
    {
        SimulatorDisplay SimDisplay;
        public FrmAssembler()
        {
            InitializeComponent();
        }

        private void FrmAssembler_Load(object sender, EventArgs e)
        {
            SimDisplay = new SimulatorDisplay(FlwRam);
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SimDisplay.SetRamValue(Convert.ToInt32(TxtSetAddress.Text), TxtSetValue.Text);
            LblValveA.Text = "0A";
            LblValveB.Text = "0B";
            LblValveC.Text = "0C";
            LblValveD.Text = "0D";
            LblValveIP.Text = "0E";
            LblValveSP.Text = "0F";
            LblFlagZ.Text = "True";
            LblFlagC.Text = "True";
            LblFlagF.Text = "True";
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            TxtGetValue.Text = SimDisplay.GetRamValue(Convert.ToInt32(TxtGetAddress.Text)).ToString();

        }


    }
}
