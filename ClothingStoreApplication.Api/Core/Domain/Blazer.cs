namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Blazer : ClothingItem
    {
        public string LiningMaterial { get; private set; }
        public string ButtonStyle { get; private set; }
        public string VentStyle { get; private set; }
        public string Lapels { get; private set; }
        public string Padding { get; private set; }

        private Blazer() { }

        public class Builder
        {
            private readonly Blazer _blazer = new Blazer();

            public Builder SetId(Guid id)
            {
                _blazer.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _blazer.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _blazer.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _blazer.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _blazer.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _blazer.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _blazer.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _blazer.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _blazer.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _blazer.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _blazer.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _blazer.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _blazer.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _blazer.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _blazer.Gender = gender;
                return this;
            }

            public Builder SetLiningMaterial(string liningMaterial)
            {
                _blazer.LiningMaterial = liningMaterial;
                return this;
            }

            public Builder SetButtonStyle(string buttonStyle)
            {
                _blazer.ButtonStyle = buttonStyle;
                return this;
            }

            public Builder SetVentStyle(string ventStyle)
            {
                _blazer.VentStyle = ventStyle;
                return this;
            }

            public Builder SetLapels(string lapels)
            {
                _blazer.Lapels = lapels;
                return this;
            }

            public Builder SetPadding(string padding)
            {
                _blazer.Padding = padding;
                return this;
            }

            // Build method to return the final Blazer object
            public Blazer Build()
            {
                if (string.IsNullOrWhiteSpace(_blazer.Name)) throw new InvalidOperationException("Name is required");

                return _blazer;
            }
        }
    }
}
