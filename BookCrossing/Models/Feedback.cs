using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class Feedback
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public DateTime CreationDate { get; set; }

        public int IdAuthor { get; set; }  

        public int IdRecipient { get; set; }

        [ForeignKey(nameof(IdAuthor))]
        public User? Author { get; set; }

        [ForeignKey(nameof(IdRecipient))]
        public User? Recepient { get; set; }
    }
}
