
namespace ЛР_1._2
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
            this.GenerateCollBtn = new System.Windows.Forms.Button();
            this.AscendingBtn = new System.Windows.Forms.Button();
            this.DescendingBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.PrintAllBtn = new System.Windows.Forms.Button();
            this.ListAm = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateCollBtn
            // 
            this.GenerateCollBtn.Location = new System.Drawing.Point(284, 106);
            this.GenerateCollBtn.Name = "GenerateCollBtn";
            this.GenerateCollBtn.Size = new System.Drawing.Size(232, 36);
            this.GenerateCollBtn.TabIndex = 0;
            this.GenerateCollBtn.Text = "Генерировать коллекцию";
            this.GenerateCollBtn.UseVisualStyleBackColor = true;
            this.GenerateCollBtn.Click += new System.EventHandler(this.GenerateCollBtn_Click);
            // 
            // AscendingBtn
            // 
            this.AscendingBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AscendingBtn.Location = new System.Drawing.Point(131, 106);
            this.AscendingBtn.Name = "AscendingBtn";
            this.AscendingBtn.Size = new System.Drawing.Size(121, 36);
            this.AscendingBtn.TabIndex = 1;
            this.AscendingBtn.Text = "По возрастанию";
            this.AscendingBtn.UseVisualStyleBackColor = false;
            this.AscendingBtn.Click += new System.EventHandler(this.AscendingBtn_Click);
            // 
            // DescendingBtn
            // 
            this.DescendingBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DescendingBtn.Location = new System.Drawing.Point(131, 148);
            this.DescendingBtn.Name = "DescendingBtn";
            this.DescendingBtn.Size = new System.Drawing.Size(121, 36);
            this.DescendingBtn.TabIndex = 2;
            this.DescendingBtn.Text = "По убыванию";
            this.DescendingBtn.UseVisualStyleBackColor = false;
            this.DescendingBtn.Click += new System.EventHandler(this.DescendingBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MinBtn.Location = new System.Drawing.Point(542, 148);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(121, 36);
            this.MinBtn.TabIndex = 3;
            this.MinBtn.Text = "Минимальный";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MaxBtn.Location = new System.Drawing.Point(542, 106);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(121, 36);
            this.MaxBtn.TabIndex = 4;
            this.MaxBtn.Text = "Максимальный";
            this.MaxBtn.UseVisualStyleBackColor = false;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // PrintAllBtn
            // 
            this.PrintAllBtn.Location = new System.Drawing.Point(284, 148);
            this.PrintAllBtn.Name = "PrintAllBtn";
            this.PrintAllBtn.Size = new System.Drawing.Size(232, 36);
            this.PrintAllBtn.TabIndex = 5;
            this.PrintAllBtn.Text = "Показать все";
            this.PrintAllBtn.UseVisualStyleBackColor = true;
            this.PrintAllBtn.Click += new System.EventHandler(this.PrintAllBtn_Click);
            // 
            // ListAm
            // 
            this.ListAm.Location = new System.Drawing.Point(353, 80);
            this.ListAm.Name = "ListAm";
            this.ListAm.Size = new System.Drawing.Size(100, 20);
            this.ListAm.TabIndex = 6;
            this.ListAm.TextChanged += new System.EventHandler(this.ListAm_TextChanged);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(284, 190);
            this.List.Multiline = true;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(232, 69);
            this.List.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 338);
            this.Controls.Add(this.List);
            this.Controls.Add(this.ListAm);
            this.Controls.Add(this.PrintAllBtn);
            this.Controls.Add(this.MaxBtn);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.DescendingBtn);
            this.Controls.Add(this.AscendingBtn);
            this.Controls.Add(this.GenerateCollBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateCollBtn;
        private System.Windows.Forms.Button AscendingBtn;
        private System.Windows.Forms.Button DescendingBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button PrintAllBtn;
        private System.Windows.Forms.TextBox ListAm;
        private System.Windows.Forms.TextBox List;
    }
}

