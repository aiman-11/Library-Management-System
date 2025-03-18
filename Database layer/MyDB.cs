using System.Data;
using System.Data.SqlClient;

namespace Database_layer
{
    public class MyDB

    {
        // ConnectionState String 
        private string connection_string = "Data Source=AIMANSTUDIO\\SQLEXPRESS;Initial Catalog=library management system;Integrated Security=true;";

        public DataTable GetAllBooks()
        {
            DataTable books = new DataTable();

            // Sql Connection 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection_string;
            conn.Open();

             // Sql Command or query to be execute
            string query = "select * from books";
            SqlCommand cmd = new SqlCommand(query, conn);

            // Data Adapter to run sql command
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(books); // fetch and store data in books

            conn.Close();

            return books; // Return books datatable

        }
    }
}