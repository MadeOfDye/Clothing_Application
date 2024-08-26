namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Dress : ClothingItem
    {
        public string DressLength { get; private set; }
        public string NecklineStyle { get; private set; }
        public string SleeveLength { get; private set; }
        public string FitType { get; private set; }
        public string HemStyle { get; private set; }
        public string WaistStyle { get; private set; }
        public string OccasionType { get; private set; }
        public bool IsLined { get; private set; }

        private Dress() { }

        public class Builder
        {
            private readonly Dress _dress = new Dress();

            public Builder SetId(Guid id)
            {
                _dress.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _dress.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _dress.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _dress.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _dress.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _dress.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _dress.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _dress.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _dress.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _dress.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _dress.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _dress.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _dress.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _dress.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _dress.Gender = gender;
                return this;
            }

            public Builder SetDressLength(string dressLength)
            {
                _dress.DressLength = dressLength;
                return this;
            }

            public Builder SetNecklineStyle(string necklineStyle)
            {
                _dress.NecklineStyle = necklineStyle;
                return this;
            }

            public Builder SetSleeveLength(string sleeveLength)
            {
                _dress.SleeveLength = sleeveLength;
                return this;
            }

            public Builder SetFitType(string fitType)
            {
                _dress.FitType = fitType;
                return this;
            }

            public Builder SetHemStyle(string hemStyle)
            {
                _dress.HemStyle = hemStyle;
                return this;
            }

            public Builder SetWaistStyle(string waistStyle)
            {
                _dress.WaistStyle = waistStyle;
                return this;
            }

            public Builder SetOccasionType(string occasionType)
            {
                _dress.OccasionType = occasionType;
                return this;
            }

            public Builder SetIsLined(bool isLined)
            {
                _dress.IsLined = isLined;
                return this;
            }

            // Build method to return the final Dress object
            public Dress Build()
            {
                if (string.IsNullOrWhiteSpace(_dress.Name)) throw new InvalidOperationException("Name is required");

                return _dress;
            }
        }
    }
}
