using System;
using System.Collections.Generic;

namespace HitRave.Models
{
    /// <summary>
    /// Model to represent a product to be sold
    /// </summary>
    public class ProductsModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProductsModel"/> is published.
        /// </summary>
        /// <value>
        ///   <c>true</c> if published; otherwise, <c>false</c>.
        /// </value>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets the average rating of the product.
        /// </summary>
        /// <value>
        /// The average rating.
        /// </value>
        public float AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the rating count.
        /// </summary>
        /// <value>
        /// The rating count.
        /// </value>
        public int RatingCount { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }


        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        /// <value>
        /// The reviews.
        /// </value>
        public virtual ICollection<ReviewModel> Reviews { get; set; } 

        /// <summary>
        /// Gets or sets the short product description.
        /// </summary>
        /// <value>
        /// Short description.
        /// </value>
        public string DescriptionShort { get; set; }

        /// <summary>
        /// Gets or sets the long discription.
        /// </summary>
        /// <value>
        /// The full description.
        /// </value>
        public string DescriptionLong { get; set; }

        /// <summary>
        /// Gets or sets the product icon path.
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [sold out].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [sold out]; otherwise, <c>false</c>.
        /// </value>
        public bool SoldOut { get; set; }

        /// <summary>
        /// Gets or sets the published date time.
        /// </summary>
        /// <value>
        /// The published date time.
        /// </value>
        public DateTime? PublishedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the off market date time.
        /// </summary>
        /// <value>
        /// The off market date time.
        /// </value>
        public DateTime? OffMarketDateTime { get; set; }
    }
}