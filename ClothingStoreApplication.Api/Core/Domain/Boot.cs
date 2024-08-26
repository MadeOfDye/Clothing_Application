namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Boot : ClothingItem
    {
        public string ToeShape { get; private set; }
        public string HeelHeight { get; private set; }
        public string ClosureType { get; private set; }
        public string ShaftHeight { get; private set; }
        public string SoleMaterial { get; private set; }
        public string BootStyle { get; private set; }
        public string LiningMaterial { get; private set; }
        public string OutsoleFeatures { get; private set; }
        public bool IsWaterResistant { get; private set; }

        private Boot() { }

        public class Builder
        {
            private readonly Boot _boot = new Boot();

            public Builder SetId(Guid id)
            {
                _boot.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _boot.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _boot.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _boot.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _boot.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _boot.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _boot.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _boot.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _boot.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _boot.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _boot.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _boot.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _boot.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _boot.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _boot.Gender = gender;
                return this;
            }

            public Builder SetToeShape(string toeShape)
            {
                _boot.ToeShape = toeShape;
                return this;
            }

            public Builder SetHeelHeight(string heelHeight)
            {
                _boot.HeelHeight = heelHeight;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _boot.ClosureType = closureType;
                return this;
            }

            public Builder SetShaftHeight(string shaftHeight)
            {
                _boot.ShaftHeight = shaftHeight;
                return this;
            }

            public Builder SetSoleMaterial(string soleMaterial)
            {
                _boot.SoleMaterial = soleMaterial;
                return this;
            }

            public Builder SetBootStyle(string bootStyle)
            {
                _boot.BootStyle = bootStyle;
                return this;
            }

            public Builder SetLiningMaterial(string liningMaterial)
            {
                _boot.LiningMaterial = liningMaterial;
                return this;
            }

            public Builder SetOutsoleFeatures(string outsoleFeatures)
            {
                _boot.OutsoleFeatures = outsoleFeatures;
                return this;
            }

            public Builder SetIsWaterResistant(bool isWaterResistant)
            {
                _boot.IsWaterResistant = isWaterResistant;
                return this;
            }

            // Build method to return the final Boot object
            public Boot Build()
            {
                if (string.IsNullOrWhiteSpace(_boot.Name)) throw new InvalidOperationException("Name is required");

                return _boot;
            }
        }
    }
}
