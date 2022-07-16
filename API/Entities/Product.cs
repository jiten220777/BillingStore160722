namespace API.Entities
{
    public class Product
    {
   
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string HSNCode { get; set; }
        public int QuantityInStock { get; set; }
        public string Unit { get; set; }
        public long PurchaseRate { get; set; }
        public long SaleRate { get; set; }
        public long CGST { get; set; }
        public long SGST { get; set; }
        public long IGST { get; set; }
        public int ReorderLevel { get; set; }
        public string ProductPictureUrl { get; set; }

    }
}