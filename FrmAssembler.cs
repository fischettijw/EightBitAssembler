﻿using System;
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

        private void BtnSet32_Click(object sender, EventArgs e)
        {
            SimDisplay.SetRamValue(32, "64");
        }

        private void BtnGet32_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SimDisplay.GetRamValue(32));
        }
    }
}
