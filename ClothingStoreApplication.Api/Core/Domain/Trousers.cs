namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Trousers : ClothingItem
    {
        public string WaistRise { get; private set; }
        public string LegStyle { get; private set; }
        public string ClosureType { get; private set; }
        public bool HasBeltLoops { get; private set; }
        public string PocketConfiguration { get; private set; }

        private Trousers() { }

        public class Builder
        {
            private readonly Trousers _trousers = new Trousers();

            public Builder SetId(Guid id)
            {
                _trousers.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _trousers.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _trousers.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _trousers.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _trousers.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _trousers.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _trousers.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _trousers.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _trousers.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _trousers.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _trousers.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _trousers.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _trousers.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _trousers.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _trousers.Gender = gender;
                return this;
            }

            public Builder SetWaistRise(string waistRise)
            {
                _trousers.WaistRise = waistRise;
                return this;
            }

            public Builder SetLegStyle(string legStyle)
            {
                _trousers.LegStyle = legStyle;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _trousers.ClosureType = closureType;
                return this;
            }

            public Builder SetHasBeltLoops(bool hasBeltLoops)
            {
                _trousers.HasBeltLoops = hasBeltLoops;
                return this;
            }

            public Builder SetPocketConfiguration(string pocketConfiguration)
            {
                _trousers.PocketConfiguration = pocketConfiguration;
                return this;
            }

            // Build method to return the final Trousers object
            public Trousers Build()
            {
                if (string.IsNullOrWhiteSpace(_trousers.Name)) throw new InvalidOperationException("Name is required");

                return _trousers;
            }
        }
    }
}
