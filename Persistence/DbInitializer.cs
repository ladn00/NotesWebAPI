using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    internal class DbInitializer
    {
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
