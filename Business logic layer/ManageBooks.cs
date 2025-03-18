using Database_layer;
using System.Data;

namespace Business_logic_layer
{
    public class ManageBooks
    {
        private MyDB my_db = new MyDB();

        public DataTable GetAllBooks()
        {
            return my_db.GetAllBooks();
        }
    }
}
