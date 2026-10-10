namespace Lab2B
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
            this.hairDresserGroupBox = new System.Windows.Forms.GroupBox();
            this.radLau = new System.Windows.Forms.RadioButton();
            this.radSue = new System.Windows.Forms.RadioButton();
            this.radRon = new System.Windows.Forms.RadioButton();
            this.radPat = new System.Windows.Forms.RadioButton();
            this.radJane = new System.Windows.Forms.RadioButton();
            this.clientTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.checkExtensions = new System.Windows.Forms.CheckBox();
            this.checkHighlights = new System.Windows.Forms.CheckBox();
            this.checkColour = new System.Windows.Forms.CheckBox();
            this.checkCut = new System.Windows.Forms.CheckBox();
            this.clientVisitGroupBox = new System.Windows.Forms.GroupBox();
            this.visitTextBox = new System.Windows.Forms.TextBox();
            this.clientVisitLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalPriceTextLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.hairDresserGroupBox.SuspendLayout();
            this.clientTypeGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.clientVisitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairDresserGroupBox
            // 
            this.hairDresserGroupBox.Controls.Add(this.radLau);
            this.hairDresserGroupBox.Controls.Add(this.radSue);
            this.hairDresserGroupBox.Controls.Add(this.radRon);
            this.hairDresserGroupBox.Controls.Add(this.radPat);
            this.hairDresserGroupBox.Controls.Add(this.radJane);
            this.hairDresserGroupBox.Location = new System.Drawing.Point(12, 23);
            this.hairDresserGroupBox.Name = "hairDresserGroupBox";
            this.hairDresserGroupBox.Size = new System.Drawing.Size(258, 242);
            this.hairDresserGroupBox.TabIndex = 0;
            this.hairDresserGroupBox.TabStop = false;
            this.hairDresserGroupBox.Text = "Hairdresser";
            this.hairDresserGroupBox.Enter += new System.EventHandler(this.hairDresserGroupBox_Enter);
            // 
            // radLau
            // 
            this.radLau.AutoSize = true;
            this.radLau.Location = new System.Drawing.Point(6, 203);
            this.radLau.Name = "radLau";
            this.radLau.Size = new System.Drawing.Size(130, 24);
            this.radLau.TabIndex = 8;
            this.radLau.TabStop = true;
            this.radLau.Text = "Laura Renkins";
            this.radLau.UseVisualStyleBackColor = true;
            // 
            // radSue
            // 
            this.radSue.AutoSize = true;
            this.radSue.Location = new System.Drawing.Point(6, 164);
            this.radSue.Name = "radSue";
            this.radSue.Size = new System.Drawing.Size(103, 24);
            this.radSue.TabIndex = 8;
            this.radSue.TabStop = true;
            this.radSue.Text = "Sue Pallon";
            this.radSue.UseVisualStyleBackColor = true;
            // 
            // radRon
            // 
            this.radRon.AutoSize = true;
            this.radRon.Location = new System.Drawing.Point(6, 125);
            this.radRon.Name = "radRon";
            this.radRon.Size = new System.Drawing.Size(134, 24);
            this.radRon.TabIndex = 8;
            this.radRon.TabStop = true;
            this.radRon.Text = "Ron Chambers";
            this.radRon.UseVisualStyleBackColor = true;
            // 
            // radPat
            // 
            this.radPat.AutoSize = true;
            this.radPat.Location = new System.Drawing.Point(6, 86);
            this.radPat.Name = "radPat";
            this.radPat.Size = new System.Drawing.Size(116, 24);
            this.radPat.TabIndex = 8;
            this.radPat.TabStop = true;
            this.radPat.Text = "Pat Johnson";
            this.radPat.UseVisualStyleBackColor = true;
            // 
            // radJane
            // 
            this.radJane.AutoSize = true;
            this.radJane.Location = new System.Drawing.Point(6, 44);
            this.radJane.Name = "radJane";
            this.radJane.Size = new System.Drawing.Size(118, 24);
            this.radJane.TabIndex = 8;
            this.radJane.TabStop = true;
            this.radJane.Text = "Jane Samley";
            this.radJane.UseVisualStyleBackColor = true;
            // 
            // clientTypeGroupBox
            // 
            this.clientTypeGroupBox.Controls.Add(this.radSenior);
            this.clientTypeGroupBox.Controls.Add(this.radStudent);
            this.clientTypeGroupBox.Controls.Add(this.radChild);
            this.clientTypeGroupBox.Controls.Add(this.radStandard);
            this.clientTypeGroupBox.Location = new System.Drawing.Point(12, 299);
            this.clientTypeGroupBox.Name = "clientTypeGroupBox";
            this.clientTypeGroupBox.Size = new System.Drawing.Size(258, 208);
            this.clientTypeGroupBox.TabIndex = 1;
            this.clientTypeGroupBox.TabStop = false;
            this.clientTypeGroupBox.Text = "Client Type";
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(6, 151);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(139, 24);
            this.radSenior.TabIndex = 8;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior (over 65)";
            this.radSenior.UseVisualStyleBackColor = true;
            this.radSenior.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(6, 121);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(84, 24);
            this.radStudent.TabIndex = 8;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(6, 82);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(170, 24);
            this.radChild.TabIndex = 8;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child (12 and under)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(6, 42);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(134, 24);
            this.radStandard.TabIndex = 8;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard Adult";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.checkExtensions);
            this.servicesGroupBox.Controls.Add(this.checkHighlights);
            this.servicesGroupBox.Controls.Add(this.checkColour);
            this.servicesGroupBox.Controls.Add(this.checkCut);
            this.servicesGroupBox.Location = new System.Drawing.Point(364, 23);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(241, 242);
            this.servicesGroupBox.TabIndex = 2;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Services";
            // 
            // checkExtensions
            // 
            this.checkExtensions.AutoSize = true;
            this.checkExtensions.Location = new System.Drawing.Point(18, 165);
            this.checkExtensions.Name = "checkExtensions";
            this.checkExtensions.Size = new System.Drawing.Size(106, 24);
            this.checkExtensions.TabIndex = 3;
            this.checkExtensions.Text = "Extensions";
            this.checkExtensions.UseVisualStyleBackColor = true;
            // 
            // checkHighlights
            // 
            this.checkHighlights.AutoSize = true;
            this.checkHighlights.Location = new System.Drawing.Point(18, 125);
            this.checkHighlights.Name = "checkHighlights";
            this.checkHighlights.Size = new System.Drawing.Size(98, 24);
            this.checkHighlights.TabIndex = 2;
            this.checkHighlights.Text = "Highlights";
            this.checkHighlights.UseVisualStyleBackColor = true;
            // 
            // checkColour
            // 
            this.checkColour.AutoSize = true;
            this.checkColour.Location = new System.Drawing.Point(18, 86);
            this.checkColour.Name = "checkColour";
            this.checkColour.Size = new System.Drawing.Size(74, 24);
            this.checkColour.TabIndex = 1;
            this.checkColour.Text = "Colour";
            this.checkColour.UseVisualStyleBackColor = true;
            // 
            // checkCut
            // 
            this.checkCut.AutoSize = true;
            this.checkCut.Location = new System.Drawing.Point(18, 44);
            this.checkCut.Name = "checkCut";
            this.checkCut.Size = new System.Drawing.Size(53, 24);
            this.checkCut.TabIndex = 0;
            this.checkCut.Text = "Cut";
            this.checkCut.UseVisualStyleBackColor = true;
            // 
            // clientVisitGroupBox
            // 
            this.clientVisitGroupBox.Controls.Add(this.visitTextBox);
            this.clientVisitGroupBox.Controls.Add(this.clientVisitLabel);
            this.clientVisitGroupBox.Location = new System.Drawing.Point(370, 305);
            this.clientVisitGroupBox.Name = "clientVisitGroupBox";
            this.clientVisitGroupBox.Size = new System.Drawing.Size(235, 202);
            this.clientVisitGroupBox.TabIndex = 3;
            this.clientVisitGroupBox.TabStop = false;
            this.clientVisitGroupBox.Text = "Client Visits";
            // 
            // visitTextBox
            // 
            this.visitTextBox.Location = new System.Drawing.Point(12, 74);
            this.visitTextBox.Name = "visitTextBox";
            this.visitTextBox.Size = new System.Drawing.Size(202, 26);
            this.visitTextBox.TabIndex = 1;
            // 
            // clientVisitLabel
            // 
            this.clientVisitLabel.AutoSize = true;
            this.clientVisitLabel.Location = new System.Drawing.Point(8, 40);
            this.clientVisitLabel.Name = "clientVisitLabel";
            this.clientVisitLabel.Size = new System.Drawing.Size(173, 20);
            this.clientVisitLabel.TabIndex = 0;
            this.clientVisitLabel.Text = "Number of Client Visits:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(74, 602);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(114, 46);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(269, 602);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 46);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(486, 602);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 46);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalPriceTextLabel
            // 
            this.totalPriceTextLabel.AutoSize = true;
            this.totalPriceTextLabel.Location = new System.Drawing.Point(353, 559);
            this.totalPriceTextLabel.Name = "totalPriceTextLabel";
            this.totalPriceTextLabel.Size = new System.Drawing.Size(87, 20);
            this.totalPriceTextLabel.TabIndex = 7;
            this.totalPriceTextLabel.Text = "Total Price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(455, 559);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.totalPriceLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 686);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceTextLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clientVisitGroupBox);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.clientTypeGroupBox);
            this.Controls.Add(this.hairDresserGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hairDresserGroupBox.ResumeLayout(false);
            this.hairDresserGroupBox.PerformLayout();
            this.clientTypeGroupBox.ResumeLayout(false);
            this.clientTypeGroupBox.PerformLayout();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.clientVisitGroupBox.ResumeLayout(false);
            this.clientVisitGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hairDresserGroupBox;
        private System.Windows.Forms.GroupBox clientTypeGroupBox;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.GroupBox clientVisitGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton radJane;
        private System.Windows.Forms.Label totalPriceTextLabel;
        private System.Windows.Forms.RadioButton radLau;
        private System.Windows.Forms.RadioButton radSue;
        private System.Windows.Forms.RadioButton radRon;
        private System.Windows.Forms.RadioButton radPat;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.CheckBox checkExtensions;
        private System.Windows.Forms.CheckBox checkHighlights;
        private System.Windows.Forms.CheckBox checkColour;
        private System.Windows.Forms.CheckBox checkCut;
        private System.Windows.Forms.Label clientVisitLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox visitTextBox;
    }
}

