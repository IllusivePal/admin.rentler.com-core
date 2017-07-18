using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Article
    {
        public int ArticleId { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public bool IsDeleted { get; set; }

        public Blog Blog { get; set; }
        public User Author { get; set; }
    }
}
