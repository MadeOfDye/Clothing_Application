namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Trainer : ClothingItem
    {
        public string UsageType { get; private set; }
        public string Cushioning { get; private set; }
        public string Breathability { get; private set; }
        public string HeelDrop { get; private set; }
        public string StabilityFeatures { get; private set; }

        private Trainer() { }

        public class Builder
        {
            private readonly Trainer _trainer = new Trainer();

            public Builder SetId(Guid id)
            {
                _trainer.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _trainer.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _trainer.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _trainer.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _trainer.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _trainer.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _trainer.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _trainer.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _trainer.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _trainer.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _trainer.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _trainer.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _trainer.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _trainer.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _trainer.Gender = gender;
                return this;
            }

            public Builder SetUsageType(string usageType)
            {
                _trainer.UsageType = usageType;
                return this;
            }

            public Builder SetCushioning(string cushioning)
            {
                _trainer.Cushioning = cushioning;
                return this;
            }

            public Builder SetBreathability(string breathability)
            {
                _trainer.Breathability = breathability;
                return this;
            }

            public Builder SetHeelDrop(string heelDrop)
            {
                _trainer.HeelDrop = heelDrop;
                return this;
            }

            public Builder SetStabilityFeatures(string stabilityFeatures)
            {
                _trainer.StabilityFeatures = stabilityFeatures;
                return this;
            }

            // Build method to return the final Trainer object
            public Trainer Build()
            {
                if (string.IsNullOrWhiteSpace(_trainer.Name)) throw new InvalidOperationException("Name is required");

                return _trainer;
            }
        }
    }
}
