namespace therapy_management_gui
{
    partial class PatientDetailsForm
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
            this.pb_patient_details = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_patient_details)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_patient_details
            // 
            this.pb_patient_details.Location = new System.Drawing.Point(27, 145);
            this.pb_patient_details.Name = "pb_patient_details";
            this.pb_patient_details.Size = new System.Drawing.Size(763, 604);
            this.pb_patient_details.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_patient_details.TabIndex = 0;
            this.pb_patient_details.TabStop = false;
            // 
            // PatientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 775);
            this.Controls.Add(this.pb_patient_details);
            this.Name = "PatientDetailsForm";
            this.Text = "PatientDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_patient_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_patient_details;
    }
}