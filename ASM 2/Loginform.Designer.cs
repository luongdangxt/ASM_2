namespace asm_2
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 23);
            label1.Name = "label1";
            label1.Size = new Size(788, 62);
            label1.TabIndex = 0;
            label1.Text = "CARCULATE WATER BILL PROGRAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(407, 186);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(407, 230);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // TbPassword
            // 
            TbPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPassword.Location = new Point(554, 236);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(213, 38);
            TbPassword.TabIndex = 3;
            TbPassword.TabStop = false;
            // 
            // TbUsername
            // 
            TbUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbUsername.Location = new Point(554, 186);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(213, 38);
            TbUsername.TabIndex = 4;
            TbUsername.TabStop = false;
            TbUsername.KeyDown += textBox2_KeyDown;
            TbUsername.KeyPress += textBox2_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(310, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 234);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(127, 176);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.TabStop = false;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 176);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 535);
            Controls.Add(TbUsername);
            Controls.Add(TbPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Loginform";
            Text = "Login";
            FormClosing += Form3_FormClosing;
            KeyDown += Form3_KeyDown;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TbPassword;
        private TextBox TbUsername;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
    }
}