﻿namespace kosta_test
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Отдел = new System.Windows.Forms.TextBox();
            this.Должность = new System.Windows.Forms.TextBox();
            this.Номер = new System.Windows.Forms.TextBox();
            this.Серия = new System.Windows.Forms.TextBox();
            this.Др = new System.Windows.Forms.TextBox();
            this.Отчество = new System.Windows.Forms.TextBox();
            this.Фамилия = new System.Windows.Forms.TextBox();
            this.Имя = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Структура = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.Структура.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.ID);
            this.tabPage1.Controls.Add(this.Отдел);
            this.tabPage1.Controls.Add(this.Должность);
            this.tabPage1.Controls.Add(this.Номер);
            this.tabPage1.Controls.Add(this.Серия);
            this.tabPage1.Controls.Add(this.Др);
            this.tabPage1.Controls.Add(this.Отчество);
            this.tabPage1.Controls.Add(this.Фамилия);
            this.tabPage1.Controls.Add(this.Имя);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Структура";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(247, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ошибка";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Новый сотрудник";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Отдел";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Должность";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Номер";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Серия";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Др";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Отчество";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Имя";
            this.label1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(684, 289);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 13;
            this.ID.Visible = false;
            // 
            // Отдел
            // 
            this.Отдел.Location = new System.Drawing.Point(684, 243);
            this.Отдел.Name = "Отдел";
            this.Отдел.Size = new System.Drawing.Size(100, 22);
            this.Отдел.TabIndex = 12;
            this.Отдел.Visible = false;
            // 
            // Должность
            // 
            this.Должность.Location = new System.Drawing.Point(684, 200);
            this.Должность.Name = "Должность";
            this.Должность.Size = new System.Drawing.Size(100, 22);
            this.Должность.TabIndex = 11;
            this.Должность.Visible = false;
            // 
            // Номер
            // 
            this.Номер.Location = new System.Drawing.Point(480, 284);
            this.Номер.Name = "Номер";
            this.Номер.Size = new System.Drawing.Size(100, 22);
            this.Номер.TabIndex = 10;
            this.Номер.Visible = false;
            // 
            // Серия
            // 
            this.Серия.Location = new System.Drawing.Point(480, 243);
            this.Серия.Name = "Серия";
            this.Серия.Size = new System.Drawing.Size(100, 22);
            this.Серия.TabIndex = 9;
            this.Серия.Visible = false;
            // 
            // Др
            // 
            this.Др.Location = new System.Drawing.Point(480, 200);
            this.Др.Name = "Др";
            this.Др.Size = new System.Drawing.Size(100, 22);
            this.Др.TabIndex = 8;
            this.Др.Visible = false;
            // 
            // Отчество
            // 
            this.Отчество.Location = new System.Drawing.Point(314, 284);
            this.Отчество.Name = "Отчество";
            this.Отчество.Size = new System.Drawing.Size(100, 22);
            this.Отчество.TabIndex = 7;
            this.Отчество.Visible = false;
            this.Отчество.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Фамилия
            // 
            this.Фамилия.Location = new System.Drawing.Point(314, 240);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(100, 22);
            this.Фамилия.TabIndex = 6;
            this.Фамилия.Visible = false;
            // 
            // Имя
            // 
            this.Имя.Location = new System.Drawing.Point(314, 200);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(100, 22);
            this.Имя.TabIndex = 5;
            this.Имя.Visible = false;
            this.Имя.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(241, 390);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(241, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(555, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(241, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 164);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Структура
            // 
            this.Структура.Controls.Add(this.tabPage1);
            this.Структура.Location = new System.Drawing.Point(0, 2);
            this.Структура.Name = "Структура";
            this.Структура.SelectedIndex = 0;
            this.Структура.Size = new System.Drawing.Size(807, 455);
            this.Структура.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Структура);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Структура.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Отдел;
        private System.Windows.Forms.TextBox Должность;
        private System.Windows.Forms.TextBox Номер;
        private System.Windows.Forms.TextBox Серия;
        private System.Windows.Forms.TextBox Др;
        private System.Windows.Forms.TextBox Отчество;
        private System.Windows.Forms.TextBox Фамилия;
        private System.Windows.Forms.TextBox Имя;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Структура;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

