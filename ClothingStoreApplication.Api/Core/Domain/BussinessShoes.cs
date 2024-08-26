namespace ClothingStoreApplication.Api.Core.Domain
{
    public class BussinessShoes : ClothingItem
    {
        public string Type { get; private set; }
        public string LeatherType { get; private set; }
        public string Lining {  get; private set; }
        public string ToeStyle { get; private set; }

        private BussinessShoes() { }
        
        public class Builder
        {
            private readonly BussinessShoes _bussinessShoes = new BussinessShoes();

            public Builder SetId(Guid id)
            {
                _bussinessShoes.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _bussinessShoes.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _bussinessShoes.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _bussinessShoes.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _bussinessShoes.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _bussinessShoes.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _bussinessShoes.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _bussinessShoes.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _bussinessShoes.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _bussinessShoes.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _bussinessShoes.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _bussinessShoes.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _bussinessShoes.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _bussinessShoes.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _bussinessShoes.Gender = gender;
                return this;
            }

            public Builder SetType(string type)
            {
                _bussinessShoes.Type = type;
                return this;
            }

            public Builder SetTLeatherType(string leatherType)
            {
                _bussinessShoes.LeatherType = leatherType;
                return this;
            }

            public Builder SetLining(string lining)
            {
                _bussinessShoes.Lining = lining;
                return this;
            }

            public Builder SetToeStyle(string toeStyle)
            {
                _bussinessShoes.ToeStyle = toeStyle;
                return this;
            }

            public BussinessShoes Build()
            {
                //TODO: Validation Logic
                return _bussinessShoes;
            }
        }

    }
}
