namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Suit : ClothingItem
    {
        public string SuitType { get; private set; }
        public string Lapels { get; private set; }
        public string Fit { get; private set; }
        public string Vents { get; private set; }
        public string ButtonStyle { get; private set; }

        private Suit() { }

        public class Builder
        {
            private readonly Suit _suit = new Suit();

            public Builder SetId(Guid id)
            {
                _suit.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _suit.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _suit.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _suit.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _suit.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _suit.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _suit.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _suit.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _suit.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _suit.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _suit.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _suit.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _suit.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _suit.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _suit.Gender = gender;
                return this;
            }

            public Builder SetSuitType(string suitType)
            {
                _suit.SuitType = suitType;
                return this;
            }

            public Builder SetLapels(string lapels)
            {
                _suit.Lapels = lapels;
                return this;
            }

            public Builder SetFit(string fit)
            {
                _suit.Fit = fit;
                return this;
            }

            public Builder SetVents(string vents)
            {
                _suit.Vents = vents;
                return this;
            }

            public Builder SetButtonStyle(string buttonStyle)
            {
                _suit.ButtonStyle = buttonStyle;
                return this;
            }

            // Build method to return the final Suit object
            public Suit Build()
            {
                if (string.IsNullOrWhiteSpace(_suit.Name)) throw new InvalidOperationException("Name is required");

                return _suit;
            }
        }
    }
}
