namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Perfume : ClothingItem
    {
        public string FragranceFamily { get; private set; }
        public string TopNotes { get; private set; }
        public string MiddleNotes { get; private set; }
        public string BaseNotes { get; private set; }
        public string Concentration { get; private set; }

        private Perfume() { }

        public class Builder
        {
            private readonly Perfume _perfume = new Perfume();

            public Builder SetId(Guid id)
            {
                _perfume.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _perfume.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _perfume.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _perfume.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _perfume.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _perfume.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _perfume.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _perfume.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _perfume.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _perfume.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _perfume.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _perfume.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _perfume.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _perfume.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _perfume.Gender = gender;
                return this;
            }

            public Builder SetFragranceFamily(string fragranceFamily)
            {
                _perfume.FragranceFamily = fragranceFamily;
                return this;
            }

            public Builder SetTopNotes(string topNotes)
            {
                _perfume.TopNotes = topNotes;
                return this;
            }

            public Builder SetMiddleNotes(string middleNotes)
            {
                _perfume.MiddleNotes = middleNotes;
                return this;
            }

            public Builder SetBaseNotes(string baseNotes)
            {
                _perfume.BaseNotes = baseNotes;
                return this;
            }

            public Builder SetConcentration(string concentration)
            {
                _perfume.Concentration = concentration;
                return this;
            }

            // Build method to return the final Perfume object
            public Perfume Build()
            {
                if (string.IsNullOrWhiteSpace(_perfume.Name)) throw new InvalidOperationException("Name is required");

                return _perfume;
            }
        }
    }
}
