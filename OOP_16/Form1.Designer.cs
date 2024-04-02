namespace OOP_16
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
            lbl_1 = new Label();
            lbl_2 = new Label();
            lbl_3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbl_4 = new Label();
            btn_1 = new Button();
            btn_2 = new Button();
            SuspendLayout();
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl_1.Location = new Point(64, 51);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(81, 28);
            lbl_1.TabIndex = 0;
            lbl_1.Text = "Місто";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl_2.Location = new Point(64, 128);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(88, 28);
            lbl_2.TabIndex = 1;
            lbl_2.Text = "Вулиця";
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl_3.Location = new Point(66, 205);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(81, 28);
            lbl_3.TabIndex = 2;
            lbl_3.Text = "Номер";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 49);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 129);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 207);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 27);
            textBox3.TabIndex = 5;
            // 
            // lbl_4
            // 
            lbl_4.AutoSize = true;
            lbl_4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl_4.Location = new Point(12, 287);
            lbl_4.Name = "lbl_4";
            lbl_4.Size = new Size(155, 28);
            lbl_4.TabIndex = 6;
            lbl_4.Text = "Ваша адреса:";
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Aquamarine;
            btn_1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_1.Location = new Point(96, 360);
            btn_1.Margin = new Padding(3, 4, 3, 4);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(144, 51);
            btn_1.TabIndex = 7;
            btn_1.Text = "Розпочати";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Aquamarine;
            btn_2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_2.Location = new Point(264, 360);
            btn_2.Margin = new Padding(3, 4, 3, 4);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(126, 51);
            btn_2.TabIndex = 8;
            btn_2.Text = "Видалити";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 473);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(lbl_4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_3);
            Controls.Add(lbl_2);
            Controls.Add(lbl_1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP 16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_1;
        private Label lbl_2;
        private Label lbl_3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbl_4;
        private Button btn_1;
        private Button btn_2;
    }
}
