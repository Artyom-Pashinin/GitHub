namespace race
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
            this.comboBox_cars_in_race = new System.Windows.Forms.ComboBox();
            this.comboBox_car_to_bet = new System.Windows.Forms.ComboBox();
            this.comboBox_stake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_start_race = new System.Windows.Forms.Button();
            this.pictureBox_car_5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car_4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_finish_Line = new System.Windows.Forms.PictureBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_finish_Line)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_cars_in_race
            // 
            this.comboBox_cars_in_race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cars_in_race.FormattingEnabled = true;
            this.comboBox_cars_in_race.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_cars_in_race.Location = new System.Drawing.Point(133, 297);
            this.comboBox_cars_in_race.Name = "comboBox_cars_in_race";
            this.comboBox_cars_in_race.Size = new System.Drawing.Size(84, 21);
            this.comboBox_cars_in_race.TabIndex = 0;
            this.comboBox_cars_in_race.SelectedIndexChanged += new System.EventHandler(this.comboBox_cars_in_race_SelectedIndexChanged);
            // 
            // comboBox_car_to_bet
            // 
            this.comboBox_car_to_bet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_car_to_bet.FormattingEnabled = true;
            this.comboBox_car_to_bet.Location = new System.Drawing.Point(399, 297);
            this.comboBox_car_to_bet.Name = "comboBox_car_to_bet";
            this.comboBox_car_to_bet.Size = new System.Drawing.Size(92, 21);
            this.comboBox_car_to_bet.TabIndex = 1;
            this.comboBox_car_to_bet.SelectedIndexChanged += new System.EventHandler(this.comboBox_car_to_bet_SelectedIndexChanged);
            // 
            // comboBox_stake
            // 
            this.comboBox_stake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stake.FormattingEnabled = true;
            this.comboBox_stake.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "250",
            "500",
            "1,000",
            "10,000",
            "50,000"});
            this.comboBox_stake.Location = new System.Drawing.Point(589, 297);
            this.comboBox_stake.Name = "comboBox_stake";
            this.comboBox_stake.Size = new System.Drawing.Size(92, 21);
            this.comboBox_stake.TabIndex = 2;
            this.comboBox_stake.SelectedIndexChanged += new System.EventHandler(this.comboBox_stake_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество машин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поставить на машину";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ставка";
            // 
            // button_start_race
            // 
            this.button_start_race.Location = new System.Drawing.Point(27, 344);
            this.button_start_race.Name = "button_start_race";
            this.button_start_race.Size = new System.Drawing.Size(655, 32);
            this.button_start_race.TabIndex = 5;
            this.button_start_race.TabStop = false;
            this.button_start_race.Text = "СТАРТ";
            this.button_start_race.UseVisualStyleBackColor = true;
            this.button_start_race.Visible = false;
            this.button_start_race.Click += new System.EventHandler(this.button_start_race_Click);
            // 
            // pictureBox_car_5
            // 
            this.pictureBox_car_5.Image = global::race.Properties.Resources._5;
            this.pictureBox_car_5.Location = new System.Drawing.Point(576, 206);
            this.pictureBox_car_5.Name = "pictureBox_car_5";
            this.pictureBox_car_5.Size = new System.Drawing.Size(83, 40);
            this.pictureBox_car_5.TabIndex = 6;
            this.pictureBox_car_5.TabStop = false;
            // 
            // pictureBox_car_4
            // 
            this.pictureBox_car_4.Image = global::race.Properties.Resources._4;
            this.pictureBox_car_4.Location = new System.Drawing.Point(576, 160);
            this.pictureBox_car_4.Name = "pictureBox_car_4";
            this.pictureBox_car_4.Size = new System.Drawing.Size(83, 40);
            this.pictureBox_car_4.TabIndex = 6;
            this.pictureBox_car_4.TabStop = false;
            // 
            // pictureBox_car_3
            // 
            this.pictureBox_car_3.Image = global::race.Properties.Resources._3;
            this.pictureBox_car_3.Location = new System.Drawing.Point(576, 114);
            this.pictureBox_car_3.Name = "pictureBox_car_3";
            this.pictureBox_car_3.Size = new System.Drawing.Size(83, 40);
            this.pictureBox_car_3.TabIndex = 6;
            this.pictureBox_car_3.TabStop = false;
            // 
            // pictureBox_car_2
            // 
            this.pictureBox_car_2.Image = global::race.Properties.Resources._2;
            this.pictureBox_car_2.Location = new System.Drawing.Point(576, 68);
            this.pictureBox_car_2.Name = "pictureBox_car_2";
            this.pictureBox_car_2.Size = new System.Drawing.Size(83, 40);
            this.pictureBox_car_2.TabIndex = 6;
            this.pictureBox_car_2.TabStop = false;
            // 
            // pictureBox_car_1
            // 
            this.pictureBox_car_1.Image = global::race.Properties.Resources._1;
            this.pictureBox_car_1.Location = new System.Drawing.Point(576, 22);
            this.pictureBox_car_1.Name = "pictureBox_car_1";
            this.pictureBox_car_1.Size = new System.Drawing.Size(83, 40);
            this.pictureBox_car_1.TabIndex = 6;
            this.pictureBox_car_1.TabStop = false;
            // 
            // pictureBox_finish_Line
            // 
            this.pictureBox_finish_Line.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_finish_Line.Location = new System.Drawing.Point(117, 12);
            this.pictureBox_finish_Line.Name = "pictureBox_finish_Line";
            this.pictureBox_finish_Line.Size = new System.Drawing.Size(10, 245);
            this.pictureBox_finish_Line.TabIndex = 7;
            this.pictureBox_finish_Line.TabStop = false;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(666, 34);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(20, 13);
            this.label_1.TabIndex = 8;
            this.label_1.Text = "#1";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(666, 81);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(20, 13);
            this.label_2.TabIndex = 8;
            this.label_2.Text = "#2";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(666, 128);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(20, 13);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "#3";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(666, 173);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(20, 13);
            this.label_4.TabIndex = 8;
            this.label_4.Text = "#4";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(666, 219);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(20, 13);
            this.label_5.TabIndex = 8;
            this.label_5.Text = "#5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 396);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.pictureBox_finish_Line);
            this.Controls.Add(this.pictureBox_car_5);
            this.Controls.Add(this.pictureBox_car_4);
            this.Controls.Add(this.pictureBox_car_3);
            this.Controls.Add(this.pictureBox_car_2);
            this.Controls.Add(this.pictureBox_car_1);
            this.Controls.Add(this.button_start_race);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_stake);
            this.Controls.Add(this.comboBox_car_to_bet);
            this.Controls.Add(this.comboBox_cars_in_race);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RACE";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_finish_Line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_cars_in_race;
        private System.Windows.Forms.ComboBox comboBox_car_to_bet;
        private System.Windows.Forms.ComboBox comboBox_stake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_start_race;
        private System.Windows.Forms.PictureBox pictureBox_car_1;
        private System.Windows.Forms.PictureBox pictureBox_car_2;
        private System.Windows.Forms.PictureBox pictureBox_car_3;
        private System.Windows.Forms.PictureBox pictureBox_car_4;
        private System.Windows.Forms.PictureBox pictureBox_car_5;
        private System.Windows.Forms.PictureBox pictureBox_finish_Line;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_5;
    }
}

