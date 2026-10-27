using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public DateTime PublicationYear {  get; set; }

        public string ShortDescription { get; set; }

        public byte Cover { get; set; }

        public string Status { get; set; }

        public string Location { get; set; }

        public DateTime DateAdded { get; set; }

        public int IdUser { get; set; }

        [ForeignKey(nameof(IdUser))]
        public User? User { get; set; }
    }
}
