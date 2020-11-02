namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.репозиториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.откритьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закритьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отладкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLight = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDark = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.проектиToolStripMenuItem,
            this.сборкаToolStripMenuItem,
            this.отладкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.тестToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.откритьToolStripMenuItem,
            this.закритьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.репозиториюToolStripMenuItem,
            this.файлToolStripMenuItem1});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // репозиториюToolStripMenuItem
            // 
            this.репозиториюToolStripMenuItem.Name = "репозиториюToolStripMenuItem";
            this.репозиториюToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.репозиториюToolStripMenuItem.Text = "Репозиторию";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // откритьToolStripMenuItem
            // 
            this.откритьToolStripMenuItem.Name = "откритьToolStripMenuItem";
            this.откритьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.откритьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.откритьToolStripMenuItem.Text = "Открить";
            this.откритьToolStripMenuItem.Click += new System.EventHandler(this.откритьToolStripMenuItem_Click);
            // 
            // закритьToolStripMenuItem
            // 
            this.закритьToolStripMenuItem.Name = "закритьToolStripMenuItem";
            this.закритьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закритьToolStripMenuItem.Text = "Закрить";
            // 
            // правкиToolStripMenuItem
            // 
            this.правкиToolStripMenuItem.Name = "правкиToolStripMenuItem";
            this.правкиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.правкиToolStripMenuItem.Text = "Правки";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // проектиToolStripMenuItem
            // 
            this.проектиToolStripMenuItem.Name = "проектиToolStripMenuItem";
            this.проектиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.проектиToolStripMenuItem.Text = "Проекти";
            // 
            // сборкаToolStripMenuItem
            // 
            this.сборкаToolStripMenuItem.Name = "сборкаToolStripMenuItem";
            this.сборкаToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.сборкаToolStripMenuItem.Text = "Сборка";
            // 
            // отладкаToolStripMenuItem
            // 
            this.отладкаToolStripMenuItem.Name = "отладкаToolStripMenuItem";
            this.отладкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.отладкаToolStripMenuItem.Text = "Отладка";
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLight,
            this.btnDark});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.форматToolStripMenuItem.Text = "Стить";
            this.форматToolStripMenuItem.Click += new System.EventHandler(this.форматToolStripMenuItem_Click);
            // 
            // btnLight
            // 
            this.btnLight.Checked = true;
            this.btnLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnLight.Name = "btnLight";
            this.btnLight.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.btnLight.Size = new System.Drawing.Size(212, 22);
            this.btnLight.Text = "Світла тема";
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnDark
            // 
            this.btnDark.Name = "btnDark";
            this.btnDark.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.btnDark.Size = new System.Drawing.Size(212, 22);
            this.btnDark.Text = "Чорна тема";
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сборкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отладкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem откритьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закритьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem репозиториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnLight;
        private System.Windows.Forms.ToolStripMenuItem btnDark;
    }
}

