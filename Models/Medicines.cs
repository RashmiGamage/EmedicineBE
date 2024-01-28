namespace EmedicineBE.Models
{
    public class Medicines
    {
        public int MedicinID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime ExDate { get; set;}
        public string ImageUrl { get; set;}
        public int Status { get; set;}
    }
}
