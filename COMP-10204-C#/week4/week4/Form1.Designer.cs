namespace week4
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.accountTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.clearAccountButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.savingAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.chequingAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.accountInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.transactionListBox = new System.Windows.Forms.ListBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.depositRadioButton = new System.Windows.Forms.RadioButton();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.currentBalanceTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.accountTypeGroupBox.SuspendLayout();
            this.accountInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(33, 36);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // accountTypeGroupBox
            // 
            this.accountTypeGroupBox.Controls.Add(this.clearAccountButton);
            this.accountTypeGroupBox.Controls.Add(this.createAccountButton);
            this.accountTypeGroupBox.Controls.Add(this.savingAccountRadioButton);
            this.accountTypeGroupBox.Controls.Add(this.chequingAccountRadioButton);
            this.accountTypeGroupBox.Location = new System.Drawing.Point(12, 88);
            this.accountTypeGroupBox.Name = "accountTypeGroupBox";
            this.accountTypeGroupBox.Size = new System.Drawing.Size(303, 200);
            this.accountTypeGroupBox.TabIndex = 1;
            this.accountTypeGroupBox.TabStop = false;
            this.accountTypeGroupBox.Text = "Account Type";
            // 
            // clearAccountButton
            // 
            this.clearAccountButton.Location = new System.Drawing.Point(148, 131);
            this.clearAccountButton.Name = "clearAccountButton";
            this.clearAccountButton.Size = new System.Drawing.Size(75, 41);
            this.clearAccountButton.TabIndex = 4;
            this.clearAccountButton.Text = "Clear";
            this.clearAccountButton.UseVisualStyleBackColor = true;
            this.clearAccountButton.Click += new System.EventHandler(this.clearAccountButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(25, 131);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 41);
            this.createAccountButton.TabIndex = 3;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // savingAccountRadioButton
            // 
            this.savingAccountRadioButton.AutoSize = true;
            this.savingAccountRadioButton.Location = new System.Drawing.Point(25, 78);
            this.savingAccountRadioButton.Name = "savingAccountRadioButton";
            this.savingAccountRadioButton.Size = new System.Drawing.Size(146, 24);
            this.savingAccountRadioButton.TabIndex = 2;
            this.savingAccountRadioButton.TabStop = true;
            this.savingAccountRadioButton.Text = "Savings Account";
            this.savingAccountRadioButton.UseVisualStyleBackColor = true;
            // 
            // chequingAccountRadioButton
            // 
            this.chequingAccountRadioButton.AutoSize = true;
            this.chequingAccountRadioButton.Location = new System.Drawing.Point(25, 39);
            this.chequingAccountRadioButton.Name = "chequingAccountRadioButton";
            this.chequingAccountRadioButton.Size = new System.Drawing.Size(158, 24);
            this.chequingAccountRadioButton.TabIndex = 1;
            this.chequingAccountRadioButton.TabStop = true;
            this.chequingAccountRadioButton.Text = "Chequing Account";
            this.chequingAccountRadioButton.UseVisualStyleBackColor = true;
            // 
            // accountInformationGroupBox
            // 
            this.accountInformationGroupBox.Controls.Add(this.statusLabel);
            this.accountInformationGroupBox.Controls.Add(this.button3);
            this.accountInformationGroupBox.Controls.Add(this.transactionListBox);
            this.accountInformationGroupBox.Controls.Add(this.amountTextBox);
            this.accountInformationGroupBox.Controls.Add(this.depositRadioButton);
            this.accountInformationGroupBox.Controls.Add(this.withdrawRadioButton);
            this.accountInformationGroupBox.Controls.Add(this.amountLabel);
            this.accountInformationGroupBox.Controls.Add(this.label6);
            this.accountInformationGroupBox.Controls.Add(this.transactionLabel);
            this.accountInformationGroupBox.Controls.Add(this.currentBalanceTextBox);
            this.accountInformationGroupBox.Controls.Add(this.accountTextBox);
            this.accountInformationGroupBox.Controls.Add(this.currentBalanceLabel);
            this.accountInformationGroupBox.Controls.Add(this.accountLabel);
            this.accountInformationGroupBox.Location = new System.Drawing.Point(12, 355);
            this.accountInformationGroupBox.Name = "accountInformationGroupBox";
            this.accountInformationGroupBox.Size = new System.Drawing.Size(827, 392);
            this.accountInformationGroupBox.TabIndex = 2;
            this.accountInformationGroupBox.TabStop = false;
            this.accountInformationGroupBox.Text = "Account Information";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Add Transaction";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // transactionListBox
            // 
            this.transactionListBox.FormattingEnabled = true;
            this.transactionListBox.ItemHeight = 20;
            this.transactionListBox.Location = new System.Drawing.Point(25, 103);
            this.transactionListBox.Name = "transactionListBox";
            this.transactionListBox.Size = new System.Drawing.Size(198, 184);
            this.transactionListBox.TabIndex = 16;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(630, 224);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(177, 26);
            this.amountTextBox.TabIndex = 15;
            // 
            // depositRadioButton
            // 
            this.depositRadioButton.AutoSize = true;
            this.depositRadioButton.Location = new System.Drawing.Point(631, 158);
            this.depositRadioButton.Name = "depositRadioButton";
            this.depositRadioButton.Size = new System.Drawing.Size(90, 24);
            this.depositRadioButton.TabIndex = 14;
            this.depositRadioButton.TabStop = true;
            this.depositRadioButton.Text = "Desposit";
            this.depositRadioButton.UseVisualStyleBackColor = true;
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.AutoSize = true;
            this.withdrawRadioButton.Location = new System.Drawing.Point(630, 114);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(93, 24);
            this.withdrawRadioButton.TabIndex = 13;
            this.withdrawRadioButton.TabStop = true;
            this.withdrawRadioButton.Text = "Withdraw";
            this.withdrawRadioButton.UseVisualStyleBackColor = true;
            this.withdrawRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(627, 201);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 20);
            this.amountLabel.TabIndex = 12;
            this.amountLabel.Text = "Amount";
            this.amountLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add Transaction";
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(21, 80);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(100, 20);
            this.transactionLabel.TabIndex = 10;
            this.transactionLabel.Text = "Transactions";
            // 
            // currentBalanceTextBox
            // 
            this.currentBalanceTextBox.Location = new System.Drawing.Point(631, 37);
            this.currentBalanceTextBox.Name = "currentBalanceTextBox";
            this.currentBalanceTextBox.Size = new System.Drawing.Size(176, 26);
            this.currentBalanceTextBox.TabIndex = 9;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(113, 34);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(158, 26);
            this.accountTextBox.TabIndex = 8;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(501, 40);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(124, 20);
            this.currentBalanceLabel.TabIndex = 7;
            this.currentBalanceLabel.Text = "Current Balance";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(21, 37);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(81, 20);
            this.accountLabel.TabIndex = 6;
            this.accountLabel.Text = "Account #";
            this.accountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(513, 36);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(125, 33);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(180, 26);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(605, 36);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 26);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(21, 329);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 20);
            this.statusLabel.TabIndex = 18;
            this.statusLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 828);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.accountInformationGroupBox);
            this.Controls.Add(this.accountTypeGroupBox);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.accountTypeGroupBox.ResumeLayout(false);
            this.accountTypeGroupBox.PerformLayout();
            this.accountInformationGroupBox.ResumeLayout(false);
            this.accountInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox accountTypeGroupBox;
        private System.Windows.Forms.Button clearAccountButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.RadioButton savingAccountRadioButton;
        private System.Windows.Forms.RadioButton chequingAccountRadioButton;
        private System.Windows.Forms.GroupBox accountInformationGroupBox;
        private System.Windows.Forms.RadioButton withdrawRadioButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.TextBox currentBalanceTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox transactionListBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.RadioButton depositRadioButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

