namespace ClothingStoreApplication.Api.Core.Domain
{
    public class TrenchCoat : ClothingItem
    {
        public string BeltType { get; private set; }
        public string Lining { get; private set; }
        public string Closure { get; private set; }
        public string WeatherResistance { get; private set; }
        public bool HasEpaulets { get; private set; }

        private TrenchCoat() { }

        public class Builder
        {
            private readonly TrenchCoat _trenchCoat = new TrenchCoat();

            public Builder SetId(Guid id)
            {
                _trenchCoat.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _trenchCoat.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _trenchCoat.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _trenchCoat.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _trenchCoat.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _trenchCoat.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _trenchCoat.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _trenchCoat.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _trenchCoat.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _trenchCoat.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _trenchCoat.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _trenchCoat.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _trenchCoat.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _trenchCoat.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _trenchCoat.Gender = gender;
                return this;
            }

            public Builder SetBeltType(string beltType)
            {
                _trenchCoat.BeltType = beltType;
                return this;
            }

            public Builder SetLining(string lining)
            {
                _trenchCoat.Lining = lining;
                return this;
            }

            public Builder SetClosure(string closure)
            {
                _trenchCoat.Closure = closure;
                return this;
            }

            public Builder SetWeatherResistance(string weatherResistance)
            {
                _trenchCoat.WeatherResistance = weatherResistance;
                return this;
            }

            public Builder SetHasEpaulets(bool hasEpaulets)
            {
                _trenchCoat.HasEpaulets = hasEpaulets;
                return this;
            }

            // Build method to return the final TrenchCoat object
            public TrenchCoat Build()
            {
                if (string.IsNullOrWhiteSpace(_trenchCoat.Name)) throw new InvalidOperationException("Name is required");

                return _trenchCoat;
            }
        }
    }
}
