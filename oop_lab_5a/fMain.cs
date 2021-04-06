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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCPU.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Number";
            column.Name = "Номер";
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Segment";
            column.Name = "Вертикальний сегмент";
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Core";
            column.Name = "Кількість ядер";
            column.Width = 60;
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Year";
            column.Name = "Рiк випуску";
            column.Width = 60;
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BFrequency";
            column.Name = "Базова частота";
            column.Width = 80;
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TFrequency";
            column.Name = "Максимальна частота";
            column.Width = 80;
            gvCPU.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HyperT";
            column.Name = "Hyper-Threading";
            gvCPU.Columns.Add(column);
            bindSrcCPU.Add(new CPU("i5-9300H", "Mobile", 4, 2019, 2.40, 4.10, true));
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CPU cpu = new CPU();
            fCPU ft = new fCPU(cpu);
            if (ft.ShowDialog() == DialogResult.OK)
                bindSrcCPU.Add(cpu);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CPU cpu = (CPU)bindSrcCPU.List[bindSrcCPU.Position];
            fCPU ft = new fCPU(cpu);
            if (ft.ShowDialog() == DialogResult.OK)
                bindSrcCPU.List[bindSrcCPU.Position] = cpu;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
            "Видалення запису", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning) == DialogResult.OK)
                bindSrcCPU.RemoveCurrent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                bindSrcCPU.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
