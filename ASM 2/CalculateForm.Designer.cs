namespace asm_2
{
    partial class CalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            groupBox1 = new GroupBox();
            label12 = new Label();
            button5 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cbType = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tbdes = new TextBox();
            tbtotal = new TextBox();
            tbamout = new TextBox();
            tbthismonth = new TextBox();
            tblastmonth = new TextBox();
            tbPhone = new TextBox();
            tbnum = new TextBox();
            tbName = new TextBox();
            tbId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvWaterBill = new ListView();
            label13 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbType);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbdes);
            groupBox1.Controls.Add(tbtotal);
            groupBox1.Controls.Add(tbamout);
            groupBox1.Controls.Add(tbthismonth);
            groupBox1.Controls.Add(tblastmonth);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbnum);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(173, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(867, 66);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 17;
            label12.Text = "Description";
            // 
            // button5
            // 
            button5.Location = new Point(858, 310);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 26;
            button5.TabStop = false;
            button5.Text = "Frint bill";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(567, 245);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 25;
            label11.Text = "(m3)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(567, 182);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 24;
            label10.Text = "(m3)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 245);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 23;
            label9.Text = "Total (with tax)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 182);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 22;
            label8.Text = "Amount used";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 33);
            label7.Name = "label7";
            label7.Size = new Size(87, 40);
            label7.TabIndex = 21;
            label7.Text = "Water this \r\nmonth (m3)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 33);
            label6.Name = "label6";
            label6.Size = new Size(87, 40);
            label6.TabIndex = 20;
            label6.Text = "Water last \r\nmonth (m3)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 245);
            label5.Name = "label5";
            label5.Size = new Size(85, 40);
            label5.TabIndex = 19;
            label5.Text = "Number of \r\nmembers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 190);
            label4.Name = "label4";
            label4.Size = new Size(70, 40);
            label4.TabIndex = 18;
            label4.Text = "Type of \r\ncustomer";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Household ", "Administrative agency, public services", "Production units", "Business services" });
            cbType.Location = new Point(107, 193);
            cbType.Name = "cbType";
            cbType.Size = new Size(151, 28);
            cbType.TabIndex = 17;
            cbType.TabStop = false;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(678, 310);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.TabStop = false;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(479, 310);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.TabStop = false;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 310);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.TabStop = false;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(107, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.TabStop = false;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbdes
            // 
            tbdes.Location = new Point(712, 89);
            tbdes.Multiline = true;
            tbdes.Name = "tbdes";
            tbdes.ReadOnly = true;
            tbdes.Size = new Size(390, 196);
            tbdes.TabIndex = 11;
            tbdes.TabStop = false;
            tbdes.TextChanged += tbdes_TextChanged;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(436, 242);
            tbtotal.Name = "tbtotal";
            tbtotal.ReadOnly = true;
            tbtotal.Size = new Size(125, 27);
            tbtotal.TabIndex = 10;
            tbtotal.TabStop = false;
            // 
            // tbamout
            // 
            tbamout.Location = new Point(436, 175);
            tbamout.Name = "tbamout";
            tbamout.ReadOnly = true;
            tbamout.Size = new Size(125, 27);
            tbamout.TabIndex = 9;
            tbamout.TabStop = false;
            tbamout.TextChanged += tbamout_TextChanged;
            // 
            // tbthismonth
            // 
            tbthismonth.Location = new Point(479, 92);
            tbthismonth.Name = "tbthismonth";
            tbthismonth.Size = new Size(125, 27);
            tbthismonth.TabIndex = 8;
            tbthismonth.TabStop = false;
            tbthismonth.TextChanged += tbthismonth_TextChanged;
            // 
            // tblastmonth
            // 
            tblastmonth.Location = new Point(332, 92);
            tblastmonth.Name = "tblastmonth";
            tblastmonth.Size = new Size(122, 27);
            tblastmonth.TabIndex = 7;
            tblastmonth.TabStop = false;
            tblastmonth.TextChanged += tblastmonth_TextChanged;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(107, 139);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(151, 27);
            tbPhone.TabIndex = 6;
            tbPhone.TabStop = false;
            // 
            // tbnum
            // 
            tbnum.Location = new Point(107, 246);
            tbnum.Name = "tbnum";
            tbnum.ReadOnly = true;
            tbnum.Size = new Size(151, 27);
            tbnum.TabIndex = 5;
            tbnum.TabStop = false;
            tbnum.TextChanged += tbnum_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(107, 92);
            tbName.Name = "tbName";
            tbName.Size = new Size(151, 27);
            tbName.TabIndex = 4;
            tbName.TabStop = false;
            // 
            // tbId
            // 
            tbId.Location = new Point(107, 46);
            tbId.Name = "tbId";
            tbId.Size = new Size(151, 27);
            tbId.TabIndex = 3;
            tbId.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 139);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // lvWaterBill
            // 
            lvWaterBill.FullRowSelect = true;
            lvWaterBill.GridLines = true;
            lvWaterBill.Location = new Point(-1, 447);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(1383, 252);
            lvWaterBill.TabIndex = 16;
            lvWaterBill.TabStop = false;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.View = View.Details;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(399, 13);
            label13.Name = "label13";
            label13.Size = new Size(540, 62);
            label13.TabIndex = 27;
            label13.Text = "CALCULATE WATER BILL";
            // 
            // CalculateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 658);
            Controls.Add(label13);
            Controls.Add(groupBox1);
            Controls.Add(lvWaterBill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculateForm";
            Text = "Calculate water bill";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbdes;
        private TextBox tbtotal;
        private TextBox tbamout;
        private TextBox tbthismonth;
        private TextBox tblastmonth;
        private TextBox tbPhone;
        private TextBox tbnum;
        private TextBox tbName;
        private TextBox tbId;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListView lvWaterBill;
        private ComboBox cbType;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label12;
        private Button button5;
        private Label label13;
    }
}
