using System.Windows.Forms;
using System.Drawing;
using System;

namespace oop_lab_7
{
    public partial class fMain : Form
    {
        CEmblem[] emblem;
        int EmblemCount = 0;
        int CurrEmblIndex;

        public fMain()
        {
            InitializeComponent();
            emblem = new CEmblem[100]; // Створення масиву для об'єктів - кіл
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (EmblemCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrEmblIndex = EmblemCount;
            EmblemCount++;
            // Створення нового об'єкта - екземпляра класу CCircle
            emblem[CurrEmblIndex] =
            new CEmblem(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            emblem[CurrEmblIndex].Show();
            cbCircles.Items.Add("Емблема №" + (EmblemCount - 1).ToString());
            cbCircles.SelectedIndex = EmblemCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        { // Приховування поточного об'єкта - екземпляра класу CCircle
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Hide();
        }

        private void btbShow_Click(object sender, EventArgs e)
        { // Приховування поточного об'єкта - екземпляра класу CCircle
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        { // Розширення поточного об'єкта - екземпляра класу CCircle
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        { // Стискання поточного об'єкта - екземпляра класу CCircle
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0))  return;
            emblem[CurrEmblIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        { // Переміщення вверх поточного об'єкта
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        { // Переміщення вниз поточного об'єкта
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Move(0, 10);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        { // Переміщення вліво поточного об'єкта
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Move(-10, 0);
        }

        private void btnRight_Click(object sender, EventArgs e)
        { // Переміщення вправо поточного об'єкта
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            emblem[CurrEmblIndex].Move(10, 0);
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        { // Переміщення поточного об'єкта вверх на більшу відстань
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            for (int i = 0; i < 100; i++) {
                emblem[CurrEmblIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        { // Переміщення поточного об'єкта вниз на більшу відстань
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            for (int i = 0; i < 100; i++) {
                emblem[CurrEmblIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        { // Переміщення поточного об'єкта вліво на більшу відстань
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            for (int i = 0; i < 100; i++) {
                emblem[CurrEmblIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        { // Переміщення поточного об'єкта вправо на більшу відстань
            CurrEmblIndex = cbCircles.SelectedIndex;
            if ((CurrEmblIndex > EmblemCount) || (CurrEmblIndex < 0)) return;
            for (int i = 0; i < 100; i++) {
                emblem[CurrEmblIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}