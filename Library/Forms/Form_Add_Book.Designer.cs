namespace Library
{
    partial class Form_Add_Book
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxISBN13 = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitle.Location = new System.Drawing.Point(60, 100);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitle.MaxLength = 100;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(520, 31);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAuthor.Location = new System.Drawing.Point(60, 190);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAuthor.MaxLength = 100;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(520, 31);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publication date:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(60, 370);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(224, 33);
            this.comboBoxGenre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pages:";
            // 
            // textBoxPages
            // 
            this.textBoxPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPages.Location = new System.Drawing.Point(356, 370);
            this.textBoxPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPages.MaxLength = 4;
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(111, 31);
            this.textBoxPages.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "ISBN-13:";
            // 
            // textBoxISBN13
            // 
            this.textBoxISBN13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxISBN13.Location = new System.Drawing.Point(356, 280);
            this.textBoxISBN13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxISBN13.MaxLength = 13;
            this.textBoxISBN13.Name = "textBoxISBN13";
            this.textBoxISBN13.Size = new System.Drawing.Size(224, 31);
            this.textBoxISBN13.TabIndex = 11;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.CustomFormat = "";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(60, 280);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(224, 31);
            this.datePicker.TabIndex = 15;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxDescription.Location = new System.Drawing.Point(60, 460);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDescription.MaxLength = 5000;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(520, 202);
            this.richTextBoxDescription.TabIndex = 16;
            this.richTextBoxDescription.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Description:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(410, 715);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(60, 715);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 50);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form_Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 833);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxISBN13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(666, 861);
            this.Name = "Form_Add_Book";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTitle;
        private Label label1;
        private Label label2;
        private TextBox textBoxAuthor;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxGenre;
        private Label label5;
        private TextBox textBoxPages;
        private Label label6;
        private TextBox textBoxISBN13;
        private DateTimePicker datePicker;
        private RichTextBox richTextBoxDescription;
        private Label label7;
        private Button btnSave;
        private Button btnBack;
    }
}