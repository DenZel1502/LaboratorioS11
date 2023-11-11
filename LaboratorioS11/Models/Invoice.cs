using System.Security.AccessControl;

namespace LaboratorioS11.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public string DocumentNumber { get; set; }

        //Customers
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
