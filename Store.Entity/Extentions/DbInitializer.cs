using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Entity.Extentions
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
