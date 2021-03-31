using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldingMigrationHometask
{
    public partial class Author
    {
        public Author()
        {
            Articles = new HashSet<Article>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public bool IsPopular { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
