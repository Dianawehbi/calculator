namespace Calculator_App
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
            Panel calculator_choice;
            rbtn_scentific = new RadioButton();
            rbtn_simple = new RadioButton();
            result = new TextBox();
            btn_1 = new Button();
            btn_4 = new Button();
            btn_7 = new Button();
            btn_clear = new Button();
            btn_2 = new Button();
            btn_5 = new Button();
            btn_8 = new Button();
            btn_0 = new Button();
            btn_3 = new Button();
            btn_6 = new Button();
            btn_9 = new Button();
            btn_dot = new Button();
            btn_add = new Button();
            button13 = new Button();
            button14 = new Button();
            button16 = new Button();
            button17 = new Button();
            lbl_op = new Label();
            grpBox_scientific = new GroupBox();
            sin = new RadioButton();
            pow = new RadioButton();
            sqrt = new RadioButton();
            cos = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            grbBox_design = new GroupBox();
            fontColor = new CheckBox();
            backColor = new CheckBox();
            pictureBox1 = new PictureBox();
            lbl_result = new Label();
            calculator_choice = new Panel();
            calculator_choice.SuspendLayout();
            grpBox_scientific.SuspendLayout();
            grbBox_design.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // calculator_choice
            // 
            calculator_choice.BorderStyle = BorderStyle.Fixed3D;
            calculator_choice.Controls.Add(rbtn_scentific);
            calculator_choice.Controls.Add(rbtn_simple);
            calculator_choice.Location = new Point(18, 14);
            calculator_choice.Name = "calculator_choice";
            calculator_choice.Size = new Size(120, 90);
            calculator_choice.TabIndex = 0;
            // 
            // rbtn_scentific
            // 
            rbtn_scentific.AutoSize = true;
            rbtn_scentific.Location = new Point(3, 46);
            rbtn_scentific.Name = "rbtn_scentific";
            rbtn_scentific.Size = new Size(101, 24);
            rbtn_scentific.TabIndex = 1;
            rbtn_scentific.TabStop = true;
            rbtn_scentific.Text = "Scientific";
            rbtn_scentific.UseVisualStyleBackColor = true;
            rbtn_scentific.CheckedChanged += rbtn_scentific_CheckedChanged;
            // 
            // rbtn_simple
            // 
            rbtn_simple.AutoSize = true;
            rbtn_simple.Location = new Point(3, 3);
            rbtn_simple.Name = "rbtn_simple";
            rbtn_simple.Size = new Size(83, 24);
            rbtn_simple.TabIndex = 0;
            rbtn_simple.TabStop = true;
            rbtn_simple.Text = "Simple";
            rbtn_simple.UseVisualStyleBackColor = true;
            rbtn_simple.CheckedChanged += rbtn_simple_CheckedChanged;
            // 
            // result
            // 
            result.BackColor = SystemColors.ControlLight;
            result.Enabled = false;
            result.Location = new Point(23, 149);
            result.Name = "result";
            result.Size = new Size(385, 28);
            result.TabIndex = 2;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(23, 192);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(64, 28);
            btn_1.TabIndex = 3;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(23, 226);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(64, 28);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(23, 260);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(64, 28);
            btn_7.TabIndex = 3;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(23, 294);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(64, 28);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(93, 192);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(64, 28);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(93, 226);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(64, 28);
            btn_5.TabIndex = 3;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(93, 260);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(64, 28);
            btn_8.TabIndex = 3;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(93, 294);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(64, 28);
            btn_0.TabIndex = 3;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(163, 192);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(64, 28);
            btn_3.TabIndex = 3;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(163, 226);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(64, 28);
            btn_6.TabIndex = 3;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(163, 260);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(64, 28);
            btn_9.TabIndex = 3;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_Click;
            // 
            // btn_dot
            // 
            btn_dot.Location = new Point(163, 294);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(64, 28);
            btn_dot.TabIndex = 3;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(262, 227);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(64, 28);
            btn_add.TabIndex = 3;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_operator;
            // 
            // button13
            // 
            button13.Location = new Point(262, 261);
            button13.Name = "button13";
            button13.Size = new Size(64, 28);
            button13.TabIndex = 3;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btn_operator;
            // 
            // button14
            // 
            button14.Location = new Point(332, 227);
            button14.Name = "button14";
            button14.Size = new Size(64, 28);
            button14.TabIndex = 3;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btn_operator;
            // 
            // button16
            // 
            button16.Location = new Point(332, 261);
            button16.Name = "button16";
            button16.Size = new Size(64, 28);
            button16.TabIndex = 3;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btn_operator;
            // 
            // button17
            // 
            button17.Location = new Point(262, 295);
            button17.Name = "button17";
            button17.Size = new Size(134, 28);
            button17.TabIndex = 3;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_equal;
            // 
            // lbl_op
            // 
            lbl_op.AutoSize = true;
            lbl_op.Location = new Point(262, 196);
            lbl_op.Name = "lbl_op";
            lbl_op.Size = new Size(146, 20);
            lbl_op.TabIndex = 4;
            lbl_op.Text = "Simple Operation";
            // 
            // grpBox_scientific
            // 
            grpBox_scientific.Controls.Add(sin);
            grpBox_scientific.Controls.Add(pow);
            grpBox_scientific.Controls.Add(sqrt);
            grpBox_scientific.Controls.Add(cos);
            grpBox_scientific.Location = new Point(23, 328);
            grpBox_scientific.Name = "grpBox_scientific";
            grpBox_scientific.Size = new Size(373, 50);
            grpBox_scientific.TabIndex = 5;
            grpBox_scientific.TabStop = false;
            grpBox_scientific.Text = "Scientific";
            grpBox_scientific.Visible = false;
            // 
            // sin
            // 
            sin.AutoSize = true;
            sin.Location = new Point(131, 24);
            sin.Name = "sin";
            sin.Size = new Size(52, 24);
            sin.TabIndex = 1;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = true;
            sin.CheckedChanged += scientific_operatt;
            // 
            // pow
            // 
            pow.AutoSize = true;
            pow.Location = new Point(296, 24);
            pow.Name = "pow";
            pow.Size = new Size(77, 24);
            pow.TabIndex = 1;
            pow.Text = "power";
            pow.UseVisualStyleBackColor = true;
            pow.CheckedChanged += power_radio;
            // 
            // sqrt
            // 
            sqrt.AutoSize = true;
            sqrt.Location = new Point(216, 24);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(60, 24);
            sqrt.TabIndex = 1;
            sqrt.Text = "sqrt";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.CheckedChanged += scientific_operatt;
            // 
            // cos
            // 
            cos.AutoSize = true;
            cos.Location = new Point(18, 24);
            cos.Name = "cos";
            cos.Size = new Size(55, 24);
            cos.TabIndex = 0;
            cos.TabStop = true;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = true;
            cos.CheckedChanged += scientific_operatt;
            // 
            // grbBox_design
            // 
            grbBox_design.Controls.Add(fontColor);
            grbBox_design.Controls.Add(backColor);
            grbBox_design.Location = new Point(23, 384);
            grbBox_design.Name = "grbBox_design";
            grbBox_design.Size = new Size(373, 57);
            grbBox_design.TabIndex = 6;
            grbBox_design.TabStop = false;
            grbBox_design.Text = "change Design";
            // 
            // fontColor
            // 
            fontColor.AutoSize = true;
            fontColor.Location = new Point(239, 27);
            fontColor.Name = "fontColor";
            fontColor.Size = new Size(72, 24);
            fontColor.TabIndex = 0;
            fontColor.Text = "Font ";
            fontColor.UseVisualStyleBackColor = true;
            fontColor.CheckedChanged += ToggleFont;
            // 
            // backColor
            // 
            backColor.AutoSize = true;
            backColor.Location = new Point(18, 27);
            backColor.Name = "backColor";
            backColor.Size = new Size(176, 24);
            backColor.TabIndex = 0;
            backColor.Text = "Background Color";
            backColor.UseVisualStyleBackColor = true;
            backColor.CheckedChanged += ToggleBackgroundColor;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(262, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Location = new Point(18, 117);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(58, 20);
            lbl_result.TabIndex = 1;
            lbl_result.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(430, 453);
            Controls.Add(btn_5);
            Controls.Add(pictureBox1);
            Controls.Add(grbBox_design);
            Controls.Add(grpBox_scientific);
            Controls.Add(lbl_op);
            Controls.Add(btn_dot);
            Controls.Add(btn_9);
            Controls.Add(button16);
            Controls.Add(btn_0);
            Controls.Add(btn_8);
            Controls.Add(btn_6);
            Controls.Add(button14);
            Controls.Add(btn_clear);
            Controls.Add(button13);
            Controls.Add(btn_3);
            Controls.Add(btn_7);
            Controls.Add(button17);
            Controls.Add(btn_add);
            Controls.Add(btn_2);
            Controls.Add(btn_4);
            Controls.Add(btn_1);
            Controls.Add(result);
            Controls.Add(lbl_result);
            Controls.Add(calculator_choice);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            calculator_choice.ResumeLayout(false);
            calculator_choice.PerformLayout();
            grpBox_scientific.ResumeLayout(false);
            grpBox_scientific.PerformLayout();
            grbBox_design.ResumeLayout(false);
            grbBox_design.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtn_scentific;
        private RadioButton rbtn_simple;
        private TextBox result;
        private Button btn_1;
        private Button btn_4;
        private Button btn_7;
        private Button btn_clear;
        private Button btn_2;
        private Button btn_5;
        private Button btn_8;
        private Button btn_0;
        private Button btn_3;
        private Button btn_6;
        private Button btn_9;
        private Button btn_dot;
        private Button btn_add;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button17;
        private Label lbl_op;
        private GroupBox grpBox_scientific;
        private RadioButton sqrt;
        private RadioButton cos;
        private RadioButton sin;
        private RadioButton pow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox grbBox_design;
        private CheckBox backColor;
        private CheckBox fontColor;
        private PictureBox pictureBox1;
        private Label lbl_result;
    }
}
