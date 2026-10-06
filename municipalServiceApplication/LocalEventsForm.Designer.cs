namespace MunicipalServiceApplication
{
    partial class LocalEventsForm : Form
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
            IbITitle = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            btnSearch = new Button();
            btnShowAll = new Button();
            lstEvents = new ListBox();
            lblRecommendations = new Label();
            btnBack = new Button();
            lstRecommendations = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // IbITitle
            // 
            IbITitle.AutoSize = true;
            IbITitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbITitle.Location = new Point(263, 50);
            IbITitle.Name = "IbITitle";
            IbITitle.Size = new Size(398, 32);
            IbITitle.TabIndex = 0;
            IbITitle.Text = "Local Events and Announcements";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(282, 118);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(343, 118);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(502, 118);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(551, 118);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(389, 171);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(551, 171);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(102, 23);
            btnShowAll.TabIndex = 6;
            btnShowAll.Text = "Show All Events";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.Location = new Point(282, 260);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(500, 109);
            lstEvents.TabIndex = 7;
            lstEvents.SelectedIndexChanged += lstEvents_SelectedIndexChanged;
            // 
            // lblRecommendations
            // 
            lblRecommendations.AutoSize = true;
            lblRecommendations.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecommendations.Location = new Point(420, 392);
            lblRecommendations.Name = "lblRecommendations";
            lblRecommendations.Size = new Size(167, 25);
            lblRecommendations.TabIndex = 8;
            lblRecommendations.Text = "Recommendations";
            lblRecommendations.Click += lblRecommendations_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(676, 567);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lstRecommendations
            // 
            lstRecommendations.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRecommendations.FormattingEnabled = true;
            lstRecommendations.Location = new Point(282, 438);
            lstRecommendations.Name = "lstRecommendations";
            lstRecommendations.Size = new Size(500, 94);
            lstRecommendations.TabIndex = 10;
            lstRecommendations.SelectedIndexChanged += lstRecommendations_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 217);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 11;
            label1.Text = "Upcoming Events";
            label1.UseMnemonic = false;
            // 
            // LocalEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(label1);
            Controls.Add(lstRecommendations);
            Controls.Add(btnBack);
            Controls.Add(lblRecommendations);
            Controls.Add(lstEvents);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(IbITitle);
            Name = "LocalEventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Events and Announcements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbITitle;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Button btnSearch;
        private Button btnShowAll;
        private ListBox lstEvents;
        private Label lblRecommendations;
        private Button btnBack;
        private ListBox lstRecommendations;
        private Label label1;
    }
}