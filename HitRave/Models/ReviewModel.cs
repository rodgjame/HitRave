using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HitRave.Models
{
    /// <summary>
    /// Model to represent a single review
    /// </summary>
    public class ReviewModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the user who made the review.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public UserModel User { get; set; }

        /// <summary>
        /// Gets or sets the review date time.
        /// </summary>
        /// <value>
        /// The review date time.
        /// </value>
        public DateTime ReviewDateTime { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReviewModel"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReviewModel"/> is spam.
        /// </summary>
        /// <value>
        ///   <c>true</c> if spam; otherwise, <c>false</c>.
        /// </value>
        public bool Spam { get; set; }
    }
}