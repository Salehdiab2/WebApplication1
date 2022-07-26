using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.ArraySort;

namespace WebApplication1.Models
{
    public class ArrayContext:DbContext
    {
        public ArrayContext(DbContextOptions options) : base(options) { }
        public DbSet<ArrayPosition> ArrayPosition { get; set; }
        public DbSet<SortedArray> SortedArray { get; set; }

    }
}
