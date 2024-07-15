using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18._2.Models
{
    internal class Key
    {
        // Id(int)
        // Cod de acces : Guid unic.

        public int Id { get; set; }
        public Guid KeyCode { get; set; }
        public int? CarId { get; set; }
    }
}
