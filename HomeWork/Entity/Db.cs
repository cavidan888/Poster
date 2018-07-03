using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Model;

namespace HomeWork.Entity
{
    class Db
    {
        public static int authorId = 0;
        public static int categoryId = 1;
        public static int postId = 1;

        public static List<Author> authors = new List<Author>();
        public static List<Category> categories = new List<Category>();
        public static List<Post> posts = new List<Post>();
    }
}
