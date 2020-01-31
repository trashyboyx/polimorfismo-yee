using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo_yee.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public sealed override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + " (Customs fee: $ " + CustomsFee + ")";
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
