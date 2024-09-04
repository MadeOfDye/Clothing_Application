namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Jeans : ClothingItem
    {
        public string DenimWeight { get; private set; }
        public string WashType { get; private set; }
        public bool Stretch { get; private set; }
        public bool Fading { get; private set; }
        public string CutType { get; private set; }

        private Jeans() { }

        public class Builder
        {
            private readonly Jeans _jeans = new Jeans();

            public Builder SetId(Guid id)
            {
                _jeans.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _jeans.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _jeans.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _jeans.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _jeans.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _jeans.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _jeans.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _jeans.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _jeans.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _jeans.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _jeans.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _jeans.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _jeans.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _jeans.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _jeans.Gender = gender;
                return this;
            }

            public Builder SetDenimWeight(string denimWeight)
            {
                _jeans.DenimWeight = denimWeight;
                return this;
            }

            public Builder SetWashType(string washType)
            {
                _jeans.WashType = washType;
                return this;
            }

            public Builder SetStretch(bool stretch)
            {
                _jeans.Stretch = stretch;
                return this;
            }

            public Builder SetFading(bool fading)
            {
                _jeans.Fading = fading;
                return this;
            }

            public Builder SetCutType(string cutType)
            {
                _jeans.CutType = cutType;
                return this;
            }

            // Build method to return the final Jeans object
            public Jeans Build()
            {
                if (string.IsNullOrWhiteSpace(_jeans.Name)) throw new InvalidOperationException("Name is required");

                return _jeans;
            }
        }
    }
}
