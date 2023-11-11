namespace LaboratorioS11.Models
{
    public class Detail
    {
        public int Id { get; set; }

        //Reomendación -> Agregar una llave de navegación con el Id y la llave foranea

        //Products
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //Invoices
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
