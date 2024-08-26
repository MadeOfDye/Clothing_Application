
namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Accessory : ClothingItem
    {
        public string Type { get; private set; }
        public bool IsAdjustableSize { get; private set;}
        public string FunctionalFeatures { get; private set; }

        private Accessory() { }

        public class Builder
        {
            private readonly Accessory _accessory = new Accessory();

            public Builder SetId(Guid id)
            {
                _accessory.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _accessory.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _accessory.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _accessory.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _accessory.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price) 
            {
                _accessory.Price = price;
                return this;
            }

            public Builder SetDiscount(bool discount)
            {
                _accessory.IsDiscount = discount;
                return this;
            }

            public Builder SetDiscountAmount(double  discountAmount)
            {
                _accessory.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetComposition(string composition)
            {
                _accessory.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _accessory.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _accessory.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _accessory.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _accessory.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _accessory.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _accessory.Gender = gender;
                return this;
            }

            public Builder SetType(string type) 
            { 
                _accessory.Type = type;
                return this;
            }

            public Builder setIsAdjustableSize(bool IsAdjustableSize)
            {
                _accessory.IsAdjustableSize = IsAdjustableSize;
                return this;
            }

            public Builder setFunctionalFeatures(string functionalFeatures)
            {
                _accessory.FunctionalFeatures = functionalFeatures;
                return this;
            }

            public Accessory Build()
            {
                //Validation Logic

                return _accessory;
            }

        }

    }
}
