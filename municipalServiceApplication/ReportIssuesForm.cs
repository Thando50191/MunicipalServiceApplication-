using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MunicipalServiceApplication
{
    public partial class ReportIssuesForm : Form
    {
        public List<Issue> issues = new List<Issue>();
        private string attachedFilePath = "";
        public ReportIssuesForm()
        {
            InitializeComponent();
        }
        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 25;

            if (cmbCategory.SelectedIndex != -1)
                progress += 25;

            if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                progress += 25;

            if (!string.IsNullOrWhiteSpace(attachedFilePath))
                progress += 25;

            progressBar.Value = progress;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IbILocation_Click(object sender, EventArgs e)
        {

        }

        private void IbIDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a file to attach";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFilePath = openFileDialog.FileName;

                    lblEngagementMessage.Text =
                        "File attached: " + Path.GetFileName(attachedFilePath);
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an issue category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please describe the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDescription.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(attachedFilePath))
            {
                MessageBox.Show("Please attach a file or image.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = txtDescription.Text.Trim(),
                AttachedFile = attachedFilePath
            };

            issues.Add(newIssue);

            progressBar.Value = 100;

            lblEngagementMessage.Text =
                "Thank you! Your issue has been successfully submitted.";

            MessageBox.Show(
                "Your issue has been submitted successfully.",
                "Submission Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();

            attachedFilePath = "";

            progressBar.Value = 0;
        }
    }
}
