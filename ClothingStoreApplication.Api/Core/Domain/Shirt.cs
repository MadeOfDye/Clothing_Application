﻿namespace ClothingStoreApplication.Api.Core.Domain
{
    public class Shirt : ClothingItem
    {
        public string Cut { get; private set; }
        public string SleeveLength { get; private set; }
        public string CollarStyle { get; private set; }
        public string CuffStyle { get; private set; }
        public string PocketType { get; private set; }

        // Private constructor for the builder pattern
        private Shirt() { }

        public class Builder
        {
            private readonly Shirt _shirt = new Shirt();

            public Builder SetId(Guid id)
            {
                _shirt.Id = id;
                return this;
            }

            public Builder SetName(string name)
            {
                _shirt.Name = name;
                return this;
            }

            public Builder SetDescription(string description)
            {
                _shirt.Description = description;
                return this;
            }

            public Builder SetColor(string color)
            {
                _shirt.Color = color;
                return this;
            }

            public Builder SetMaterial(string material)
            {
                _shirt.Material = material;
                return this;
            }

            public Builder SetPrice(decimal price)
            {
                _shirt.Price = price;
                return this;
            }

            public Builder SetIsDiscount(bool isDiscount)
            {
                _shirt.IsDiscount = isDiscount;
                return this;
            }

            public Builder SetDiscountAmount(double discountAmount)
            {
                _shirt.DiscountAmount = discountAmount;
                return this;
            }

            public Builder SetMaterialComposition(string composition)
            {
                _shirt.MaterialComposition = composition;
                return this;
            }

            public Builder SetSize(string size)
            {
                _shirt.Size = size;
                return this;
            }

            public Builder SetNewArrival(bool newArrival)
            {
                _shirt.IsNewArrival = newArrival;
                return this;
            }

            public Builder SetIsBestSeller(bool isBestSeller)
            {
                _shirt.IsBestSeller = isBestSeller;
                return this;
            }

            public Builder SetCollection(string collection)
            {
                _shirt.Collection = collection;
                return this;
            }

            public Builder SetStyle(string style)
            {
                _shirt.Style = style;
                return this;
            }

            public Builder setGender(string gender)
            {
                _shirt.Gender = gender;
                return this;
            }

            public Builder SetCut(string cut)
            {
                _shirt.Cut = cut;
                return this;
            }

            public Builder SetSleeveLength(string sleeveLength)
            {
                _shirt.SleeveLength = sleeveLength;
                return this;
            }

            public Builder SetCollarStyle(string collarStyle)
            {
                _shirt.CollarStyle = collarStyle;
                return this;
            }

            public Builder SetCuffStyle(string cuffStyle)
            {
                _shirt.CuffStyle = cuffStyle;
                return this;
            }

            public Builder SetPocketType(string pocketType)
            {
                _shirt.PocketType = pocketType;
                return this;
            }



            // Build method to return the final Shirt object
            public Shirt Build()
            {
                // Validation logic (optional)
                if (string.IsNullOrWhiteSpace(_shirt.Name)) throw new InvalidOperationException("Name is required");

                return _shirt;
            }

        }
    }
}
