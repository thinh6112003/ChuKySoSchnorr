namespace ChuKySoSchnorr
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
            panel1 = new Panel();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            textBox6 = new TextBox();
            button3 = new Button();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label13 = new Label();
            label9 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            panel3 = new Panel();
            label11 = new Label();
            button4 = new Button();
            textBox10 = new TextBox();
            label12 = new Label();
            label15 = new Label();
            textBox11 = new TextBox();
            label16 = new Label();
            textBox12 = new TextBox();
            label17 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox13 = new TextBox();
            label18 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 632);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(11, 363);
            label7.Name = "label7";
            label7.Size = new Size(224, 23);
            label7.TabIndex = 12;
            label7.Text = "Lỗi khi tạo tham số và khóa:";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlLightLight;
            textBox5.Location = new Point(165, 327);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.RightToLeft = RightToLeft.Yes;
            textBox5.Size = new Size(154, 27);
            textBox5.TabIndex = 11;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 330);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 10;
            label6.Text = "Khóa công khai y:";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(112, 257);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 9;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 207);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 7;
            label5.Text = "Chọn khóa bí mật x:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 159);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 5;
            label4.Text = "Chọn số nguyên g:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 111);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 3;
            label3.Text = "Chọn số nguyên q:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(47, 11);
            label2.Name = "label2";
            label2.Size = new Size(246, 35);
            label2.TabIndex = 2;
            label2.Text = "Tạo tham số và khóa";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 67);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn số nguyên tố p:";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(388, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 632);
            panel2.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ControlLightLight;
            textBox6.Location = new Point(15, 372);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(307, 54);
            textBox6.TabIndex = 18;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatAppearance.BorderSize = 0;
            button3.Location = new Point(232, 59);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(90, 29);
            button3.TabIndex = 27;
            button3.Text = "Chọn file";
            button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 340);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 17;
            label8.Text = "Thành phần thứ hai s:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(15, 101);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(307, 54);
            textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ControlLightLight;
            textBox8.Location = new Point(179, 293);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(141, 27);
            textBox8.TabIndex = 16;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F);
            label13.Location = new Point(100, 11);
            label13.Name = "label13";
            label13.Size = new Size(135, 35);
            label13.TabIndex = 15;
            label13.Text = "Tạo chữ ký";
            label13.Click += label13_Click;
            // 
            // label9
            // 
            label9.Location = new Point(12, 296);
            label9.Name = "label9";
            label9.Size = new Size(161, 40);
            label9.TabIndex = 15;
            label9.Text = "Thành phần thứ nhất r:";
            label9.Click += label9_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 65);
            label14.Name = "label14";
            label14.Size = new Size(213, 20);
            label14.TabIndex = 13;
            label14.Text = "Chọn hoặc nhập thông điệp M:";
            label14.Click += label14_Click;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ControlLightLight;
            textBox9.Location = new Point(179, 249);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(141, 27);
            textBox9.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 252);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 13;
            label10.Text = "Số ngẫu nhiên k:";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(122, 179);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 22;
            button2.Text = "Sign";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(textBox13);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(textBox11);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(textBox12);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(754, 12);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 632);
            panel3.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(56, 11);
            label11.Name = "label11";
            label11.Size = new Size(187, 35);
            label11.TabIndex = 13;
            label11.Text = "Kiểm tra chữ ký";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatAppearance.BorderSize = 0;
            button4.Location = new Point(231, 59);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(90, 29);
            button4.TabIndex = 30;
            button4.Text = "Chọn file";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(14, 101);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(307, 54);
            textBox10.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 65);
            label12.Name = "label12";
            label12.Size = new Size(213, 20);
            label12.TabIndex = 28;
            label12.Text = "Chọn hoặc nhập thông điệp M:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(14, 179);
            label15.Name = "label15";
            label15.Size = new Size(165, 20);
            label15.TabIndex = 28;
            label15.Text = "Chọn hoặc nhập chữ ký:";
            label15.Click += label15_Click;
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ControlLightLight;
            textBox11.Location = new Point(14, 327);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(307, 54);
            textBox11.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label16.Location = new Point(11, 293);
            label16.Name = "label16";
            label16.Size = new Size(148, 20);
            label16.TabIndex = 30;
            label16.Text = "Thành phần thứ hai s:";
            // 
            // textBox12
            // 
            textBox12.BackColor = SystemColors.ControlLightLight;
            textBox12.Location = new Point(14, 251);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(303, 27);
            textBox12.TabIndex = 29;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label17.Location = new Point(11, 218);
            label17.Name = "label17";
            label17.Size = new Size(161, 20);
            label17.TabIndex = 28;
            label17.Text = "Thành phần thứ nhất r:";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatAppearance.BorderSize = 0;
            button5.Location = new Point(227, 209);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(90, 29);
            button5.TabIndex = 32;
            button5.Text = "Chọn file";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.FlatAppearance.BorderSize = 0;
            button6.Location = new Point(231, 286);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(90, 29);
            button6.TabIndex = 33;
            button6.Text = "Chọn file";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleGreen;
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(117, 403);
            button7.Name = "button7";
            button7.Size = new Size(113, 46);
            button7.TabIndex = 28;
            button7.Text = "Check";
            button7.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.ControlLightLight;
            textBox13.Location = new Point(14, 507);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(307, 54);
            textBox13.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(11, 473);
            label18.Name = "label18";
            label18.Size = new Size(63, 20);
            label18.TabIndex = 34;
            label18.Text = "Kết quả:";
            label18.Click += label18_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1118, 653);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Schnorr Sign";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Label label13;
        private Label label14;
        private Button button2;
        private TextBox textBox7;
        private Button button3;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private Label label15;
        private Button button4;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox11;
        private Label label16;
        private TextBox textBox12;
        private Label label17;
        private Button button6;
        private Button button5;
        private TextBox textBox13;
        private Label label18;
        private Button button7;
    }
}
