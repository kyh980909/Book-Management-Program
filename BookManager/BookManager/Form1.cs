using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";

            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) => {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();

            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
        }
    }
}
