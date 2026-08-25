namespace CLINIC_QUEUE_MANAGEMENT_SYSTEM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();

            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();

            this.lblPatientType = new System.Windows.Forms.Label();
            this.cmbPatientType = new System.Windows.Forms.ComboBox();

            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lblQueueResultsHeading = new System.Windows.Forms.Label();

            this.lblQueueNumberCaption = new System.Windows.Forms.Label();
            this.txtQueueNumberResult = new System.Windows.Forms.TextBox();

            this.lblPatientTypeCaption = new System.Windows.Forms.Label();
            this.txtPatientTypeResult = new System.Windows.Forms.TextBox();

            this.lblPriorityCaption = new System.Windows.Forms.Label();
            this.txtPriorityResult = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.Text = "Clinic Queue Management System";

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 70);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Patient Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(160, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 23);

            // lblAge
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 105);
            this.lblAge.Name = "lblAge";
            this.lblAge.Text = "Age:";

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(160, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(80, 23);

            // lblReason
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(24, 140);
            this.lblReason.Name = "lblReason";
            this.lblReason.Text = "Reason for Visit:";

            // txtReason
            this.txtReason.Location = new System.Drawing.Point(160, 136);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(240, 23);

            // lblPatientType
            this.lblPatientType.AutoSize = true;
            this.lblPatientType.Location = new System.Drawing.Point(24, 175);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Text = "Patient Type:";

            // cmbPatientType
            this.cmbPatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientType.Location = new System.Drawing.Point(160, 171);
            this.cmbPatientType.Name = "cmbPatientType";
            this.cmbPatientType.Size = new System.Drawing.Size(160, 23);
            this.cmbPatientType.Items.AddRange(new object[] { "Regular", "Senior", "Pregnant", "Emergency" });

            // btnAddToQueue
            this.btnAddToQueue.Location = new System.Drawing.Point(160, 212);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(115, 32);
            this.btnAddToQueue.Text = "ADD TO QUEUE";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(285, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 32);
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblQueueResultsHeading
            this.lblQueueResultsHeading.AutoSize = true;
            this.lblQueueResultsHeading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.lblQueueResultsHeading.Location = new System.Drawing.Point(160, 260);
            this.lblQueueResultsHeading.Name = "lblQueueResultsHeading";
            this.lblQueueResultsHeading.Text = "QUEUE RESULTS";

            // lblQueueNumberCaption
            this.lblQueueNumberCaption.AutoSize = true;
            this.lblQueueNumberCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.lblQueueNumberCaption.Location = new System.Drawing.Point(24, 300);
            this.lblQueueNumberCaption.Name = "lblQueueNumberCaption";
            this.lblQueueNumberCaption.Text = "QUEUE NUMBER:";

            // txtQueueNumberResult
            this.txtQueueNumberResult.Location = new System.Drawing.Point(160, 297);
            this.txtQueueNumberResult.Name = "txtQueueNumberResult";
            this.txtQueueNumberResult.ReadOnly = true;
            this.txtQueueNumberResult.Size = new System.Drawing.Size(160, 23);

            // lblPatientTypeCaption
            this.lblPatientTypeCaption.AutoSize = true;
            this.lblPatientTypeCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.lblPatientTypeCaption.Location = new System.Drawing.Point(24, 335);
            this.lblPatientTypeCaption.Name = "lblPatientTypeCaption";
            this.lblPatientTypeCaption.Text = "PATIENT TYPE:";

            // txtPatientTypeResult
            this.txtPatientTypeResult.Location = new System.Drawing.Point(160, 332);
            this.txtPatientTypeResult.Name = "txtPatientTypeResult";
            this.txtPatientTypeResult.ReadOnly = true;
            this.txtPatientTypeResult.Size = new System.Drawing.Size(160, 23);

            // lblPriorityCaption
            this.lblPriorityCaption.AutoSize = true;
            this.lblPriorityCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.lblPriorityCaption.Location = new System.Drawing.Point(24, 370);
            this.lblPriorityCaption.Name = "lblPriorityCaption";
            this.lblPriorityCaption.Text = "PRIORITY:";

            // txtPriorityResult
            this.txtPriorityResult.Location = new System.Drawing.Point(160, 367);
            this.txtPriorityResult.Name = "txtPriorityResult";
            this.txtPriorityResult.ReadOnly = true;
            this.txtPriorityResult.Size = new System.Drawing.Size(160, 23);
            this.txtPriorityResult.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPriorityResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblPatientType);
            this.Controls.Add(this.cmbPatientType);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblQueueResultsHeading);
            this.Controls.Add(this.lblQueueNumberCaption);
            this.Controls.Add(this.txtQueueNumberResult);
            this.Controls.Add(this.lblPatientTypeCaption);
            this.Controls.Add(this.txtPatientTypeResult);
            this.Controls.Add(this.lblPriorityCaption);
            this.Controls.Add(this.txtPriorityResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clinic Queue Management System - Barangay Apokon";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblPatientType;
        private System.Windows.Forms.ComboBox cmbPatientType;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblQueueResultsHeading;
        private System.Windows.Forms.Label lblQueueNumberCaption;
        private System.Windows.Forms.TextBox txtQueueNumberResult;
        private System.Windows.Forms.Label lblPatientTypeCaption;
        private System.Windows.Forms.TextBox txtPatientTypeResult;
        private System.Windows.Forms.Label lblPriorityCaption;
        private System.Windows.Forms.TextBox txtPriorityResult;
    }
}
