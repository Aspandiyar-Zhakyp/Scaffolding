using System;

namespace ScaffoldingMigrationHometask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MigrationHometaskContext())
            {
                context.Add(new Author
                {
                    Name = "Misha",
                    Age = 23,
                    Country = "Ukraine",
                    IsPopular = false
                });
                context.SaveChanges();
            };
        }
    }
}
