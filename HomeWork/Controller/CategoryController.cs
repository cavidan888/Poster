using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Model;
using HomeWork.Entity;
using System.Windows.Forms;


namespace HomeWork.Controller
{
    class CategoryController
    {
        public static void Create(string catName)
        {
            Category category = new Category();
            category.Id = Db.categoryId;
            category.Name = catName;
            Db.categoryId++;
            Db.categories.Add(category);
        }

        public static void Read(RichTextBox s)
        {
            foreach (var item in Db.categories)
            {
                s.Text += item.Id + ". " + item.Name + "\r\n";
            }
        }
    }
}
