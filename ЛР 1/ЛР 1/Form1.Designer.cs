
namespace ЛР_1
{
    partial class Form1
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
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.SumBtn = new System.Windows.Forms.Button();
            this.SubstrBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.RestBtn = new System.Windows.Forms.Button();
            this.DevBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.MemAdd = new System.Windows.Forms.Button();
            this.MemRem = new System.Windows.Forms.Button();
            this.MemReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 37);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(178, 20);
            this.aBox.TabIndex = 0;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(235, 37);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(178, 20);
            this.bBox.TabIndex = 1;
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(196, 37);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(33, 20);
            this.CleanBtn.TabIndex = 2;
            this.CleanBtn.Text = "C";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // SumBtn
            // 
            this.SumBtn.Location = new System.Drawing.Point(148, 63);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(133, 25);
            this.SumBtn.TabIndex = 3;
            this.SumBtn.Text = "Сложить";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // SubstrBtn
            // 
            this.SubstrBtn.Location = new System.Drawing.Point(148, 94);
            this.SubstrBtn.Name = "SubstrBtn";
            this.SubstrBtn.Size = new System.Drawing.Size(133, 25);
            this.SubstrBtn.TabIndex = 4;
            this.SubstrBtn.Text = "Вычесть";
            this.SubstrBtn.UseVisualStyleBackColor = true;
            this.SubstrBtn.Click += new System.EventHandler(this.SubstrBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Location = new System.Drawing.Point(148, 125);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(133, 25);
            this.MultBtn.TabIndex = 5;
            this.MultBtn.Text = "Умножить";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // RestBtn
            // 
            this.RestBtn.Location = new System.Drawing.Point(148, 187);
            this.RestBtn.Name = "RestBtn";
            this.RestBtn.Size = new System.Drawing.Size(133, 25);
            this.RestBtn.TabIndex = 6;
            this.RestBtn.Text = "Остаток";
            this.RestBtn.UseVisualStyleBackColor = true;
            this.RestBtn.Click += new System.EventHandler(this.RestBtn_Click);
            // 
            // DevBtn
            // 
            this.DevBtn.Location = new System.Drawing.Point(148, 156);
            this.DevBtn.Name = "DevBtn";
            this.DevBtn.Size = new System.Drawing.Size(133, 25);
            this.DevBtn.TabIndex = 7;
            this.DevBtn.Text = "Разделить";
            this.DevBtn.UseVisualStyleBackColor = true;
            this.DevBtn.Click += new System.EventHandler(this.DevBtn_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 218);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(400, 20);
            this.ResultBox.TabIndex = 9;
            // 
            // MemAdd
            // 
            this.MemAdd.Location = new System.Drawing.Point(12, 63);
            this.MemAdd.Name = "MemAdd";
            this.MemAdd.Size = new System.Drawing.Size(31, 22);
            this.MemAdd.TabIndex = 10;
            this.MemAdd.Text = "M+";
            this.MemAdd.UseVisualStyleBackColor = true;
            this.MemAdd.Click += new System.EventHandler(this.MemAdd_Click);
            // 
            // MemRem
            // 
            this.MemRem.Location = new System.Drawing.Point(49, 63);
            this.MemRem.Name = "MemRem";
            this.MemRem.Size = new System.Drawing.Size(31, 22);
            this.MemRem.TabIndex = 12;
            this.MemRem.Text = "M-";
            this.MemRem.UseVisualStyleBackColor = true;
            this.MemRem.Click += new System.EventHandler(this.MemRem_Click);
            // 
            // MemReset
            // 
            this.MemReset.Location = new System.Drawing.Point(86, 63);
            this.MemReset.Name = "MemReset";
            this.MemReset.Size = new System.Drawing.Size(36, 21);
            this.MemReset.TabIndex = 13;
            this.MemReset.Text = "MR";
            this.MemReset.UseVisualStyleBackColor = true;
            this.MemReset.Click += new System.EventHandler(this.MemReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 247);
            this.Controls.Add(this.MemReset);
            this.Controls.Add(this.MemRem);
            this.Controls.Add(this.MemAdd);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.DevBtn);
            this.Controls.Add(this.RestBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.SubstrBtn);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button SubstrBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button RestBtn;
        private System.Windows.Forms.Button DevBtn;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button MemAdd;
        private System.Windows.Forms.Button MemRem;
        private System.Windows.Forms.Button MemReset;
    }
}

