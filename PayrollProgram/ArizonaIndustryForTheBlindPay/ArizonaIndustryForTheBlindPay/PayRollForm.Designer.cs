namespace ArizonaIndustryForTheBlindPay
{
    partial class PayRollForm
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
            this.payPeriodNextButton = new System.Windows.Forms.Button();
            this.namePanel = new System.Windows.Forms.Panel();
            this.hoursWorkedPanel = new System.Windows.Forms.Panel();
            this.dayButtonNext = new System.Windows.Forms.Button();
            this.dayButtonBack = new System.Windows.Forms.Button();
            this.lblPeriodDay = new System.Windows.Forms.Label();
            this.lblTotalHoursChange = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.hoursWorkedOkButton = new System.Windows.Forms.Button();
            this.hoursWorkedBackButton = new System.Windows.Forms.Button();
            this.typeOfWorkBackButton = new System.Windows.Forms.Button();
            this.typeOfWorkNextButton = new System.Windows.Forms.Button();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.lblTypeOfWork = new System.Windows.Forms.Label();
            this.namePanelNextButton = new System.Windows.Forms.Button();
            this.namePanelBackButton = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.chooseExcelButton = new System.Windows.Forms.Button();
            this.namePanel.SuspendLayout();
            this.hoursWorkedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayPeriod
            // 
            this.lblPayPeriod.AutoSize = true;
            this.lblPayPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPeriod.Location = new System.Drawing.Point(12, 103);
            this.lblPayPeriod.Name = "lblPayPeriod";
            this.lblPayPeriod.Size = new System.Drawing.Size(164, 32);
            this.lblPayPeriod.TabIndex = 0;
            this.lblPayPeriod.Text = "Pay Period";
            // 
            // payPeriodTextBox
            // 
            this.payPeriodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payPeriodTextBox.Location = new System.Drawing.Point(226, 100);
            this.payPeriodTextBox.Name = "payPeriodTextBox";
            this.payPeriodTextBox.Size = new System.Drawing.Size(100, 38);
            this.payPeriodTextBox.TabIndex = 1;
            // 
            // payPeriodNextButton
            // 
            this.payPeriodNextButton.Location = new System.Drawing.Point(278, 180);
            this.payPeriodNextButton.Name = "payPeriodNextButton";
            this.payPeriodNextButton.Size = new System.Drawing.Size(92, 41);
            this.payPeriodNextButton.TabIndex = 2;
            this.payPeriodNextButton.Text = "Next";
            this.payPeriodNextButton.UseVisualStyleBackColor = true;
            this.payPeriodNextButton.Click += new System.EventHandler(this.payPeriodNextButton_Click);
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.hoursWorkedPanel);
            this.namePanel.Controls.Add(this.namePanelNextButton);
            this.namePanel.Controls.Add(this.namePanelBackButton);
            this.namePanel.Controls.Add(this.namesListBox);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(382, 233);
            this.namePanel.TabIndex = 3;
            this.namePanel.Visible = false;
            // 
            // hoursWorkedPanel
            // 
            this.hoursWorkedPanel.Controls.Add(this.dayButtonNext);
            this.hoursWorkedPanel.Controls.Add(this.dayButtonBack);
            this.hoursWorkedPanel.Controls.Add(this.lblPeriodDay);
            this.hoursWorkedPanel.Controls.Add(this.lblTotalHoursChange);
            this.hoursWorkedPanel.Controls.Add(this.lblTotalHours);
            this.hoursWorkedPanel.Controls.Add(this.hoursWorkedOkButton);
            this.hoursWorkedPanel.Controls.Add(this.hoursWorkedBackButton);
            this.hoursWorkedPanel.Controls.Add(this.typeOfWorkBackButton);
            this.hoursWorkedPanel.Controls.Add(this.typeOfWorkNextButton);
            this.hoursWorkedPanel.Controls.Add(this.hoursWorkedTextBox);
            this.hoursWorkedPanel.Controls.Add(this.lblTypeOfWork);
            this.hoursWorkedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursWorkedPanel.Location = new System.Drawing.Point(0, 0);
            this.hoursWorkedPanel.Name = "hoursWorkedPanel";
            this.hoursWorkedPanel.Size = new System.Drawing.Size(382, 233);
            this.hoursWorkedPanel.TabIndex = 3;
            this.hoursWorkedPanel.Visible = false;
            // 
            // dayButtonNext
            // 
            this.dayButtonNext.Location = new System.Drawing.Point(307, 32);
            this.dayButtonNext.Name = "dayButtonNext";
            this.dayButtonNext.Size = new System.Drawing.Size(75, 23);
            this.dayButtonNext.TabIndex = 10;
            this.dayButtonNext.Text = ">>";
            this.dayButtonNext.UseVisualStyleBackColor = true;
            this.dayButtonNext.Click += new System.EventHandler(this.dayButtonNext_Click);
            // 
            // dayButtonBack
            // 
            this.dayButtonBack.Location = new System.Drawing.Point(226, 32);
            this.dayButtonBack.Name = "dayButtonBack";
            this.dayButtonBack.Size = new System.Drawing.Size(75, 23);
            this.dayButtonBack.TabIndex = 9;
            this.dayButtonBack.Text = "<<";
            this.dayButtonBack.UseVisualStyleBackColor = true;
            this.dayButtonBack.Click += new System.EventHandler(this.dayButtonBack_Click);
            // 
            // lblPeriodDay
            // 
            this.lblPeriodDay.AutoSize = true;
            this.lblPeriodDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodDay.Location = new System.Drawing.Point(274, 9);
            this.lblPeriodDay.Name = "lblPeriodDay";
            this.lblPeriodDay.Size = new System.Drawing.Size(58, 20);
            this.lblPeriodDay.TabIndex = 8;
            this.lblPeriodDay.Text = "Day 1";
            // 
            // lblTotalHoursChange
            // 
            this.lblTotalHoursChange.AutoSize = true;
            this.lblTotalHoursChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoursChange.Location = new System.Drawing.Point(237, 144);
            this.lblTotalHoursChange.Name = "lblTotalHoursChange";
            this.lblTotalHoursChange.Size = new System.Drawing.Size(24, 25);
            this.lblTotalHoursChange.TabIndex = 7;
            this.lblTotalHoursChange.Text = "0";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(100, 144);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(131, 25);
            this.lblTotalHours.TabIndex = 6;
            this.lblTotalHours.Text = "Total Hours:";
            // 
            // hoursWorkedOkButton
            // 
            this.hoursWorkedOkButton.Location = new System.Drawing.Point(276, 180);
            this.hoursWorkedOkButton.Name = "hoursWorkedOkButton";
            this.hoursWorkedOkButton.Size = new System.Drawing.Size(94, 41);
            this.hoursWorkedOkButton.TabIndex = 5;
            this.hoursWorkedOkButton.Text = "OK";
            this.hoursWorkedOkButton.UseVisualStyleBackColor = true;
            this.hoursWorkedOkButton.Click += new System.EventHandler(this.hoursWorkedOkButton_Click);
            // 
            // hoursWorkedBackButton
            // 
            this.hoursWorkedBackButton.Location = new System.Drawing.Point(12, 180);
            this.hoursWorkedBackButton.Name = "hoursWorkedBackButton";
            this.hoursWorkedBackButton.Size = new System.Drawing.Size(94, 41);
            this.hoursWorkedBackButton.TabIndex = 4;
            this.hoursWorkedBackButton.Text = "Back";
            this.hoursWorkedBackButton.UseVisualStyleBackColor = true;
            this.hoursWorkedBackButton.Click += new System.EventHandler(this.hoursWorkedBackButton_Click);
            // 
            // typeOfWorkBackButton
            // 
            this.typeOfWorkBackButton.Location = new System.Drawing.Point(12, 32);
            this.typeOfWorkBackButton.Name = "typeOfWorkBackButton";
            this.typeOfWorkBackButton.Size = new System.Drawing.Size(70, 23);
            this.typeOfWorkBackButton.TabIndex = 3;
            this.typeOfWorkBackButton.Text = "<<";
            this.typeOfWorkBackButton.UseVisualStyleBackColor = true;
            this.typeOfWorkBackButton.Click += new System.EventHandler(this.typeOfWorkBackButton_Click);
            // 
            // typeOfWorkNextButton
            // 
            this.typeOfWorkNextButton.Location = new System.Drawing.Point(88, 34);
            this.typeOfWorkNextButton.Name = "typeOfWorkNextButton";
            this.typeOfWorkNextButton.Size = new System.Drawing.Size(71, 21);
            this.typeOfWorkNextButton.TabIndex = 2;
            this.typeOfWorkNextButton.Text = ">>";
            this.typeOfWorkNextButton.UseVisualStyleBackColor = true;
            this.typeOfWorkNextButton.Click += new System.EventHandler(this.typeOfWorkNextButton_Click);
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(143, 79);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(100, 38);
            this.hoursWorkedTextBox.TabIndex = 1;
            // 
            // lblTypeOfWork
            // 
            this.lblTypeOfWork.AutoSize = true;
            this.lblTypeOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfWork.Location = new System.Drawing.Point(14, 9);
            this.lblTypeOfWork.Name = "lblTypeOfWork";
            this.lblTypeOfWork.Size = new System.Drawing.Size(129, 20);
            this.lblTypeOfWork.TabIndex = 0;
            this.lblTypeOfWork.Text = "Indirect Hours";
            // 
            // namePanelNextButton
            // 
            this.namePanelNextButton.Location = new System.Drawing.Point(271, 180);
            this.namePanelNextButton.Name = "namePanelNextButton";
            this.namePanelNextButton.Size = new System.Drawing.Size(99, 41);
            this.namePanelNextButton.TabIndex = 2;
            this.namePanelNextButton.Text = "Next";
            this.namePanelNextButton.UseVisualStyleBackColor = true;
            this.namePanelNextButton.Click += new System.EventHandler(this.namePanelNextButton_Click);
            // 
            // namePanelBackButton
            // 
            this.namePanelBackButton.Location = new System.Drawing.Point(12, 180);
            this.namePanelBackButton.Name = "namePanelBackButton";
            this.namePanelBackButton.Size = new System.Drawing.Size(99, 41);
            this.namePanelBackButton.TabIndex = 1;
            this.namePanelBackButton.Text = "Back";
            this.namePanelBackButton.UseVisualStyleBackColor = true;
            this.namePanelBackButton.Click += new System.EventHandler(this.namePanelBackButton_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.ItemHeight = 25;
            this.namesListBox.Items.AddRange(new object[] {
            "name1",
            "name2",
            "name3",
            "name4",
            "name5"});
            this.namesListBox.Location = new System.Drawing.Point(12, 12);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(358, 129);
            this.namesListBox.TabIndex = 0;
            // 
            // chooseExcelButton
            // 
            this.chooseExcelButton.Location = new System.Drawing.Point(12, 180);
            this.chooseExcelButton.Name = "chooseExcelButton";
            this.chooseExcelButton.Size = new System.Drawing.Size(108, 41);
            this.chooseExcelButton.TabIndex = 5;
            this.chooseExcelButton.Text = "Choose Excel";
            this.chooseExcelButton.UseVisualStyleBackColor = true;
            this.chooseExcelButton.Click += new System.EventHandler(this.chooseExcelButton_Click_1);
            // 
            // PayRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 233);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.payPeriodNextButton);
            this.Controls.Add(this.payPeriodTextBox);
            this.Controls.Add(this.lblPayPeriod);
            this.Controls.Add(this.chooseExcelButton);
            this.Name = "PayRollForm";
            this.Text = "Arizona Industry For The Blind";
            this.namePanel.ResumeLayout(false);
            this.hoursWorkedPanel.ResumeLayout(false);
            this.hoursWorkedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayPeriod;
        private System.Windows.Forms.TextBox payPeriodTextBox;
        private System.Windows.Forms.Button payPeriodNextButton;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Button namePanelNextButton;
        private System.Windows.Forms.Button namePanelBackButton;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Panel hoursWorkedPanel;
        private System.Windows.Forms.Label lblTypeOfWork;
        private System.Windows.Forms.Button hoursWorkedOkButton;
        private System.Windows.Forms.Button hoursWorkedBackButton;
        private System.Windows.Forms.Button typeOfWorkBackButton;
        private System.Windows.Forms.Button typeOfWorkNextButton;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label lblTotalHoursChange;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Button dayButtonNext;
        private System.Windows.Forms.Button dayButtonBack;
        private System.Windows.Forms.Label lblPeriodDay;
        private System.Windows.Forms.Button chooseExcelButton;
    }
}

