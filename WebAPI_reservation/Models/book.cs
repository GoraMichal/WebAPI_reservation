using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_reservation.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string CustomerName { get; set; } 
        public string Room { get; set; }
    }
}
