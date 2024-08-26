namespace ClothingStoreApplication.Api.Core.Domain
{
    public class RunningShoes : ClothingItem
    {
        public string ShoeWeight { get; private set; }
        public string DropHeight { get; private set; }
        public string CushioningLevel { get; private set; }
        public string UpperMaterial { get; private set; }
        public string Breathability { get; private set; }
        public string TreadType { get; private set; }
        public string StabilityFeatures { get; private set; }
        public string HeelCounter { get; private set; }
        public string LacingSystem { get; private set; }

        private RunningShoes() { }

        public class Builder
        {
            private readonly RunningShoes _runningShoes = new RunningShoes();

            public Builder SetId(Guid id)
            {
                _runningShoes.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _runningShoes.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _runningShoes.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _runningShoes.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _runningShoes.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _runningShoes.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _runningShoes.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _runningShoes.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _runningShoes.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _runningShoes.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _runningShoes.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _runningShoes.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _runningShoes.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _runningShoes.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _runningShoes.Gender = gender;
                return this;
            }

            public Builder SetShoeWeight(string shoeWeight)
            {
                _runningShoes.ShoeWeight = shoeWeight;
                return this;
            }

            public Builder SetDropHeight(string dropHeight)
            {
                _runningShoes.DropHeight = dropHeight;
                return this;
            }

            public Builder SetCushioningLevel(string cushioningLevel)
            {
                _runningShoes.CushioningLevel = cushioningLevel;
                return this;
            }

            public Builder SetUpperMaterial(string upperMaterial)
            {
                _runningShoes.UpperMaterial = upperMaterial;
                return this;
            }

            public Builder SetBreathability(string breathability)
            {
                _runningShoes.Breathability = breathability;
                return this;
            }

            public Builder SetTreadType(string treadType)
            {
                _runningShoes.TreadType = treadType;
                return this;
            }

            public Builder SetStabilityFeatures(string stabilityFeatures)
            {
                _runningShoes.StabilityFeatures = stabilityFeatures;
                return this;
            }

            public Builder SetHeelCounter(string heelCounter)
            {
                _runningShoes.HeelCounter = heelCounter;
                return this;
            }

            public Builder SetLacingSystem(string lacingSystem)
            {
                _runningShoes.LacingSystem = lacingSystem;
                return this;
            }

            // Build method to return the final RunningShoes object
            public RunningShoes Build()
            {
                if (string.IsNullOrWhiteSpace(_runningShoes.Name)) throw new InvalidOperationException("Name is required");

                return _runningShoes;
            }
        }
    }
}
