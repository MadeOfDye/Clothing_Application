namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Skort : ClothingItem
    {
        public string SkortLength { get; private set; }
        public string WaistStyle { get; private set; }
        public string ClosureType { get; private set; }
        public string ShortsLining { get; private set; }
        public string DecorativeDetails { get; private set; }

        private Skort() { }

        public class Builder
        {
            private readonly Skort _skort = new Skort();

            public Builder SetId(Guid id)
            {
                _skort.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _skort.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _skort.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _skort.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _skort.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _skort.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _skort.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _skort.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _skort.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _skort.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _skort.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _skort.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _skort.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _skort.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _skort.Gender = gender;
                return this;
            }

            public Builder SetSkortLength(string skortLength)
            {
                _skort.SkortLength = skortLength;
                return this;
            }

            public Builder SetWaistStyle(string waistStyle)
            {
                _skort.WaistStyle = waistStyle;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _skort.ClosureType = closureType;
                return this;
            }

            public Builder SetShortsLining(string shortsLining)
            {
                _skort.ShortsLining = shortsLining;
                return this;
            }

            public Builder SetDecorativeDetails(string decorativeDetails)
            {
                _skort.DecorativeDetails = decorativeDetails;
                return this;
            }

            // Build method to return the final Skort object
            public Skort Build()
            {
                if (string.IsNullOrWhiteSpace(_skort.Name)) throw new InvalidOperationException("Name is required");

                return _skort;
            }
        }
    }
}
