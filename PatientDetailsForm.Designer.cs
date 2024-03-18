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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_birth_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_patient_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_patient_details
            // 
            this.pb_patient_details.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_patient_details.Location = new System.Drawing.Point(27, 420);
            this.pb_patient_details.Name = "pb_patient_details";
            this.pb_patient_details.Size = new System.Drawing.Size(892, 604);
            this.pb_patient_details.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_patient_details.TabIndex = 0;
            this.pb_patient_details.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 50);
            this.label2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_birth_date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_mail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_tel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_last_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_first_name);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 366);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persönliche Daten";
            // 
            // dtp_birth_date
            // 
            this.dtp_birth_date.Location = new System.Drawing.Point(162, 310);
            this.dtp_birth_date.Name = "dtp_birth_date";
            this.dtp_birth_date.Size = new System.Drawing.Size(714, 31);
            this.dtp_birth_date.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Geburtsdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-Mail";
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.Location = new System.Drawing.Point(162, 246);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(714, 35);
            this.tb_mail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // tb_tel
            // 
            this.tb_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tel.Location = new System.Drawing.Point(162, 181);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(714, 35);
            this.tb_tel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nachname";
            // 
            // tb_last_name
            // 
            this.tb_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_last_name.Location = new System.Drawing.Point(162, 118);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(714, 35);
            this.tb_last_name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vorname";
            // 
            // tb_first_name
            // 
            this.tb_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_first_name.Location = new System.Drawing.Point(162, 58);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(714, 35);
            this.tb_first_name.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Location = new System.Drawing.Point(0, 1057);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 100);
            this.panel1.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(454, 33);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(188, 43);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Patient löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(669, 33);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(250, 43);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Änderungen speichern";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // PatientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 1158);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_patient_details);
            this.Name = "PatientDetailsForm";
            this.Text = "PatientDetailsForm";
            this.Load += new System.EventHandler(this.PatientDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_patient_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_patient_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_birth_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}