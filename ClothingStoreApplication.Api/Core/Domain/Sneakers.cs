namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Sneakers : ClothingItem
    {
        public string SoleType { get; private set; }
        public string ClosureType { get; private set; }
        public string ArchSupport { get; private set; }
        public string InsoleType { get; private set; }
        public string OutsoleGrip { get; private set; }

        private Sneakers() { }

        public class Builder
        {
            private readonly Sneakers _sneakers = new Sneakers();

            public Builder SetId(Guid id)
            {
                _sneakers.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _sneakers.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _sneakers.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _sneakers.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _sneakers.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _sneakers.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _sneakers.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _sneakers.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _sneakers.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _sneakers.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _sneakers.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _sneakers.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _sneakers.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _sneakers.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _sneakers.Gender = gender;
                return this;
            }

            public Builder SetSoleType(string soleType)
            {
                _sneakers.SoleType = soleType;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _sneakers.ClosureType = closureType;
                return this;
            }

            public Builder SetArchSupport(string archSupport)
            {
                _sneakers.ArchSupport = archSupport;
                return this;
            }

            public Builder SetInsoleType(string insoleType)
            {
                _sneakers.InsoleType = insoleType;
                return this;
            }

            public Builder SetOutsoleGrip(string outsoleGrip)
            {
                _sneakers.OutsoleGrip = outsoleGrip;
                return this;
            }

            // Build method to return the final Sneakers object
            public Sneakers Build()
            {
                if (string.IsNullOrWhiteSpace(_sneakers.Name)) throw new InvalidOperationException("Name is required");

                return _sneakers;
            }
        }
    }
}
