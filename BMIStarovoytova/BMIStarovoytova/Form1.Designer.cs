namespace BMIStarovoytova
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rost = new System.Windows.Forms.TextBox();
            this.ves = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BMI = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.man = new System.Windows.Forms.Panel();
            this.woman = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Женский = new System.Windows.Forms.PictureBox();
            this.Мужской = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.man.SuspendLayout();
            this.woman.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Женский)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Мужской)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о том что такое BMI и как калькулятор работает";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(307, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "BMI калькулятор";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(371, 321);
            this.trackBar1.Maximum = 35;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(417, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "см";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "кг";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rost
            // 
            this.rost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rost.Location = new System.Drawing.Point(117, 298);
            this.rost.Name = "rost";
            this.rost.Size = new System.Drawing.Size(60, 27);
            this.rost.TabIndex = 16;
            // 
            // ves
            // 
            this.ves.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ves.Location = new System.Drawing.Point(117, 335);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(60, 27);
            this.ves.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(393, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 11);
            this.label7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(485, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 12);
            this.label8.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(581, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 12);
            this.label9.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(678, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 12);
            this.label10.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Недостаточный";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Здоровый";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Избыточный";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(701, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ожирение";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 27;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // BMI
            // 
            this.BMI.AutoSize = true;
            this.BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMI.Location = new System.Drawing.Point(562, 305);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(42, 24);
            this.BMI.TabIndex = 18;
            this.BMI.Text = "BMI";
            this.BMI.Click += new System.EventHandler(this.BMI_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Карта";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // man
            // 
            this.man.Controls.Add(this.Мужской);
            this.man.Location = new System.Drawing.Point(45, 154);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(121, 135);
            this.man.TabIndex = 29;
            this.man.Paint += new System.Windows.Forms.PaintEventHandler(this.man_Paint);
            // 
            // woman
            // 
            this.woman.Controls.Add(this.Женский);
            this.woman.Location = new System.Drawing.Point(186, 154);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(123, 135);
            this.woman.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(468, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 248);
            this.panel1.TabIndex = 31;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(15, 18);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(193, 207);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 11;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Женский
            // 
            this.Женский.Image = global::BMIStarovoytova.Properties.Resources.female_icon;
            this.Женский.Location = new System.Drawing.Point(14, 19);
            this.Женский.Name = "Женский";
            this.Женский.Size = new System.Drawing.Size(97, 106);
            this.Женский.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Женский.TabIndex = 13;
            this.Женский.TabStop = false;
            this.Женский.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Мужской
            // 
            this.Мужской.Image = global::BMIStarovoytova.Properties.Resources.male_icon;
            this.Мужской.Location = new System.Drawing.Point(14, 19);
            this.Мужской.Name = "Мужской";
            this.Мужской.Size = new System.Drawing.Size(93, 106);
            this.Мужской.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Мужской.TabIndex = 12;
            this.Мужской.TabStop = false;
            this.Мужской.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.ves);
            this.Controls.Add(this.rost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.man.ResumeLayout(false);
            this.woman.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Женский)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Мужской)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox Мужской;
        private System.Windows.Forms.PictureBox Женский;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rost;
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label BMI;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel man;
        private System.Windows.Forms.Panel woman;
        private System.Windows.Forms.Panel panel1;
    }
}

