namespace MyAwfulClickingApp
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
            this.button_clicker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_clickCount = new System.Windows.Forms.TextBox();
            this.textBox_wow = new System.Windows.Forms.TextBox();
            this.textBox_seriously = new System.Windows.Forms.TextBox();
            this.textBox_aaa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_clicker
            // 
            this.button_clicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_clicker.Location = new System.Drawing.Point(66, 206);
            this.button_clicker.Name = "button_clicker";
            this.button_clicker.Size = new System.Drawing.Size(186, 60);
            this.button_clicker.TabIndex = 0;
            this.button_clicker.Text = "Clicker button";
            this.button_clicker.UseVisualStyleBackColor = true;
            this.button_clicker.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "This button has been clicked...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "times";
            // 
            // textBox_clickCount
            // 
            this.textBox_clickCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_clickCount.Enabled = false;
            this.textBox_clickCount.Location = new System.Drawing.Point(129, 94);
            this.textBox_clickCount.Name = "textBox_clickCount";
            this.textBox_clickCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_clickCount.Size = new System.Drawing.Size(36, 20);
            this.textBox_clickCount.TabIndex = 3;
            this.textBox_clickCount.TabStop = false;
            this.textBox_clickCount.Text = "0";
            this.textBox_clickCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wow
            // 
            this.textBox_wow.BackColor = System.Drawing.Color.White;
            this.textBox_wow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_wow.Location = new System.Drawing.Point(12, 272);
            this.textBox_wow.Name = "textBox_wow";
            this.textBox_wow.ReadOnly = true;
            this.textBox_wow.Size = new System.Drawing.Size(113, 20);
            this.textBox_wow.TabIndex = 4;
            this.textBox_wow.Text = "wow, get a life!";
            this.textBox_wow.Visible = false;
            // 
            // textBox_seriously
            // 
            this.textBox_seriously.BackColor = System.Drawing.Color.White;
            this.textBox_seriously.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_seriously.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_seriously.ForeColor = System.Drawing.Color.Red;
            this.textBox_seriously.Location = new System.Drawing.Point(140, 285);
            this.textBox_seriously.Name = "textBox_seriously";
            this.textBox_seriously.ReadOnly = true;
            this.textBox_seriously.Size = new System.Drawing.Size(184, 33);
            this.textBox_seriously.TabIndex = 5;
            this.textBox_seriously.Text = "Seriously, stop.";
            this.textBox_seriously.Visible = false;
            // 
            // textBox_aaa
            // 
            this.textBox_aaa.BackColor = System.Drawing.Color.White;
            this.textBox_aaa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_aaa.Font = new System.Drawing.Font("Comic Sans MS", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_aaa.ForeColor = System.Drawing.Color.Blue;
            this.textBox_aaa.Location = new System.Drawing.Point(12, 206);
            this.textBox_aaa.Name = "textBox_aaa";
            this.textBox_aaa.ReadOnly = true;
            this.textBox_aaa.Size = new System.Drawing.Size(320, 49);
            this.textBox_aaa.TabIndex = 6;
            this.textBox_aaa.Text = "AAAAAAAAAAAA";
            this.textBox_aaa.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(336, 349);
            this.Controls.Add(this.textBox_aaa);
            this.Controls.Add(this.textBox_seriously);
            this.Controls.Add(this.textBox_wow);
            this.Controls.Add(this.textBox_clickCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clicker);
            this.Name = "Form1";
            this.Text = "ClickerApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_clicker;
        private Label label1;
        private Label label2;
        private TextBox textBox_clickCount;
        private TextBox textBox_wow;
        private TextBox textBox_seriously;
        private TextBox textBox_aaa;
    }   
}