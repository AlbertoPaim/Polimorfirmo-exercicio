
namespace Polimorfirmo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }
        public ImportedProduct(double customsFee, string name, double price) : base(name, price) 
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {

            return  Price + CustomsFee; 
        }

        public override string PriceTage()
        {
            return $"{Name} $ {TotalPrice()} (Cusoms fee): $ {CustomsFee})";
        }
    }
}
