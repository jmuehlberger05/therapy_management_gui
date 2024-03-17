namespace therapy_management_gui
{
    partial class Form1
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add_patient = new System.Windows.Forms.Button();
            this.btn_refresh_patients = new System.Windows.Forms.Button();
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_refresh_cases = new System.Windows.Forms.Button();
            this.dgv_cases = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cases)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoEllipsis = true;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(29, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(296, 59);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "TherapizeYou";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bt_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1837, 118);
            this.panel1.TabIndex = 1;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(1679, 36);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(129, 49);
            this.bt_search.TabIndex = 5;
            this.bt_search.Text = "search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(1416, 43);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(245, 35);
            this.tb_search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "(nach Budgetkürzung)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(29, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 908);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_add_patient);
            this.panel3.Controls.Add(this.btn_refresh_patients);
            this.panel3.Controls.Add(this.dgv_patients);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(178, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 908);
            this.panel3.TabIndex = 3;
            // 
            // btn_add_patient
            // 
            this.btn_add_patient.Location = new System.Drawing.Point(425, 828);
            this.btn_add_patient.Name = "btn_add_patient";
            this.btn_add_patient.Size = new System.Drawing.Size(340, 49);
            this.btn_add_patient.TabIndex = 5;
            this.btn_add_patient.Text = "Neuen Patienten anlegen";
            this.btn_add_patient.UseVisualStyleBackColor = true;
            this.btn_add_patient.Click += new System.EventHandler(this.btn_add_patient_Click);
            // 
            // btn_refresh_patients
            // 
            this.btn_refresh_patients.Location = new System.Drawing.Point(636, 30);
            this.btn_refresh_patients.Name = "btn_refresh_patients";
            this.btn_refresh_patients.Size = new System.Drawing.Size(129, 49);
            this.btn_refresh_patients.TabIndex = 4;
            this.btn_refresh_patients.Text = "refresh";
            this.btn_refresh_patients.UseVisualStyleBackColor = true;
            this.btn_refresh_patients.Click += new System.EventHandler(this.btn_refresh_patients_Click);
            // 
            // dgv_patients
            // 
            this.dgv_patients.BackgroundColor = System.Drawing.Color.White;
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patients.Location = new System.Drawing.Point(38, 103);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.RowHeadersVisible = false;
            this.dgv_patients.RowHeadersWidth = 82;
            this.dgv_patients.RowTemplate.Height = 33;
            this.dgv_patients.Size = new System.Drawing.Size(727, 706);
            this.dgv_patients.TabIndex = 3;
            this.dgv_patients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patients_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patienten";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btn_refresh_cases);
            this.panel4.Controls.Add(this.dgv_cases);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(1011, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 908);
            this.panel4.TabIndex = 5;
            // 
            // btn_refresh_cases
            // 
            this.btn_refresh_cases.Location = new System.Drawing.Point(636, 30);
            this.btn_refresh_cases.Name = "btn_refresh_cases";
            this.btn_refresh_cases.Size = new System.Drawing.Size(129, 49);
            this.btn_refresh_cases.TabIndex = 4;
            this.btn_refresh_cases.Text = "refresh";
            this.btn_refresh_cases.UseVisualStyleBackColor = true;
            this.btn_refresh_cases.Click += new System.EventHandler(this.btn_refresh_cases_Click);
            // 
            // dgv_cases
            // 
            this.dgv_cases.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cases.Location = new System.Drawing.Point(38, 103);
            this.dgv_cases.Name = "dgv_cases";
            this.dgv_cases.RowHeadersVisible = false;
            this.dgv_cases.RowHeadersWidth = 82;
            this.dgv_cases.RowTemplate.Height = 33;
            this.dgv_cases.Size = new System.Drawing.Size(727, 774);
            this.dgv_cases.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Krankheitsfälle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1079);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TherapizeYou";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_patients;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_refresh_cases;
        private System.Windows.Forms.DataGridView dgv_cases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_add_patient;
        private System.Windows.Forms.Button btn_refresh_patients;
    }
}

