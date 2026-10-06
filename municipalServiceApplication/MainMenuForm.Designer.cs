namespace MunicipalServiceApplication
{
    partial class MainMenuForm
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
            lblTitle = new Label();
            lblInstruction = new Label();
            btnReportIssues = new Button();
            btnLocalEvents = new Button();
            btnServiceStatus = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(135, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Municipal Service Application";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruction.Location = new Point(212, 93);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(208, 21);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "How can we help you today?";
            lblInstruction.TextAlign = ContentAlignment.MiddleCenter;
            lblInstruction.Click += label2_Click;
            // 
            // btnReportIssues
            // 
            btnReportIssues.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportIssues.Location = new Point(176, 146);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(300, 60);
            btnReportIssues.TabIndex = 2;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = true;
            btnReportIssues.Click += button1_Click;
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalEvents.Location = new Point(176, 226);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(300, 60);
            btnLocalEvents.TabIndex = 3;
            btnLocalEvents.Text = "Local Events and Announcements";
            btnLocalEvents.UseVisualStyleBackColor = true;
            btnLocalEvents.Click += btnLocalEvents_Click;
            // 
            // btnServiceStatus
            // 
            btnServiceStatus.Enabled = false;
            btnServiceStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServiceStatus.Location = new Point(176, 303);
            btnServiceStatus.Name = "btnServiceStatus";
            btnServiceStatus.Size = new Size(300, 60);
            btnServiceStatus.TabIndex = 4;
            btnServiceStatus.Text = "Service Request Status";
            btnServiceStatus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(272, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 25);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 491);
            Controls.Add(btnExit);
            Controls.Add(btnServiceStatus);
            Controls.Add(btnLocalEvents);
            Controls.Add(btnReportIssues);
            Controls.Add(lblInstruction);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstruction;
        private Button btnReportIssues;
        private Button btnLocalEvents;
        private Button btnServiceStatus;
        private Button btnExit;
    }
}
