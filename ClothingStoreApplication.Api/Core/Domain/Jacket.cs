namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Jacket : ClothingItem
    {
        public string InsulationType { get; private set; }
        public string OuterShell { get; private set; }
        public string HoodStyle { get; private set; }
        public string PocketType { get; private set; }
        public string CuffStyle { get; private set; }

        private Jacket() { }

        public class Builder
        {
            private readonly Jacket _jacket = new Jacket();

            public Builder SetId(Guid id)
            {
                _jacket.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _jacket.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _jacket.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _jacket.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _jacket.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _jacket.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _jacket.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _jacket.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _jacket.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _jacket.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _jacket.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _jacket.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _jacket.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _jacket.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _jacket.Gender = gender;
                return this;
            }

            public Builder SetInsulationType(string insulationType)
            {
                _jacket.InsulationType = insulationType;
                return this;
            }

            public Builder SetOuterShell(string outerShell)
            {
                _jacket.OuterShell = outerShell;
                return this;
            }

            public Builder SetHoodStyle(string hoodStyle)
            {
                _jacket.HoodStyle = hoodStyle;
                return this;
            }

            public Builder SetPocketType(string pocketType)
            {
                _jacket.PocketType = pocketType;
                return this;
            }

            public Builder SetCuffStyle(string cuffStyle)
            {
                _jacket.CuffStyle = cuffStyle;
                return this;
            }

            // Build method to return the final Jacket object
            public Jacket Build()
            {
                if (string.IsNullOrWhiteSpace(_jacket.Name)) throw new InvalidOperationException("Name is required");

                return _jacket;
            }
        }
    }
}
