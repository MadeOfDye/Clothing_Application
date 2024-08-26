namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Backpack : ClothingItem
    {

        public string Capacity { get; private set; }
        public string StrapType { get; private set; }
        public string Compartments { get; private set; }
        public string ClosureType { get; private set; }

        public Backpack() { }

        public class Builder
        {
            private readonly Backpack _backpack = new Backpack();

            public Builder SetId(Guid id)
            {
                _backpack.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _backpack.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _backpack.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _backpack.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _backpack.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price) 
            {
                _backpack.Price = price;
                return this;
            }

            public Builder SetDiscount(bool discount)
            {
                _backpack.IsDiscount = discount;
                return this;
            }

            public Builder SetDiscountAmount(double  discountAmount)
            {
                _backpack.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetComposition(string composition)
            {
                _backpack.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _backpack.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _backpack.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _backpack.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _backpack.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _backpack.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _backpack.Gender = gender;
                return this;
            }

            public Builder SetCapacity(string capacity)
            {
                _backpack.Capacity = capacity;
                return this;
            }

            public Builder SetStrapType(string strapType)
            {
                _backpack.StrapType = strapType;
                return this;
            }

            public Builder SetCompartments(string compartments)
            {
                _backpack.Compartments = compartments;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _backpack.ClosureType = closureType;
                return this;
            }

            public Backpack Build()
            {
                //Validatioin logic

                return _backpack;
            }
        }
    }
}
