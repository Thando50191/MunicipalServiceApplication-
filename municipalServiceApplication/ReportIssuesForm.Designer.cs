namespace MunicipalServiceApplication
{
    partial class ReportIssuesForm 
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
            lblTitle = new Label();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAttachFile = new Button();
            progressBar = new ProgressBar();
            lblEngagementMessage = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(347, 24);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "REPORT AN ISSUE";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(256, 66);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(80, 21);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location:";
            lblLocation.Click += IbILocation_Click;
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(340, 68);
            txtLocation.Margin = new Padding(2);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(393, 23);
            txtLocation.TabIndex = 2;
            txtLocation.Text = "Enter the Location of the issue";
            txtLocation.TextChanged += textBox1_TextChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(252, 109);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 21);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Water", "Electricty", "Roads", "Waste Collection", "Street Lights", "Sewage ", "Other" });
            cmbCategory.Location = new Point(347, 109);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 29);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(241, 155);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 21);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Decription:";
            lblDescription.Click += IbIDescription_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(241, 190);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(500, 100);
            txtDescription.TabIndex = 6;
            // 
            // btnAttachFile
            // 
            btnAttachFile.BackColor = Color.LightSkyBlue;
            btnAttachFile.ForeColor = Color.Black;
            btnAttachFile.Location = new Point(242, 314);
            btnAttachFile.Name = "btnAttachFile";
            btnAttachFile.Size = new Size(114, 30);
            btnAttachFile.TabIndex = 7;
            btnAttachFile.Text = "Attach File";
            btnAttachFile.UseVisualStyleBackColor = false;
            btnAttachFile.Click += btnAttachFile_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(241, 369);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(403, 23);
            progressBar.TabIndex = 8;
            // 
            // lblEngagementMessage
            // 
            lblEngagementMessage.AutoSize = true;
            lblEngagementMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEngagementMessage.ForeColor = Color.Black;
            lblEngagementMessage.Location = new Point(241, 409);
            lblEngagementMessage.Name = "lblEngagementMessage";
            lblEngagementMessage.Size = new Size(558, 21);
            lblEngagementMessage.TabIndex = 9;
            lblEngagementMessage.Text = "Please provide the details of the issue to help us improve your community.";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkSeaGreen;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(412, 467);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 28);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(620, 467);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(84, 28);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ReportIssuesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1065, 616);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblEngagementMessage);
            Controls.Add(progressBar);
            Controls.Add(btnAttachFile);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ReportIssuesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report an issue";
            Load += ReportIssuesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnAttachFile;
        private ProgressBar progressBar;
        private Label lblEngagementMessage;
        private Button btnSubmit;
        private Button btnBack;
    }
}