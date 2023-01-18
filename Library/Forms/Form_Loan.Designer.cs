namespace Library
{
    partial class Form_Loan
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCurrentBorrower = new System.Windows.Forms.Label();
            this.lblPublicationDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblIsbn13 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.btnLoan = new System.Windows.Forms.Button();
            this.datePickerLoan = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentBorrower3 = new System.Windows.Forms.Label();
            this.btnFindID = new System.Windows.Forms.Button();
            this.lblBorrowedBy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMembers = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCurrentBorrower2 = new System.Windows.Forms.Label();
            this.lblReturnFrom = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.datePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblCurrentBorrower);
            this.groupBox1.Controls.Add(this.lblPublicationDate);
            this.groupBox1.Controls.Add(this.lblGenre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPages);
            this.groupBox1.Controls.Add(this.lblIsbn13);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book details";
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.Color.Navy;
            this.lblDescription.Location = new System.Drawing.Point(16, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(522, 91);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "{description}";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Description:";
            // 
            // lblCurrentBorrower
            // 
            this.lblCurrentBorrower.AutoSize = true;
            this.lblCurrentBorrower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBorrower.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentBorrower.Location = new System.Drawing.Point(189, 239);
            this.lblCurrentBorrower.Name = "lblCurrentBorrower";
            this.lblCurrentBorrower.Size = new System.Drawing.Size(104, 15);
            this.lblCurrentBorrower.TabIndex = 3;
            this.lblCurrentBorrower.Text = "{current borrower}";
            // 
            // lblPublicationDate
            // 
            this.lblPublicationDate.AutoSize = true;
            this.lblPublicationDate.ForeColor = System.Drawing.Color.Navy;
            this.lblPublicationDate.Location = new System.Drawing.Point(431, 36);
            this.lblPublicationDate.Name = "lblPublicationDate";
            this.lblPublicationDate.Size = new System.Drawing.Size(103, 15);
            this.lblPublicationDate.TabIndex = 11;
            this.lblPublicationDate.Text = "{publication_date}";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.Navy;
            this.lblGenre.Location = new System.Drawing.Point(69, 86);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(45, 15);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "{genre}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Current borrower of this book:";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.ForeColor = System.Drawing.Color.Navy;
            this.lblPages.Location = new System.Drawing.Point(382, 86);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(46, 15);
            this.lblPages.TabIndex = 9;
            this.lblPages.Text = "{pages}";
            // 
            // lblIsbn13
            // 
            this.lblIsbn13.AutoSize = true;
            this.lblIsbn13.ForeColor = System.Drawing.Color.Navy;
            this.lblIsbn13.Location = new System.Drawing.Point(382, 61);
            this.lblIsbn13.Name = "lblIsbn13";
            this.lblIsbn13.Size = new System.Drawing.Size(52, 15);
            this.lblIsbn13.TabIndex = 8;
            this.lblIsbn13.Text = "{ISBN13}";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.Color.Navy;
            this.lblAuthor.Location = new System.Drawing.Point(69, 61);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 15);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "{author}";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(69, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 15);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "{title}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pages:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "ISBN13:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publication date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dataGridViewHistory);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan History";
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToOrderColumns = true;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            this.dataGridViewHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewHistory.Location = new System.Drawing.Point(16, 29);
            this.dataGridViewHistory.MultiSelect = false;
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 62;
            this.dataGridViewHistory.RowTemplate.Height = 25;
            this.dataGridViewHistory.Size = new System.Drawing.Size(532, 135);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(16, 179);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(241, 30);
            this.btnLoan.TabIndex = 4;
            this.btnLoan.Text = "Loan book";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // datePickerLoan
            // 
            this.datePickerLoan.Location = new System.Drawing.Point(112, 28);
            this.datePickerLoan.Name = "datePickerLoan";
            this.datePickerLoan.Size = new System.Drawing.Size(145, 23);
            this.datePickerLoan.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lblCurrentBorrower3);
            this.groupBox3.Controls.Add(this.btnFindID);
            this.groupBox3.Controls.Add(this.lblBorrowedBy);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxMemberId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxMembers);
            this.groupBox3.Controls.Add(this.datePickerLoan);
            this.groupBox3.Controls.Add(this.btnLoan);
            this.groupBox3.Location = new System.Drawing.Point(12, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 225);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loan this book";
            // 
            // lblCurrentBorrower3
            // 
            this.lblCurrentBorrower3.AutoSize = true;
            this.lblCurrentBorrower3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBorrower3.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentBorrower3.Location = new System.Drawing.Point(151, 152);
            this.lblCurrentBorrower3.Name = "lblCurrentBorrower3";
            this.lblCurrentBorrower3.Size = new System.Drawing.Size(104, 15);
            this.lblCurrentBorrower3.TabIndex = 15;
            this.lblCurrentBorrower3.Text = "{current borrower}";
            this.lblCurrentBorrower3.Visible = false;
            // 
            // btnFindID
            // 
            this.btnFindID.Location = new System.Drawing.Point(189, 104);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(68, 23);
            this.btnFindID.TabIndex = 20;
            this.btnFindID.Text = "Find ID";
            this.btnFindID.UseVisualStyleBackColor = true;
            this.btnFindID.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // lblBorrowedBy
            // 
            this.lblBorrowedBy.AutoSize = true;
            this.lblBorrowedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBorrowedBy.Location = new System.Drawing.Point(16, 152);
            this.lblBorrowedBy.Name = "lblBorrowedBy";
            this.lblBorrowedBy.Size = new System.Drawing.Size(129, 15);
            this.lblBorrowedBy.TabIndex = 14;
            this.lblBorrowedBy.Text = "Currently borrowed by:";
            this.lblBorrowedBy.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Find Member by ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Loan date:";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(133, 104);
            this.textBoxMemberId.MaxLength = 5;
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(50, 23);
            this.textBoxMemberId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Member Name:";
            // 
            // comboBoxMembers
            // 
            this.comboBoxMembers.FormattingEnabled = true;
            this.comboBoxMembers.Location = new System.Drawing.Point(112, 65);
            this.comboBoxMembers.Name = "comboBoxMembers";
            this.comboBoxMembers.Size = new System.Drawing.Size(145, 23);
            this.comboBoxMembers.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.lblCurrentBorrower2);
            this.groupBox4.Controls.Add(this.lblReturnFrom);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.datePickerReturn);
            this.groupBox4.Controls.Add(this.btnReturn);
            this.groupBox4.Location = new System.Drawing.Point(303, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 225);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Return this book";
            // 
            // lblCurrentBorrower2
            // 
            this.lblCurrentBorrower2.AutoSize = true;
            this.lblCurrentBorrower2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBorrower2.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentBorrower2.Location = new System.Drawing.Point(112, 68);
            this.lblCurrentBorrower2.Name = "lblCurrentBorrower2";
            this.lblCurrentBorrower2.Size = new System.Drawing.Size(104, 15);
            this.lblCurrentBorrower2.TabIndex = 15;
            this.lblCurrentBorrower2.Text = "{current borrower}";
            this.lblCurrentBorrower2.Visible = false;
            // 
            // lblReturnFrom
            // 
            this.lblReturnFrom.AutoSize = true;
            this.lblReturnFrom.Location = new System.Drawing.Point(16, 68);
            this.lblReturnFrom.Name = "lblReturnFrom";
            this.lblReturnFrom.Size = new System.Drawing.Size(74, 15);
            this.lblReturnFrom.TabIndex = 18;
            this.lblReturnFrom.Text = "Return from:";
            this.lblReturnFrom.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(16, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Return date:";
            // 
            // datePickerReturn
            // 
            this.datePickerReturn.Location = new System.Drawing.Point(112, 28);
            this.datePickerReturn.Name = "datePickerReturn";
            this.datePickerReturn.Size = new System.Drawing.Size(145, 23);
            this.datePickerReturn.TabIndex = 6;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(16, 179);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(241, 30);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 717);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(607, 722);
            this.Name = "Form_Loan";
            this.Text = "Loan and return books";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private GroupBox groupBox2;
        private Label label5;
        private Label label7;
        private Label lblCurrentBorrower;
        private Button btnLoan;
        private DateTimePicker datePickerLoan;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DateTimePicker datePickerReturn;
        private Button btnReturn;
        private Label lblPublicationDate;
        private Label lblGenre;
        private Label lblPages;
        private Label lblIsbn13;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblDescription;
        private Label label14;
        private DataGridView dataGridViewHistory;
        private TextBox textBoxMemberId;
        private Label label8;
        private ComboBox comboBoxMembers;
        private Label label10;
        private Label lblReturnFrom;
        private Label lblCurrentBorrower2;
        private Label label13;
        private Button btnFindID;
        private Label label11;
        private Label lblCurrentBorrower3;
        private Label lblBorrowedBy;
    }
}