namespace HW7_1
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
            this.plus1 = new System.Windows.Forms.Button();
            this.multy2 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.exit2 = new System.Windows.Forms.Button();
            this.finishNumber = new System.Windows.Forms.Label();
            this.currentNumber = new System.Windows.Forms.Label();
            this.gameEnd = new System.Windows.Forms.TextBox();
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
            // plus1
            // 
            this.plus1.Location = new System.Drawing.Point(202, 12);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(90, 30);
            this.plus1.TabIndex = 2;
            this.plus1.Text = "+1";
            this.plus1.UseVisualStyleBackColor = true;
            // 
            // multy2
            // 
            this.multy2.Location = new System.Drawing.Point(202, 48);
            this.multy2.Name = "multy2";
            this.multy2.Size = new System.Drawing.Size(90, 30);
            this.multy2.TabIndex = 3;
            this.multy2.Text = "х2";
            this.multy2.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(202, 84);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(12, 159);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(134, 30);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "Главное меню";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // exit2
            // 
            this.exit2.Location = new System.Drawing.Point(158, 159);
            this.exit2.Name = "exit2";
            this.exit2.Size = new System.Drawing.Size(134, 30);
            this.exit2.TabIndex = 6;
            this.exit2.Text = "Выход";
            this.exit2.UseVisualStyleBackColor = true;
            this.exit2.Click += new System.EventHandler(this.exit2_Click);
            // 
            // finishNumber
            // 
            this.finishNumber.AutoSize = true;
            this.finishNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishNumber.Location = new System.Drawing.Point(12, 12);
            this.finishNumber.Name = "finishNumber";
            this.finishNumber.Size = new System.Drawing.Size(115, 20);
            this.finishNumber.TabIndex = 7;
            this.finishNumber.Text = "Данное число";
            // 
            // currentNumber
            // 
            this.currentNumber.AutoSize = true;
            this.currentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentNumber.Location = new System.Drawing.Point(12, 48);
            this.currentNumber.Name = "currentNumber";
            this.currentNumber.Size = new System.Drawing.Size(148, 20);
            this.currentNumber.TabIndex = 8;
            this.currentNumber.Text = "Текущее значение";
            // 
            // gameEnd
            // 
            this.gameEnd.Location = new System.Drawing.Point(0, 0);
            this.gameEnd.Multiline = true;
            this.gameEnd.Name = "gameEnd";
            this.gameEnd.Size = new System.Drawing.Size(304, 153);
            this.gameEnd.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.ControlBox = false;
            this.Controls.Add(this.gameEnd);
            this.Controls.Add(this.currentNumber);
            this.Controls.Add(this.finishNumber);
            this.Controls.Add(this.exit2);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.multy2);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.play);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button exit1;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.Button multy2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button exit2;
        private System.Windows.Forms.Label finishNumber;
        private System.Windows.Forms.Label currentNumber;
        private System.Windows.Forms.TextBox gameEnd;
    }
}

