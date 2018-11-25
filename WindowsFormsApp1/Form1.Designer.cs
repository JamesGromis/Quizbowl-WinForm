namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Q4Qbox = new System.Windows.Forms.TextBox();
            this.Q4ABox = new System.Windows.Forms.TextBox();
            this.Q4SubmitButton = new System.Windows.Forms.Button();
            this.Q3NextQButton = new System.Windows.Forms.Button();
            this.Q5QBox = new System.Windows.Forms.TextBox();
            this.Q5ABox = new System.Windows.Forms.TextBox();
            this.Q5SubmitButton = new System.Windows.Forms.Button();
            this.Q4NextQButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(51, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(645, 167);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Submit Answer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Next Question";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(51, 27);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(645, 167);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(252, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(312, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Submit Answer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "Next Question";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(51, 27);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(645, 170);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(252, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(312, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(318, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = "Submit Answer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Q4Qbox
            // 
            this.Q4Qbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q4Qbox.Location = new System.Drawing.Point(51, 27);
            this.Q4Qbox.Multiline = true;
            this.Q4Qbox.Name = "Q4Qbox";
            this.Q4Qbox.ReadOnly = true;
            this.Q4Qbox.Size = new System.Drawing.Size(645, 170);
            this.Q4Qbox.TabIndex = 12;
            this.Q4Qbox.Text = resources.GetString("Q4Qbox.Text");
            this.Q4Qbox.TextChanged += new System.EventHandler(this.Q4Qbox_TextChanged);
            // 
            // Q4ABox
            // 
            this.Q4ABox.Location = new System.Drawing.Point(234, 216);
            this.Q4ABox.Name = "Q4ABox";
            this.Q4ABox.Size = new System.Drawing.Size(330, 20);
            this.Q4ABox.TabIndex = 13;
            this.Q4ABox.TextChanged += new System.EventHandler(this.Q4ABox_TextChanged);
            // 
            // Q4SubmitButton
            // 
            this.Q4SubmitButton.Location = new System.Drawing.Point(318, 259);
            this.Q4SubmitButton.Name = "Q4SubmitButton";
            this.Q4SubmitButton.Size = new System.Drawing.Size(144, 30);
            this.Q4SubmitButton.TabIndex = 14;
            this.Q4SubmitButton.Text = "Submit Answer";
            this.Q4SubmitButton.UseVisualStyleBackColor = true;
            this.Q4SubmitButton.Click += new System.EventHandler(this.Q4SubmitButton_Click);
            // 
            // Q3NextQButton
            // 
            this.Q3NextQButton.Location = new System.Drawing.Point(448, 362);
            this.Q3NextQButton.Name = "Q3NextQButton";
            this.Q3NextQButton.Size = new System.Drawing.Size(160, 42);
            this.Q3NextQButton.TabIndex = 15;
            this.Q3NextQButton.Text = "Next Question";
            this.Q3NextQButton.UseVisualStyleBackColor = true;
            this.Q3NextQButton.Click += new System.EventHandler(this.Q3NextQButton_Click);
            // 
            // Q5QBox
            // 
            this.Q5QBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q5QBox.Location = new System.Drawing.Point(51, 30);
            this.Q5QBox.Multiline = true;
            this.Q5QBox.Name = "Q5QBox";
            this.Q5QBox.ReadOnly = true;
            this.Q5QBox.Size = new System.Drawing.Size(645, 164);
            this.Q5QBox.TabIndex = 16;
            this.Q5QBox.Text = resources.GetString("Q5QBox.Text");
            this.Q5QBox.TextChanged += new System.EventHandler(this.Q5QBox_TextChanged);
            // 
            // Q5ABox
            // 
            this.Q5ABox.Location = new System.Drawing.Point(234, 216);
            this.Q5ABox.Name = "Q5ABox";
            this.Q5ABox.Size = new System.Drawing.Size(330, 20);
            this.Q5ABox.TabIndex = 17;
            this.Q5ABox.TextChanged += new System.EventHandler(this.Q5ABox_TextChanged);
            // 
            // Q5SubmitButton
            // 
            this.Q5SubmitButton.Location = new System.Drawing.Point(318, 259);
            this.Q5SubmitButton.Name = "Q5SubmitButton";
            this.Q5SubmitButton.Size = new System.Drawing.Size(144, 30);
            this.Q5SubmitButton.TabIndex = 18;
            this.Q5SubmitButton.Text = "Submit Answer";
            this.Q5SubmitButton.UseVisualStyleBackColor = true;
            this.Q5SubmitButton.Click += new System.EventHandler(this.Q5SubmitButton_Click);
            // 
            // Q4NextQButton
            // 
            this.Q4NextQButton.Location = new System.Drawing.Point(448, 362);
            this.Q4NextQButton.Name = "Q4NextQButton";
            this.Q4NextQButton.Size = new System.Drawing.Size(160, 42);
            this.Q4NextQButton.TabIndex = 19;
            this.Q4NextQButton.Text = "Next Question";
            this.Q4NextQButton.UseVisualStyleBackColor = true;
            this.Q4NextQButton.Click += new System.EventHandler(this.Q4NextQButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Q4NextQButton);
            this.Controls.Add(this.Q5SubmitButton);
            this.Controls.Add(this.Q5ABox);
            this.Controls.Add(this.Q5QBox);
            this.Controls.Add(this.Q3NextQButton);
            this.Controls.Add(this.Q4SubmitButton);
            this.Controls.Add(this.Q4ABox);
            this.Controls.Add(this.Q4Qbox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Q4Qbox;
        private System.Windows.Forms.TextBox Q4ABox;
        private System.Windows.Forms.Button Q4SubmitButton;
        private System.Windows.Forms.Button Q3NextQButton;
        private System.Windows.Forms.TextBox Q5QBox;
        private System.Windows.Forms.TextBox Q5ABox;
        private System.Windows.Forms.Button Q5SubmitButton;
        private System.Windows.Forms.Button Q4NextQButton;
    }
}

