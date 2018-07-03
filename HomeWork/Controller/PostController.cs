using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Entity;
using HomeWork.Model;
using System.Windows.Forms;

namespace HomeWork.Controller
{
    class PostController
    {
        public static void Create(string postName , DateTime postPublishDate , int postReadCount , int selectedAutId , int selectedCutId)
        {
            Post post = new Post();
            post.Id = Db.postId;
            post.Name = postName;
            post.PublishDate = postPublishDate;
            post.ReadCount = postReadCount;
            post.AuthorId = selectedAutId;
            post.CategoryId = selectedCutId;
            Db.postId++;
            Db.posts.Add(post);
        }

        public static void Read(RichTextBox s)
        {
            var Authname = string.Empty;
            var catName = string.Empty;

            foreach (var item in Db.posts)
            {
                foreach (var authors in Db.authors)
                {
                    if (item.AuthorId == authors.Id)
                    {
                        Authname = authors.Name;
                    }
                }

                foreach (var categories in Db.categories)
                {
                    if (categories.Id == item.Id)
                    {
                        catName = categories.Name;
                    }
                }

                var btn = new Button();
                btn.Name = "read";
                btn.Width = 120;
                btn.Height = 50;
                btn.Location = new System.Drawing.Point(230);
                btn.Text = "Read Post";
                Main main = new Main();
                s.Controls.Add(btn);

                s.Text += item.Id + ". " + item.Name + " " + item.PublishDate.ToShortDateString() + " " + item.ReadCount + " " + Authname + " " + catName + "\r\n";
            }
        }
    }
}
