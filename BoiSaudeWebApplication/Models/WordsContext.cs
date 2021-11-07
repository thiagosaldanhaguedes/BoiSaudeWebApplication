using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoiSaudeWebApplication.Models
{
    public class WordsContext : DbContext
    {
        public WordsContext(DbContextOptions<WordsContext> options) : base(options)
        {

        }

        public DbSet<Words> Words { get; set; }
    }
}
