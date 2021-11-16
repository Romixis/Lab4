
namespace Proga_lab_4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startSorting = new System.Windows.Forms.ToolStripMenuItem();
            this.dataExcelBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSheetsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bubbleSort = new System.Windows.Forms.CheckBox();
            this.sortingInsert = new System.Windows.Forms.CheckBox();
            this.shakerSorting = new System.Windows.Forms.CheckBox();
            this.quickSorting = new System.Windows.Forms.CheckBox();
            this.bogoSort = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sortAscending = new System.Windows.Forms.CheckBox();
            this.sortDescending = new System.Windows.Forms.CheckBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bubbleInfo = new System.Windows.Forms.RichTextBox();
            this.insertInfo = new System.Windows.Forms.RichTextBox();
            this.shakerInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSorting,
            this.dataExcelBtn,
            this.googleSheetsBtn,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1544, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startSorting
            // 
            this.startSorting.Name = "startSorting";
            this.startSorting.Size = new System.Drawing.Size(91, 24);
            this.startSorting.Text = "Запустить";
            this.startSorting.Click += new System.EventHandler(this.startSorting_Click);
            // 
            // dataExcelBtn
            // 
            this.dataExcelBtn.Name = "dataExcelBtn";
            this.dataExcelBtn.Size = new System.Drawing.Size(57, 24);
            this.dataExcelBtn.Text = "Excel";
            this.dataExcelBtn.Click += new System.EventHandler(this.dataExcelBtn_Click);
            // 
            // googleSheetsBtn
            // 
            this.googleSheetsBtn.Name = "googleSheetsBtn";
            this.googleSheetsBtn.Size = new System.Drawing.Size(119, 24);
            this.googleSheetsBtn.Text = "Google Sheets";
            this.googleSheetsBtn.Click += new System.EventHandler(this.googleSheetsBtn_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberSort});
            this.dataGridView1.Location = new System.Drawing.Point(22, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(180, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // numberSort
            // 
            this.numberSort.HeaderText = "Данные";
            this.numberSort.MinimumWidth = 6;
            this.numberSort.Name = "numberSort";
            this.numberSort.Width = 125;
            // 
            // bubbleSort
            // 
            this.bubbleSort.AutoSize = true;
            this.bubbleSort.Location = new System.Drawing.Point(22, 44);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(197, 21);
            this.bubbleSort.TabIndex = 3;
            this.bubbleSort.Text = "Пузырьковая сортировка";
            this.bubbleSort.UseMnemonic = false;
            this.bubbleSort.UseVisualStyleBackColor = true;
            this.bubbleSort.CheckedChanged += new System.EventHandler(this.bubbleSort_CheckedChanged);
            // 
            // sortingInsert
            // 
            this.sortingInsert.AutoSize = true;
            this.sortingInsert.Location = new System.Drawing.Point(22, 87);
            this.sortingInsert.Name = "sortingInsert";
            this.sortingInsert.Size = new System.Drawing.Size(180, 21);
            this.sortingInsert.TabIndex = 4;
            this.sortingInsert.Text = "Сортировка вставками";
            this.sortingInsert.UseVisualStyleBackColor = true;
            this.sortingInsert.CheckedChanged += new System.EventHandler(this.sortingInsert_CheckedChanged);
            // 
            // shakerSorting
            // 
            this.shakerSorting.AutoSize = true;
            this.shakerSorting.Location = new System.Drawing.Point(22, 124);
            this.shakerSorting.Name = "shakerSorting";
            this.shakerSorting.Size = new System.Drawing.Size(184, 21);
            this.shakerSorting.TabIndex = 5;
            this.shakerSorting.Text = "Шейкерная сортировка";
            this.shakerSorting.UseVisualStyleBackColor = true;
            this.shakerSorting.CheckedChanged += new System.EventHandler(this.shakerSorting_CheckedChanged);
            // 
            // quickSorting
            // 
            this.quickSorting.AutoSize = true;
            this.quickSorting.Location = new System.Drawing.Point(22, 165);
            this.quickSorting.Name = "quickSorting";
            this.quickSorting.Size = new System.Drawing.Size(167, 21);
            this.quickSorting.TabIndex = 6;
            this.quickSorting.Text = "Быстрая сортировка";
            this.quickSorting.UseVisualStyleBackColor = true;
            this.quickSorting.CheckedChanged += new System.EventHandler(this.quickSorting_CheckedChanged);
            // 
            // bogoSort
            // 
            this.bogoSort.AutoSize = true;
            this.bogoSort.Location = new System.Drawing.Point(22, 205);
            this.bogoSort.Name = "bogoSort";
            this.bogoSort.Size = new System.Drawing.Size(72, 21);
            this.bogoSort.TabIndex = 7;
            this.bogoSort.Text = "BOGO";
            this.bogoSort.UseVisualStyleBackColor = true;
            this.bogoSort.CheckedChanged += new System.EventHandler(this.bogoSort_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sortAscending
            // 
            this.sortAscending.AutoSize = true;
            this.sortAscending.Location = new System.Drawing.Point(22, 278);
            this.sortAscending.Name = "sortAscending";
            this.sortAscending.Size = new System.Drawing.Size(218, 21);
            this.sortAscending.TabIndex = 8;
            this.sortAscending.Text = "Сортировка по возрастанию";
            this.sortAscending.UseVisualStyleBackColor = true;
            // 
            // sortDescending
            // 
            this.sortDescending.AutoSize = true;
            this.sortDescending.Location = new System.Drawing.Point(22, 321);
            this.sortDescending.Name = "sortDescending";
            this.sortDescending.Size = new System.Drawing.Size(198, 21);
            this.sortDescending.TabIndex = 9;
            this.sortDescending.Text = "Сортировка по убыванию";
            this.sortDescending.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(432, 402);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(364, 259);
            this.zedGraphControl1.TabIndex = 10;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(293, 69);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(364, 241);
            this.zedGraphControl2.TabIndex = 11;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(998, 402);
            this.zedGraphControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(384, 250);
            this.zedGraphControl3.TabIndex = 12;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Location = new System.Drawing.Point(697, 69);
            this.zedGraphControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(384, 230);
            this.zedGraphControl4.TabIndex = 13;
            this.zedGraphControl4.UseExtendedPrintDialog = true;
            this.zedGraphControl4.Load += new System.EventHandler(this.zedGraphControl4_Load);
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.Location = new System.Drawing.Point(1110, 69);
            this.zedGraphControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.ScrollGrace = 0D;
            this.zedGraphControl5.ScrollMaxX = 0D;
            this.zedGraphControl5.ScrollMaxY = 0D;
            this.zedGraphControl5.ScrollMaxY2 = 0D;
            this.zedGraphControl5.ScrollMinX = 0D;
            this.zedGraphControl5.ScrollMinY = 0D;
            this.zedGraphControl5.ScrollMinY2 = 0D;
            this.zedGraphControl5.Size = new System.Drawing.Size(397, 230);
            this.zedGraphControl5.TabIndex = 14;
            this.zedGraphControl5.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пузырьковая сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Сортировка вставками";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1243, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Шейкерная сортировка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Быстрая сортировка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1167, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bogo";
            // 
            // bubbleInfo
            // 
            this.bubbleInfo.Location = new System.Drawing.Point(293, 321);
            this.bubbleInfo.Name = "bubbleInfo";
            this.bubbleInfo.Size = new System.Drawing.Size(364, 21);
            this.bubbleInfo.TabIndex = 20;
            this.bubbleInfo.Text = "";
            // 
            // insertInfo
            // 
            this.insertInfo.Location = new System.Drawing.Point(697, 319);
            this.insertInfo.Name = "insertInfo";
            this.insertInfo.Size = new System.Drawing.Size(384, 23);
            this.insertInfo.TabIndex = 21;
            this.insertInfo.Text = "";
            // 
            // shakerInfo
            // 
            this.shakerInfo.Location = new System.Drawing.Point(1110, 319);
            this.shakerInfo.Name = "shakerInfo";
            this.shakerInfo.Size = new System.Drawing.Size(387, 23);
            this.shakerInfo.TabIndex = 22;
            this.shakerInfo.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(432, 676);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(364, 27);
            this.richTextBox4.TabIndex = 23;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(998, 676);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(384, 24);
            this.richTextBox5.TabIndex = 24;
            this.richTextBox5.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1544, 737);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.shakerInfo);
            this.Controls.Add(this.insertInfo);
            this.Controls.Add(this.bubbleInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl5);
            this.Controls.Add(this.zedGraphControl4);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.sortDescending);
            this.Controls.Add(this.sortAscending);
            this.Controls.Add(this.bogoSort);
            this.Controls.Add(this.quickSorting);
            this.Controls.Add(this.shakerSorting);
            this.Controls.Add(this.sortingInsert);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startSorting;
        private System.Windows.Forms.ToolStripMenuItem dataExcelBtn;
        private System.Windows.Forms.ToolStripMenuItem googleSheetsBtn;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox bubbleSort;
        private System.Windows.Forms.CheckBox sortingInsert;
        private System.Windows.Forms.CheckBox shakerSorting;
        private System.Windows.Forms.CheckBox quickSorting;
        private System.Windows.Forms.CheckBox bogoSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox sortAscending;
        private System.Windows.Forms.CheckBox sortDescending;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberSort;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private ZedGraph.ZedGraphControl zedGraphControl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox bubbleInfo;
        private System.Windows.Forms.RichTextBox insertInfo;
        private System.Windows.Forms.RichTextBox shakerInfo;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
    }
}

