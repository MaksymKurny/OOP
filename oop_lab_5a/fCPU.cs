using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_5a
{
    public partial class fCPU : Form
    {
        public CPU TheCPU;
        public fCPU(CPU cpu)
        {
            TheCPU = cpu;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheCPU.Number = tbNumber.Text.Trim();
            TheCPU.Core = int.Parse(tbCore.Text.Trim());
            TheCPU.Year = int.Parse(tbYear.Text.Trim());
            TheCPU.BFrequency = double.Parse(tbBFrequency.Text.Trim());
            TheCPU.TFrequency = double.Parse(tbTFrequency.Text.Trim());
            TheCPU.HyperT = chbHyperT.Checked;
            TheCPU.Segment = (rbMobile.Checked)?"Mobile":"Desktop";

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fCPU_Load(object sender, EventArgs e)
        {
            if (TheCPU != null)
            {
                tbNumber.Text = TheCPU.Number;
                tbCore.Text = TheCPU.Core.ToString();
                tbYear.Text = TheCPU.Year.ToString();
                tbBFrequency.Text = TheCPU.BFrequency.ToString("0.00");
                tbTFrequency.Text = TheCPU.TFrequency.ToString("0.00");
                chbHyperT.Checked = TheCPU.HyperT;
                if (TheCPU.Segment == "Mobile") 
                    rbMobile.Checked = true;
                else rbDesktop.Checked = true;
            }
        }
    }
}
