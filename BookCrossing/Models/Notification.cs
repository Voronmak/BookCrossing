using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class Notification
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Text { get; set; }

        public bool IsRead { get; set; }

        public DateTime CreationDate { get; set; }

        public int IdUser { get; set; }

        public int IdRequest { get; set; }

        [ForeignKey(nameof(IdUser))]
        public User? User { get; set; }

        [ForeignKey(nameof(IdRequest))]
        public Exchange_Request? Request { get; set; }
    }
}
