namespace HW7_3
{
    partial class MainForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.nameSp = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TabIndex = 2;
            this.name.Text = "<Заявитель>";
            this.name.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(12, 90);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(200, 20);
            this.position.TabIndex = 3;
            this.position.Text = "<Должность заявителя>";
            this.position.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(12, 12);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(201, 20);
            this.company.TabIndex = 0;
            this.company.Text = "<Фирма>";
            this.company.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // nameSp
            // 
            this.nameSp.Location = new System.Drawing.Point(12, 116);
            this.nameSp.Name = "nameSp";
            this.nameSp.Size = new System.Drawing.Size(200, 20);
            this.nameSp.TabIndex = 4;
            this.nameSp.Text = "<Заявитель в Родительнои падеже>";
            this.nameSp.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(12, 38);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(201, 20);
            this.director.TabIndex = 1;
            this.director.Text = "<Директор>";
            this.director.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Шаблон";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(425, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата начала отпуска";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата конца отпуска";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.director);
            this.Controls.Add(this.nameSp);
            this.Controls.Add(this.company);
            this.Controls.Add(this.name);
            this.Controls.Add(this.position);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Заявление на отпуск";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.TextBox nameSp;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

