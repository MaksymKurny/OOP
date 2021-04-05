
namespace oop_lab_4
{
    partial class fCPU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chbHyperT = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbBFrequency = new System.Windows.Forms.TextBox();
            this.tbCore = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMobile = new System.Windows.Forms.RadioButton();
            this.rbDesctop = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(220, 20);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(150, 22);
            this.tbNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер процесора";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(318, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chbHyperT
            // 
            this.chbHyperT.AutoSize = true;
            this.chbHyperT.Location = new System.Drawing.Point(10, 21);
            this.chbHyperT.Name = "chbHyperT";
            this.chbHyperT.Size = new System.Drawing.Size(210, 21);
            this.chbHyperT.TabIndex = 3;
            this.chbHyperT.Text = "Підтримка Hyper-Threading";
            this.chbHyperT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTFrequency);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.tbBFrequency);
            this.groupBox1.Controls.Add(this.tbCore);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Максимальна частота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Базова частота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рiк випуску";
            // 
            // tbTFrequency
            // 
            this.tbTFrequency.Location = new System.Drawing.Point(220, 140);
            this.tbTFrequency.Name = "tbTFrequency";
            this.tbTFrequency.Size = new System.Drawing.Size(150, 22);
            this.tbTFrequency.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість ядер";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(220, 80);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(150, 22);
            this.tbYear.TabIndex = 4;
            // 
            // tbBFrequency
            // 
            this.tbBFrequency.Location = new System.Drawing.Point(220, 110);
            this.tbBFrequency.Name = "tbBFrequency";
            this.tbBFrequency.Size = new System.Drawing.Size(150, 22);
            this.tbBFrequency.TabIndex = 6;
            // 
            // tbCore
            // 
            this.tbCore.Location = new System.Drawing.Point(220, 50);
            this.tbCore.Name = "tbCore";
            this.tbCore.Size = new System.Drawing.Size(150, 22);
            this.tbCore.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbMobile);
            this.groupBox2.Controls.Add(this.rbDesctop);
            this.groupBox2.Controls.Add(this.chbHyperT);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткові дані";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Вертикальний сегмент";
            // 
            // rbMobile
            // 
            this.rbMobile.AutoSize = true;
            this.rbMobile.Location = new System.Drawing.Point(10, 70);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(70, 21);
            this.rbMobile.TabIndex = 6;
            this.rbMobile.TabStop = true;
            this.rbMobile.Text = "Mobile";
            this.rbMobile.UseVisualStyleBackColor = true;
            // 
            // rbDesctop
            // 
            this.rbDesctop.AutoSize = true;
            this.rbDesctop.Location = new System.Drawing.Point(86, 70);
            this.rbDesctop.Name = "rbDesctop";
            this.rbDesctop.Size = new System.Drawing.Size(81, 21);
            this.rbDesctop.TabIndex = 5;
            this.rbDesctop.TabStop = true;
            this.rbDesctop.Text = "Desktop";
            this.rbDesctop.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fCPU
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 313);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fCPU";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий процесор";
            this.Load += new System.EventHandler(this.fCPU_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chbHyperT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbMobile;
        private System.Windows.Forms.RadioButton rbDesctop;
        private System.Windows.Forms.Label label6;
    }
}