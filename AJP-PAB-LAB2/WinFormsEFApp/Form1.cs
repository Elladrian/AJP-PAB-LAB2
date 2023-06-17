using WinFormsEFApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace WinFormsEFApp
{
    public partial class Form1 : Form
    {
        Ajppablab2Context db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillAuthorDataGridView();
            fillBooksDataGridView();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        public void fillBooksDataGridView()
        {
            using (Ajppablab2Context db = new())
            {
                try
                {
                    db.Books.Load();
                    this.bookBindingSource.DataSource = db.Books.Local.ToBindingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Occured erorr {ex.Message}");
                }
            }
        }

        public void fillAuthorDataGridView()
        {
            using (Ajppablab2Context db = new())
            {
                try
                {
                    db.Authors.Load();
                    this.authorBindingSource.DataSource = db.Authors.Local.ToBindingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Occured erorr {ex.Message}");
                }
            }       
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            using (Ajppablab2Context db = new())
            {
                try
                {
                    string authorName = authorNameText.Text;
                    string authorDescription = authorDescriptionText.Text;

                    db.Authors.Add(new() { Name = authorName, Description = authorDescription });
                    db.SaveChanges();

                    db.Authors.Load();
                    this.authorBindingSource.DataSource = db.Authors.Local.ToBindingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Occured erorr {ex.Message}");
                }
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            using (Ajppablab2Context db = new())
            {
                try
                {
                    string bookName = bookNameText.Text;
                    int bookPages;
                    if (!Int32.TryParse(bookPagesText.Text, out bookPages)) bookPages = 3;

                    db.Books.Add(new() { Name = bookName, Pages = bookPages });
                    db.SaveChanges();

                    db.Books.Load();
                    this.bookBindingSource.DataSource = db.Books.Local.ToBindingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Occured erorr {ex.Message}");
                }
            }
        }

        private void bothButton_Click(object sender, EventArgs e)
        {
            // With transaction
            using (Ajppablab2Context db = new())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        string authorName = authorNameText.Text;
                        string authorDescription = authorDescriptionText.Text;

                        Author addedAuthor = new() { Name = authorName, Description = authorDescription };
                        db.Authors.Add(addedAuthor);
                        db.SaveChanges();

                        db.Authors.Load();
                        this.authorBindingSource.DataSource = db.Authors.Local.ToBindingList();

                        string bookName = bookNameText.Text;
                        int bookPages;
                        if (!Int32.TryParse(bookPagesText.Text, out bookPages)) bookPages = 3;

                        db.Books.Add(new() { Name = bookName, Pages = bookPages, AuthorId = addedAuthor.Id });
                        db.SaveChanges();

                        db.Books.Load();
                        this.bookBindingSource.DataSource = db.Books.Local.ToBindingList();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Occured error: {ex.Message}");

                        db.ChangeTracker.Clear();

                        db.Authors.Load();
                        this.authorDataGridView.DataSource = db.Authors.Local.ToBindingList();

                        db.Books.Load();
                        this.bookDataGridView.DataSource = db.Books.Local.ToBindingList();
                    }
                }
            }

            /*// Without transaction
            using (Ajppablab2Context db = new())
            {
                try
                {
                    string authorName = authorNameText.Text;
                    string authorDescription = authorDescriptionText.Text;

                    Author addedAuthor = new() { Name = authorName, Description = authorDescription };
                    db.Authors.Add(addedAuthor);
                    db.SaveChanges();

                    db.Authors.Load();
                    this.authorBindingSource.DataSource = db.Authors.Local.ToBindingList();

                    string bookName = bookNameText.Text;
                    int bookPages;
                    if (!Int32.TryParse(bookPagesText.Text, out bookPages)) bookPages = 3;

                    db.Books.Add(new() { Name = bookName, Pages = bookPages, AuthorId = addedAuthor.Id });
                    db.SaveChanges();

                    db.Books.Load();
                    this.bookBindingSource.DataSource = db.Books.Local.ToBindingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Occured error: {ex.Message}");
                }
            }*/

        }

        #region unused
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        #endregion

        private void clearButton_Click(object sender, EventArgs e)
        {
            using (Ajppablab2Context db = new())
            {
                db.Authors.RemoveRange(db.Authors);
                db.Books.RemoveRange(db.Books);
                db.SaveChanges();
            }

            fillAuthorDataGridView();
            fillBooksDataGridView();
        }
    }
}