using Business_logic_layer;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ManageBooks books = new ManageBooks();
            BooksTable.DataSource = books.GetAllBooks();
        }
    }
}
