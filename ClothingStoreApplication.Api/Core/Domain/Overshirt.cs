namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Overshirt : ClothingItem
    {
        public string FitType { get; private set; }
        public string ClosureType { get; private set; }
        public string PocketConfiguration { get; private set; }
        public string Lining { get; private set; }
        public string CuffStyle { get; private set; }
        public string HemStyle { get; private set; }
        public string CollarStyle { get; private set; }

        private Overshirt() { }

        public class Builder
        {
            private readonly Overshirt _overshirt = new Overshirt();

            public Builder SetId(Guid id)
            {
                _overshirt.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _overshirt.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _overshirt.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _overshirt.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _overshirt.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _overshirt.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _overshirt.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _overshirt.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _overshirt.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _overshirt.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _overshirt.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _overshirt.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _overshirt.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _overshirt.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _overshirt.Gender = gender;
                return this;
            }

            public Builder SetFitType(string fitType)
            {
                _overshirt.FitType = fitType;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _overshirt.ClosureType = closureType;
                return this;
            }

            public Builder SetPocketConfiguration(string pocketConfiguration)
            {
                _overshirt.PocketConfiguration = pocketConfiguration;
                return this;
            }

            public Builder SetLining(string lining)
            {
                _overshirt.Lining = lining;
                return this;
            }

            public Builder SetCuffStyle(string cuffStyle)
            {
                _overshirt.CuffStyle = cuffStyle;
                return this;
            }

            public Builder SetHemStyle(string hemStyle)
            {
                _overshirt.HemStyle = hemStyle;
                return this;
            }

            public Builder SetCollarStyle(string collarStyle)
            {
                _overshirt.CollarStyle = collarStyle;
                return this;
            }

            // Build method to return the final Overshirt object
            public Overshirt Build()
            {
                if (string.IsNullOrWhiteSpace(_overshirt.Name)) throw new InvalidOperationException("Name is required");

                return _overshirt;
            }
        }
    }
}
