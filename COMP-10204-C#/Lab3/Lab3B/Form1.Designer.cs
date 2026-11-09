namespace Lab3B
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
            this.hairdresser = new System.Windows.Forms.ComboBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.hairdresserGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.totalPriceButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.chargedListBox = new System.Windows.Forms.ListBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.hairdresserGroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairdresser
            // 
            this.hairdresser.FormattingEnabled = true;
            this.hairdresser.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.hairdresser.Location = new System.Drawing.Point(6, 34);
            this.hairdresser.Name = "hairdresser";
            this.hairdresser.Size = new System.Drawing.Size(233, 28);
            this.hairdresser.TabIndex = 0;
            this.hairdresser.Text = "Jane Samley";
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 20;
            this.serviceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.serviceListBox.Location = new System.Drawing.Point(15, 34);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(218, 164);
            this.serviceListBox.TabIndex = 3;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // hairdresserGroupBox
            // 
            this.hairdresserGroupBox.Controls.Add(this.hairdresser);
            this.hairdresserGroupBox.Location = new System.Drawing.Point(12, 24);
            this.hairdresserGroupBox.Name = "hairdresserGroupBox";
            this.hairdresserGroupBox.Size = new System.Drawing.Size(245, 203);
            this.hairdresserGroupBox.TabIndex = 4;
            this.hairdresserGroupBox.TabStop = false;
            this.hairdresserGroupBox.Text = "Select a Hairdresser:";
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.serviceListBox);
            this.serviceGroupBox.Location = new System.Drawing.Point(300, 24);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(239, 203);
            this.serviceGroupBox.TabIndex = 5;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select a Service:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chargedListBox);
            this.groupBox1.Location = new System.Drawing.Point(545, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 203);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Location = new System.Drawing.Point(808, 24);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(229, 203);
            this.priceGroupBox.TabIndex = 7;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(897, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(837, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 32);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(612, 325);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(200, 32);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // totalPriceButton
            // 
            this.totalPriceButton.Location = new System.Drawing.Point(377, 325);
            this.totalPriceButton.Name = "totalPriceButton";
            this.totalPriceButton.Size = new System.Drawing.Size(200, 32);
            this.totalPriceButton.TabIndex = 12;
            this.totalPriceButton.Text = "Calculate Total Price";
            this.totalPriceButton.UseVisualStyleBackColor = true;
            this.totalPriceButton.Click += new System.EventHandler(this.totalPriceButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(153, 325);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(200, 32);
            this.addServiceButton.TabIndex = 13;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // chargedListBox
            // 
            this.chargedListBox.FormattingEnabled = true;
            this.chargedListBox.ItemHeight = 20;
            this.chargedListBox.Location = new System.Drawing.Point(6, 25);
            this.chargedListBox.Name = "chargedListBox";
            this.chargedListBox.Size = new System.Drawing.Size(231, 164);
            this.chargedListBox.TabIndex = 0;
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 20;
            this.priceListBox.Location = new System.Drawing.Point(6, 25);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(218, 164);
            this.priceListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 382);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.totalPriceButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serviceGroupBox);
            this.Controls.Add(this.hairdresserGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.hairdresserGroupBox.ResumeLayout(false);
            this.serviceGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hairdresser;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.GroupBox hairdresserGroupBox;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button totalPriceButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.ListBox chargedListBox;
        private System.Windows.Forms.ListBox priceListBox;
    }
}

