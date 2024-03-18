namespace therapy_management_gui
{
    partial class NewCaseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_patient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.nud_sessions = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sessions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_sessions);
            this.groupBox1.Controls.Add(this.cbx_patient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 366);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daten";
            // 
            // cbx_patient
            // 
            this.cbx_patient.FormattingEnabled = true;
            this.cbx_patient.Location = new System.Drawing.Point(190, 64);
            this.cbx_patient.Name = "cbx_patient";
            this.cbx_patient.Size = new System.Drawing.Size(587, 33);
            this.cbx_patient.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anzahl Einheiten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Beschreibung";
            // 
            // tb_description
            // 
            this.tb_description.AllowDrop = true;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(190, 181);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(587, 111);
            this.tb_description.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titel";
            // 
            // tb_title
            // 
            this.tb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.Location = new System.Drawing.Point(190, 118);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(587, 35);
            this.tb_title.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Neuen Krankheitsfall hinzufügen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 100);
            this.panel1.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(585, 32);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 43);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(729, 32);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(111, 43);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // nud_sessions
            // 
            this.nud_sessions.Location = new System.Drawing.Point(245, 316);
            this.nud_sessions.Name = "nud_sessions";
            this.nud_sessions.Size = new System.Drawing.Size(532, 31);
            this.nud_sessions.TabIndex = 13;
            // 
            // NewCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "NewCaseForm";
            this.Text = "Neuen Krankheitsfall erstellen";
            this.Load += new System.EventHandler(this.NewCaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_sessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cbx_patient;
        private System.Windows.Forms.NumericUpDown nud_sessions;
    }
}