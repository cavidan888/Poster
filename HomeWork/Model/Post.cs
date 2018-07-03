using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Model
{
    class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public int ReadCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
