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
    public partial class CategoryWindow : Form
    {
        public CategoryWindow()
        {
            InitializeComponent();

            addCat.Click += addCategory;
        }

        private void addCategory(object sender, EventArgs e)
        {
            var categoryName = catName.Text;
            CategoryController.Create(categoryName);
        }
    }
}
