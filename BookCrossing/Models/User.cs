using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Models
{
    class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public DateTime RegistrationDate {  get; set; }

        public int IdRole { get; set; }

        public int IdReceiver { get; set; }

        public int IdSender { get; set; }

        [ForeignKey(nameof(IdRole))]
        public Role? Role { get; set; }

        public User? Receiver {  get; set; }

        public User? Sender { get; set; }
    }
}
