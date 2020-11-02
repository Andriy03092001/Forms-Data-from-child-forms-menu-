namespace WindowsFormsApp2
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
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.listProductForMen = new System.Windows.Forms.ListBox();
            this.listProductForWomen = new System.Windows.Forms.ListBox();
            this.bntAdd2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(26, 230);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(253, 37);
            this.btnAdd1.TabIndex = 1;
            this.btnAdd1.Text = "Додати чоловічий одяг";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // listProductForMen
            // 
            this.listProductForMen.FormattingEnabled = true;
            this.listProductForMen.Location = new System.Drawing.Point(26, 12);
            this.listProductForMen.Name = "listProductForMen";
            this.listProductForMen.Size = new System.Drawing.Size(253, 212);
            this.listProductForMen.TabIndex = 2;
            // 
            // listProductForWomen
            // 
            this.listProductForWomen.FormattingEnabled = true;
            this.listProductForWomen.Location = new System.Drawing.Point(285, 12);
            this.listProductForWomen.Name = "listProductForWomen";
            this.listProductForWomen.Size = new System.Drawing.Size(253, 212);
            this.listProductForWomen.TabIndex = 3;
            // 
            // bntAdd2
            // 
            this.bntAdd2.Location = new System.Drawing.Point(285, 230);
            this.bntAdd2.Name = "bntAdd2";
            this.bntAdd2.Size = new System.Drawing.Size(253, 37);
            this.bntAdd2.TabIndex = 4;
            this.bntAdd2.Text = "Додати жіночий одяг";
            this.bntAdd2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Видалити вибраний елемент";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Видалити вибраний елемент";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 331);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntAdd2);
            this.Controls.Add(this.listProductForWomen);
            this.Controls.Add(this.listProductForMen);
            this.Controls.Add(this.btnAdd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.ListBox listProductForMen;
        private System.Windows.Forms.ListBox listProductForWomen;
        private System.Windows.Forms.Button bntAdd2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

