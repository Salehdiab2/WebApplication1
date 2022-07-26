using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ArraySort
{
    public class SortedArray
    {
        [Key]
        public int Id { get; set; }
        public int preSorted_position { get; set; }
        public int sorted_position { get; set; }

        public int number { get; set; }
    }
}
