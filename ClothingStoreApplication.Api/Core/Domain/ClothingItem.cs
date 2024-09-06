namespace ClothingStoreApplication.Api.Core.Domain
{
    public abstract class ClothingItem
    {
        public Guid Id { get; protected set; } // EF requires public or protected setters for mapping
        public string Name { get; protected set; }
        public string Color { get; protected set; }
        public string Description { get; protected set; }
        public string Material { get; protected set; }
        public decimal Price { get; protected set; }
        public bool IsDiscount { get; protected set; }
        public double DiscountAmount { get; protected set; }
        public string MaterialComposition { get; protected set; }
        public string Size { get; protected set; }
        public bool IsNewArrival { get; protected set; }
        public bool IsBestSeller { get; protected set; }
        public string Collection { get; protected set; }
        public string Style { get; protected set; }
        public string Gender {  get; protected set; }

        // Protected constructor for EF compatibility
        protected ClothingItem() { }

        // Domain logic to calculate final price after discount
        public decimal GetFinalPrice()
        {
            return IsDiscount ? Price - (decimal)DiscountAmount : Price;
        }
    }
}
