using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class Exchange_Request
    {
        public int ID { get; set; }

        public string Message { get; set; }

        public string Status { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public int IdBook { get; set; }

        public int IdInitiator { get; set; }

        public int IdRecipient { get; set; }

        public int IdNotification { get; set; }

        public int IdExchangeHistory { get; set; }

        [ForeignKey(nameof(IdBook))]
        public Book? Book { get; set; }

        [ForeignKey(nameof(IdInitiator))]
        public User? Initiator { get; set; }

        [ForeignKey(nameof(IdRecipient))]
        public User? Recipient { get; set; }

        public Notification? Notification { get; set; }

        public Exchange_History? Exchange_History { get; set; }
    }
}
