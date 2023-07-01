using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source=GORWPC0008;Initial Catalog=AJPPABLAB2;Persist Security Info=True;User ID=Administrator;Password=cisco123!L";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.authorTableAdapter.Fill(this.aJPPABLAB2DataSet.Author);
            this.bookTableAdapter.Fill(this.aJPPABLAB2DataSet.Book);
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlExpression = "INSERT INTO Author (Name, Description) Values (@Name, @Description)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    string authorName = authorNameText.Text;
                    string authorDescription = authorDescriptionText.Text;

                    SqlParameter authorNameParameter = new SqlParameter("@Name", authorName);
                    SqlParameter authorDescriptionParameter = new SqlParameter("@Description", authorDescription);

                    command.Parameters.Add(authorNameParameter);
                    command.Parameters.Add(authorDescriptionParameter);

                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Occurred error: {ex.Message}");
            }
            finally
            {
                this.authorTableAdapter.Fill(this.aJPPABLAB2DataSet.Author);
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlExpression = "INSERT INTO Book (Name, Pages) Values (@Name, @Pages)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    string bookName = bookNameText.Text;
                    int bookPages;
                    if(!Int32.TryParse(bookPagesText.Text, out bookPages)) bookPages = 3;

                    SqlParameter bookNameParameter = new SqlParameter("@Name", bookName);
                    SqlParameter bookPagesParameter = new SqlParameter("@Pages", bookPages);

                    command.Parameters.Add(bookNameParameter);
                    command.Parameters.Add(bookPagesParameter);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occurred error: {ex.Message}");
            }
            finally
            {
                this.bookTableAdapter.Fill(this.aJPPABLAB2DataSet.Book);
            }
        }

        private void bothButton_Click(object sender, EventArgs e)
        {
            // With transaction
            int? authorId = null;
            string sqlExpression = "INSERT INTO Author (Name, Description) Values (@Name, @Description); SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Transaction = transaction;

                try
                {
                    string authorName = authorNameText.Text;
                    string authorDescription = authorDescriptionText.Text;

                    SqlParameter authorNameParameter = new SqlParameter("@Name", authorName);
                    SqlParameter authorDescriptionParameter = new SqlParameter("@Description", authorDescription);

                    command.Parameters.Add(authorNameParameter);
                    command.Parameters.Add(authorDescriptionParameter);
                    command.CommandTimeout = 200;
                    authorId = Convert.ToInt32(command.ExecuteScalar());

                    sqlExpression = "INSERT INTO Book (Name, Pages) Values (@Name, @Pages)";
                    if (authorId != null)
                    {
                        sqlExpression = "INSERT INTO Book (Name, Pages, AuthorId) Values (@Name, @Pages, @AuthorId)";
                    }

                    command.CommandText = sqlExpression;
                    command.Parameters.Clear();

                    string bookName = bookNameText.Text;
                    int bookPages;
                    if (!Int32.TryParse(bookPagesText.Text, out bookPages)) bookPages = 3;

                    SqlParameter bookNameParameter = new SqlParameter("@Name", bookName);
                    SqlParameter bookPagesParameter = new SqlParameter("@Pages", bookPages);
                    command.Parameters.Add(bookNameParameter);
                    command.Parameters.Add(bookPagesParameter);

                    if (authorId != null)
                    {
                        SqlParameter authorIdParameter = new SqlParameter("@AuthorId", authorId);
                        command.Parameters.Add(authorIdParameter);
                    }

                    command.ExecuteNonQuery();
                    transaction.Commit();
                    this.authorTableAdapter.Fill(this.aJPPABLAB2DataSet.Author);
                    this.bookTableAdapter.Fill(this.aJPPABLAB2DataSet.Book);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Occurred error: {ex.Message}");
                    transaction.Rollback();
                    this.authorTableAdapter.Fill(this.aJPPABLAB2DataSet.Author);
                    this.bookTableAdapter.Fill(this.aJPPABLAB2DataSet.Book);
                }
            }
        
            // Without transaction
            /* 
            int? authorId = null;
            try
            {
                string sqlExpression = "INSERT INTO Author (Name, Description) Values (@Name, @Description); SELECT SCOPE_IDENTITY()";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    string authorName = authorNameText.Text;
                    string authorDescription = authorDescriptionText.Text;

                    SqlParameter authorNameParameter = new SqlParameter("@Name", authorName);
                    SqlParameter authorDescriptionParameter = new SqlParameter("@Description", authorDescription);

                    command.Parameters.Add(authorNameParameter);
                    command.Parameters.Add(authorDescriptionParameter);
                    authorId = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occurred error: {ex.Message}");
            }
            finally
            {
                this.authorTableAdapter.Fill(this.aJPPABLAB2DataSet.Author);
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = "INSERT INTO Book (Name, Pages) Values (@Name, @Pages)";
                    if (authorId != null)
                    {
                        sqlExpression = "INSERT INTO Book (Name, Pages, AuthorId) Values (@Name, @Pages, @AuthorId)";
                    }

                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    string bookName = bookNameText.Text;
                    int bookPages;
                    if (!Int32.TryParse(bookPagesText.Text, out bookPages)) bookPages = 3;

                    SqlParameter bookNameParameter = new SqlParameter("@Name", bookName);
                    SqlParameter bookPagesParameter = new SqlParameter("@Pages", bookPages);
                    command.Parameters.Add(bookNameParameter);
                    command.Parameters.Add(bookPagesParameter);

                    if (authorId != null)
                    {
                        SqlParameter authorIdParameter = new SqlParameter("@AuthorId", authorId);
                        command.Parameters.Add(authorIdParameter);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occurred error: {ex.Message}");
            }
            finally
            {
                this.bookTableAdapter.Fill(this.aJPPABLAB2DataSet.Book);
            }
            */
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlExpression = "DELETE FROM Author";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();

                sqlExpression = "DELETE FROM Book";
                command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }

            this.authorTableAdapter.Fill(this.aJPPABLAB2DataSet.Author);
            this.bookTableAdapter.Fill(this.aJPPABLAB2DataSet.Book);
        }

        #region notused
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e) { }
        #endregion
    }
}
