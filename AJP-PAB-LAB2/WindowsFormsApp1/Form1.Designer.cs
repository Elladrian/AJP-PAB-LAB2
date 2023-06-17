namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.authorNameText = new System.Windows.Forms.TextBox();
            this.authorDescriptionText = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.GroupBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookBox = new System.Windows.Forms.GroupBox();
            this.bookLabel = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.bookPagesText = new System.Windows.Forms.TextBox();
            this.authorButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.bothButton = new System.Windows.Forms.Button();
            this.aJPPABLAB2DataSet = new WindowsFormsApp1.AJPPABLAB2DataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new WindowsFormsApp1.AJPPABLAB2DataSetTableAdapters.BookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new WindowsFormsApp1.AJPPABLAB2DataSetTableAdapters.AuthorTableAdapter();
            this.authorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.authorBox.SuspendLayout();
            this.bookBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aJPPABLAB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bookBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(703, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(447, 515);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // authorNameText
            // 
            this.authorNameText.Location = new System.Drawing.Point(12, 45);
            this.authorNameText.Name = "authorNameText";
            this.authorNameText.Size = new System.Drawing.Size(182, 20);
            this.authorNameText.TabIndex = 2;
            this.authorNameText.Text = "Name";
            // 
            // authorDescriptionText
            // 
            this.authorDescriptionText.Location = new System.Drawing.Point(12, 83);
            this.authorDescriptionText.Name = "authorDescriptionText";
            this.authorDescriptionText.Size = new System.Drawing.Size(182, 20);
            this.authorDescriptionText.TabIndex = 3;
            this.authorDescriptionText.Text = "Description";
            this.authorDescriptionText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // authorBox
            // 
            this.authorBox.Controls.Add(this.authorLabel);
            this.authorBox.Controls.Add(this.authorNameText);
            this.authorBox.Controls.Add(this.authorDescriptionText);
            this.authorBox.Location = new System.Drawing.Point(22, 23);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(200, 127);
            this.authorBox.TabIndex = 4;
            this.authorBox.TabStop = false;
            this.authorBox.Text = "AuthorBox";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 20);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Author";
            this.authorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookBox
            // 
            this.bookBox.Controls.Add(this.bookPagesText);
            this.bookBox.Controls.Add(this.bookNameText);
            this.bookBox.Controls.Add(this.bookLabel);
            this.bookBox.Location = new System.Drawing.Point(22, 171);
            this.bookBox.Name = "bookBox";
            this.bookBox.Size = new System.Drawing.Size(200, 124);
            this.bookBox.TabIndex = 5;
            this.bookBox.TabStop = false;
            this.bookBox.Text = "BookBox";
            this.bookBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Location = new System.Drawing.Point(15, 20);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(32, 13);
            this.bookLabel.TabIndex = 0;
            this.bookLabel.Text = "Book";
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(12, 48);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(182, 20);
            this.bookNameText.TabIndex = 1;
            this.bookNameText.Text = "Name";
            // 
            // bookPagesText
            // 
            this.bookPagesText.Location = new System.Drawing.Point(12, 88);
            this.bookPagesText.Name = "bookPagesText";
            this.bookPagesText.Size = new System.Drawing.Size(182, 20);
            this.bookPagesText.TabIndex = 2;
            this.bookPagesText.Text = "Pages";
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(22, 319);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(200, 30);
            this.authorButton.TabIndex = 6;
            this.authorButton.Text = "Add Author";
            this.authorButton.UseVisualStyleBackColor = true;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(22, 355);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(200, 30);
            this.bookButton.TabIndex = 7;
            this.bookButton.Text = "Add Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // bothButton
            // 
            this.bothButton.Location = new System.Drawing.Point(22, 391);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(200, 30);
            this.bothButton.TabIndex = 8;
            this.bothButton.Text = "Add Author and Book";
            this.bothButton.UseVisualStyleBackColor = true;
            this.bothButton.Click += new System.EventHandler(this.bothButton_Click);
            // 
            // aJPPABLAB2DataSet
            // 
            this.aJPPABLAB2DataSet.DataSetName = "AJPPABLAB2DataSet";
            this.aJPPABLAB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.aJPPABLAB2DataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.aJPPABLAB2DataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // authorBindingSource1
            // 
            this.authorBindingSource1.DataMember = "Author";
            this.authorBindingSource1.DataSource = this.aJPPABLAB2DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(333, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(348, 515);
            this.dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(22, 427);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 30);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear Tables";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 539);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bothButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.authorButton);
            this.Controls.Add(this.bookBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.authorBox.ResumeLayout(false);
            this.authorBox.PerformLayout();
            this.bookBox.ResumeLayout(false);
            this.bookBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aJPPABLAB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox authorNameText;
        private System.Windows.Forms.TextBox authorDescriptionText;
        private System.Windows.Forms.GroupBox authorBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.GroupBox bookBox;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox bookPagesText;
        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button bothButton;
        private AJPPABLAB2DataSet aJPPABLAB2DataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private AJPPABLAB2DataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private AJPPABLAB2DataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.BindingSource authorBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clearButton;
    }
}

