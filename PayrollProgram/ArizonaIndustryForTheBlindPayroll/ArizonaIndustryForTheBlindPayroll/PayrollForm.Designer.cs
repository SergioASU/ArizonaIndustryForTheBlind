namespace ArizonaIndustryForTheBlindPayroll
{
    partial class PayrollForm
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
            this.lblPayPeriod = new System.Windows.Forms.Label();
            this.payPeriodTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.namePanel = new System.Windows.Forms.Panel();
            this.hoursWorkedPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.backButtonHoursWorked = new System.Windows.Forms.Button();
            this.backWorkButton = new System.Windows.Forms.Button();
            this.nextWorkButton = new System.Windows.Forms.Button();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.lblTypeOfWork = new System.Windows.Forms.Label();
            this.nextButtonNamePanel = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.backButtonNamePanel = new System.Windows.Forms.Button();
            this.namePanel.SuspendLayout();
            this.hoursWorkedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayPeriod
            // 
            this.lblPayPeriod.AutoSize = true;
            this.lblPayPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPeriod.Location = new System.Drawing.Point(12, 81);
            this.lblPayPeriod.Name = "lblPayPeriod";
            this.lblPayPeriod.Size = new System.Drawing.Size(173, 32);
            this.lblPayPeriod.TabIndex = 0;
            this.lblPayPeriod.Text = "Pay Period:";
            // 
            // payPeriodTextBox
            // 
            this.payPeriodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payPeriodTextBox.Location = new System.Drawing.Point(247, 78);
            this.payPeriodTextBox.Name = "payPeriodTextBox";
            this.payPeriodTextBox.Size = new System.Drawing.Size(54, 38);
            this.payPeriodTextBox.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(114, 144);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(122, 48);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.hoursWorkedPanel);
            this.namePanel.Controls.Add(this.nextButtonNamePanel);
            this.namePanel.Controls.Add(this.namesListBox);
            this.namePanel.Controls.Add(this.backButtonNamePanel);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(363, 204);
            this.namePanel.TabIndex = 3;
            this.namePanel.Visible = false;
            // 
            // hoursWorkedPanel
            // 
            this.hoursWorkedPanel.Controls.Add(this.okButton);
            this.hoursWorkedPanel.Controls.Add(this.backButtonHoursWorked);
            this.hoursWorkedPanel.Controls.Add(this.backWorkButton);
            this.hoursWorkedPanel.Controls.Add(this.nextWorkButton);
            this.hoursWorkedPanel.Controls.Add(this.hoursTextBox);
            this.hoursWorkedPanel.Controls.Add(this.lblTypeOfWork);
            this.hoursWorkedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursWorkedPanel.Location = new System.Drawing.Point(0, 0);
            this.hoursWorkedPanel.Name = "hoursWorkedPanel";
            this.hoursWorkedPanel.Size = new System.Drawing.Size(363, 204);
            this.hoursWorkedPanel.TabIndex = 6;
            this.hoursWorkedPanel.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(260, 147);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 45);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // backButtonHoursWorked
            // 
            this.backButtonHoursWorked.Location = new System.Drawing.Point(12, 147);
            this.backButtonHoursWorked.Name = "backButtonHoursWorked";
            this.backButtonHoursWorked.Size = new System.Drawing.Size(91, 45);
            this.backButtonHoursWorked.TabIndex = 10;
            this.backButtonHoursWorked.Text = "Back";
            this.backButtonHoursWorked.UseVisualStyleBackColor = true;
            this.backButtonHoursWorked.Click += new System.EventHandler(this.backButtonHoursWorked_Click);
            // 
            // backWorkButton
            // 
            this.backWorkButton.Location = new System.Drawing.Point(46, 88);
            this.backWorkButton.Name = "backWorkButton";
            this.backWorkButton.Size = new System.Drawing.Size(75, 23);
            this.backWorkButton.TabIndex = 9;
            this.backWorkButton.Text = "<<";
            this.backWorkButton.UseVisualStyleBackColor = true;
            // 
            // nextWorkButton
            // 
            this.nextWorkButton.Location = new System.Drawing.Point(233, 88);
            this.nextWorkButton.Name = "nextWorkButton";
            this.nextWorkButton.Size = new System.Drawing.Size(75, 23);
            this.nextWorkButton.TabIndex = 8;
            this.nextWorkButton.Text = ">>";
            this.nextWorkButton.UseVisualStyleBackColor = true;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(127, 75);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 38);
            this.hoursTextBox.TabIndex = 7;
            // 
            // lblTypeOfWork
            // 
            this.lblTypeOfWork.AutoSize = true;
            this.lblTypeOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfWork.Location = new System.Drawing.Point(65, 12);
            this.lblTypeOfWork.Name = "lblTypeOfWork";
            this.lblTypeOfWork.Size = new System.Drawing.Size(227, 25);
            this.lblTypeOfWork.TabIndex = 6;
            this.lblTypeOfWork.Text = "Indirect Hours Worked";
            // 
            // nextButtonNamePanel
            // 
            this.nextButtonNamePanel.Location = new System.Drawing.Point(276, 158);
            this.nextButtonNamePanel.Name = "nextButtonNamePanel";
            this.nextButtonNamePanel.Size = new System.Drawing.Size(75, 34);
            this.nextButtonNamePanel.TabIndex = 5;
            this.nextButtonNamePanel.Text = "Next";
            this.nextButtonNamePanel.UseVisualStyleBackColor = true;
            this.nextButtonNamePanel.Click += new System.EventHandler(this.nextButtonNamePanel_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.ItemHeight = 25;
            this.namesListBox.Items.AddRange(new object[] {
            "Name1",
            "Name2",
            "Name3",
            "Name4",
            "Name5"});
            this.namesListBox.Location = new System.Drawing.Point(12, 12);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(339, 129);
            this.namesListBox.TabIndex = 1;
            // 
            // backButtonNamePanel
            // 
            this.backButtonNamePanel.Location = new System.Drawing.Point(12, 158);
            this.backButtonNamePanel.Name = "backButtonNamePanel";
            this.backButtonNamePanel.Size = new System.Drawing.Size(75, 34);
            this.backButtonNamePanel.TabIndex = 4;
            this.backButtonNamePanel.Text = "Back";
            this.backButtonNamePanel.UseVisualStyleBackColor = true;
            this.backButtonNamePanel.Click += new System.EventHandler(this.backButtonNamePanel_Click);
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 204);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.payPeriodTextBox);
            this.Controls.Add(this.lblPayPeriod);
            this.Location = new System.Drawing.Point(240, 120);
            this.Name = "PayrollForm";
            this.Text = "Arizona Industry For The Blind";
            this.Load += new System.EventHandler(this.PayPeriodForm_Load);
            this.namePanel.ResumeLayout(false);
            this.hoursWorkedPanel.ResumeLayout(false);
            this.hoursWorkedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayPeriod;
        private System.Windows.Forms.TextBox payPeriodTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Button nextButtonNamePanel;
        private System.Windows.Forms.Button backButtonNamePanel;
        private System.Windows.Forms.Panel hoursWorkedPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button backButtonHoursWorked;
        private System.Windows.Forms.Button backWorkButton;
        private System.Windows.Forms.Button nextWorkButton;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label lblTypeOfWork;
    }
}

