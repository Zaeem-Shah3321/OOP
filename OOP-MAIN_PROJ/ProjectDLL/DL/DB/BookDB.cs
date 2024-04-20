using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDLL.BL;
using ProjectDLL.DLInterface;
using System.Data.SqlClient;

namespace ProjectDLL.DL.DB
{
    public class BookDB:IBook
    {
        public void Create(Book book)
        {
            DataBase.openConnection();
            string query = $"insert into Book values('{book.getName()}','{book.getAuthor()}','{book.getLocation()}','{book.getCopies()}','{book.getCopiesAvailable()}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }
        public bool IsExist(string name)
        {
            DataBase.openConnection();
            string query = $"select * from Book where Name = '{name}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exist = false;
            while (reader.Read())
            {
                exist = true;
            }
            DataBase.closeConnection();
            return exist;
        }


        public Book Read(string find)
        {
            DataBase.openConnection();
            string query = $"select * from Book where Name = '{find}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Book book = null;
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string author = reader["Author"].ToString();
                string location = reader["Location"].ToString();
                int copies = int.Parse(reader["Total Copies"].ToString());
                int copiesAvailable = int.Parse(reader["Copies Available"].ToString());
                book = new Book(name, author, location, copies, copiesAvailable);
            }
            DataBase.closeConnection();
            return book;

        }
        public void DeleteBook(string bookName)
        {
            DataBase.openConnection();
            string query = $"DELETE FROM Book WHERE Name = '{bookName}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }

        public List<Book> ViewAllBooks(IBook bookDL)
        {
            List<Book> books = new List<Book>();

            DataBase.openConnection();
            string query = "SELECT * FROM Book";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine(" All Books....");

            while (reader.Read())
            {
                string name = reader.GetString(0);
                string author = reader.GetString(1);
                string location = reader.GetString(2);
                int copies = reader.GetInt32(3);
                int copiesAvailable = reader.GetInt32(4);

                Book book = new Book(name, author, location, copies, copiesAvailable);
                books.Add(book);
            }

            reader.Close();
            DataBase.closeConnection();

            return books;
        }
        public void UpdateBook(Book bookToUpdate, IBook bookDL)
        {
            DataBase.openConnection();
            string query = $"UPDATE Book SET Author = '{bookToUpdate.getAuthor()}', Location = '{bookToUpdate.getLocation()}', [Total Copies] = {bookToUpdate.getCopies()}, [Copies Available] = {bookToUpdate.getCopiesAvailable()} WHERE Name = '{bookToUpdate.getName()}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }
        public Book SearchByName(string name)
        {
            Book foundBook = null;
            DataBase.openConnection();
            string query = $"SELECT * FROM Book WHERE Name = '{name}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // Assuming your Book class has a constructor that takes relevant parameters
                    foundBook = new Book(
                    reader["Name"].ToString(),
                    reader["Author"].ToString(),
                    reader["Location"].ToString(),
                    int.Parse(reader["Total Copies"].ToString()),
                    int.Parse(reader["Copies Available"].ToString())
                );
            }

            reader.Close();
            DataBase.closeConnection();
            return foundBook;
        }

    }
}
