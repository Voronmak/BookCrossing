using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class Exchange_History
    {
        public int Id { get; set; }

        public DateTime CompletionDate { get; set; }

        public int IdRequest { get; set; }

        public int IdBook { get; set; }

        public int IdSender { get; set; }

        public int IdReceiver { get; set; }

        [ForeignKey(nameof(IdRequest))]
        public Exchange_Request? Request { get; set; }

        [ForeignKey(nameof(IdBook))]
        public Book? Book { get; set; }

        [ForeignKey(nameof(IdSender))]
        public User? Sender { get; set; }

        [ForeignKey(nameof(IdReceiver))]
        public User? Receiver { get; set; }
    }
}
