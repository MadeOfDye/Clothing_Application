namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Shorts : ClothingItem
    {
        public string Length { get; private set; }
        public string Fit { get; private set; }
        public string Pockets { get; private set; }
        public string WaistbandStyle { get; private set; }
        public string FabricType { get; private set; }

        private Shorts() { }

        public class Builder
        {
            private readonly Shorts _shorts = new Shorts();

            public Builder SetId(Guid id)
            {
                _shorts.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _shorts.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _shorts.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _shorts.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _shorts.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _shorts.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _shorts.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _shorts.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _shorts.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _shorts.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _shorts.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _shorts.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _shorts.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _shorts.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _shorts.Gender = gender;
                return this;
            }

            public Builder SetLength(string length)
            {
                _shorts.Length = length;
                return this;
            }

            public Builder SetFit(string fit)
            {
                _shorts.Fit = fit;
                return this;
            }

            public Builder SetPockets(string pockets)
            {
                _shorts.Pockets = pockets;
                return this;
            }

            public Builder SetWaistbandStyle(string waistbandStyle)
            {
                _shorts.WaistbandStyle = waistbandStyle;
                return this;
            }

            public Builder SetFabricType(string fabricType)
            {
                _shorts.FabricType = fabricType;
                return this;
            }

            // Build method to return the final Shorts object
            public Shorts Build()
            {
                if (string.IsNullOrWhiteSpace(_shorts.Name)) throw new InvalidOperationException("Name is required");

                return _shorts;
            }
        }
    }
}
