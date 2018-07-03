using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.View;
using HomeWork.Entity;
using HomeWork.Controller;

namespace HomeWork
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            authorAdder.Click += addAuthor;
            categoryAdder.Click += addCategory;
            postAdder.Click += addPost;
            authorShower.Click += showAuth;
            categoryShower.Click += showCat;
            postShower.Click += showPost;
        }

        

        private void addAuthor(object sender, EventArgs e)
        {
            AuthorWindow authorWindow = new AuthorWindow();
            
            authorWindow.Show();
        }



        private void addCategory(object sender, EventArgs e)
        {
            CategoryWindow category = new CategoryWindow();
            
            category.Show();
        }


        private void addPost(object sender, EventArgs e)
        {
            PostWindow postWindow = new PostWindow();
            
            postWindow.Show();
        }


        private void showAuth(object sender, EventArgs e)
        {
            authorResultBox.Clear();
            AuthorController.Read(authorResultBox);
        }

        private void showCat(object sender, EventArgs e)
        {
            CategoryResultBox.Clear();
            CategoryController.Read(CategoryResultBox);
        }

        private void showPost(object sender, EventArgs e)
        {
            postBox.Clear();
            PostController.Read(postBox);
        }
    }
}
