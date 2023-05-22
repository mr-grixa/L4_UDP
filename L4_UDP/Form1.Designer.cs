namespace L4_UDP
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
            this.button_IP = new System.Windows.Forms.Button();
            this.textBox_Port1 = new System.Windows.Forms.TextBox();
            this.textBox_IP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_GenerateFunction1 = new System.Windows.Forms.ComboBox();
            this.comboBox_GenerateFunction2 = new System.Windows.Forms.ComboBox();
            this.comboBox_GenerateFunction3 = new System.Windows.Forms.ComboBox();
            this.comboBox_GenerateFunction4 = new System.Windows.Forms.ComboBox();
            this.textBox_IP2 = new System.Windows.Forms.TextBox();
            this.textBox_IP3 = new System.Windows.Forms.TextBox();
            this.textBox_IP4 = new System.Windows.Forms.TextBox();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.textBox_Port3 = new System.Windows.Forms.TextBox();
            this.textBox_Port4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_IP
            // 
            this.button_IP.Location = new System.Drawing.Point(9, 116);
            this.button_IP.Name = "button_IP";
            this.button_IP.Size = new System.Drawing.Size(371, 54);
            this.button_IP.TabIndex = 89;
            this.button_IP.Text = "Подключится";
            this.button_IP.UseVisualStyleBackColor = true;
            this.button_IP.Click += new System.EventHandler(this.button_IP_lidar_Click);
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Location = new System.Drawing.Point(102, 12);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(69, 20);
            this.textBox_Port1.TabIndex = 88;
            this.textBox_Port1.Text = "2368";
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Location = new System.Drawing.Point(27, 12);
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.Size = new System.Drawing.Size(69, 20);
            this.textBox_IP1.TabIndex = 87;
            this.textBox_IP1.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "ip";
            // 
            // comboBox_GenerateFunction1
            // 
            this.comboBox_GenerateFunction1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GenerateFunction1.FormattingEnabled = true;
            this.comboBox_GenerateFunction1.Items.AddRange(new object[] {
            "Синусоида",
            "Линейные данные",
            "Случайные данные",
            "Кубический "});
            this.comboBox_GenerateFunction1.Location = new System.Drawing.Point(178, 10);
            this.comboBox_GenerateFunction1.Name = "comboBox_GenerateFunction1";
            this.comboBox_GenerateFunction1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_GenerateFunction1.TabIndex = 91;
            // 
            // comboBox_GenerateFunction2
            // 
            this.comboBox_GenerateFunction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GenerateFunction2.FormattingEnabled = true;
            this.comboBox_GenerateFunction2.Items.AddRange(new object[] {
            "Синусоида",
            "Линейные данные",
            "Случайные данные",
            "Кубический "});
            this.comboBox_GenerateFunction2.Location = new System.Drawing.Point(178, 37);
            this.comboBox_GenerateFunction2.Name = "comboBox_GenerateFunction2";
            this.comboBox_GenerateFunction2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_GenerateFunction2.TabIndex = 92;
            // 
            // comboBox_GenerateFunction3
            // 
            this.comboBox_GenerateFunction3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GenerateFunction3.FormattingEnabled = true;
            this.comboBox_GenerateFunction3.Items.AddRange(new object[] {
            "Синусоида",
            "Линейные данные",
            "Случайные данные",
            "Кубический "});
            this.comboBox_GenerateFunction3.Location = new System.Drawing.Point(178, 64);
            this.comboBox_GenerateFunction3.Name = "comboBox_GenerateFunction3";
            this.comboBox_GenerateFunction3.Size = new System.Drawing.Size(121, 21);
            this.comboBox_GenerateFunction3.TabIndex = 93;
            // 
            // comboBox_GenerateFunction4
            // 
            this.comboBox_GenerateFunction4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GenerateFunction4.FormattingEnabled = true;
            this.comboBox_GenerateFunction4.Items.AddRange(new object[] {
            "Синусоида",
            "Линейные данные",
            "Случайные данные",
            "Кубический "});
            this.comboBox_GenerateFunction4.Location = new System.Drawing.Point(178, 91);
            this.comboBox_GenerateFunction4.Name = "comboBox_GenerateFunction4";
            this.comboBox_GenerateFunction4.Size = new System.Drawing.Size(121, 21);
            this.comboBox_GenerateFunction4.TabIndex = 94;
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Location = new System.Drawing.Point(27, 38);
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(69, 20);
            this.textBox_IP2.TabIndex = 95;
            this.textBox_IP2.Text = "127.0.0.1";
            // 
            // textBox_IP3
            // 
            this.textBox_IP3.Location = new System.Drawing.Point(27, 64);
            this.textBox_IP3.Name = "textBox_IP3";
            this.textBox_IP3.Size = new System.Drawing.Size(69, 20);
            this.textBox_IP3.TabIndex = 96;
            this.textBox_IP3.Text = "127.0.0.1";
            // 
            // textBox_IP4
            // 
            this.textBox_IP4.Location = new System.Drawing.Point(27, 92);
            this.textBox_IP4.Name = "textBox_IP4";
            this.textBox_IP4.Size = new System.Drawing.Size(69, 20);
            this.textBox_IP4.TabIndex = 97;
            this.textBox_IP4.Text = "127.0.0.1";
            // 
            // textBox_Port2
            // 
            this.textBox_Port2.Location = new System.Drawing.Point(102, 37);
            this.textBox_Port2.Name = "textBox_Port2";
            this.textBox_Port2.Size = new System.Drawing.Size(69, 20);
            this.textBox_Port2.TabIndex = 98;
            this.textBox_Port2.Text = "2368";
            // 
            // textBox_Port3
            // 
            this.textBox_Port3.Location = new System.Drawing.Point(102, 65);
            this.textBox_Port3.Name = "textBox_Port3";
            this.textBox_Port3.Size = new System.Drawing.Size(69, 20);
            this.textBox_Port3.TabIndex = 99;
            this.textBox_Port3.Text = "2368";
            // 
            // textBox_Port4
            // 
            this.textBox_Port4.Location = new System.Drawing.Point(102, 92);
            this.textBox_Port4.Name = "textBox_Port4";
            this.textBox_Port4.Size = new System.Drawing.Size(69, 20);
            this.textBox_Port4.TabIndex = 100;
            this.textBox_Port4.Text = "2368";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "ip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "ip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "ip";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(305, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 104;
            this.checkBox1.Text = "Включить";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(305, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 17);
            this.checkBox2.TabIndex = 105;
            this.checkBox2.Text = "Включить";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(305, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 106;
            this.checkBox3.Text = "Включить";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(305, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 17);
            this.checkBox4.TabIndex = 107;
            this.checkBox4.Text = "Включить";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 182);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Port4);
            this.Controls.Add(this.textBox_Port3);
            this.Controls.Add(this.textBox_Port2);
            this.Controls.Add(this.textBox_IP4);
            this.Controls.Add(this.textBox_IP3);
            this.Controls.Add(this.textBox_IP2);
            this.Controls.Add(this.comboBox_GenerateFunction4);
            this.Controls.Add(this.comboBox_GenerateFunction3);
            this.Controls.Add(this.comboBox_GenerateFunction2);
            this.Controls.Add(this.comboBox_GenerateFunction1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_IP);
            this.Controls.Add(this.textBox_Port1);
            this.Controls.Add(this.textBox_IP1);
            this.Name = "Form1";
            this.Text = "Щербинин Григорий 201-325 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_IP;
        private System.Windows.Forms.TextBox textBox_Port1;
        private System.Windows.Forms.TextBox textBox_IP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_GenerateFunction1;
        private System.Windows.Forms.ComboBox comboBox_GenerateFunction2;
        private System.Windows.Forms.ComboBox comboBox_GenerateFunction3;
        private System.Windows.Forms.ComboBox comboBox_GenerateFunction4;
        private System.Windows.Forms.TextBox textBox_IP2;
        private System.Windows.Forms.TextBox textBox_IP3;
        private System.Windows.Forms.TextBox textBox_IP4;
        private System.Windows.Forms.TextBox textBox_Port2;
        private System.Windows.Forms.TextBox textBox_Port3;
        private System.Windows.Forms.TextBox textBox_Port4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

