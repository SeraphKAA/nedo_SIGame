﻿namespace Guess_the_melody
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

        #region 

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.player_button = new System.Windows.Forms.Button();
            this.admin_button = new System.Windows.Forms.Button();
            this.back_to_persons_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(212, 46);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(102, 23);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Выбрать папку";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Visible = false;
            this.folderButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 17);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(13, 72);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 13);
            this.pathLabel.TabIndex = 2;
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(3, 316);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(102, 94);
            this.a1.TabIndex = 3;
            this.a1.Text = "button1";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Visible = false;
            this.a1.Click += new System.EventHandler(this.ObChooseButtonPressed);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(111, 316);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(102, 94);
            this.a2.TabIndex = 4;
            this.a2.Text = "button2";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Visible = false;
            this.a2.Click += new System.EventHandler(this.ObChooseButtonPressed);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(219, 316);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(102, 94);
            this.a3.TabIndex = 5;
            this.a3.Text = "button3";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Visible = false;
            this.a3.Click += new System.EventHandler(this.ObChooseButtonPressed);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(70, 161);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(181, 56);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Воспроизвести";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Visible = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // player_button
            // 
            this.player_button.Location = new System.Drawing.Point(70, 185);
            this.player_button.Name = "player_button";
            this.player_button.Size = new System.Drawing.Size(181, 52);
            this.player_button.TabIndex = 7;
            this.player_button.Text = "Игрок";
            this.player_button.UseVisualStyleBackColor = true;
            this.player_button.Click += new System.EventHandler(this.player_button_Click);
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(70, 127);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(181, 52);
            this.admin_button.TabIndex = 8;
            this.admin_button.Text = "Админ";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // back_to_persons_Button
            // 
            this.back_to_persons_Button.Location = new System.Drawing.Point(212, 17);
            this.back_to_persons_Button.Name = "back_to_persons_Button";
            this.back_to_persons_Button.Size = new System.Drawing.Size(102, 23);
            this.back_to_persons_Button.TabIndex = 9;
            this.back_to_persons_Button.Text = "Вернуться";
            this.back_to_persons_Button.UseVisualStyleBackColor = true;
            this.back_to_persons_Button.Visible = false;
            this.back_to_persons_Button.Click += new System.EventHandler(this.back_to_persons_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 432);
            this.Controls.Add(this.back_to_persons_Button);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.player_button);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.folderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosedForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button player_button;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button back_to_persons_Button;
    }
}