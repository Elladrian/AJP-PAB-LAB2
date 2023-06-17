using WinFormsEFApp.Models;
using Microsoft.EntityFrameworkCore;

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
            Ajppablab2Context db = new();
            db.Books.Load();
            this.bookBindingSource.DataSource = db.Books.Local.ToBindingList();
        }

        public void fillAuthorDataGridView()
        {
            Ajppablab2Context db = new();
            db.Authors.Load();
            this.authorBindingSource.DataSource = db.Authors.Local.ToBindingList();
        }

        private void authorButton_Click(object sender, EventArgs e)
        {

        }

        private void bookButton_Click(object sender, EventArgs e)
        {

        }

        private void bothButton_Click(object sender, EventArgs e)
        {

        }

        #region unused
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        #endregion


        private void clearButton_Click(object sender, EventArgs e)
        {
            Ajppablab2Context db = new();
            db.Authors.RemoveRange(db.Authors);
            db.Books.RemoveRange(db.Books);
            db.SaveChanges();

            fillAuthorDataGridView();
            fillBooksDataGridView();
        }
    }
}