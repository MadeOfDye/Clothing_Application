namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Skirt : ClothingItem
    {
        public string SkirtLength { get; private set; }
        public string WaistStyle { get; private set; }
        public string SkirtShape { get; private set; }
        public string Closure { get; private set; }
        public string Slit { get; private set; }

        private Skirt() { }

        public class Builder
        {
            private readonly Skirt _skirt = new Skirt();

            public Builder SetId(Guid id)
            {
                _skirt.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _skirt.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _skirt.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _skirt.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _skirt.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _skirt.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _skirt.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _skirt.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _skirt.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _skirt.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _skirt.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _skirt.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _skirt.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _skirt.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _skirt.Gender = gender;
                return this;
            }

            public Builder SetSkirtLength(string skirtLength)
            {
                _skirt.SkirtLength = skirtLength;
                return this;
            }

            public Builder SetWaistStyle(string waistStyle)
            {
                _skirt.WaistStyle = waistStyle;
                return this;
            }

            public Builder SetSkirtShape(string skirtShape)
            {
                _skirt.SkirtShape = skirtShape;
                return this;
            }

            public Builder SetClosure(string closure)
            {
                _skirt.Closure = closure;
                return this;
            }

            public Builder SetSlit(string slit)
            {
                _skirt.Slit = slit;
                return this;
            }

            // Build method to return the final Skirt object
            public Skirt Build()
            {
                if (string.IsNullOrWhiteSpace(_skirt.Name)) throw new InvalidOperationException("Name is required");

                return _skirt;
            }
        }
    }
}
