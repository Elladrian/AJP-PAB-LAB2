namespace WinFormsEFApp
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
            authorDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorBindingSource = new BindingSource(components);
            bookDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pagesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            authorLabel = new Label();
            BookLabel = new Label();
            authorNameText = new TextBox();
            authorDescriptionText = new TextBox();
            bookNameText = new TextBox();
            bookPagesText = new TextBox();
            authorButton = new Button();
            bookButton = new Button();
            bothButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // authorDataGridView
            // 
            authorDataGridView.AllowUserToAddRows = false;
            authorDataGridView.AllowUserToDeleteRows = false;
            authorDataGridView.AutoGenerateColumns = false;
            authorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            authorDataGridView.DataSource = authorBindingSource;
            authorDataGridView.Location = new Point(300, 12);
            authorDataGridView.Name = "authorDataGridView";
            authorDataGridView.ReadOnly = true;
            authorDataGridView.Size = new Size(408, 483);
            authorDataGridView.TabIndex = 0;
            authorDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Models.Author);
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.AllowUserToDeleteRows = false;
            bookDataGridView.AutoGenerateColumns = false;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, pagesDataGridViewTextBoxColumn, authorIdDataGridViewTextBoxColumn });
            bookDataGridView.DataSource = bookBindingSource;
            bookDataGridView.Location = new Point(714, 12);
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.ReadOnly = true;
            bookDataGridView.Size = new Size(461, 483);
            bookDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            pagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(48, 92);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(44, 15);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Author";
            // 
            // BookLabel
            // 
            BookLabel.AutoSize = true;
            BookLabel.Location = new Point(48, 209);
            BookLabel.Name = "BookLabel";
            BookLabel.Size = new Size(34, 15);
            BookLabel.TabIndex = 3;
            BookLabel.Text = "Book";
            // 
            // authorNameText
            // 
            authorNameText.Location = new Point(48, 110);
            authorNameText.Name = "authorNameText";
            authorNameText.Size = new Size(164, 23);
            authorNameText.TabIndex = 4;
            authorNameText.Text = "Name";
            // 
            // authorDescriptionText
            // 
            authorDescriptionText.Location = new Point(48, 139);
            authorDescriptionText.Name = "authorDescriptionText";
            authorDescriptionText.Size = new Size(164, 23);
            authorDescriptionText.TabIndex = 5;
            authorDescriptionText.Text = "Description";
            // 
            // bookNameText
            // 
            bookNameText.Location = new Point(48, 227);
            bookNameText.Name = "bookNameText";
            bookNameText.Size = new Size(164, 23);
            bookNameText.TabIndex = 6;
            bookNameText.Text = "Name";
            // 
            // bookPagesText
            // 
            bookPagesText.Location = new Point(48, 256);
            bookPagesText.Name = "bookPagesText";
            bookPagesText.Size = new Size(164, 23);
            bookPagesText.TabIndex = 7;
            bookPagesText.Text = "Pages";
            // 
            // authorButton
            // 
            authorButton.Location = new Point(38, 333);
            authorButton.Name = "authorButton";
            authorButton.Size = new Size(195, 32);
            authorButton.TabIndex = 8;
            authorButton.Text = "Add Author";
            authorButton.UseVisualStyleBackColor = true;
            authorButton.Click += authorButton_Click;
            // 
            // bookButton
            // 
            bookButton.Location = new Point(38, 371);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(195, 32);
            bookButton.TabIndex = 9;
            bookButton.Text = "Add Book";
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // bothButton
            // 
            bothButton.Location = new Point(38, 409);
            bothButton.Name = "bothButton";
            bothButton.Size = new Size(195, 32);
            bothButton.TabIndex = 10;
            bothButton.Text = "Add Author and Book";
            bothButton.UseVisualStyleBackColor = true;
            bothButton.Click += bothButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(38, 447);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(195, 32);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear Tables";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 507);
            Controls.Add(clearButton);
            Controls.Add(bothButton);
            Controls.Add(bookButton);
            Controls.Add(authorButton);
            Controls.Add(bookPagesText);
            Controls.Add(bookNameText);
            Controls.Add(authorDescriptionText);
            Controls.Add(authorNameText);
            Controls.Add(BookLabel);
            Controls.Add(authorLabel);
            Controls.Add(bookDataGridView);
            Controls.Add(authorDataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView authorDataGridView;
        private DataGridView bookDataGridView;
        private Label authorLabel;
        private Label BookLabel;
        private TextBox authorNameText;
        private TextBox authorDescriptionText;
        private TextBox bookNameText;
        private TextBox bookPagesText;
        private Button authorButton;
        private Button bookButton;
        private Button bothButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource authorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private BindingSource bookBindingSource;
        private Button clearButton;
    }
}