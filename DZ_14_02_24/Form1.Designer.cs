namespace DZ_14_02_24
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
            generator_Button = new Button();
            start_textBox = new TextBox();
            end_textBox = new TextBox();
            result_textBox = new TextBox();
            start_label = new Label();
            end_label = new Label();
            clear_button = new Button();
            fibonachi_button = new Button();
            stop_button = new Button();
            pause_button = new Button();
            resume_button = new Button();
            SuspendLayout();
            // 
            // generator_Button
            // 
            generator_Button.Location = new Point(12, 123);
            generator_Button.Name = "generator_Button";
            generator_Button.Size = new Size(199, 34);
            generator_Button.TabIndex = 0;
            generator_Button.Text = "Згенерувати";
            generator_Button.UseVisualStyleBackColor = true;
            generator_Button.Click += generator_Button_Click;
            // 
            // start_textBox
            // 
            start_textBox.BorderStyle = BorderStyle.FixedSingle;
            start_textBox.Location = new Point(12, 26);
            start_textBox.Name = "start_textBox";
            start_textBox.Size = new Size(150, 23);
            start_textBox.TabIndex = 1;
            start_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // end_textBox
            // 
            end_textBox.BorderStyle = BorderStyle.FixedSingle;
            end_textBox.Location = new Point(12, 85);
            end_textBox.Name = "end_textBox";
            end_textBox.Size = new Size(150, 23);
            end_textBox.TabIndex = 2;
            end_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // result_textBox
            // 
            result_textBox.BorderStyle = BorderStyle.None;
            result_textBox.Location = new Point(168, 8);
            result_textBox.Multiline = true;
            result_textBox.Name = "result_textBox";
            result_textBox.ReadOnly = true;
            result_textBox.ScrollBars = ScrollBars.Vertical;
            result_textBox.Size = new Size(265, 100);
            result_textBox.TabIndex = 3;
            result_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // start_label
            // 
            start_label.AutoSize = true;
            start_label.Font = new Font("Segoe UI", 9F);
            start_label.Location = new Point(12, 8);
            start_label.Name = "start_label";
            start_label.Size = new Size(150, 15);
            start_label.TabIndex = 4;
            start_label.Text = "Введіть початок діапазону";
            // 
            // end_label
            // 
            end_label.AutoSize = true;
            end_label.Location = new Point(12, 67);
            end_label.Name = "end_label";
            end_label.Size = new Size(143, 15);
            end_label.TabIndex = 5;
            end_label.Text = "Введіть кунець діапазону";
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.IndianRed;
            clear_button.Location = new Point(217, 123);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(199, 34);
            clear_button.TabIndex = 6;
            clear_button.Text = "Очистити";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // fibonachi_button
            // 
            fibonachi_button.Location = new Point(12, 163);
            fibonachi_button.Name = "fibonachi_button";
            fibonachi_button.Size = new Size(150, 44);
            fibonachi_button.TabIndex = 7;
            fibonachi_button.Text = "Згенерувати Фібоначі";
            fibonachi_button.UseVisualStyleBackColor = true;
            fibonachi_button.Click += fibonachi_button_Click;
            // 
            // stop_button
            // 
            stop_button.BackColor = Color.IndianRed;
            stop_button.Location = new Point(324, 163);
            stop_button.Name = "stop_button";
            stop_button.Size = new Size(92, 44);
            stop_button.TabIndex = 8;
            stop_button.Text = "Зупинка потоку";
            stop_button.UseVisualStyleBackColor = false;
            stop_button.Click += stop_button_Click;
            // 
            // pause_button
            // 
            pause_button.BackColor = Color.Yellow;
            pause_button.Location = new Point(263, 163);
            pause_button.Name = "pause_button";
            pause_button.Size = new Size(55, 44);
            pause_button.TabIndex = 9;
            pause_button.Text = "Пауза потоку";
            pause_button.UseVisualStyleBackColor = false;
            pause_button.Click += pause_button_Click;
            // 
            // resume_button
            // 
            resume_button.BackColor = Color.LawnGreen;
            resume_button.Location = new Point(168, 163);
            resume_button.Name = "resume_button";
            resume_button.Size = new Size(89, 44);
            resume_button.TabIndex = 10;
            resume_button.Text = "Продовжити потік";
            resume_button.UseVisualStyleBackColor = false;
            resume_button.Click += resume_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 240);
            Controls.Add(resume_button);
            Controls.Add(pause_button);
            Controls.Add(stop_button);
            Controls.Add(fibonachi_button);
            Controls.Add(clear_button);
            Controls.Add(end_label);
            Controls.Add(start_label);
            Controls.Add(result_textBox);
            Controls.Add(end_textBox);
            Controls.Add(start_textBox);
            Controls.Add(generator_Button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generator_Button;
        private TextBox start_textBox;
        private TextBox end_textBox;
        private TextBox result_textBox;
        private Label start_label;
        private Label end_label;
        private Button clear_button;
        private Button fibonachi_button;
        private Button stop_button;
        private Button pause_button;
        private Button resume_button;
    }
}
