using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldingMigrationHometask
{
    public partial class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}
