using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldingMigrationHometask
{
    public partial class Article
    {
        public Article()
        {
            Categories = new HashSet<Category>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
