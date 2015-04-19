namespace shipApp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addToQueue_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ship5_progressBar = new System.Windows.Forms.ProgressBar();
            this.ship5_label = new System.Windows.Forms.Label();
            this.ship4_progressBar = new System.Windows.Forms.ProgressBar();
            this.ship4_label = new System.Windows.Forms.Label();
            this.ship3_progressBar = new System.Windows.Forms.ProgressBar();
            this.ship3_label = new System.Windows.Forms.Label();
            this.ship2_progressBar = new System.Windows.Forms.ProgressBar();
            this.ship2_label = new System.Windows.Forms.Label();
            this.ship1_progressBar = new System.Windows.Forms.ProgressBar();
            this.ship1_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Танкер",
            "Лодка",
            "Баржа",
            "Паром"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // addToQueue_button
            // 
            this.addToQueue_button.Location = new System.Drawing.Point(185, 13);
            this.addToQueue_button.Name = "addToQueue_button";
            this.addToQueue_button.Size = new System.Drawing.Size(169, 23);
            this.addToQueue_button.TabIndex = 1;
            this.addToQueue_button.Text = "Добавить в очередь загрузки";
            this.addToQueue_button.UseVisualStyleBackColor = true;
            this.addToQueue_button.Click += new System.EventHandler(this.addToQueue_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ship5_progressBar);
            this.groupBox1.Controls.Add(this.ship5_label);
            this.groupBox1.Controls.Add(this.ship4_progressBar);
            this.groupBox1.Controls.Add(this.ship4_label);
            this.groupBox1.Controls.Add(this.ship3_progressBar);
            this.groupBox1.Controls.Add(this.ship3_label);
            this.groupBox1.Controls.Add(this.ship2_progressBar);
            this.groupBox1.Controls.Add(this.ship2_label);
            this.groupBox1.Controls.Add(this.ship1_progressBar);
            this.groupBox1.Controls.Add(this.ship1_label);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Очередь загрузки";
            // 
            // ship5_progressBar
            // 
            this.ship5_progressBar.Location = new System.Drawing.Point(93, 168);
            this.ship5_progressBar.Name = "ship5_progressBar";
            this.ship5_progressBar.Size = new System.Drawing.Size(483, 31);
            this.ship5_progressBar.Step = 1;
            this.ship5_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ship5_progressBar.TabIndex = 1;
            // 
            // ship5_label
            // 
            this.ship5_label.AutoSize = true;
            this.ship5_label.Location = new System.Drawing.Point(19, 178);
            this.ship5_label.Name = "ship5_label";
            this.ship5_label.Size = new System.Drawing.Size(10, 13);
            this.ship5_label.TabIndex = 0;
            this.ship5_label.Text = " ";
            // 
            // ship4_progressBar
            // 
            this.ship4_progressBar.Location = new System.Drawing.Point(93, 131);
            this.ship4_progressBar.Name = "ship4_progressBar";
            this.ship4_progressBar.Size = new System.Drawing.Size(483, 31);
            this.ship4_progressBar.Step = 1;
            this.ship4_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ship4_progressBar.TabIndex = 1;
            // 
            // ship4_label
            // 
            this.ship4_label.AutoSize = true;
            this.ship4_label.Location = new System.Drawing.Point(19, 141);
            this.ship4_label.Name = "ship4_label";
            this.ship4_label.Size = new System.Drawing.Size(10, 13);
            this.ship4_label.TabIndex = 0;
            this.ship4_label.Text = " ";
            // 
            // ship3_progressBar
            // 
            this.ship3_progressBar.Location = new System.Drawing.Point(93, 94);
            this.ship3_progressBar.Name = "ship3_progressBar";
            this.ship3_progressBar.Size = new System.Drawing.Size(483, 31);
            this.ship3_progressBar.Step = 1;
            this.ship3_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ship3_progressBar.TabIndex = 1;
            // 
            // ship3_label
            // 
            this.ship3_label.AutoSize = true;
            this.ship3_label.Location = new System.Drawing.Point(19, 104);
            this.ship3_label.Name = "ship3_label";
            this.ship3_label.Size = new System.Drawing.Size(10, 13);
            this.ship3_label.TabIndex = 0;
            this.ship3_label.Text = " ";
            // 
            // ship2_progressBar
            // 
            this.ship2_progressBar.Location = new System.Drawing.Point(93, 57);
            this.ship2_progressBar.Name = "ship2_progressBar";
            this.ship2_progressBar.Size = new System.Drawing.Size(483, 31);
            this.ship2_progressBar.Step = 1;
            this.ship2_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ship2_progressBar.TabIndex = 1;
            // 
            // ship2_label
            // 
            this.ship2_label.AutoSize = true;
            this.ship2_label.Location = new System.Drawing.Point(19, 67);
            this.ship2_label.Name = "ship2_label";
            this.ship2_label.Size = new System.Drawing.Size(10, 13);
            this.ship2_label.TabIndex = 0;
            this.ship2_label.Text = " ";
            // 
            // ship1_progressBar
            // 
            this.ship1_progressBar.Location = new System.Drawing.Point(93, 20);
            this.ship1_progressBar.Name = "ship1_progressBar";
            this.ship1_progressBar.Size = new System.Drawing.Size(483, 31);
            this.ship1_progressBar.Step = 1;
            this.ship1_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ship1_progressBar.TabIndex = 1;
            // 
            // ship1_label
            // 
            this.ship1_label.AutoSize = true;
            this.ship1_label.Location = new System.Drawing.Point(19, 30);
            this.ship1_label.Name = "ship1_label";
            this.ship1_label.Size = new System.Drawing.Size(10, 13);
            this.ship1_label.TabIndex = 0;
            this.ship1_label.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addToQueue_button);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addToQueue_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ship1_progressBar;
        private System.Windows.Forms.Label ship1_label;
        private System.Windows.Forms.ProgressBar ship5_progressBar;
        private System.Windows.Forms.Label ship5_label;
        private System.Windows.Forms.ProgressBar ship4_progressBar;
        private System.Windows.Forms.Label ship4_label;
        private System.Windows.Forms.ProgressBar ship3_progressBar;
        private System.Windows.Forms.Label ship3_label;
        private System.Windows.Forms.ProgressBar ship2_progressBar;
        private System.Windows.Forms.Label ship2_label;
    }
}

