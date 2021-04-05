
namespace oop_lab_4
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCPU = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbCPUsInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddCPU
            // 
            this.btnAddCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCPU.Location = new System.Drawing.Point(420, 12);
            this.btnAddCPU.Name = "btnAddCPU";
            this.btnAddCPU.Size = new System.Drawing.Size(150, 40);
            this.btnAddCPU.TabIndex = 0;
            this.btnAddCPU.Text = "Додати процесор";
            this.btnAddCPU.UseVisualStyleBackColor = true;
            this.btnAddCPU.Click += new System.EventHandler(this.btnAddCPU_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(420, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbCPUsInfo
            // 
            this.tbCPUsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPUsInfo.Location = new System.Drawing.Point(12, 12);
            this.tbCPUsInfo.Multiline = true;
            this.tbCPUsInfo.Name = "tbCPUsInfo";
            this.tbCPUsInfo.ReadOnly = true;
            this.tbCPUsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCPUsInfo.Size = new System.Drawing.Size(400, 430);
            this.tbCPUsInfo.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.tbCPUsInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCPU);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCPU;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbCPUsInfo;
    }
}

