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

        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            string labelFormat = "{0,-5}{1,-19}{2,-30}";
            string instructionFormat = "{0,-7}{1,-6}{2,-10}{3,20}";
            string commentFormat = "{0,-100}";
            //string columnsFormat2 = "{0,-5}{1,-2}{2,-6}{3,-10}{4,20}";
            LbxCode.Items.Add(string.Format(labelFormat, "", "Loop:", "; This is a comment"));
            LbxCode.Items.Add(string.Format(instructionFormat, "08F6", "MOV", "C, 98FB", "; This is a comment"));
            //LbxCode.Items.Add(string.Format(columnsFormat2, "08F6", "", "MOV", "C, 98FB", "; This is a comment"));
            //LbxCode.Items.Add(string.Format(columnsFormat2, "08F6", "", "MOV", "C, 98FB", "; This is a comment"));
            //LbxCode.Items.Add(string.Format(columnsFormat2, "08F6", "", "MOV", "C, 98FB", "; This is a comment"));
            //LbxCode.Items.Add(string.Format(columnsFormat2, "08F6", "", "MOV", "C, 98FB", "; This is a comment"));
            //LbxCode.Items.Add(string.Format(columnsFormat2, "08F6", "", "MOV", "C, 98FB", "; This is a comment"));
            LbxCode.Items.Add(string.Format(commentFormat, "; This is a full line comment"));
        }
    }
}
