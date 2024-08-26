namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Coat : ClothingItem
    {
        public string CoatLength { get; private set; }
        public string FitType { get; private set; }
        public string ClosureType { get; private set; }
        public string LiningMaterial { get; private set; }
        public string SleeveLength { get; private set; }
        public string PocketStyle { get; private set; }
        public string CollarStyle { get; private set; }
        public bool IsHooded { get; private set; }
        public bool IsWaterResistant { get; private set; }
        public string InsulationType { get; private set; }

        private Coat() { }

        public class Builder
        {
            private readonly Coat _coat = new Coat();

            public Builder SetId(Guid id)
            {
                _coat.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _coat.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _coat.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _coat.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _coat.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _coat.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _coat.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _coat.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _coat.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _coat.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _coat.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _coat.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _coat.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _coat.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _coat.Gender = gender;
                return this;
            }

            public Builder SetCoatLength(string coatLength)
            {
                _coat.CoatLength = coatLength;
                return this;
            }

            public Builder SetFitType(string fitType)
            {
                _coat.FitType = fitType;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _coat.ClosureType = closureType;
                return this;
            }

            public Builder SetLiningMaterial(string liningMaterial)
            {
                _coat.LiningMaterial = liningMaterial;
                return this;
            }

            public Builder SetSleeveLength(string sleeveLength)
            {
                _coat.SleeveLength = sleeveLength;
                return this;
            }

            public Builder SetPocketStyle(string pocketStyle)
            {
                _coat.PocketStyle = pocketStyle;
                return this;
            }

            public Builder SetCollarStyle(string collarStyle)
            {
                _coat.CollarStyle = collarStyle;
                return this;
            }

            public Builder SetIsHooded(bool isHooded)
            {
                _coat.IsHooded = isHooded;
                return this;
            }

            public Builder SetIsWaterResistant(bool isWaterResistant)
            {
                _coat.IsWaterResistant = isWaterResistant;
                return this;
            }

            public Builder SetInsulationType(string insulationType)
            {
                _coat.InsulationType = insulationType;
                return this;
            }

            // Build method to return the final Coat object
            public Coat Build()
            {
                if (string.IsNullOrWhiteSpace(_coat.Name)) throw new InvalidOperationException("Name is required");

                return _coat;
            }
        }
    }
}
