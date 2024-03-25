namespace sporSalon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            panel1 = new Panel();
            label15 = new Label();
            label14 = new Label();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(451, 40);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(29, 232);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(451, 708);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 2;
            label1.Text = "Kişinin aldığı ürünler";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 32;
            listBox2.Location = new Point(524, 232);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(432, 708);
            listBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(524, 24);
            label2.Name = "label2";
            label2.Size = new Size(289, 38);
            label2.TabIndex = 4;
            label2.Text = "Tarihe göre satılanlar";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(712, 74);
            button1.Name = "button1";
            button1.Size = new Size(244, 56);
            button1.TabIndex = 5;
            button1.Text = "Bugün";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(524, 85);
            maskedTextBox1.Mask = "0000/00/00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(173, 39);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Location = new Point(524, 136);
            button2.Name = "button2";
            button2.Size = new Size(432, 69);
            button2.TabIndex = 7;
            button2.Text = "Getir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Adsız_tasarım1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(990, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 166);
            panel1.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(195, 95);
            label15.Name = "label15";
            label15.Size = new Size(83, 29);
            label15.TabIndex = 3;
            label15.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(195, 35);
            label14.Name = "label14";
            label14.Size = new Size(83, 29);
            label14.TabIndex = 2;
            label14.Text = "label14";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(45, 91);
            label4.Name = "label4";
            label4.Size = new Size(140, 38);
            label4.TabIndex = 1;
            label4.Text = "Aylık Ciro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(22, 33);
            label3.Name = "label3";
            label3.Size = new Size(167, 38);
            label3.TabIndex = 0;
            label3.Text = "Günlük Ciro:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Location = new Point(29, 136);
            button3.Name = "button3";
            button3.Size = new Size(451, 69);
            button3.TabIndex = 9;
            button3.Text = "Siparişleri getir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Adsız_tasarım1;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(991, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 519);
            panel2.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(434, 98);
            label13.Name = "label13";
            label13.Size = new Size(75, 38);
            label13.TabIndex = 9;
            label13.Text = "Aylık";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(235, 98);
            label12.Name = "label12";
            label12.Size = new Size(102, 38);
            label12.TabIndex = 8;
            label12.Text = "Günlük";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(35, 441);
            label11.Name = "label11";
            label11.Size = new Size(161, 38);
            label11.TabIndex = 7;
            label11.Text = "Tavuk Pilav:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(101, 383);
            label10.Name = "label10";
            label10.Size = new Size(95, 38);
            label10.TabIndex = 6;
            label10.Text = "BCAA:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(-1, 327);
            label9.Name = "label9";
            label9.Size = new Size(197, 38);
            label9.TabIndex = 5;
            label9.Text = "Krbnhdrt Tozu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(18, 273);
            label8.Name = "label8";
            label8.Size = new Size(178, 38);
            label8.TabIndex = 4;
            label8.Text = "Protein Tozu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(60, 220);
            label7.Name = "label7";
            label7.Size = new Size(136, 38);
            label7.TabIndex = 3;
            label7.Text = "Büyük Su:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(58, 167);
            label6.Name = "label6";
            label6.Size = new Size(138, 38);
            label6.TabIndex = 2;
            label6.Text = "Küçük Su:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(113, 17);
            label5.Name = "label5";
            label5.Size = new Size(396, 44);
            label5.TabIndex = 2;
            label5.Text = "Ürünlerin Satılma Oranları";
            // 
            // button4
            // 
            button4.Location = new Point(456, 108);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 4;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1624, 961);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "TİTAN YÖNETİCİ PANELİ";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private Label label2;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Button button3;
        private Panel panel2;
        private Label label5;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label14;
        private Label label15;
        private Button button4;
    }
}