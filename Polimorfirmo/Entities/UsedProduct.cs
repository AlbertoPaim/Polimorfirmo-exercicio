
namespace Polimorfirmo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        public UsedProduct()
        {
        }
        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price) 
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTage()
        {
            return $"{Name} (used) $ {Price} (Manufactury date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}

