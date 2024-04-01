namespace Lab18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(18, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1329, 624);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1321, 578);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1026, 490);
            button4.Name = "button4";
            button4.Size = new Size(271, 65);
            button4.TabIndex = 4;
            button4.Text = "Очистити консоль";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(752, 490);
            button1.Name = "button1";
            button1.Size = new Size(252, 65);
            button1.TabIndex = 3;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(832, 40);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 421);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 36);
            label1.TabIndex = 1;
            label1.Text = "Введіть одновимірний масив:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1977, 382);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1321, 586);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(513, 216);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(199, 186);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(732, 317);
            button3.Name = "button3";
            button3.Size = new Size(196, 66);
            button3.TabIndex = 4;
            button3.Text = "Очистити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(732, 233);
            button2.Name = "button2";
            button2.Size = new Size(196, 66);
            button2.TabIndex = 3;
            button2.Text = "Змінити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(85, 279);
            label2.Name = "label2";
            label2.Size = new Size(399, 36);
            label2.TabIndex = 2;
            label2.Text = "Введіть двовимірний масив:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._18_2;
            pictureBox2.Location = new Point(48, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1261, 192);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 623);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            ShowIcon = false;
            Text = "Лабораторна 18 Кривонос Варіант 9";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button button4;
    }
}
