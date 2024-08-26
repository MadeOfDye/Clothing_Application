namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Bodysuit : ClothingItem
    {
        public string NecklineStyle { get; private set; }
        public string SleeveLength { get; private set; }
        public string BottomStyle { get; private set; }
        public string ClosureType { get; private set; }
        public string StretchLevel { get; private set; }
        public string SupportFeatures { get; private set; }
        public string FabricTransparency { get; private set; }
        public string BackDesign { get; private set; }

        private Bodysuit() { }

        public class Builder
        {
            private readonly Bodysuit _bodysuit = new Bodysuit();

            public Builder SetId(Guid id)
            {
                _bodysuit.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _bodysuit.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _bodysuit.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _bodysuit.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _bodysuit.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _bodysuit.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _bodysuit.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _bodysuit.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _bodysuit.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _bodysuit.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _bodysuit.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _bodysuit.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _bodysuit.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _bodysuit.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _bodysuit.Gender = gender;
                return this;
            }

            public Builder SetNecklineStyle(string necklineStyle)
            {
                _bodysuit.NecklineStyle = necklineStyle;
                return this;
            }

            public Builder SetSleeveLength(string sleeveLength)
            {
                _bodysuit.SleeveLength = sleeveLength;
                return this;
            }

            public Builder SetBottomStyle(string bottomStyle)
            {
                _bodysuit.BottomStyle = bottomStyle;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _bodysuit.ClosureType = closureType;
                return this;
            }

            public Builder SetStretchLevel(string stretchLevel)
            {
                _bodysuit.StretchLevel = stretchLevel;
                return this;
            }

            public Builder SetSupportFeatures(string supportFeatures)
            {
                _bodysuit.SupportFeatures = supportFeatures;
                return this;
            }

            public Builder SetFabricTransparency(string fabricTransparency)
            {
                _bodysuit.FabricTransparency = fabricTransparency;
                return this;
            }

            public Builder SetBackDesign(string backDesign)
            {
                _bodysuit.BackDesign = backDesign;
                return this;
            }

            // Build method to return the final Bodysuit object
            public Bodysuit Build()
            {
                if (string.IsNullOrWhiteSpace(_bodysuit.Name)) throw new InvalidOperationException("Name is required");

                return _bodysuit;
            }
        }
    }
}
