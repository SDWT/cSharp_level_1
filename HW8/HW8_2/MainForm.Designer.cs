namespace HW8_2
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
            this.play = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(12, 42);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(280, 30);
            this.play.TabIndex = 0;
            this.play.Text = "Играть";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.Play_Click);
            // 
            // exit1
            // 
            this.exit1.Location = new System.Drawing.Point(12, 78);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(280, 30);
            this.exit1.TabIndex = 1;
            this.exit1.Text = "Выход";
            this.exit1.UseVisualStyleBackColor = true;
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.ControlBox = false;
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.play);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Викторина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button exit1;
    }
}

