
namespace _TRPO3VMK
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlAddDir = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBPalNumAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBPhoneAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBNameAdd = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVSpecialize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVFIO = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFromAdd = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlAddDir.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Учет больных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddDir);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.tabControlAddDir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Справочник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddDir
            // 
            this.buttonAddDir.Location = new System.Drawing.Point(6, 371);
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.Size = new System.Drawing.Size(268, 23);
            this.buttonAddDir.TabIndex = 2;
            this.buttonAddDir.Text = "Добавить";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(279, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControlAddDir
            // 
            this.tabControlAddDir.Controls.Add(this.tabPage5);
            this.tabControlAddDir.Controls.Add(this.tabPage6);
            this.tabControlAddDir.Controls.Add(this.tabPage7);
            this.tabControlAddDir.Location = new System.Drawing.Point(7, 6);
            this.tabControlAddDir.Name = "tabControlAddDir";
            this.tabControlAddDir.SelectedIndex = 0;
            this.tabControlAddDir.Size = new System.Drawing.Size(267, 359);
            this.tabControlAddDir.TabIndex = 0;
            this.tabControlAddDir.SelectedIndexChanged += new System.EventHandler(this.tabControlAddDir_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.textBoxBPalNumAdd);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.textBoxBPhoneAdd);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.textBoxBNameAdd);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(259, 333);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Отделение";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер палаты";
            // 
            // textBoxBPalNumAdd
            // 
            this.textBoxBPalNumAdd.Location = new System.Drawing.Point(6, 97);
            this.textBoxBPalNumAdd.Name = "textBoxBPalNumAdd";
            this.textBoxBPalNumAdd.Size = new System.Drawing.Size(247, 20);
            this.textBoxBPalNumAdd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // textBoxBPhoneAdd
            // 
            this.textBoxBPhoneAdd.Location = new System.Drawing.Point(6, 58);
            this.textBoxBPhoneAdd.Name = "textBoxBPhoneAdd";
            this.textBoxBPhoneAdd.Size = new System.Drawing.Size(247, 20);
            this.textBoxBPhoneAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // textBoxBNameAdd
            // 
            this.textBoxBNameAdd.Location = new System.Drawing.Point(6, 19);
            this.textBoxBNameAdd.Name = "textBoxBNameAdd";
            this.textBoxBNameAdd.Size = new System.Drawing.Size(247, 20);
            this.textBoxBNameAdd.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.textBoxVSpecialize);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.textBoxVFIO);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(259, 333);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Врач";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Специализация";
            // 
            // textBoxVSpecialize
            // 
            this.textBoxVSpecialize.Location = new System.Drawing.Point(9, 58);
            this.textBoxVSpecialize.Name = "textBoxVSpecialize";
            this.textBoxVSpecialize.Size = new System.Drawing.Size(247, 20);
            this.textBoxVSpecialize.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ФИО";
            // 
            // textBoxVFIO
            // 
            this.textBoxVFIO.Location = new System.Drawing.Point(9, 19);
            this.textBoxVFIO.Name = "textBoxVFIO";
            this.textBoxVFIO.Size = new System.Drawing.Size(247, 20);
            this.textBoxVFIO.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.textBoxFromAdd);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(259, 333);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Откуда поступил";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Откуда поступил";
            // 
            // textBoxFromAdd
            // 
            this.textBoxFromAdd.Location = new System.Drawing.Point(9, 19);
            this.textBoxFromAdd.Name = "textBoxFromAdd";
            this.textBoxFromAdd.Size = new System.Drawing.Size(247, 20);
            this.textBoxFromAdd.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчеты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Помощь";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(483, 388);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(495, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(267, 388);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(259, 362);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Инфо 1";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(259, 362);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Инфо 2";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlAddDir.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlAddDir;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBPhoneAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBPalNumAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVSpecialize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVFIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFromAdd;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
    }
}

