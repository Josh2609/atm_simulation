namespace ATM_simulation
{
    partial class atmSim
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
            this.tbAccNum = new System.Windows.Forms.TextBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.lblPIN = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.pbATM = new System.Windows.Forms.PictureBox();
            this.lblDisplayOut = new System.Windows.Forms.Label();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNumInactiveR = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNumInactiveL = new System.Windows.Forms.Button();
            this.btnNumInactiveLong = new System.Windows.Forms.Button();
            this.btnNumEnter = new System.Windows.Forms.Button();
            this.btnNumClear = new System.Windows.Forms.Button();
            this.btnNumCancel = new System.Windows.Forms.Button();
            this.btnScreen1 = new System.Windows.Forms.Button();
            this.lblScreenBtn2 = new System.Windows.Forms.Label();
            this.lblScreenBtn3 = new System.Windows.Forms.Label();
            this.btnScreen2 = new System.Windows.Forms.Button();
            this.btnScreen3 = new System.Windows.Forms.Button();
            this.btnScreen4 = new System.Windows.Forms.Button();
            this.lblScreenBtn4 = new System.Windows.Forms.Label();
            this.lblScreenBtn8 = new System.Windows.Forms.Label();
            this.lblScreenBtn7 = new System.Windows.Forms.Label();
            this.lblScreenBtn6 = new System.Windows.Forms.Label();
            this.lblScreenBtn5 = new System.Windows.Forms.Label();
            this.btnScreen8 = new System.Windows.Forms.Button();
            this.btnScreen7 = new System.Windows.Forms.Button();
            this.btnScreen6 = new System.Windows.Forms.Button();
            this.btnScreen5 = new System.Windows.Forms.Button();
            this.tbSetPin = new System.Windows.Forms.TextBox();
            this.lblCurrTime = new System.Windows.Forms.Label();
            this.lblLoginErrorMsg = new System.Windows.Forms.Label();
            this.lblScreenBtn1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbATM)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAccNum
            // 
            this.tbAccNum.Location = new System.Drawing.Point(210, 143);
            this.tbAccNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAccNum.MaxLength = 6;
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.ReadOnly = true;
            this.tbAccNum.Size = new System.Drawing.Size(76, 20);
            this.tbAccNum.TabIndex = 0;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAccNum.Location = new System.Drawing.Point(207, 123);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(87, 13);
            this.lblAccNum.TabIndex = 1;
            this.lblAccNum.Text = "Account Number";
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPIN.Location = new System.Drawing.Point(233, 123);
            this.lblPIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(25, 13);
            this.lblPIN.TabIndex = 37;
            this.lblPIN.Text = "PIN";
            this.lblPIN.Visible = false;
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(210, 143);
            this.tbPIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPIN.MaxLength = 4;
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.ReadOnly = true;
            this.tbPIN.Size = new System.Drawing.Size(76, 20);
            this.tbPIN.TabIndex = 38;
            this.tbPIN.UseSystemPasswordChar = true;
            this.tbPIN.Visible = false;
            // 
            // pbATM
            // 
            this.pbATM.BackgroundImage = global::ATM_simulation.Properties.Resources.atmScreen;
            this.pbATM.Location = new System.Drawing.Point(0, 0);
            this.pbATM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbATM.Name = "pbATM";
            this.pbATM.Size = new System.Drawing.Size(500, 321);
            this.pbATM.TabIndex = 57;
            this.pbATM.TabStop = false;
            // 
            // lblDisplayOut
            // 
            this.lblDisplayOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDisplayOut.Location = new System.Drawing.Point(83, 34);
            this.lblDisplayOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayOut.Name = "lblDisplayOut";
            this.lblDisplayOut.Size = new System.Drawing.Size(338, 255);
            this.lblDisplayOut.TabIndex = 58;
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(161, 360);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(38, 41);
            this.btnNum1.TabIndex = 59;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(203, 360);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(38, 41);
            this.btnNum2.TabIndex = 60;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(245, 360);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(38, 41);
            this.btnNum3.TabIndex = 61;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(245, 405);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(38, 41);
            this.btnNum6.TabIndex = 64;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(203, 405);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(38, 41);
            this.btnNum5.TabIndex = 63;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(161, 405);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(38, 41);
            this.btnNum4.TabIndex = 62;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(245, 451);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(38, 41);
            this.btnNum9.TabIndex = 67;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(203, 451);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(38, 41);
            this.btnNum8.TabIndex = 66;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(161, 451);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(38, 41);
            this.btnNum7.TabIndex = 65;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNumInactiveR
            // 
            this.btnNumInactiveR.Location = new System.Drawing.Point(245, 496);
            this.btnNumInactiveR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumInactiveR.Name = "btnNumInactiveR";
            this.btnNumInactiveR.Size = new System.Drawing.Size(38, 41);
            this.btnNumInactiveR.TabIndex = 70;
            this.btnNumInactiveR.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(203, 496);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(38, 41);
            this.btnNum0.TabIndex = 69;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNumInactiveL
            // 
            this.btnNumInactiveL.Location = new System.Drawing.Point(161, 496);
            this.btnNumInactiveL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumInactiveL.Name = "btnNumInactiveL";
            this.btnNumInactiveL.Size = new System.Drawing.Size(38, 41);
            this.btnNumInactiveL.TabIndex = 68;
            this.btnNumInactiveL.UseVisualStyleBackColor = true;
            // 
            // btnNumInactiveLong
            // 
            this.btnNumInactiveLong.Location = new System.Drawing.Point(302, 496);
            this.btnNumInactiveLong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumInactiveLong.Name = "btnNumInactiveLong";
            this.btnNumInactiveLong.Size = new System.Drawing.Size(56, 41);
            this.btnNumInactiveLong.TabIndex = 74;
            this.btnNumInactiveLong.UseVisualStyleBackColor = true;
            // 
            // btnNumEnter
            // 
            this.btnNumEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNumEnter.Location = new System.Drawing.Point(302, 451);
            this.btnNumEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumEnter.Name = "btnNumEnter";
            this.btnNumEnter.Size = new System.Drawing.Size(56, 41);
            this.btnNumEnter.TabIndex = 73;
            this.btnNumEnter.Text = "Enter";
            this.btnNumEnter.UseVisualStyleBackColor = false;
            this.btnNumEnter.Click += new System.EventHandler(this.btnNumEnter_Click);
            // 
            // btnNumClear
            // 
            this.btnNumClear.BackColor = System.Drawing.Color.Yellow;
            this.btnNumClear.Location = new System.Drawing.Point(302, 405);
            this.btnNumClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumClear.Name = "btnNumClear";
            this.btnNumClear.Size = new System.Drawing.Size(56, 41);
            this.btnNumClear.TabIndex = 72;
            this.btnNumClear.Text = "Clear";
            this.btnNumClear.UseVisualStyleBackColor = false;
            this.btnNumClear.Click += new System.EventHandler(this.btnNumClear_Click);
            // 
            // btnNumCancel
            // 
            this.btnNumCancel.BackColor = System.Drawing.Color.Red;
            this.btnNumCancel.Location = new System.Drawing.Point(302, 360);
            this.btnNumCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumCancel.Name = "btnNumCancel";
            this.btnNumCancel.Size = new System.Drawing.Size(56, 41);
            this.btnNumCancel.TabIndex = 71;
            this.btnNumCancel.Text = "Cancel";
            this.btnNumCancel.UseVisualStyleBackColor = false;
            this.btnNumCancel.Click += new System.EventHandler(this.btnNumCancel_Click);
            // 
            // btnScreen1
            // 
            this.btnScreen1.Location = new System.Drawing.Point(14, 123);
            this.btnScreen1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen1.Name = "btnScreen1";
            this.btnScreen1.Size = new System.Drawing.Size(29, 32);
            this.btnScreen1.TabIndex = 77;
            this.btnScreen1.UseVisualStyleBackColor = true;
            this.btnScreen1.Click += new System.EventHandler(this.btnScreen1_Click);
            // 
            // lblScreenBtn2
            // 
            this.lblScreenBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn2.Location = new System.Drawing.Point(83, 178);
            this.lblScreenBtn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn2.Name = "lblScreenBtn2";
            this.lblScreenBtn2.Size = new System.Drawing.Size(86, 13);
            this.lblScreenBtn2.TabIndex = 79;
            this.lblScreenBtn2.Text = "Check Balance";
            this.lblScreenBtn2.Visible = false;
            // 
            // lblScreenBtn3
            // 
            this.lblScreenBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn3.Location = new System.Drawing.Point(83, 223);
            this.lblScreenBtn3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn3.Name = "lblScreenBtn3";
            this.lblScreenBtn3.Size = new System.Drawing.Size(76, 14);
            this.lblScreenBtn3.TabIndex = 80;
            this.lblScreenBtn3.Text = "Return Card";
            this.lblScreenBtn3.Visible = false;
            // 
            // btnScreen2
            // 
            this.btnScreen2.Location = new System.Drawing.Point(14, 167);
            this.btnScreen2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen2.Name = "btnScreen2";
            this.btnScreen2.Size = new System.Drawing.Size(29, 32);
            this.btnScreen2.TabIndex = 81;
            this.btnScreen2.UseVisualStyleBackColor = true;
            this.btnScreen2.Click += new System.EventHandler(this.btnScreen2_Click);
            // 
            // btnScreen3
            // 
            this.btnScreen3.Location = new System.Drawing.Point(14, 211);
            this.btnScreen3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen3.Name = "btnScreen3";
            this.btnScreen3.Size = new System.Drawing.Size(29, 32);
            this.btnScreen3.TabIndex = 82;
            this.btnScreen3.UseVisualStyleBackColor = true;
            this.btnScreen3.Click += new System.EventHandler(this.btnScreen3_Click);
            // 
            // btnScreen4
            // 
            this.btnScreen4.Location = new System.Drawing.Point(14, 253);
            this.btnScreen4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen4.Name = "btnScreen4";
            this.btnScreen4.Size = new System.Drawing.Size(29, 32);
            this.btnScreen4.TabIndex = 83;
            this.btnScreen4.UseVisualStyleBackColor = true;
            this.btnScreen4.Click += new System.EventHandler(this.btnScreen4_Click);
            // 
            // lblScreenBtn4
            // 
            this.lblScreenBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn4.Location = new System.Drawing.Point(83, 266);
            this.lblScreenBtn4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn4.Name = "lblScreenBtn4";
            this.lblScreenBtn4.Size = new System.Drawing.Size(64, 14);
            this.lblScreenBtn4.TabIndex = 84;
            this.lblScreenBtn4.Text = "Change Pin";
            this.lblScreenBtn4.Visible = false;
            // 
            // lblScreenBtn8
            // 
            this.lblScreenBtn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn8.Location = new System.Drawing.Point(357, 266);
            this.lblScreenBtn8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn8.Name = "lblScreenBtn8";
            this.lblScreenBtn8.Size = new System.Drawing.Size(64, 14);
            this.lblScreenBtn8.TabIndex = 88;
            this.lblScreenBtn8.Text = "Return Card";
            this.lblScreenBtn8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblScreenBtn8.Visible = false;
            // 
            // lblScreenBtn7
            // 
            this.lblScreenBtn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn7.Location = new System.Drawing.Point(357, 223);
            this.lblScreenBtn7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn7.Name = "lblScreenBtn7";
            this.lblScreenBtn7.Size = new System.Drawing.Size(64, 14);
            this.lblScreenBtn7.TabIndex = 87;
            this.lblScreenBtn7.Text = "Return Card";
            this.lblScreenBtn7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblScreenBtn7.Visible = false;
            // 
            // lblScreenBtn6
            // 
            this.lblScreenBtn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn6.Location = new System.Drawing.Point(330, 179);
            this.lblScreenBtn6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn6.Name = "lblScreenBtn6";
            this.lblScreenBtn6.Size = new System.Drawing.Size(87, 14);
            this.lblScreenBtn6.TabIndex = 86;
            this.lblScreenBtn6.Text = "Check Balance";
            this.lblScreenBtn6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblScreenBtn6.Visible = false;
            // 
            // lblScreenBtn5
            // 
            this.lblScreenBtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn5.Location = new System.Drawing.Point(311, 133);
            this.lblScreenBtn5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn5.Name = "lblScreenBtn5";
            this.lblScreenBtn5.Size = new System.Drawing.Size(110, 15);
            this.lblScreenBtn5.TabIndex = 85;
            this.lblScreenBtn5.Text = "Recent Transactions";
            this.lblScreenBtn5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblScreenBtn5.Visible = false;
            // 
            // btnScreen8
            // 
            this.btnScreen8.Location = new System.Drawing.Point(457, 253);
            this.btnScreen8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen8.Name = "btnScreen8";
            this.btnScreen8.Size = new System.Drawing.Size(29, 32);
            this.btnScreen8.TabIndex = 92;
            this.btnScreen8.UseVisualStyleBackColor = true;
            this.btnScreen8.Click += new System.EventHandler(this.btnScreen8_Click);
            // 
            // btnScreen7
            // 
            this.btnScreen7.Location = new System.Drawing.Point(457, 211);
            this.btnScreen7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen7.Name = "btnScreen7";
            this.btnScreen7.Size = new System.Drawing.Size(29, 32);
            this.btnScreen7.TabIndex = 91;
            this.btnScreen7.UseVisualStyleBackColor = true;
            this.btnScreen7.Click += new System.EventHandler(this.btnScreen7_Click);
            // 
            // btnScreen6
            // 
            this.btnScreen6.Location = new System.Drawing.Point(457, 167);
            this.btnScreen6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen6.Name = "btnScreen6";
            this.btnScreen6.Size = new System.Drawing.Size(29, 32);
            this.btnScreen6.TabIndex = 90;
            this.btnScreen6.UseVisualStyleBackColor = true;
            this.btnScreen6.Click += new System.EventHandler(this.btnScreen6_Click);
            // 
            // btnScreen5
            // 
            this.btnScreen5.Location = new System.Drawing.Point(457, 123);
            this.btnScreen5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreen5.Name = "btnScreen5";
            this.btnScreen5.Size = new System.Drawing.Size(29, 32);
            this.btnScreen5.TabIndex = 89;
            this.btnScreen5.UseVisualStyleBackColor = true;
            this.btnScreen5.Click += new System.EventHandler(this.btnScreen5_Click);
            // 
            // tbSetPin
            // 
            this.tbSetPin.Location = new System.Drawing.Point(210, 167);
            this.tbSetPin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSetPin.MaxLength = 4;
            this.tbSetPin.Name = "tbSetPin";
            this.tbSetPin.ReadOnly = true;
            this.tbSetPin.Size = new System.Drawing.Size(76, 20);
            this.tbSetPin.TabIndex = 93;
            this.tbSetPin.Visible = false;
            // 
            // lblCurrTime
            // 
            this.lblCurrTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCurrTime.Location = new System.Drawing.Point(339, 34);
            this.lblCurrTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrTime.Name = "lblCurrTime";
            this.lblCurrTime.Size = new System.Drawing.Size(82, 19);
            this.lblCurrTime.TabIndex = 95;
            this.lblCurrTime.Text = "timer";
            this.lblCurrTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoginErrorMsg
            // 
            this.lblLoginErrorMsg.AutoSize = true;
            this.lblLoginErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLoginErrorMsg.Location = new System.Drawing.Point(161, 174);
            this.lblLoginErrorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginErrorMsg.Name = "lblLoginErrorMsg";
            this.lblLoginErrorMsg.Size = new System.Drawing.Size(104, 13);
            this.lblLoginErrorMsg.TabIndex = 96;
            this.lblLoginErrorMsg.Text = "Login Error Message";
            this.lblLoginErrorMsg.Visible = false;
            // 
            // lblScreenBtn1
            // 
            this.lblScreenBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScreenBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScreenBtn1.Location = new System.Drawing.Point(83, 133);
            this.lblScreenBtn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenBtn1.Name = "lblScreenBtn1";
            this.lblScreenBtn1.Size = new System.Drawing.Size(76, 15);
            this.lblScreenBtn1.TabIndex = 97;
            this.lblScreenBtn1.Text = "Withdraw Cash";
            this.lblScreenBtn1.Visible = false;
            // 
            // atmSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 655);
            this.Controls.Add(this.lblScreenBtn1);
            this.Controls.Add(this.lblLoginErrorMsg);
            this.Controls.Add(this.lblCurrTime);
            this.Controls.Add(this.tbSetPin);
            this.Controls.Add(this.btnScreen8);
            this.Controls.Add(this.btnScreen7);
            this.Controls.Add(this.btnScreen6);
            this.Controls.Add(this.btnScreen5);
            this.Controls.Add(this.lblScreenBtn8);
            this.Controls.Add(this.lblScreenBtn7);
            this.Controls.Add(this.lblScreenBtn6);
            this.Controls.Add(this.lblScreenBtn5);
            this.Controls.Add(this.lblScreenBtn4);
            this.Controls.Add(this.btnScreen4);
            this.Controls.Add(this.btnScreen3);
            this.Controls.Add(this.btnScreen2);
            this.Controls.Add(this.lblScreenBtn3);
            this.Controls.Add(this.lblScreenBtn2);
            this.Controls.Add(this.btnScreen1);
            this.Controls.Add(this.tbAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.btnNumInactiveLong);
            this.Controls.Add(this.btnNumEnter);
            this.Controls.Add(this.btnNumClear);
            this.Controls.Add(this.btnNumCancel);
            this.Controls.Add(this.btnNumInactiveR);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNumInactiveL);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblDisplayOut);
            this.Controls.Add(this.pbATM);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "atmSim";
            this.Text = "T15 Bank ATM";
            this.Load += new System.EventHandler(this.atmSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbATM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.PictureBox pbATM;
        private System.Windows.Forms.Label lblDisplayOut;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNumInactiveR;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNumInactiveL;
        private System.Windows.Forms.Button btnNumInactiveLong;
        private System.Windows.Forms.Button btnNumEnter;
        private System.Windows.Forms.Button btnNumClear;
        private System.Windows.Forms.Button btnNumCancel;
        private System.Windows.Forms.Button btnScreen1;
        private System.Windows.Forms.Label lblScreenBtn2;
        private System.Windows.Forms.Label lblScreenBtn3;
        private System.Windows.Forms.Button btnScreen2;
        private System.Windows.Forms.Button btnScreen3;
        private System.Windows.Forms.Button btnScreen4;
        private System.Windows.Forms.Label lblScreenBtn4;
        private System.Windows.Forms.Label lblScreenBtn8;
        private System.Windows.Forms.Label lblScreenBtn7;
        private System.Windows.Forms.Label lblScreenBtn6;
        private System.Windows.Forms.Label lblScreenBtn5;
        private System.Windows.Forms.Button btnScreen8;
        private System.Windows.Forms.Button btnScreen7;
        private System.Windows.Forms.Button btnScreen6;
        private System.Windows.Forms.Button btnScreen5;
        private System.Windows.Forms.TextBox tbSetPin;
        private System.Windows.Forms.Label lblCurrTime;
        private System.Windows.Forms.Label lblLoginErrorMsg;
        private System.Windows.Forms.Label lblScreenBtn1;
    }
}

