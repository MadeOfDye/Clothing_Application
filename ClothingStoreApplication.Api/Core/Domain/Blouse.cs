namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Blouse : ClothingItem
    {
        public string NecklineStyle { get; private set; }
        public string SleeveStyle { get; private set; }
        public string Hemline { get; private set; }
        public string ClosureType { get; private set; }
        public string DecorativeDetails { get; private set; }

        private Blouse() { }

        public class Builder
        {
            private readonly Blouse _blouse = new Blouse();

            public Builder SetId(Guid id)
            {
                _blouse.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _blouse.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _blouse.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _blouse.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _blouse.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _blouse.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _blouse.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _blouse.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _blouse.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _blouse.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _blouse.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _blouse.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _blouse.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _blouse.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _blouse.Gender = gender;
                return this;
            }

            public Builder SetNecklineStyle(string necklineStyle)
            {
                _blouse.NecklineStyle = necklineStyle;
                return this;
            }

            public Builder SetSleeveStyle(string sleeveStyle)
            {
                _blouse.SleeveStyle = sleeveStyle;
                return this;
            }

            public Builder SetHemline(string hemline)
            {
                _blouse.Hemline = hemline;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _blouse.ClosureType = closureType;
                return this;
            }

            public Builder SetDecorativeDetails(string decorativeDetails)
            {
                _blouse.DecorativeDetails = decorativeDetails;
                return this;
            }

            // Build method to return the final Blouse object
            public Blouse Build()
            {
                if (string.IsNullOrWhiteSpace(_blouse.Name)) throw new InvalidOperationException("Name is required");

                return _blouse;
            }
        }
    }
}
