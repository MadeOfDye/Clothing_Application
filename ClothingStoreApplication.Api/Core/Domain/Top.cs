namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Top : ClothingItem
    {
        public string TopType { get; private set; }
        public string NecklineStyle { get; private set; }
        public string SleeveLength { get; private set; }
        public string FitType { get; private set; }
        public string HemStyle { get; private set; }
        public string FabricType { get; private set; }
        public string BackDesign { get; private set; }
        public string ClosureType { get; private set; }
        public string DecorativeDetails { get; private set; }
        public string Length { get; private set; }
        public string Layering { get; private set; }

        private Top() { }

        public class Builder
        {
            private readonly Top _tops = new Top();

            public Builder SetId(Guid id)
            {
                _tops.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _tops.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _tops.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _tops.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _tops.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _tops.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _tops.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _tops.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _tops.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _tops.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _tops.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _tops.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _tops.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _tops.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _tops.Gender = gender;
                return this;
            }

            public Builder SetTopType(string topType)
            {
                _tops.TopType = topType;
                return this;
            }

            public Builder SetNecklineStyle(string necklineStyle)
            {
                _tops.NecklineStyle = necklineStyle;
                return this;
            }

            public Builder SetSleeveLength(string sleeveLength)
            {
                _tops.SleeveLength = sleeveLength;
                return this;
            }

            public Builder SetFitType(string fitType)
            {
                _tops.FitType = fitType;
                return this;
            }

            public Builder SetHemStyle(string hemStyle)
            {
                _tops.HemStyle = hemStyle;
                return this;
            }

            public Builder SetFabricType(string fabricType)
            {
                _tops.FabricType = fabricType;
                return this;
            }

            public Builder SetBackDesign(string backDesign)
            {
                _tops.BackDesign = backDesign;
                return this;
            }

            public Builder SetClosureType(string closureType)
            {
                _tops.ClosureType = closureType;
                return this;
            }

            public Builder SetDecorativeDetails(string decorativeDetails)
            {
                _tops.DecorativeDetails = decorativeDetails;
                return this;
            }

            public Builder SetLength(string length)
            {
                _tops.Length = length;
                return this;
            }

            public Builder SetLayering(string layering)
            {
                _tops.Layering = layering;
                return this;
            }

            // Build method to return the final Tops object
            public Top Build()
            {
                if (string.IsNullOrWhiteSpace(_tops.Name)) throw new InvalidOperationException("Name is required");

                return _tops;
            }
        }
    }
}
