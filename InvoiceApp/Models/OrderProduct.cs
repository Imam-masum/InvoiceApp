using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApp.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("CustomerOrder")]
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}
