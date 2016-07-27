namespace ATM_simulation
{
    partial class centralServ
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
            this.components = new System.ComponentModel.Container();
            this.btnNewTerminal = new System.Windows.Forms.Button();
            this.btnCloseTerminals = new System.Windows.Forms.Button();
            this.rbDataRace = new System.Windows.Forms.RadioButton();
            this.rbLock = new System.Windows.Forms.RadioButton();
            this.rbSemaphore = new System.Windows.Forms.RadioButton();
            this.lblCurrActTerm = new System.Windows.Forms.Label();
            this.lblCurrTime = new System.Windows.Forms.Label();
            this.accountDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewTerminal
            // 
            this.btnNewTerminal.Location = new System.Drawing.Point(13, 177);
            this.btnNewTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewTerminal.Name = "btnNewTerminal";
            this.btnNewTerminal.Size = new System.Drawing.Size(143, 39);
            this.btnNewTerminal.TabIndex = 0;
            this.btnNewTerminal.Text = "New ATM Terminal";
            this.btnNewTerminal.UseVisualStyleBackColor = true;
            this.btnNewTerminal.Click += new System.EventHandler(this.btnNewTerminal_Click);
            // 
            // btnCloseTerminals
            // 
            this.btnCloseTerminals.Location = new System.Drawing.Point(325, 177);
            this.btnCloseTerminals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseTerminals.Name = "btnCloseTerminals";
            this.btnCloseTerminals.Size = new System.Drawing.Size(143, 39);
            this.btnCloseTerminals.TabIndex = 2;
            this.btnCloseTerminals.Text = "Close All";
            this.btnCloseTerminals.UseVisualStyleBackColor = true;
            this.btnCloseTerminals.Click += new System.EventHandler(this.btnCloseTerminals_Click);
            // 
            // rbDataRace
            // 
            this.rbDataRace.AutoSize = true;
            this.rbDataRace.Checked = true;
            this.rbDataRace.Location = new System.Drawing.Point(181, 236);
            this.rbDataRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDataRace.Name = "rbDataRace";
            this.rbDataRace.Size = new System.Drawing.Size(96, 21);
            this.rbDataRace.TabIndex = 3;
            this.rbDataRace.TabStop = true;
            this.rbDataRace.Text = "Data Race";
            this.rbDataRace.UseVisualStyleBackColor = true;
            this.rbDataRace.CheckedChanged += new System.EventHandler(this.rbDataRace_CheckedChanged);
            // 
            // rbLock
            // 
            this.rbLock.AutoSize = true;
            this.rbLock.Location = new System.Drawing.Point(181, 263);
            this.rbLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLock.Name = "rbLock";
            this.rbLock.Size = new System.Drawing.Size(126, 21);
            this.rbLock.TabIndex = 4;
            this.rbLock.Text = "Race Fix - Lock";
            this.rbLock.UseVisualStyleBackColor = true;
            this.rbLock.CheckedChanged += new System.EventHandler(this.rbLock_CheckedChanged);
            // 
            // rbSemaphore
            // 
            this.rbSemaphore.AutoSize = true;
            this.rbSemaphore.Location = new System.Drawing.Point(181, 290);
            this.rbSemaphore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSemaphore.Name = "rbSemaphore";
            this.rbSemaphore.Size = new System.Drawing.Size(169, 21);
            this.rbSemaphore.TabIndex = 5;
            this.rbSemaphore.Text = "Race Fix - Semaphore";
            this.rbSemaphore.UseVisualStyleBackColor = true;
            this.rbSemaphore.CheckedChanged += new System.EventHandler(this.rbSemaphore_CheckedChanged);
            // 
            // lblCurrActTerm
            // 
            this.lblCurrActTerm.AutoSize = true;
            this.lblCurrActTerm.Location = new System.Drawing.Point(12, 334);
            this.lblCurrActTerm.Name = "lblCurrActTerm";
            this.lblCurrActTerm.Size = new System.Drawing.Size(179, 17);
            this.lblCurrActTerm.TabIndex = 6;
            this.lblCurrActTerm.Text = "Current Active Terminals: 0";
            // 
            // lblCurrTime
            // 
            this.lblCurrTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCurrTime.Location = new System.Drawing.Point(371, 25);
            this.lblCurrTime.Name = "lblCurrTime";
            this.lblCurrTime.Size = new System.Drawing.Size(109, 23);
            this.lblCurrTime.TabIndex = 96;
            this.lblCurrTime.Text = "timer";
            this.lblCurrTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountDataBindingSource
            // 
            this.accountDataBindingSource.DataSource = typeof(ATM_simulation.AccountData);
            // 
            // centralServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(492, 454);
            this.Controls.Add(this.lblCurrTime);
            this.Controls.Add(this.lblCurrActTerm);
            this.Controls.Add(this.rbSemaphore);
            this.Controls.Add(this.rbLock);
            this.Controls.Add(this.rbDataRace);
            this.Controls.Add(this.btnCloseTerminals);
            this.Controls.Add(this.btnNewTerminal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "centralServ";
            this.Text = "Team15 Banking - Central Server";
            this.Load += new System.EventHandler(this.centralServ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTerminal;
        private System.Windows.Forms.BindingSource accountDataBindingSource;
        private System.Windows.Forms.Button btnCloseTerminals;
        private System.Windows.Forms.RadioButton rbDataRace;
        private System.Windows.Forms.RadioButton rbLock;
        private System.Windows.Forms.RadioButton rbSemaphore;
        private System.Windows.Forms.Label lblCurrActTerm;
        private System.Windows.Forms.Label lblCurrTime;
    }
}