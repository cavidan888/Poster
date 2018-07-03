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
    class AuthorController
    {
        public static void Create(string authorName, string authorEmail)
        {
            Author author = new Author();
            Db.authorId++;
            author.Name = authorName;
            author.Email = authorEmail;
            author.Id = Db.authorId;
            Db.authors.Add(author);

            System.Windows.Forms.MessageBox.Show(author.Id.ToString());
        }

        public static void Read(RichTextBox s)
        {
            foreach (var item in Db.authors)
            {
                Main main = new Main();
                s.Text += item.Id + ". " + item.Name + "-" + item.Email + "\r\n---------------------------- \r\n";

            }
        }
    }
}
