using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdUser { get; set; }

        public User? User { get; set; }
    }
}
