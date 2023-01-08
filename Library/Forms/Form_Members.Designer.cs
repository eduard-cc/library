namespace Library
{
    partial class Form_Members
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
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToDeleteRows = false;
            this.dataGridViewMembers.AllowUserToOrderColumns = true;
            this.dataGridViewMembers.AllowUserToResizeColumns = false;
            this.dataGridViewMembers.AllowUserToResizeRows = false;
            this.dataGridViewMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMembers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewMembers.Location = new System.Drawing.Point(32, 32);
            this.dataGridViewMembers.MultiSelect = false;
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RowHeadersWidth = 62;
            this.dataGridViewMembers.RowTemplate.Height = 25;
            this.dataGridViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembers.Size = new System.Drawing.Size(406, 216);
            this.dataGridViewMembers.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Member Name:";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMember.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddMember.Location = new System.Drawing.Point(293, 327);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(145, 30);
            this.btnAddMember.TabIndex = 24;
            this.btnAddMember.Text = "Add member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveMember.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemoveMember.Location = new System.Drawing.Point(32, 269);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(145, 30);
            this.btnRemoveMember.TabIndex = 21;
            this.btnRemoveMember.Text = "Remove member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(32, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 30);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMemberName.Location = new System.Drawing.Point(293, 275);
            this.textBoxMemberName.MaxLength = 100;
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(145, 23);
            this.textBoxMemberName.TabIndex = 22;
            // 
            // Form_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 388);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.dataGridViewMembers);
            this.MinimumSize = new System.Drawing.Size(486, 427);
            this.Name = "Form_Members";
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewMembers;
        private Label label8;
        private Button btnAddMember;
        private Button btnRemoveMember;
        private Button btnCancel;
        private TextBox textBoxMemberName;
    }
}