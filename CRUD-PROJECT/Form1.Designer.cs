namespace CRUD_PROJECT
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dtStarted = new DateTimePicker();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            txtContact = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtEmpName = new TextBox();
            txtEmpID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Insert_Btn = new Button();
            dataGridView1 = new DataGridView();
            Delete_Btn = new Button();
            Upd_Btn = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            bindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(66, 13);
            label1.Name = "label1";
            label1.Size = new Size(443, 32);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE INFORMATION SYSTEM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(92, 16);
            label2.TabIndex = 1;
            label2.Text = "Employee ID:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(118, 16);
            label3.TabIndex = 2;
            label3.Text = "Employee Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(64, 16);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtStarted);
            groupBox1.Controls.Add(rdoFemale);
            groupBox1.Controls.Add(rdoMale);
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmpName);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(27, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 318);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMATION";
            // 
            // dtStarted
            // 
            dtStarted.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtStarted.Location = new Point(182, 264);
            dtStarted.Name = "dtStarted";
            dtStarted.Size = new Size(277, 27);
            dtStarted.TabIndex = 15;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdoFemale.ForeColor = Color.MidnightBlue;
            rdoFemale.Location = new Point(264, 229);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(72, 20);
            rdoFemale.TabIndex = 14;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            rdoFemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdoMale.ForeColor = Color.MidnightBlue;
            rdoMale.Location = new Point(182, 229);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(58, 20);
            rdoMale.TabIndex = 13;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(182, 186);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(277, 31);
            txtContact.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(182, 148);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(277, 31);
            txtAge.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(182, 112);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(277, 31);
            txtAddress.TabIndex = 10;
            // 
            // txtEmpName
            // 
            txtEmpName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpName.Location = new Point(182, 75);
            txtEmpName.Multiline = true;
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(277, 31);
            txtEmpName.TabIndex = 9;
            // 
            // txtEmpID
            // 
            txtEmpID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpID.Location = new Point(182, 37);
            txtEmpID.Multiline = true;
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(277, 31);
            txtEmpID.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(12, 264);
            label8.Name = "label8";
            label8.Size = new Size(91, 16);
            label8.TabIndex = 7;
            label8.Text = "Date Started:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(12, 190);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 6;
            label7.Text = "Contact Number:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(12, 231);
            label6.Name = "label6";
            label6.Size = new Size(33, 16);
            label6.TabIndex = 5;
            label6.Text = "Sex:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 152);
            label5.Name = "label5";
            label5.Size = new Size(38, 16);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            label5.Click += label5_Click;
            // 
            // Insert_Btn
            // 
            Insert_Btn.BackColor = Color.Orange;
            Insert_Btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Insert_Btn.ForeColor = SystemColors.ActiveCaptionText;
            Insert_Btn.Location = new Point(117, 386);
            Insert_Btn.Name = "Insert_Btn";
            Insert_Btn.Size = new Size(94, 46);
            Insert_Btn.TabIndex = 5;
            Insert_Btn.Text = "INSERT";
            Insert_Btn.UseVisualStyleBackColor = false;
            Insert_Btn.Click += Insert_Btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(572, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(446, 333);
            dataGridView1.TabIndex = 6;
            // 
            // Delete_Btn
            // 
            Delete_Btn.BackColor = Color.Orange;
            Delete_Btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete_Btn.ForeColor = SystemColors.ActiveCaptionText;
            Delete_Btn.Location = new Point(346, 386);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(94, 46);
            Delete_Btn.TabIndex = 8;
            Delete_Btn.Text = "DELETE";
            Delete_Btn.UseVisualStyleBackColor = false;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // Upd_Btn
            // 
            Upd_Btn.BackColor = Color.Orange;
            Upd_Btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Upd_Btn.ForeColor = SystemColors.ActiveCaptionText;
            Upd_Btn.Location = new Point(233, 386);
            Upd_Btn.Name = "Upd_Btn";
            Upd_Btn.Size = new Size(94, 46);
            Upd_Btn.TabIndex = 10;
            Upd_Btn.Text = "UPDATE";
            Upd_Btn.UseVisualStyleBackColor = false;
            Upd_Btn.Click += Upd_Btn_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Orange;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(882, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 46);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(582, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(277, 31);
            txtSearch.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = Properties.Resources.cool_background;
            ClientSize = new Size(1033, 444);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(Upd_Btn);
            Controls.Add(Delete_Btn);
            Controls.Add(dataGridView1);
            Controls.Add(Insert_Btn);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Employee Information System";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtEmpID;
        private Label label8;
        private Label label7;
        private Label label6;
        private RadioButton rdoMale;
        private TextBox txtContact;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtEmpName;
        private RadioButton rdoFemale;
        private DateTimePicker dtStarted;
        private Button Insert_Btn;
        private DataGridView dataGridView1;
        private Button Delete_Btn;
        private Button Upd_Btn;
        private Button btnSearch;
        private TextBox txtSearch;
        private BindingSource bindingSource1;
    }
}