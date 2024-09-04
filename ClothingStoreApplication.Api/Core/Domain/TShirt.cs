namespace ClothingStoreApplication.Api.Core.Domain
{
    public class TShirt : ClothingItem
    {
	/*- Label Type: Tagless, Tag, Heat-Transfer Label ??*/
		public string NecklineStyle {  get; private set; }
		public string Fit {  get; private set; }
		public string Hem {  get; private set; }
		public string SpecialFeatures { get; private set; }

		private TShirt() { }

		public class Builder
		{
			private readonly TShirt _tShirt = new TShirt();

            public Builder SetId(Guid id)
            {
                _tShirt.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _tShirt.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _tShirt.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _tShirt.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _tShirt.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _tShirt.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _tShirt.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _tShirt.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _tShirt.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _tShirt.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _tShirt.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _tShirt.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _tShirt.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _tShirt.Style = style;
                return this;
            }

            public Builder SetGender(string gender)
            {
                _tShirt.Gender = gender;
                return this;
            }

            /*public string NecklineStyle {  get; private set; }
		public string Fit {  get; private set; }
		public string Hem {  get; private set; }
		public string SpecialFeatures { get; private set; }*/

            public Builder SetNecklineStyle(string necklineStyle)
            {
                _tShirt.NecklineStyle = necklineStyle;
                return this;
            }

            public Builder SetFit(string fit)
            {
                _tShirt.Fit = fit;
                return this;
            }

            public Builder SetHem(string hem)
            {
                _tShirt.Hem = hem;
                return this;
            }

            public Builder SetSpecialFeatures(string specialFeatures)
            {
                _tShirt.SpecialFeatures = specialFeatures;
                return this;
            }

            public TShirt Build()
            {
                return _tShirt;
            }

        }

    }
}
