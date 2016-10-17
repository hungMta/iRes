using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modal.Entities
{
    class Table
    {
        public int Id { get; set; } 
        public string Status { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }

        public Table() { }

        public Table(int id, string status, int orderId, int bookId)
        {
            this.Id = id;
            this.Status = status;
            this.OrderId = orderId;
            this.BookId = bookId;
        }

    }
}
