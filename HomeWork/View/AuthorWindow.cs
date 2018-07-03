using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Controller;

namespace HomeWork.View
{
    public partial class AuthorWindow : Form
    {
        public AuthorWindow()
        {
            InitializeComponent();

            addAuthor.Click += AddAuthor;
        }

        private void AddAuthor(object sender, EventArgs e)
        {
            var authorName = authName.Text;
            var authorSurName = authSurName.Text;
            AuthorController.Create(authorName, authorSurName);
            
        }
    }
}
