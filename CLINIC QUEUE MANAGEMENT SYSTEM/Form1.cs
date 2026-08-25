using System;
using System.Windows.Forms;

namespace CLINIC_QUEUE_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        // Shared, form-level counter — used by ALL patient types so the
        // queue stays one continuous sequence (Q001, Q002, Q003, ...).
        private int queueCounter = 0;

        public Form1()
        {
            InitializeComponent();
            cmbPatientType.SelectedIndex = 0; // default: Regular
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string reason = txtReason.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the patient's name.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            int age;
            if (!int.TryParse(ageText, out age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age (numeric, greater than 0).", "Invalid Age",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter the reason for visit.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReason.Focus();
                return;
            }

            if (cmbPatientType.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient type.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPatientType.Focus();
                return;
            }

            string patientType = cmbPatientType.SelectedItem.ToString() ?? "Regular";

            queueCounter++;
            string queueNumber = "Q" + queueCounter.ToString("000");

            string priority = GetPriority(patientType);

            txtQueueNumberResult.Text = queueNumber;
            txtPatientTypeResult.Text = patientType;
            txtPriorityResult.Text = priority;
        }

        private string GetPriority(string patientType)
        {
            switch (patientType)
            {
                case "Emergency": return "EMERGENCY";
                case "Senior": return "SENIOR PRIORITY";
                case "Pregnant": return "PRIORITY";
                case "Regular": return "REGULAR";
                default: return "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtReason.Clear();
            cmbPatientType.SelectedIndex = 0;

            txtQueueNumberResult.Text = "";
            txtPatientTypeResult.Text = "";
            txtPriorityResult.Text = "";

            txtName.Focus();
            
        }
    }
}
