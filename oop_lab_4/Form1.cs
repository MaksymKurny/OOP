using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddCPU_Click(object sender, EventArgs e)
        {
            CPU cpu = new CPU();
            fCPU fc = new fCPU(cpu);
            if (fc.ShowDialog() == DialogResult.OK)
            {
                tbCPUsInfo.Text +=
                string.Format(
                    "__________________________" +
                    "\r\nДані про " + cpu.Number +
                    "\r\nРік випуску: " + cpu.Year.ToString() +
                    "\r\nСегмент: " + cpu.Segment +
                    "\r\nЯдер: " + cpu.Core +
                    "  |  Потоків: " + cpu.GetNumberOfThreads() +
                    "\r\nБазова частота: " + cpu.BFrequency.ToString("0.00") +
                    "  |  Максимальна частота: " + cpu.TFrequency.ToString("0.00") +
                    (cpu.HyperT ? "\r\nЄ підтримка Hyper-Threading\r\n" :
                                  "\r\nНемає підтримки Hyper-Threading\r\n"));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
