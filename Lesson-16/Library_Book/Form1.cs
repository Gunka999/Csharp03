using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book
{
    public partial class Form1 : Form
    {
        private List<Book> _books;
        private List<Genre> _genres;

        public Form1()
        {
            InitializeComponent();
            _books = new List<Book>();
            _genres = new List<Genre>
            {
                new Genre{Name="Dedective"},
                new Genre{Name="Roman"},
                new Genre{Name="Love"}
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Genre.Items.AddRange(_genres.ToArray());
            cmb_FilterGenre.Items.AddRange(_genres.ToArray());
            cmb_FilterGenre.Items.Insert(0, "All");
            cmb_Genre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FilterGenre.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            string BName = txb_name.Text.Trim();
            int BNumber = Convert.ToInt32(txb_number.Text.Trim());
            byte BPrice = Convert.ToByte(txb_price.Text.Trim());
            Book book = null;
            try
            {
                book = new Book
                {
                    BookName = BName,
                    ISBNumber = BNumber,
                    BookPrice = BPrice
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Please, fill values for book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Genre selectedGenre = cmb_Genre.SelectedItem as Genre;
            if (selectedGenre ==null)
            {
                MessageBox.Show("Please,select genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            book.GenreId = selectedGenre.Id;
            book.Genre = selectedGenre.Name;
            _books.Add(book);
            FillBookList();
            ClearInput();

        }

        private void FillBookList()
        {
            lb_Book.Items.Clear();
            lb_Book.Items.AddRange(_books.ToArray());
        }

        private void ClearInput()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
        private void cmb_FilterGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre selectedGenre = cmb_FilterGenre.SelectedItem as Genre;
            if (selectedGenre ==null)
            {
                FillBookList();
            }
            else
            {
                lb_Book.Items.Clear();
                foreach (var book in _books)
                {
                    if (selectedGenre.Id==book.GenreId)
                    {
                        lb_Book.Items.Add(book);
                    }
                }
            }
        }
    }
}
