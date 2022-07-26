using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ArraySort
{
    public class ArrayPosition
    {
        [Key]
        public int Id { get; set; }
        public int position { get; set; }
        public int number { get; set; }
    }
}
